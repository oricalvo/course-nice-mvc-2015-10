var Storage = (function () {

    var data = 13;

    function getAllContacts() {
        return Network.httpGet("/api/contact");
    }

    return {
        getAllContacts: getAllContacts,
    };
})();
