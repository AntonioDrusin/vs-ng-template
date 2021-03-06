﻿/// <reference path="/app/_references.js" />
/// <reference path="./controllers.js" />
'use strict';

describe('Controllers: 404Controller', function() {
    var $scope, ctrl;

    beforeEach(module('app.controllers'));

    beforeEach(inject(function($rootScope, $controller) {
        $scope = $rootScope.$new();
        ctrl = $controller('404Controller', { $scope: $scope });
    }));

    it('should set a page title', function() {
        expect($scope.$root.title).toBe('Error 404: Page Not Found');
    });
});