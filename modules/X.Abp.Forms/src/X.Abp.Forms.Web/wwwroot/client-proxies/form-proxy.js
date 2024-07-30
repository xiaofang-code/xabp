/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module form

(function(){

  // controller x.abp.forms.responses.response

  (function(){

    abp.utils.createNamespace(window, 'x.abp.forms.responses.response');

    x.abp.forms.responses.response.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.responses.response.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.responses.response.getQuestionsWithAnswers = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses/' + id + '/questions-with-answers',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.responses.response.getFormDetails = function(formId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses/form-details/' + formId + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.responses.response.getUserFormsByUserId = function(userId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses/' + userId + '/response',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.responses.response.saveAnswers = function(formId, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses' + abp.utils.buildQueryString([{ name: 'formId', value: formId }]) + '',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.responses.response.updateAnswers = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses/' + id + '',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.responses.response['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/responses/' + id + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

  // controller x.abp.forms.questions.question

  (function(){

    abp.utils.createNamespace(window, 'x.abp.forms.questions.question');

    x.abp.forms.questions.question.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/questions' + abp.utils.buildQueryString([{ name: 'input', value: input }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.questions.question.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/questions/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.questions.question.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/questions/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.questions.question['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/questions/' + id + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

  // controller x.abp.forms.forms.form

  (function(){

    abp.utils.createNamespace(window, 'x.abp.forms.forms.form');

    x.abp.forms.forms.form.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.getResponses = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/responses' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.getCsvResponses = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/download-responses-csv' + abp.utils.buildQueryString([{ name: 'filter', value: input.filter }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.getResponsesCount = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/responses-count',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.deleteAllResponsesOfForm = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/responses',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

    x.abp.forms.forms.form.sendInviteEmail = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'invite',
        type: 'POST',
        dataType: null,
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.forms.form.create = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.forms.form.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.update = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '',
        type: 'PUT',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.forms.form.setSettings = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/settings',
        type: 'PUT',
        dataType: null,
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.forms.form.getSettings = function(formId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + formId + '/settings',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.getQuestions = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/questions' + abp.utils.buildQueryString([{ name: 'input', value: input }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.forms.forms.form.createQuestion = function(id, input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '/questions',
        type: 'POST',
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.forms.forms.form['delete'] = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/forms/' + id + '',
        type: 'DELETE',
        dataType: null
      }, ajaxParams));
    };

  })();

})();


