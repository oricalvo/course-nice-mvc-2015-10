class LocaleService {
    constructor() {
    }

    getResource(resourceName: string) {
        return "שלום";
    }
}

angular.module("MyApp").service("localeService", LocaleService);