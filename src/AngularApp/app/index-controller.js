'use strict';

angular.module('app.controllers')
    .controller('IndexController', [
        '$scope', '$location', '$window', function($scope, $location, $window) {
            $scope.$root.title = 'AngularJS Large SPA Template for Visual Studio';
            $scope.$on('$viewContentLoaded', function() {
                $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
            });
        }
    ]);
