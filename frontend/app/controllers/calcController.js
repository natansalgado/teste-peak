angular.module('peak')
    .controller('calcController', function ($scope, $http, $rootScope) {
        $rootScope.title = "Calcular"

        $scope.total = 0;
        $scope.error = false;

        $scope.submitForm = () => {
            const data = {
                installments: $scope.installments,
                value: $scope.value
            }

            $http.post('https://localhost:7245/api/Calc', data)
                .then((res) => {
                    $scope.error = false;
                    $scope.total = res.data;
                })
                .catch((err) => {
                    console.error("Erro ao tentar acessar a API:", err);
                    $scope.error = true;
                })
        }
    })