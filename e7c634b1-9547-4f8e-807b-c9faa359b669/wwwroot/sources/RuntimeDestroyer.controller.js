import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.model.js";

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

checkRuntimeDestroyerRole$Action(callContext) {
var outVars = new OS.SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS.Authorization.hasRole({
roleKey: this.roles.RuntimeDestroyer.roleKey
});
return outVars;

}


get roles() {if(!(this.hasOwnProperty("_roles"))) {
this._roles = {
RuntimeDestroyer: {
roleKey: "e7c634b1-9547-4f8e-807b-c9faa359b669.ab2a6b39-1f30-4f20-a069-cf5d18b076f4",
roleException: new OS.Exceptions.Exceptions.NotRegisteredException("RuntimeDestroyer.NotRuntimeDestroyer", "RuntimeDestroyer role required")
}
};
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

var RuntimeDestroyerController = new Controller();

var controller = RuntimeDestroyerController;


export default RuntimeDestroyerController;





