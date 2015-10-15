var Network = (function () {

    var data = 12;

    function httpGet(url) {
        console.log("Network.httpGet: " + url);
    }

    function httpPost(url) {
    }

    return {
        httpGet: httpGet,
        httpPost: httpPost,
    };
})();
