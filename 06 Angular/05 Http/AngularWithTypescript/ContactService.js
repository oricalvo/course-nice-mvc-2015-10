var ContactService = (function () {
    function ContactService($q, $http) {
        this.$q = $q;
        this.$http = $http;
    }
    ContactService.prototype.getAll = function () {
        return this.$http.get("/api/contact").then(function (response) {
            return response.data;
        });

        //var deferred = this.$q.defer();
        //setTimeout(() => {
        //    deferred.resolve([
        //        { id: 1, name: "Ori" },
        //        { id: 2, name: "Roni" },
        //    ]);
        //}, 2000);
        //return deferred.promise;
        //return this.$q.when([
        //    { id: 1, name: "Ori" },
        //    { id: 2, name: "Roni" },
        //]);
    };
    return ContactService;
})();
angular.module("MyApp").service("contactService", ContactService);
//# sourceMappingURL=ContactService.js.map