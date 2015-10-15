var HomeCtrl = (function () {
    function HomeCtrl($scope) {
        this.$scope = $scope;
    }
    HomeCtrl.prototype.change = function () {
        var _this = this;
        setTimeout(function () {
            _this.message = "XXX";
            _this.$scope.$apply();
        }, 1000);
    };
    return HomeCtrl;
})();
angular.module("MyApp").controller("HomeCtrl", HomeCtrl);
