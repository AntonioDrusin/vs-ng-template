/// <reference path="/app/_references.js" />
/// <reference path="./controllers.js" />
'use strict';

describe('Controllers: IndexController', function() {
    var $scope, ctrl;

    beforeEach(module('app.controllers'));

    beforeEach(inject(function($rootScope, $controller) {
        $scope = $rootScope.$new();
        ctrl = $controller('IndexController', { $scope: $scope });
    }));

    it('should set a page title', function() {
        expect($scope.$root.title).toBe('AngularJS Large SPA Template for Visual Studio');
    });
});