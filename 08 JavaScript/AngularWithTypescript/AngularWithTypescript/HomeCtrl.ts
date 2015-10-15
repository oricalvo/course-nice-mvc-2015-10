class HomeCtrl {
    message: string;

    constructor() {
        this.message = "Hell123o Ng+TS";
    }
}

angular.module("MyApp").controller("HomeCtrl", HomeCtrl);