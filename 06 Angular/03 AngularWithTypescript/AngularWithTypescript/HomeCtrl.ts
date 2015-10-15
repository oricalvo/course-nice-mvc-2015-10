class HomeCtrl {
    message: string;
    $scope;

    constructor($scope) {
        this.$scope = $scope;
    }

    change() {
        setTimeout(() => {
            this.message = "XXX";

            this.$scope.$apply();
        }, 1000);
    }
}

angular.module("MyApp").controller("HomeCtrl", HomeCtrl);