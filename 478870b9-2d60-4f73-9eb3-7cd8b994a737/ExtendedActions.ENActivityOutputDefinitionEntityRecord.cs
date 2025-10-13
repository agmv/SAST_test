using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityOutputDefinition
/// </summary>

public static async Task<string> CreateActivityOutputDefinition(IRequestContext requestContext,RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityOutputDefinition", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityOutputDefinitionEntityRecord ssENActivityOutputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityOutputDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"activitydefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"isinput\"" +
", \"ismandatory\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssName" +
", @ssDescription" +
", @ssActivityDefinitionId" +
", @ssIsActive" +
", @ssDataType" +
", @ssIsInput" +
", @ssIsMandatory" +
", @ssDefaultValue" +
", @ssForeignKeyEntityId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENActivityOutputDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityOutputDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutputDefinition.ssName);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActivityOutputDefinition.ssDescription);
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityOutputDefinition.ssActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityOutputDefinition.ssIsActive);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutputDefinition.ssDataType);
insertSqlCmd.CreateParameter("@ssIsInput", DbType.Boolean, ssENActivityOutputDefinition.ssIsInput);
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENActivityOutputDefinition.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENActivityOutputDefinition.ssDefaultValue);
if ((ssENActivityOutputDefinition.ssForeignKeyEntityId=="")) {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutputDefinition.ssForeignKeyEntityId);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENActivityOutputDefinition.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityOutputDefinition
/// </summary>

public static async Task<string> CreateOrUpdateActivityOutputDefinition(IRequestContext requestContext,BitArray usedFields,RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityOutputDefinition", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityOutputDefinitionEntityRecord ssENActivityOutputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(11,true);
}
string updateSet = "UPDATE " + ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"description\" = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isinput\" = @ssIsInput"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"ismandatory\" = @ssIsMandatory"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"defaultvalue\" = @ssDefaultValue"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityOutputDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityOutputDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutputDefinition.ssName);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActivityOutputDefinition.ssDescription);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityOutputDefinition.ssActivityDefinitionId);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityOutputDefinition.ssIsActive);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutputDefinition.ssDataType);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsInput", DbType.Boolean, ssENActivityOutputDefinition.ssIsInput);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENActivityOutputDefinition.ssIsMandatory);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENActivityOutputDefinition.ssDefaultValue);
}
if(usedFields[10]) {
if ((ssENActivityOutputDefinition.ssForeignKeyEntityId=="")) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutputDefinition.ssForeignKeyEntityId);

}
}
sqlCmd.CreateParameter("@idparam_ssENActivityOutputDefinition_ssId_", DbType.String, ssENActivityOutputDefinition.ssId);
int counter = 0;
if(ssENActivityOutputDefinition.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityOutputDefinition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityOutputDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"activitydefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"isinput\"" +
", \"ismandatory\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssName" +
", @ssDescription" +
", @ssActivityDefinitionId" +
", @ssIsActive" +
", @ssDataType" +
", @ssIsInput" +
", @ssIsMandatory" +
", @ssDefaultValue" +
", @ssForeignKeyEntityId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENActivityOutputDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityOutputDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutputDefinition.ssName);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActivityOutputDefinition.ssDescription);
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityOutputDefinition.ssActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityOutputDefinition.ssIsActive);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutputDefinition.ssDataType);
insertSqlCmd.CreateParameter("@ssIsInput", DbType.Boolean, ssENActivityOutputDefinition.ssIsInput);
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENActivityOutputDefinition.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENActivityOutputDefinition.ssDefaultValue);
if ((ssENActivityOutputDefinition.ssForeignKeyEntityId=="")) {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutputDefinition.ssForeignKeyEntityId);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENActivityOutputDefinition.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityOutputDefinition.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityOutputDefinition
/// </summary>

