import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export {entities, setEntities} from "./RuntimeDestroyerLib.entities-model.js";
export {staticEntities} from "./RuntimeDestroyerLib.staticEntities.js";
export class ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StatusCode", "statusCodeAttr", "StatusCode", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Body", "bodyAttr", "Body", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HttpResponseStruct";
}
}



ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure.init();

export class EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
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

static get $runtimeName() {return "HttpMethod";
}
}



EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord.init();



