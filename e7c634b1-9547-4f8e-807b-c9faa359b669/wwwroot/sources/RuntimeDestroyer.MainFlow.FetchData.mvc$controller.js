import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.model.js";
import * as RuntimeDestroyerController from "./RuntimeDestroyer.controller.js";
import RuntimeDestroyerLanguageResources from "./RuntimeDestroyer.languageResources.js";
import RuntimeDestroyer_MainFlowController from "./RuntimeDestroyer.MainFlow.controller.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getWeekday$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getWeekday$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getWeekday$DataActRefresh() {if(!(this.hasOwnProperty("_getWeekday$DataActRefresh"))) {
this._getWeekday$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetWeekday", "screenservices/RuntimeDestroyer/MainFlow/FetchData/DataActionGetWeekday", "H6TM2dNRHh0p0jdBRzhBcA", function (b) {
model.variables.getWeekdayDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getWeekdayDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getWeekdayDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false);
}.bind(this);
return OS.Logger.startActiveSpan("GetWeekday", function (span) {
if(span) {
span.setAttribute("code.function", "GetWeekday");
span.setAttribute("outsystems.function.key", "5482cd6c-a053-4a45-b332-08593d0b1842");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getWeekday$DataActRefresh;
}set getWeekday$DataActRefresh(value) {this._getWeekday$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getWeekday$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = null;
}

return this._onReadyEventHandler;
}set onReadyEventHandler(value) {this._onReadyEventHandler = value;
}

get onRenderEventHandler() {if(!(this.hasOwnProperty("_onRenderEventHandler"))) {
this._onRenderEventHandler = null;
}

return this._onRenderEventHandler;
}set onRenderEventHandler(value) {this._onRenderEventHandler = value;
}

get onDestroyEventHandler() {if(!(this.hasOwnProperty("_onDestroyEventHandler"))) {
this._onDestroyEventHandler = null;
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = null;
}

return this._onParametersChangedEventHandler;
}set onParametersChangedEventHandler(value) {this._onParametersChangedEventHandler = value;
}

// Sync Event Handler Actions
get onSyncStartEventHandler() {if(!(this.hasOwnProperty("_onSyncStartEventHandler"))) {
this._onSyncStartEventHandler = null;
}

return this._onSyncStartEventHandler;
}set onSyncStartEventHandler(value) {this._onSyncStartEventHandler = value;
}

get onSyncCompleteEventHandler() {if(!(this.hasOwnProperty("_onSyncCompleteEventHandler"))) {
this._onSyncCompleteEventHandler = null;
}

return this._onSyncCompleteEventHandler;
}set onSyncCompleteEventHandler(value) {this._onSyncCompleteEventHandler = value;
}

get onSyncErrorEventHandler() {if(!(this.hasOwnProperty("_onSyncErrorEventHandler"))) {
this._onSyncErrorEventHandler = null;
}

return this._onSyncErrorEventHandler;
}set onSyncErrorEventHandler(value) {this._onSyncErrorEventHandler = value;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex) {
return RuntimeDestroyer_MainFlowController.default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
}

getDefaultTimeout() {
return RuntimeDestroyerController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, RuntimeDestroyerLanguageResources);




