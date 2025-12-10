import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export {entities, setEntities} from "./RuntimeDestroyerProducer.entities-model.js";
export {staticEntities} from "./RuntimeDestroyer.staticEntities.js";
export class EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Is_Active", "is_ActiveAttr", "Is_Active", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Weekday";
}
}



EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord.init();



