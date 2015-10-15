class HomeCtrl {
    message: string;
    $scope;

    constructor($scope, private localeService: LocaleService) {
        this.$scope = $scope;

        this.message = localeService.getResource("helloMessage");
    }

    change() {
        setTimeout(() => {
            this.message = this.localeService.getResource("helloMessage");

            this.$scope.$apply();
        }, 1000);
    }
}

angular.module("MyApp").controller("HomeCtrl", HomeCtrl);