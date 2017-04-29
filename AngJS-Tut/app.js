(function(){
    var app = angular.module("githubViewer", [])
    var MainCtrl = function($scope, $http){

        var onUserComplete = function(response){
            $scope.user = response.data;
        }

        var onError = function(reason){
            $scope.error = "Error!!!"
        }

        $http.get("https://api.github.com/users/robconery").then(onUserComplete, onError)

        $scope.username = "angular";
        $scope.message = "Yeah!!!";

    };
    app.controller("MainCtrl", MainCtrl)
}())