
/*
 * Identify why the JS below does not display 'This is my response' in the console when run.
 * 
 * You can use node to run this js file to see it's response in your terminal:  node Test1.js
 * 
 * */


function showResponse(response) {
    console.log(response);
}

let myPromise = new Promise(function (myResolve, myReject) {
    let resp = "This is my response";

    try {
        return resp;
    } catch (error) {
        myReject("Error");
    }
});

myPromise.then(
    function (value) { showResponse(value); },
    function (error) { showResponse(error); }
);