/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module paymentAdmin

(function(){

  // controller x.abp.payment.admin.requests.paymentRequestAdmin

  (function(){

    abp.utils.createNamespace(window, 'x.abp.payment.admin.requests.paymentRequestAdmin');

    x.abp.payment.admin.requests.paymentRequestAdmin.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/payment-requests' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'creationDateMax', value: input.creationDateMax }, { name: 'creationDateMin', value: input.creationDateMin }, { name: 'paymentType', value: input.paymentType }, { name: 'status', value: input.status }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.payment.admin.requests.paymentRequestAdmin.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/payment-requests/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

  })();

  // controller x.abp.payment.admin.plans.planAdmin

  (function(){

    abp.utils.createNamespace(window, 'x.abp.payment.admin.plans.planAdmin');

    x.abp.payment.admin.plans.planAdmin.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.createGatewayPlan = function(planId, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans/' + planId + '/external-plans',
        type: 'POST',
        dataType: null,
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans' + abp.utils.buildQueryString([{ name: 'id', value: id }]) + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.deleteGatewayPlan = function(planId, gateway, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans/' + planId + '/external-plans/' + gateway + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.updateGatewayPlan = function(planId, gateway, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans/' + planId + '/external-plans/' + gateway + '',
        type: 'PUT',
        dataType: null,
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.payment.admin.plans.planAdmin.getGatewayPlans = function(planId, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/payment-admin/plans/' + planId + '/external-plans' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

  })();

})();


