function HomeCtrl($scope) {

    load();

    $scope.add = function () {
        var contact = {
            id: -1,
            name: $scope.name,
        };

        $scope.contacts.push(contact);

        save();
    }

    function save() {
        var json = JSON.stringify($scope.contacts);
        localStorage.setItem("contacts", json);
    }

    function load() {
        var contactsJson = localStorage.getItem("contacts");
        if (contactsJson) {
            $scope.contacts = JSON.parse(contactsJson);
        }
        else {
            $scope.contacts = [
                { id: 1, name: "Ori", email: "ori@gmail.com" },
                { id: 2, name: "Roni", email: "roni@gmail.com" },
            ];
        }
    }
}

angular.module("MyApp").controller("HomeCtrl", HomeCtrl);
