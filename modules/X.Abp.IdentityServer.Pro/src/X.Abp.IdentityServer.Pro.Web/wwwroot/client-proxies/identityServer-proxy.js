/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module identityServer

(function(){

  // controller x.abp.identityServer.apiResources

  (function(){

    abp.utils.createNamespace(window, 'x.abp.identityServer.apiResources');

    x.abp.identityServer.apiResources.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-resources' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.apiResources.getAllList = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-resources/all',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.apiResources.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-resources/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.apiResources.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-resources',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.apiResources.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-resources/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.apiResources['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-resources' + abp.utils.buildQueryString([{ name: 'id', value: id }]) + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

  // controller x.abp.identityServer.apiScope

  (function(){

    abp.utils.createNamespace(window, 'x.abp.identityServer.apiScope');

    x.abp.identityServer.apiScope.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-scopes',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.apiScope['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-scopes/' + id + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    x.abp.identityServer.apiScope.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-scopes/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.apiScope.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-scopes' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.apiScope.getAllList = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-scopes/all',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.apiScope.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/api-scopes/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

  })();

  // controller x.abp.identityServer.clients

  (function(){

    abp.utils.createNamespace(window, 'x.abp.identityServer.clients');

    x.abp.identityServer.clients.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/clients' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.clients.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/clients/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.clients.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/clients',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.clients.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/clients/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.clients['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/clients' + abp.utils.buildQueryString([{ name: 'id', value: id }]) + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

  // controller x.abp.identityServer.identityResources

  (function(){

    abp.utils.createNamespace(window, 'x.abp.identityServer.identityResources');

    x.abp.identityServer.identityResources.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.identityResources.getAllList = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources/all',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.identityResources.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.identityServer.identityResources.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.identityResources.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.identityServer.identityResources['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources' + abp.utils.buildQueryString([{ name: 'id', value: id }]) + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    x.abp.identityServer.identityResources.createStandardResources = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/identity-resources/create-standard-resources',
        type: 'POST',
        dataType: null
      }, ajaxParams));
    };

  })();

  // controller x.abp.identityServer.identityServerClaimTypes

  (function(){

    abp.utils.createNamespace(window, 'x.abp.identityServer.identityServerClaimTypes');

    x.abp.identityServer.identityServerClaimTypes.getList = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/identity-server/claim-types',
        type: 'GET'
      }, ajaxParams));
    };

  })();

})();


