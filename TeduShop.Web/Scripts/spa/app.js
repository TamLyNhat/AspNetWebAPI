/// <reference path="../plugins/bower_components/angular/angular.js" />

//create module
//step 1
var myApp = angular.module('myModule', []);

//step3: register the controller with module
myApp.controller("myController", myController);

//step 4
//tiên đối tượng $scope vào controller
myController.$inject = ['$scope'];

//declare
//create controller
//step 2
function myController($scope) {
    $scope.message = "This is my advanced app";
}

myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);
myApp.controller("schoolController", schoolController);

//function studentController($rootScope, $scope) {
//    $rootScope.message = "Alexander dai de";
//}

function studentController($scope) {
    $scope.message = "Alexander dai de";
}

function teacherController($scope) {
    // $scope.message = "Alexander rin tam dim";
}

function schoolController($scope) {
    $scope.message = "King og Kings";
}


//bai 19
//myApp.controller("DemoController", DemoController);
//myApp.service('Validator', Validator);

//DemoController.$inject = ['$scope', 'Validator'];

//function DemoController($scope, Validator) {
//    //Validator.checkNumber(2);
     
//    $scope.checkNumber = function () {
//        //$scope.alert = Validator.checkNumber($scope.num);
//        $scope.message = Validator.checkNumber($scope.num);
//    }
//}

//function Validator($window) {
//    return {
//        checkNumber: checkNumber
//    }

//    function checkNumber(input) {
//        if (input % 2 == 0) {
//            //$window.alert('this is even');
//            return 'this is even';
//        }
//        else {
//            //$window.alert('this is old');
//            return 'this is old';
//        }
//    }
//}

// bài 20

myApp.controller("DemoController", DemoController);

myApp.directive("alexanderDirective", alexanderDirective);

myApp.service('validatorService', validatorService);
    
DemoController.$inject = ['$scope', 'validatorService'];

function DemoController($scope, Validator) {
    //Validator.checkNumber(2);

    $scope.checkNumber = function () {
        //$scope.alert = Validator.checkNumber($scope.num);
        $scope.message = Validator.checkNumber($scope.num);
    }
}

function validatorService($window) {
    return {
        checkNumber: checkNumber
    }

    function checkNumber(input) {
        if (input % 2 == 0) {
            //$window.alert('this is even');
            return 'this is even';
        }
        else {
            //$window.alert('this is old');
            return 'this is old';
        }
    }
}

function alexanderDirective() {
    return {
        // A: thuộc tính
        //E :element
        restrict: "E",

        //restrict: "A",
        templateUrl: "/Scripts/spa/alexanderDirective.html" 
    }
}
