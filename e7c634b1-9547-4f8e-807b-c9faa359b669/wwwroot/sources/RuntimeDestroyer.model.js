import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.staticEntities.js";
export {entities, setEntities} from "./RuntimeDestroyer.entities-model.js";
export {staticEntities} from "./RuntimeDestroyer.staticEntities.js";
export class ST_00ba72a41660161c6373af90c87d0979Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new ST_00ba72a41660161c6373af90c87d0979Structure(new ST_00ba72a41660161c6373af90c87d0979Structure.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "SampleListStruct";
}
}



ST_00ba72a41660161c6373af90c87d0979Structure.init();

export class EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord extends 
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



EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord.init();

export class ST_34ce93e9f60ca0d98b2e231b96135f86Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", false, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("HttpMethod", "httpMethodAttr", "HttpMethod", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HttpRequestStruct";
}
}



ST_34ce93e9f60ca0d98b2e231b96135f86Structure.init();

export class ST_b6163e36a4b633b09c820fee73ba221eStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Name", "nameAttr", "Name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Value", "valueAttr", "Value", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HTTPHeader";
}
}



ST_b6163e36a4b633b09c820fee73ba221eStructure.init();

export class ST_67c9532b700300cd02996c0d658856f8Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Name", "nameAttr", "Name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Value", "valueAttr", "Value", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "URLQueryParameter";
}
}



ST_67c9532b700300cd02996c0d658856f8Structure.init();

export class ST_2e4d23f993f70b2a453aff430875354bStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("BaseURL", "baseURLAttr", "BaseURL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("URLPath", "uRLPathAttr", "URLPath", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("URLQueryParameters", "uRLQueryParametersAttr", "URLQueryParameters", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_67c9532b700300cd02996c0d658856f8Structure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_67c9532b700300cd02996c0d658856f8Structure))), 
this.attr("HTTPMethod", "hTTPMethodAttr", "HTTPMethod", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Headers", "headersAttr", "Headers", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_b6163e36a4b633b09c820fee73ba221eStructure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_b6163e36a4b633b09c820fee73ba221eStructure))), 
this.attr("RequestText", "requestTextAttr", "RequestText", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("RequestBinary", "requestBinaryAttr", "RequestBinary", false, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HTTPRequest2";
}
}



ST_2e4d23f993f70b2a453aff430875354bStructure.init();

export class EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("HttpMethod", "httpMethodAttr", "HttpMethod", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Body", "bodyAttr", "Body", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HttpRequest";
}
}



EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord.init();

export class EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord(new EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "SampleListEntity";
}
}



EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord.init();

export class EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Name", "nameAttr", "Name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Age", "ageAttr", "Age", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Employee";
}
}



EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord.init();

export class ST_c6c92e08cc1756053230783f07370fc0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("id", "idAttr", "id", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("name", "nameAttr", "name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("color", "colorAttr", "color", false, false, OS.DataTypes.DataTypes.Text, function () {
return RuntimeDestroyerModel.staticEntities.enum_color.c1;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Employee2";
}
}



ST_c6c92e08cc1756053230783f07370fc0Structure.init();

export class EN_80054628bf73dfa0a64914948a216302EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_80054628bf73dfa0a64914948a216302EntityRecord(new EN_80054628bf73dfa0a64914948a216302EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "SampleListGet";
}
}



EN_80054628bf73dfa0a64914948a216302EntityRecord.init();

export class ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Name", "nameAttr", "Name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure(new ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure.RecordClass({
nameAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "EmployeeName";
}
}



ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure.init();

export class EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Value", "valueAttr", "Value", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Enum_color";
}
}



EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord.init();



