// node 7.x
// uses async/await - promises

var rp = require('request-promise');
var fs = require('fs-extra');
var path = require('path');


// main function to call
var upload = async (config) => {

    try{

        config.response = {
            success: {
                pages:[]
            },
            error: {
                pages:[]
            }
        };

        var options = {
            uri: config.uri,
            method: 'POST',
            headers: {
                'Ocp-Apim-Subscription-Key': config.LUIS_subscriptionKey
            },
            json: true
        };        

        var uploadPromises = [];

        var entireBatch = await fs.readJson(config.inFile);

        var pages = getPagesForBatch(entireBatch.utterances, config.batchSize);

        // load up promise array
        pages.forEach(page => {

            var pagePromise = sendBatchToApi({
                uri: config.uri,
                method: 'POST',
                headers: {
                    'Ocp-Apim-Subscription-Key': config.LUIS_subscriptionKey
                },
                json: true,
                body: page
            });

            uploadPromises.push(pagePromise);
        })

        //execute promise array
        
        return await Promise.all(uploadPromises)
        .then(results => {
            return writeResponsesToFile(config.inFile.replace('.json','.upload.json'), results);
        }).then(response => {
            console.log("upload done");
        }).catch(err => {
            console.log("upload failure");
            console.log(err);
        });

    } catch(err){
        throw err;        
    }

}
// turn whole batch into pages batch 
// because API can only deal with N items in batch
var getPagesForBatch = (batch, maxItems) => {

    try{
        var pages = []; 
        var currentPage = 0;

        var pageCount = (batch.length % maxItems == 0) ? Math.round(batch.length / maxItems) : Math.round((batch.length / maxItems) + 1);

        for (let i = 0;i<pageCount;i++){

            var currentStart = currentPage * maxItems;
            var currentEnd = currentStart + maxItems;
            var pagedBatch = batch.slice(currentStart,currentEnd);

            var j = 0;
            pagedBatch.forEach(item=>{
                item.ExampleId = j++;
            });

            pages.push(pagedBatch);

            currentPage++;
        }
        return pages;
    }catch(err){
        throw(err);
    }
}



// send json batch as post.body to API
var sendBatchToApi = async (options) => {
    try {

        var response =  await rp.post(options);
        return {page: options.body, response:response};

    }catch(err){
        throw err;
    }   
}   

var writeResponsesToFile = async(outFile, responses)=>{

    try{
        return await fs.writeFile(outFile,JSON.stringify(responses), 'utf-8');
    }
    catch (err) {
        return err;
    }
}


module.exports = upload;