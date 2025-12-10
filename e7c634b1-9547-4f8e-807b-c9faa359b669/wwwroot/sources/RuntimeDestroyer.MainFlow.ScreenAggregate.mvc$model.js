import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as RuntimeDestroyerModel from "./RuntimeDestroyer.model.js";

var OS = OSRuntimeCore;
class GetEmployeesAggrRec extends 
OS.Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS.Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS.GenericTypeCache.getGenericList((OS.GenericTypeCache.getImplicitRecord(RuntimeDestroyerModel.EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, {
name: "Employee",
attrName: "employeeAttr",
nameForJson: "Employee",
uniqueId: "3b55179c-5be2-0c3d-1041-cf4a1dcf3f76"
}))));
}
static fromStructure(str) {
return new GetEmployeesAggrRec(new GetEmployeesAggrRec.RecordClass({
RecordListType: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEmployeesAggrRec.init();



class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("GetEmployees", "getEmployeesAggr", "GetEmployees", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetEmployeesAggrRec());
}, true, GetEmployeesAggrRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
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




