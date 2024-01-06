angular.module('peak')
    .controller('consultController', function ($scope, $http, $rootScope) {
        $rootScope.title = "Consultar"

        $scope.error = false;
        $scope.user = null;
        $scope.userId = "";

        $scope.submitForm = () => {
            $http.get(`https://localhost:7245/api/User/${$scope.userId}`)
                .then((res) => {
                    $scope.user = res.data;
                    $scope.error = false;
                })
                .catch((err) => {
                    console.error("Erro ao tentar acessar a API:", err);
                    $scope.error = true;
                })
        }
        
    })