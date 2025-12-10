import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerLibModel from "./RuntimeDestroyerLib.model.js";

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

var RuntimeDestroyerLibController = new Controller();

var controller = RuntimeDestroyerLibController;


export default RuntimeDestroyerLibController;





