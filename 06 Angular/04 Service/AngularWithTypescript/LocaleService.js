var LocaleService = (function () {
    function LocaleService() {
    }
    LocaleService.prototype.getResource = function (resourceName) {
        return "שלום";
    };
    return LocaleService;
})();
angular.module("MyApp").service("localeService", LocaleService);
//# sourceMappingURL=LocaleService.js.map