public static async Task CreateOrUpdateSomeActivityOutputDefinition(IRequestContext requestContext,RL_382066feb08849f8e2adc5062ac75efa inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityOutputDefinition", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityOutputDefinitionEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"key\", \"name\", \"description\", \"activitydefinitionid\", \"isactive\", \"datatype\", \"isinput\", \"ismandatory\", \"defaultvalue\", \"foreignkeyentityid\") VALUES ( unnest(@ssId),  unnest(@ssKey),  unnest(@ssName),  unnest(@ssDescription),  unnest(@ssActivityDefinitionId),  unnest(@ssIsActive),  unnest(@ssDataType),  unnest(@ssIsInput),  unnest(@ssIsMandatory),  unnest(@ssDefaultValue),  unnest(@ssForeignKeyEntityId)) ON CONFLICT(\"id\") do update set \"key\" = EXCLUDED.\"key\", \"name\" = EXCLUDED.\"name\", \"description\" = EXCLUDED.\"description\", \"activitydefinitionid\" = EXCLUDED.\"activitydefinitionid\", \"isactive\" = EXCLUDED.\"isactive\", \"datatype\" = EXCLUDED.\"datatype\", \"isinput\" = EXCLUDED.\"isinput\", \"ismandatory\" = EXCLUDED.\"ismandatory\", \"defaultvalue\" = EXCLUDED.\"defaultvalue\", \"foreignkeyentityid\" = EXCLUDED.\"foreignkeyentityid\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<string> insertKeyList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertDescriptionList = new List<string>();
List<object> insertActivityDefinitionIdList = new List<object>();
List<bool> insertIsActiveList = new List<bool>();
List<string> insertDataTypeList = new List<string>();
List<bool> insertIsInputList = new List<bool>();
List<bool> insertIsMandatoryList = new List<bool>();
List<string> insertDefaultValueList = new List<string>();
List<object> insertForeignKeyEntityIdList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_8535fa70cf0bfd6fa50f69a53d3b4ae1)inParamSourceList.Current).ssENActivityOutputDefinition;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssKey));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
insertIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
insertDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
insertIsInputList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsInput));
insertIsMandatoryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMandatory));
insertDefaultValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDefaultValue));
if ((record.ssForeignKeyEntityId=="")) {
insertForeignKeyEntityIdList.Add(null);
} else {
insertForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertKeyList.IsEmpty() || !insertNameList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertActivityDefinitionIdList.IsEmpty() || !insertIsActiveList.IsEmpty() || !insertDataTypeList.IsEmpty() || !insertIsInputList.IsEmpty() || !insertIsMandatoryList.IsEmpty() || !insertDefaultValueList.IsEmpty() || !insertForeignKeyEntityIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssKey",DbType.String,insertKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssActivityDefinitionId",DbType.Int32,insertActivityDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsActive",DbType.Boolean,insertIsActiveList);
executionService.CreateParameter(insertSqlCmd,"@ssDataType",DbType.String,insertDataTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssIsInput",DbType.Boolean,insertIsInputList);
executionService.CreateParameter(insertSqlCmd,"@ssIsMandatory",DbType.Boolean,insertIsMandatoryList);
executionService.CreateParameter(insertSqlCmd,"@ssDefaultValue",DbType.String,insertDefaultValueList);
executionService.CreateParameter(insertSqlCmd,"@ssForeignKeyEntityId",DbType.String,insertForeignKeyEntityIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityOutputDefinition (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityOutputDefinition
/// </summary>

public static async Task DeleteActivityOutputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityOutputDefinition", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityOutputDefinition
/// </summary>

public static async Task<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> GetActivityOutputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 outParamRecord = default;
outParamRecord = new RC_8535fa70cf0bfd6fa50f69a53d3b4ae1();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityOutputDefinition", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"activitydefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"isinput\"" +
", \"ismandatory\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
" FROM " + ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(11,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityOutputDefinitionForUpdate
/// </summary>

public static async Task<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> GetActivityOutputDefinitionForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 outParamRecord = default;
outParamRecord = new RC_8535fa70cf0bfd6fa50f69a53d3b4ae1();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityOutputDefinitionForUpdate", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"activitydefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"isinput\"" +
", \"ismandatory\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
"FROM " + ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityOutputDefinitionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(11,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityOutputDefinition
/// </summary>

public static async Task UpdateActivityOutputDefinition(IRequestContext requestContext,BitArray usedFields,RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityOutputDefinition", "4f3e548e-529a-47f7-9ee8-3f8668f028e6.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityOutputDefinitionEntityRecord ssENActivityOutputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(11,true);
}
string updateSet = "UPDATE " + ENActivityOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"description\" = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isinput\" = @ssIsInput"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"ismandatory\" = @ssIsMandatory"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"defaultvalue\" = @ssDefaultValue"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityOutputDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityOutputDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutputDefinition.ssName);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActivityOutputDefinition.ssDescription);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityOutputDefinition.ssActivityDefinitionId);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityOutputDefinition.ssIsActive);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutputDefinition.ssDataType);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsInput", DbType.Boolean, ssENActivityOutputDefinition.ssIsInput);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENActivityOutputDefinition.ssIsMandatory);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENActivityOutputDefinition.ssDefaultValue);
}
if(usedFields[10]) {
if ((ssENActivityOutputDefinition.ssForeignKeyEntityId=="")) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutputDefinition.ssForeignKeyEntityId);

}
}
sqlCmd.CreateParameter("@idparam_ssENActivityOutputDefinition_ssId_", DbType.String, ssENActivityOutputDefinition.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityOutputDefinition", ssENActivityOutputDefinition.ssId.ToString()); }}
}
return;
}

}
}
