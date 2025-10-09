using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessInputDefinition
/// </summary>

public static async Task<string> CreateProcessInputDefinition(IRequestContext requestContext,RC_cbc07de8251245064bd8f80b6b35c7f6 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessInputDefinition", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInputDefinitionEntityRecord ssENProcessInputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessInputDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"ismandatory\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssName" +
", @ssDescription" +
", @ssProcessDefinitionId" +
", @ssIsActive" +
", @ssDataType" +
", @ssDefaultValue" +
", @ssIsMandatory" +
", @ssForeignKeyEntityId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENProcessInputDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessInputDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInputDefinition.ssName);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessInputDefinition.ssDescription);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInputDefinition.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessInputDefinition.ssIsActive);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInputDefinition.ssDataType);
insertSqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessInputDefinition.ssDefaultValue);
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENProcessInputDefinition.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInputDefinition.ssForeignKeyEntityId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessInputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessInputDefinition.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessInputDefinition
/// </summary>

public static async Task<string> CreateOrUpdateProcessInputDefinition(IRequestContext requestContext,BitArray usedFields,RC_cbc07de8251245064bd8f80b6b35c7f6 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessInputDefinition", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInputDefinitionEntityRecord ssENProcessInputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"description\" = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"defaultvalue\" = @ssDefaultValue"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"ismandatory\" = @ssIsMandatory"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessInputDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessInputDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInputDefinition.ssName);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessInputDefinition.ssDescription);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInputDefinition.ssProcessDefinitionId);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessInputDefinition.ssIsActive);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInputDefinition.ssDataType);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessInputDefinition.ssDefaultValue);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENProcessInputDefinition.ssIsMandatory);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInputDefinition.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessInputDefinition_ssId_", DbType.String, ssENProcessInputDefinition.ssId);
int counter = 0;
if(ssENProcessInputDefinition.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessInputDefinition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessInputDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"ismandatory\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssName" +
", @ssDescription" +
", @ssProcessDefinitionId" +
", @ssIsActive" +
", @ssDataType" +
", @ssDefaultValue" +
", @ssIsMandatory" +
", @ssForeignKeyEntityId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENProcessInputDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessInputDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInputDefinition.ssName);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessInputDefinition.ssDescription);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInputDefinition.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessInputDefinition.ssIsActive);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInputDefinition.ssDataType);
insertSqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessInputDefinition.ssDefaultValue);
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENProcessInputDefinition.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInputDefinition.ssForeignKeyEntityId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessInputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessInputDefinition.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessInputDefinition.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessInputDefinition
/// </summary>

public static async Task CreateOrUpdateSomeProcessInputDefinition(IRequestContext requestContext,RL_7a20bba9a4dcbce87cc868fa1eaca840 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessInputDefinition", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessInputDefinitionEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"key\", \"name\", \"description\", \"processdefinitionid\", \"isactive\", \"datatype\", \"defaultvalue\", \"ismandatory\", \"foreignkeyentityid\") VALUES ( unnest(@ssId),  unnest(@ssKey),  unnest(@ssName),  unnest(@ssDescription),  unnest(@ssProcessDefinitionId),  unnest(@ssIsActive),  unnest(@ssDataType),  unnest(@ssDefaultValue),  unnest(@ssIsMandatory),  unnest(@ssForeignKeyEntityId)) ON CONFLICT(\"id\") do update set \"key\" = EXCLUDED.\"key\", \"name\" = EXCLUDED.\"name\", \"description\" = EXCLUDED.\"description\", \"processdefinitionid\" = EXCLUDED.\"processdefinitionid\", \"isactive\" = EXCLUDED.\"isactive\", \"datatype\" = EXCLUDED.\"datatype\", \"defaultvalue\" = EXCLUDED.\"defaultvalue\", \"ismandatory\" = EXCLUDED.\"ismandatory\", \"foreignkeyentityid\" = EXCLUDED.\"foreignkeyentityid\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<string> insertKeyList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertDescriptionList = new List<string>();
List<object> insertProcessDefinitionIdList = new List<object>();
List<bool> insertIsActiveList = new List<bool>();
List<string> insertDataTypeList = new List<string>();
List<string> insertDefaultValueList = new List<string>();
List<bool> insertIsMandatoryList = new List<bool>();
List<object> insertForeignKeyEntityIdList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_cbc07de8251245064bd8f80b6b35c7f6)inParamSourceList.Current).ssENProcessInputDefinition;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssKey));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
insertIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
insertDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
insertDefaultValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDefaultValue));
insertIsMandatoryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMandatory));
insertForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertKeyList.IsEmpty() || !insertNameList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertProcessDefinitionIdList.IsEmpty() || !insertIsActiveList.IsEmpty() || !insertDataTypeList.IsEmpty() || !insertDefaultValueList.IsEmpty() || !insertIsMandatoryList.IsEmpty() || !insertForeignKeyEntityIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssKey",DbType.String,insertKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessDefinitionId",DbType.Int32,insertProcessDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsActive",DbType.Boolean,insertIsActiveList);
executionService.CreateParameter(insertSqlCmd,"@ssDataType",DbType.String,insertDataTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssDefaultValue",DbType.String,insertDefaultValueList);
executionService.CreateParameter(insertSqlCmd,"@ssIsMandatory",DbType.Boolean,insertIsMandatoryList);
executionService.CreateParameter(insertSqlCmd,"@ssForeignKeyEntityId",DbType.String,insertForeignKeyEntityIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessInputDefinition (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessInputDefinition
/// </summary>

public static async Task DeleteProcessInputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessInputDefinition", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessInputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessInputDefinition
/// </summary>

public static async Task<RC_cbc07de8251245064bd8f80b6b35c7f6> GetProcessInputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_cbc07de8251245064bd8f80b6b35c7f6 outParamRecord = default;
outParamRecord = new RC_cbc07de8251245064bd8f80b6b35c7f6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessInputDefinition", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"ismandatory\"" +
", \"foreignkeyentityid\"" +
" FROM " + ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessInputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessInputDefinitionForUpdate
/// </summary>

public static async Task<RC_cbc07de8251245064bd8f80b6b35c7f6> GetProcessInputDefinitionForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_cbc07de8251245064bd8f80b6b35c7f6 outParamRecord = default;
outParamRecord = new RC_cbc07de8251245064bd8f80b6b35c7f6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessInputDefinitionForUpdate", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"ismandatory\"" +
", \"foreignkeyentityid\"" +
"FROM " + ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessInputDefinitionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessInputDefinition
/// </summary>

public static async Task UpdateProcessInputDefinition(IRequestContext requestContext,BitArray usedFields,RC_cbc07de8251245064bd8f80b6b35c7f6 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessInputDefinition", "2552fdc5-213f-4443-8a1a-ce2b932e3ddf.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInputDefinitionEntityRecord ssENProcessInputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENProcessInputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"description\" = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"defaultvalue\" = @ssDefaultValue"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"ismandatory\" = @ssIsMandatory"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessInputDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessInputDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInputDefinition.ssName);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessInputDefinition.ssDescription);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInputDefinition.ssProcessDefinitionId);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessInputDefinition.ssIsActive);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInputDefinition.ssDataType);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessInputDefinition.ssDefaultValue);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENProcessInputDefinition.ssIsMandatory);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInputDefinition.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessInputDefinition_ssId_", DbType.String, ssENProcessInputDefinition.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessInputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessInputDefinition", ssENProcessInputDefinition.ssId.ToString()); }}
}
return;
}

}
}
