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
getEmployees$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getEmployees$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods
get createOrUpdateEmployee$ServerAction() {if(!(this.hasOwnProperty("_createOrUpdateEmployee$ServerAction"))) {
this._createOrUpdateEmployee$ServerAction = function (sourceIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CreateOrUpdateEmployee", function (span) {
if(span) {
span.setAttribute("code.function", "CreateOrUpdateEmployee");
span.setAttribute("outsystems.function.key", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#CreateOrUpdateEntity");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_ENTITY_ACTION");
}

return OS.Flow.tryFinally(function () {
var inputs = {
Source: OS.DataConversion.ServerDataConverter.to(sourceIn, OS.DataTypes.DataTypes.Record)
};
return controller.callServerAction("CreateOrUpdateEmployee", "screenservices/RuntimeDestroyer/MainFlow/ScreenAggregate/ssCreateOrUpdateEmployee", "z8EpiQlzCs+i++sDUr3kcA", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("RuntimeDestroyer.MainFlow.ScreenAggregate$ssCreateOrUpdateEmployee"))();
executeServerActionResult.idOut = OS.DataConversion.ServerDataConverter.from(outputs.Id, OS.DataTypes.DataTypes.LongInteger);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
}

return this._createOrUpdateEmployee$ServerAction;
}set createOrUpdateEmployee$ServerAction(value) {this._createOrUpdateEmployee$ServerAction = value;
}

get deleteAllEmployee$ServerAction() {if(!(this.hasOwnProperty("_deleteAllEmployee$ServerAction"))) {
this._deleteAllEmployee$ServerAction = function (callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("DeleteAllEmployee", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteAllEmployee");
span.setAttribute("outsystems.function.key", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#DeleteAllEntity");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_ENTITY_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.callServerAction("DeleteAllEmployee", "screenservices/RuntimeDestroyer/MainFlow/ScreenAggregate/ssDeleteAllEmployee", "6g+6lvT1aUGpMLSpTAG69Q", {}, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
}

return this._deleteAllEmployee$ServerAction;
}set deleteAllEmployee$ServerAction(value) {this._deleteAllEmployee$ServerAction = value;
}


// Aggregates and Data Actions
get getEmployees$AggrRefresh() {if(!(this.hasOwnProperty("_getEmployees$AggrRefresh"))) {
this._getEmployees$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetEmployees", "screenservices/RuntimeDestroyer/MainFlow/ScreenAggregate/ScreenDataSetGetEmployees", "2A6dfi5SGfsQboyiA6ktqw", maxRecords, startIndex, function (b) {
model.variables.getEmployeesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEmployeesAggr.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getEmployeesAggr.constructor));
}, undefined, undefined, undefined, callContext, undefined, false);
}.bind(this);
return OS.Logger.startActiveSpan("GetEmployees", function (span) {
if(span) {
span.setAttribute("code.function", "GetEmployees");
span.setAttribute("outsystems.function.key", "86acf84f-3390-4b01-97cc-7b544701295a");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_AGGREGATE_CALL");
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

return this._getEmployees$AggrRefresh;
}set getEmployees$AggrRefresh(value) {this._getEmployees$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getEmployees$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _refresh$Action() {if(!(this.hasOwnProperty("__refresh$Action"))) {
this.__refresh$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Refresh", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "1d9ea308-4d43-4d8b-8909-9301784fa948");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Refresh");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Refresh Query: GetEmployees
var result = controller.getEmployees$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
model.flush();
return result;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__refresh$Action;
}set _refresh$Action(value) {this.__refresh$Action = value;
}

get _bootstrapData$Action() {if(!(this.hasOwnProperty("__bootstrapData$Action"))) {
this.__bootstrapData$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("BootstrapData", function (span) {
if(span) {
span.setAttribute("code.function", "BootstrapData");
span.setAttribute("outsystems.function.key", "3d3cfbaa-59f6-4852-b778-7a2a4d55c7e2");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("BootstrapData");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("RuntimeDestroyer.MainFlow.ScreenAggregate.BootstrapData$vars"))());
var createOrUpdateEmployee2Var = new OS.DataTypes.VariableHolder();
var createOrUpdateEmployeeVar = new OS.DataTypes.VariableHolder();
var createOrUpdateEmployee3Var = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Employee
// Employee.Id = 1
vars.value.employeeVar.idAttr = OS.BuiltinFunctions.integerToLongInteger(1);
// Employee.Name = "Joe"
vars.value.employeeVar.nameAttr = "Joe";
// Employee.Age = 25
vars.value.employeeVar.ageAttr = "25";
// Execute Action: CreateOrUpdateEmployee
model.flush();
return controller.createOrUpdateEmployee$ServerAction((OS.GenericTypeCache.getImplicitRecord(RuntimeDestroyerModel.EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, {
name: "Employee",
attrName: "employeeAttr",
nameForJson: "Employee",
uniqueId: "3b55179c-5be2-0c3d-1041-cf4a1dcf3f76"
})).fromStructure(vars.value.employeeVar), callContext).then(function (value) {
createOrUpdateEmployeeVar.value = value;
}).then(function () {
// Employee
// Employee.Id = 2
vars.value.employeeVar.idAttr = OS.BuiltinFunctions.integerToLongInteger(2);
// Employee.Name = "Mark"
vars.value.employeeVar.nameAttr = "Mark";
// Employee.Age = 30
vars.value.employeeVar.ageAttr = "30";
// Execute Action: CreateOrUpdateEmployee2
model.flush();
return controller.createOrUpdateEmployee$ServerAction((OS.GenericTypeCache.getImplicitRecord(RuntimeDestroyerModel.EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, {
name: "Employee",
attrName: "employeeAttr",
nameForJson: "Employee",
uniqueId: "3b55179c-5be2-0c3d-1041-cf4a1dcf3f76"
})).fromStructure(vars.value.employeeVar), callContext).then(function (value) {
createOrUpdateEmployee2Var.value = value;
});
}).then(function () {
// Employee
// Employee.Id = 3
vars.value.employeeVar.idAttr = OS.BuiltinFunctions.integerToLongInteger(3);
// Employee.Name = "Tom"
vars.value.employeeVar.nameAttr = "Tom";
// Employee.Age = 35
vars.value.employeeVar.ageAttr = "35";
// Execute Action: CreateOrUpdateEmployee3
model.flush();
return controller.createOrUpdateEmployee$ServerAction((OS.GenericTypeCache.getImplicitRecord(RuntimeDestroyerModel.EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, {
name: "Employee",
attrName: "employeeAttr",
nameForJson: "Employee",
uniqueId: "3b55179c-5be2-0c3d-1041-cf4a1dcf3f76"
})).fromStructure(vars.value.employeeVar), callContext).then(function (value) {
createOrUpdateEmployee3Var.value = value;
});
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__bootstrapData$Action;
}set _bootstrapData$Action(value) {this.__bootstrapData$Action = value;
}

get _onSort$Action() {if(!(this.hasOwnProperty("__onSort$Action"))) {
this.__onSort$Action = function (sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "4e8d0efb-ed2d-4dc3-a507-034dd8acbc87");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("RuntimeDestroyer.MainFlow.ScreenAggregate.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS.Flow.executeAsyncFlow(function () {
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetEmployees
var result = controller.getEmployees$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
model.flush();
return result;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onSort$Action;
}set _onSort$Action(value) {this.__onSort$Action = value;
}

get _deleteAll$Action() {if(!(this.hasOwnProperty("__deleteAll$Action"))) {
this.__deleteAll$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("DeleteAll", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteAll");
span.setAttribute("outsystems.function.key", "77c91b17-6169-409f-bb3e-2da90e036c09");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("DeleteAll");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: DeleteAllEmployee
model.flush();
return controller.deleteAllEmployee$ServerAction(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__deleteAll$Action;
}set _deleteAll$Action(value) {this.__deleteAll$Action = value;
}


refresh$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Refresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "1d9ea308-4d43-4d8b-8909-9301784fa948");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refresh$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

bootstrapData$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("BootstrapData__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "BootstrapData");
span.setAttribute("outsystems.function.key", "3d3cfbaa-59f6-4852-b778-7a2a4d55c7e2");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._bootstrapData$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "4e8d0efb-ed2d-4dc3-a507-034dd8acbc87");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSort$Action, callContext, sortByIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

deleteAll$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("DeleteAll__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteAll");
span.setAttribute("outsystems.function.key", "77c91b17-6169-409f-bb3e-2da90e036c09");
span.setAttribute("outsystems.function.owner.name", "RuntimeDestroyer");
span.setAttribute("outsystems.function.owner.key", "e7c634b1-9547-4f8e-807b-c9faa359b669");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._deleteAll$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}


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
Controller.registerVariableGroupType("RuntimeDestroyer.MainFlow.ScreenAggregate$ssCreateOrUpdateEmployee", [{
name: "Id",
attrName: "idOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS.DataTypes.LongInteger.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("RuntimeDestroyer.MainFlow.ScreenAggregate.BootstrapData$vars", [{
name: "Employee",
attrName: "employeeVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Record,
defaultValue: function () {
return new RuntimeDestroyerModel.EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();
},
complexType: RuntimeDestroyerModel.EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord
}]);
Controller.registerVariableGroupType("RuntimeDestroyer.MainFlow.ScreenAggregate.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, RuntimeDestroyerLanguageResources);




