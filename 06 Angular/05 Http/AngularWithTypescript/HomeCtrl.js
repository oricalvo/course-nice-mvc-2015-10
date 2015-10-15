var HomeCtrl = (function () {
    function HomeCtrl($scope, contactService) {
        this.contactService = contactService;
        this.$scope = $scope;
        this.contacts = this.contactService.getAll();
    }
    return HomeCtrl;
})();
angular.module("MyApp").controller("HomeCtrl", HomeCtrl);
//# sourceMappingURL=HomeCtrl.js.map