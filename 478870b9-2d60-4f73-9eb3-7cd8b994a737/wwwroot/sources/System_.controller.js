import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as System_Model from "./System_.model.js";

var OS = OSRuntimeCore;
class Controller extends 
OS.Controller.BaseModuleController {
constructor(model, messagesProvider, idService, translationResources) {
super(model, messagesProvider, idService, translationResources);
}

get clientActionProxies() {if(!(this.hasOwnProperty("_clientActionProxies"))) {
this._clientActionProxies = {};
}

return this._clientActionProxies;
}set clientActionProxies(value) {this._clientActionProxies = value;
}


get roles() {if(!(this.hasOwnProperty("_roles"))) {
this._roles = {};
}

return this._roles;
}set roles(value) {this._roles = value;
}

get defaultTimeout() {if(!(this.hasOwnProperty("_defaultTimeout"))) {
this._defaultTimeout = 10;
}

return this._defaultTimeout;
}set defaultTimeout(value) {this._defaultTimeout = value;
}

getDefaultTimeout() {
return this.defaultTimeout;
}

}

var System_Controller = new Controller();

var controller = System_Controller;
System_Controller.getExternalIdentityProviders$Action = function (callContext) {
return OS.Logger.startActiveSpan("GetExternalIdentityProviders", function (span) {
if(span) {
span.setAttribute("code.function", "GetExternalIdentityProviders");
span.setAttribute("outsystems.function.key", "de70fbce-fe4c-4c40-8764-797d4df2da8b");
span.setAttribute("outsystems.function.owner.name", "System_");
span.setAttribute("outsystems.function.owner.key", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var outVars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("System_.GetExternalIdentityProviders$outVars"))());
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
System_Controller.constructor.registerVariableGroupType("System_.GetExternalIdentityProviders$outVars", [{
name: "ExternalIdentityProviders",
attrName: "externalIdentityProvidersOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS.GenericTypeCache.getGenericList(OS.SystemStructures.ExternalIdentityProviderRec))();
},
complexType: (OS.GenericTypeCache.getGenericList(OS.SystemStructures.ExternalIdentityProviderRec))
}]);
System_Controller.clientActionProxies.getExternalIdentityProviders$Action = function () {
return controller.executeActionInsideJSNode(System_Controller.default.getExternalIdentityProviders$Action.bind(controller), OS.Controller.BaseViewController.activeScreen ? OS.Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
ExternalIdentityProviders: actionResults.externalIdentityProvidersOut
};
});
};
System_Controller.isBuiltinIdentityProviderActive$Action = function (callContext) {
return OS.Logger.startActiveSpan("IsBuiltinIdentityProviderActive", function (span) {
if(span) {
span.setAttribute("code.function", "IsBuiltinIdentityProviderActive");
span.setAttribute("outsystems.function.key", "18764866-65bd-44d0-b166-439b5eba5112");
span.setAttribute("outsystems.function.owner.name", "System_");
span.setAttribute("outsystems.function.owner.key", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var outVars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("System_.IsBuiltinIdentityProviderActive$outVars"))());
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
System_Controller.constructor.registerVariableGroupType("System_.IsBuiltinIdentityProviderActive$outVars", [{
name: "isActive",
attrName: "isActiveOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
System_Controller.clientActionProxies.isBuiltinIdentityProviderActive$Action = function () {
return controller.executeActionInsideJSNode(System_Controller.default.isBuiltinIdentityProviderActive$Action.bind(controller), OS.Controller.BaseViewController.activeScreen ? OS.Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
isActive: OS.DataConversion.JSNodeParamConverter.to(actionResults.isActiveOut, OS.DataTypes.DataTypes.Boolean)
};
});
};


export default System_Controller;





