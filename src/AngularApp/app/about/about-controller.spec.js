/// <reference path="/app/_references.js" />
/// <reference path="./controllers.js" />
/// <reference path="/vendor/scripts/jasmine.js" />
/* global beforeEach,module,inject:false */

'use strict';

describe('Controllers: AboutController', function() {
    var $scope, ctrl;

    beforeEach(module('app.controllers'));

    beforeEach(inject(function($rootScope, $controller) {
        $scope = $rootScope.$new();
        ctrl = $controller('AboutController', { $scope: $scope });
    }));

    it('should set a page title', function() {
        expect($scope.$root.title).toBe('AngularJS SPA | About');
    });
});