import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export {entities, setEntities} from "./System_.entities-model.js";
export {staticEntities} from "./System_.staticEntities.js";
export class ENEntityEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ApplicationId", "applicationIdAttr", "ApplicationId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsStatic", "isStaticAttr", "IsStatic", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("PrimaryKeyAttribute", "primaryKeyAttributeAttr", "PrimaryKeyAttribute", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Entity";
}
}



ENEntityEntityRecord.init();

export class ENRoleEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new ENRoleEntityRecord(new ENRoleEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Role";
}
}



ENRoleEntityRecord.init();

export class ENActivityOutputEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ActivityId", "activityIdAttr", "ActivityId", false, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("OutputDefinitionId", "outputDefinitionIdAttr", "OutputDefinitionId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OutputDefinitionKey", "outputDefinitionKeyAttr", "OutputDefinitionKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OutputValue", "outputValueAttr", "OutputValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityOutput";
}
}



ENActivityOutputEntityRecord.init();

export class ENTenantEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Tenant";
}
}



ENTenantEntityRecord.init();

export class ENActivityKindEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityKind";
}
}



ENActivityKindEntityRecord.init();

export class ENHumanActivityRoleEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ActivityInstanceId", "activityInstanceIdAttr", "ActivityInstanceId", false, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("RoleId", "roleIdAttr", "RoleId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HumanActivityRole";
}
}



ENHumanActivityRoleEntityRecord.init();

export class ENActivityStatusEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityStatus";
}
}



ENActivityStatusEntityRecord.init();

export class ENActivityOutputDefinitionEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Key", "keyAttr", "Key", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Description", "descriptionAttr", "Description", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ActivityDefinitionId", "activityDefinitionIdAttr", "ActivityDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsActive", "isActiveAttr", "IsActive", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsInput", "isInputAttr", "IsInput", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsMandatory", "isMandatoryAttr", "IsMandatory", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("DefaultValue", "defaultValueAttr", "DefaultValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityOutputDefinition";
}
}



ENActivityOutputDefinitionEntityRecord.init();

export class ENProcessInstanceEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ProcessDefinitionId", "processDefinitionIdAttr", "ProcessDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Status", "statusAttr", "Status", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("StartedOn", "startedOnAttr", "StartedOn", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("LastModifiedOn", "lastModifiedOnAttr", "LastModifiedOn", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessInstance";
}
}



ENProcessInstanceEntityRecord.init();

export class ENActivityDefinitionRoleEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("RoleId", "roleIdAttr", "RoleId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ActivityDefinitionId", "activityDefinitionIdAttr", "ActivityDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityDefinitionRole";
}
}



ENActivityDefinitionRoleEntityRecord.init();

export class ENEntityAttributeEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("EntityId", "entityIdAttr", "EntityId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Length", "lengthAttr", "Length", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Decimals", "decimalsAttr", "Decimals", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsMandatory", "isMandatoryAttr", "IsMandatory", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsAutoGenerated", "isAutoGeneratedAttr", "IsAutoGenerated", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OrderNumber", "orderNumberAttr", "OrderNumber", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "EntityAttribute";
}
}



ENEntityAttributeEntityRecord.init();

export class ENProcessStatusEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessStatus";
}
}



ENProcessStatusEntityRecord.init();

export class ENRuntimeTypeEntityRecord extends 
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
this.attr("IsActive", "isActiveAttr", "IsActive", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "RuntimeType";
}
}



ENRuntimeTypeEntityRecord.init();

export class ENEmailEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Size", "sizeAttr", "Size", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Email";
}
}



ENEmailEntityRecord.init();

export class ENProcessDefinitionEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Key", "keyAttr", "Key", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Revision", "revisionAttr", "Revision", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessDefinition";
}
}



ENProcessDefinitionEntityRecord.init();

export class ENActivityDefinitionLinkEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SourceActivityDefinitionId", "sourceActivityDefinitionIdAttr", "SourceActivityDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("TargetActivityDefinitionId", "targetActivityDefinitionIdAttr", "TargetActivityDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsActive", "isActiveAttr", "IsActive", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Outcome", "outcomeAttr", "Outcome", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityDefinitionLink";
}
}



ENActivityDefinitionLinkEntityRecord.init();

