import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.model.js";

var OS = OSRuntimeCore;

class GetWeekdayDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Out1", "out1Out", "Out1", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetWeekdayDataActRec(new GetWeekdayDataActRec.RecordClass({
out1Out: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

GetWeekdayDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("GetWeekday", "getWeekdayDataAct", "GetWeekday", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetWeekdayDataActRec());
}, true, GetWeekdayDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new VariablesRecord(new VariablesRecord.RecordClass({
getWeekdayDataAct: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
}

}

class Model extends 
OS.Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




