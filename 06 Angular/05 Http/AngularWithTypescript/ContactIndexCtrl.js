var ContactIndexCtrl = (function () {
    function ContactIndexCtrl($scope, contactService) {
        var _this = this;
        this.contactService = contactService;
        this.$scope = $scope;
        this.contactService.getAll().then(function (contacts) {
            _this.contacts = contacts;
        }).catch(function (err) {
            console.log(err);
            alert("ERROR: " + err.statusText);
        });
    }
    return ContactIndexCtrl;
})();
angular.module("MyApp").controller("ContactIndexCtrl", ContactIndexCtrl);
//# sourceMappingURL=ContactIndexCtrl.js.map