export class ENApplicationEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Type", "typeAttr", "Type", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Application";
}
}



ENApplicationEntityRecord.init();

export class ENActivityDefinitionEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Key", "keyAttr", "Key", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ProcessDefinitionId", "processDefinitionIdAttr", "ProcessDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Name", "nameAttr", "Name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Kind", "kindAttr", "Kind", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityDefinition";
}
}



ENActivityDefinitionEntityRecord.init();

export class ENActivityDefinitionLanguageEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ActivityDefinitionId", "activityDefinitionIdAttr", "ActivityDefinitionId", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Locale", "localeAttr", "Locale", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InboxInstructions", "inboxInstructionsAttr", "InboxInstructions", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityDefinitionLanguage";
}
}



ENActivityDefinitionLanguageEntityRecord.init();

export class ENProcessInputEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ProcessId", "processIdAttr", "ProcessId", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("InputDefinitionId", "inputDefinitionIdAttr", "InputDefinitionId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InputDefinitionKey", "inputDefinitionKeyAttr", "InputDefinitionKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InputValue", "inputValueAttr", "InputValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessInput";
}
}



ENProcessInputEntityRecord.init();

export class ENProcessDefinitionLanguageEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ProcessDefinitionId", "processDefinitionIdAttr", "ProcessDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Locale", "localeAttr", "Locale", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessDefinitionLanguage";
}
}



ENProcessDefinitionLanguageEntityRecord.init();

export class ENProcessOutputDefinitionEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Description", "descriptionAttr", "Description", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ProcessDefinitionId", "processDefinitionIdAttr", "ProcessDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsActive", "isActiveAttr", "IsActive", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DefaultValue", "defaultValueAttr", "DefaultValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessOutputDefinition";
}
}



ENProcessOutputDefinitionEntityRecord.init();

export class ENProcessOutputEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ProcessId", "processIdAttr", "ProcessId", false, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("OutputDefinitionId", "outputDefinitionIdAttr", "OutputDefinitionId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OutputDefinitionKey", "outputDefinitionKeyAttr", "OutputDefinitionKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("OutputValue", "outputValueAttr", "OutputValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessOutput";
}
}



ENProcessOutputEntityRecord.init();

export class ENUserEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Email", "emailAttr", "Email", false, false, OS.DataTypes.DataTypes.Email, function () {
return "";
}, true), 
this.attr("PhotoUrl", "photoUrlAttr", "PhotoUrl", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Username", "usernameAttr", "Username", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "User";
}
}



ENUserEntityRecord.init();

export class ENActivityInstanceEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ActivityDefinitionId", "activityDefinitionIdAttr", "ActivityDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ProcessInstanceId", "processInstanceIdAttr", "ProcessInstanceId", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("ProcessDefinitionId", "processDefinitionIdAttr", "ProcessDefinitionId", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Status", "statusAttr", "Status", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("StartedOn", "startedOnAttr", "StartedOn", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("LastModifiedOn", "lastModifiedOnAttr", "LastModifiedOn", false, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, true), 
this.attr("HasExpired", "hasExpiredAttr", "HasExpired", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ActivityInstance";
}
}



ENActivityInstanceEntityRecord.init();

export class ENProcessInputDefinitionEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Key", "keyAttr", "Key", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "Name", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Description", "descriptionAttr", "Description", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("ProcessDefinitionId", "processDefinitionIdAttr", "ProcessDefinitionId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("IsActive", "isActiveAttr", "IsActive", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("DataType", "dataTypeAttr", "DataType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DefaultValue", "defaultValueAttr", "DefaultValue", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsMandatory", "isMandatoryAttr", "IsMandatory", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ForeignKeyEntityId", "foreignKeyEntityIdAttr", "ForeignKeyEntityId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ProcessInputDefinition";
}
}



ENProcessInputDefinitionEntityRecord.init();

export class ENHumanActivityInstanceEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ActivityInstanceId", "activityInstanceIdAttr", "ActivityInstanceId", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("AssignedUserId", "assignedUserIdAttr", "AssignedUserId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "Message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("URL", "uRLAttr", "URL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "HumanActivityInstance";
}
}



ENHumanActivityInstanceEntityRecord.init();



