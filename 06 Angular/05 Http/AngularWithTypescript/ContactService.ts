class ContactService {
    constructor(private $q: ng.IQService, private $http: ng.IHttpService) {
    }

    getAll(): ng.IPromise<Contact[]> {

        return this.$http.get("/api/contact").then(response => {
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
    }
}

interface Contact {
    id: number;
    name: string;
}

angular.module("MyApp").service("contactService", ContactService);