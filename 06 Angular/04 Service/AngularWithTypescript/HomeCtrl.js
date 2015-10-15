var HomeCtrl = (function () {
    function HomeCtrl($scope, localeService) {
        this.localeService = localeService;
        this.$scope = $scope;
        this.message = localeService.getResource("helloMessage");
    }
    HomeCtrl.prototype.change = function () {
        var _this = this;
        setTimeout(function () {
            _this.message = _this.localeService.getResource("helloMessage");
            _this.$scope.$apply();
        }, 1000);
    };
    return HomeCtrl;
})();
angular.module("MyApp").controller("HomeCtrl", HomeCtrl);
//# sourceMappingURL=HomeCtrl.js.map