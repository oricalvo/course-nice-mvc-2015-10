class ContactIndexCtrl {
    contacts: Contact[];
    $scope;

    constructor($scope, private contactService: ContactService) {
        this.$scope = $scope;

        this.contactService.getAll().then(contacts => {
            this.contacts = contacts;
        }).catch(err => {
            console.log(err);

            alert("ERROR: " + err.statusText);
        });
    }
}

angular.module("MyApp").controller("ContactIndexCtrl", ContactIndexCtrl);