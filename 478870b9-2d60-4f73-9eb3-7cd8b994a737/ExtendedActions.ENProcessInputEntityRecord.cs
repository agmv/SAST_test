using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessInput
/// </summary>

public static async Task<long> CreateProcessInput(IRequestContext requestContext,RC_d43fed74d1678e954ae3786a22cd1029 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessInput", "6d9a582f-603a-486a-9df7-d4064fc1149a.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInputEntityRecord ssENProcessInput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessInputEntity.LocalViewName(null, null) + " (" +
" \"processid\"" +
", \"inputdefinitionid\"" +
", \"inputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"inputvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssProcessId" +
", @ssInputDefinitionId" +
", @ssInputDefinitionKey" +
", @ssName" +
", @ssDataType" +
", @ssInputValue" +
", @ssForeignKeyEntityId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessInput.ssProcessId);
insertSqlCmd.CreateParameter("@ssInputDefinitionId", DbType.String, ssENProcessInput.ssInputDefinitionId);
insertSqlCmd.CreateParameter("@ssInputDefinitionKey", DbType.String, ssENProcessInput.ssInputDefinitionKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInput.ssName);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInput.ssDataType);
insertSqlCmd.CreateParameter("@ssInputValue", DbType.String, ssENProcessInput.ssInputValue);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInput.ssForeignKeyEntityId);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessInput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessInput
/// </summary>

public static async Task<long> CreateOrUpdateProcessInput(IRequestContext requestContext,BitArray usedFields,RC_d43fed74d1678e954ae3786a22cd1029 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessInput", "6d9a582f-603a-486a-9df7-d4064fc1149a.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInputEntityRecord ssENProcessInput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processid\" = @ssProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inputdefinitionid\" = @ssInputDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inputdefinitionkey\" = @ssInputDefinitionKey"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inputvalue\" = @ssInputValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessInput_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"inputdefinitionid\" = \"inputdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessInput.ssProcessId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssInputDefinitionId", DbType.String, ssENProcessInput.ssInputDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssInputDefinitionKey", DbType.String, ssENProcessInput.ssInputDefinitionKey);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInput.ssName);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInput.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssInputValue", DbType.String, ssENProcessInput.ssInputValue);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInput.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessInput_ssId_", DbType.Int64, ssENProcessInput.ssId);
int counter = 0;
if(ssENProcessInput.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessInput (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessInputEntity.LocalViewName(null, null) + " (" +
" \"processid\"" +
", \"inputdefinitionid\"" +
", \"inputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"inputvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssProcessId" +
", @ssInputDefinitionId" +
", @ssInputDefinitionKey" +
", @ssName" +
", @ssDataType" +
", @ssInputValue" +
", @ssForeignKeyEntityId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessInput.ssProcessId);
insertSqlCmd.CreateParameter("@ssInputDefinitionId", DbType.String, ssENProcessInput.ssInputDefinitionId);
insertSqlCmd.CreateParameter("@ssInputDefinitionKey", DbType.String, ssENProcessInput.ssInputDefinitionKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInput.ssName);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInput.ssDataType);
insertSqlCmd.CreateParameter("@ssInputValue", DbType.String, ssENProcessInput.ssInputValue);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInput.ssForeignKeyEntityId);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessInput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessInput.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessInput
/// </summary>

public static async Task CreateOrUpdateSomeProcessInput(IRequestContext requestContext,RL_d3784dc8f20ed95f2aa0989c41c24312 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessInput", "6d9a582f-603a-486a-9df7-d4064fc1149a.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessInputEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"processid\", \"inputdefinitionid\", \"inputdefinitionkey\", \"name\", \"datatype\", \"inputvalue\", \"foreignkeyentityid\") VALUES ( unnest(@ssProcessId),  unnest(@ssInputDefinitionId),  unnest(@ssInputDefinitionKey),  unnest(@ssName),  unnest(@ssDataType),  unnest(@ssInputValue),  unnest(@ssForeignKeyEntityId)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"processid\" = updateTable.\"processid\", \"inputdefinitionid\" = updateTable.\"inputdefinitionid\", \"inputdefinitionkey\" = updateTable.\"inputdefinitionkey\", \"name\" = updateTable.\"name\", \"datatype\" = updateTable.\"datatype\", \"inputvalue\" = updateTable.\"inputvalue\", \"foreignkeyentityid\" = updateTable.\"foreignkeyentityid\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssProcessId) as \"processid\",  unnest(@ssInputDefinitionId) as \"inputdefinitionid\",  unnest(@ssInputDefinitionKey) as \"inputdefinitionkey\",  unnest(@ssName) as \"name\",  unnest(@ssDataType) as \"datatype\",  unnest(@ssInputValue) as \"inputvalue\",  unnest(@ssForeignKeyEntityId) as \"foreignkeyentityid\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertProcessIdList = new List<object>();
List<object> insertInputDefinitionIdList = new List<object>();
List<string> insertInputDefinitionKeyList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertDataTypeList = new List<string>();
List<string> insertInputValueList = new List<string>();
List<object> insertForeignKeyEntityIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateProcessIdList = new List<object>();
List<object> updateInputDefinitionIdList = new List<object>();
List<string> updateInputDefinitionKeyList = new List<string>();
List<string> updateNameList = new List<string>();
List<string> updateDataTypeList = new List<string>();
List<string> updateInputValueList = new List<string>();
List<object> updateForeignKeyEntityIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_d43fed74d1678e954ae3786a22cd1029)inParamSourceList.Current).ssENProcessInput;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProcessId));
updateInputDefinitionIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputDefinitionId));
updateInputDefinitionKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputDefinitionKey));
updateNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
updateDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
updateInputValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputValue));
updateForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
} else {
insertProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProcessId));
insertInputDefinitionIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputDefinitionId));
insertInputDefinitionKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputDefinitionKey));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
insertInputValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputValue));
insertForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProcessIdList.IsEmpty() || !insertInputDefinitionIdList.IsEmpty() || !insertInputDefinitionKeyList.IsEmpty() || !insertNameList.IsEmpty() || !insertDataTypeList.IsEmpty() || !insertInputValueList.IsEmpty() || !insertForeignKeyEntityIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProcessId",DbType.Int64,insertProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInputDefinitionId",DbType.String,insertInputDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInputDefinitionKey",DbType.String,insertInputDefinitionKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssDataType",DbType.String,insertDataTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssInputValue",DbType.String,insertInputValueList);
executionService.CreateParameter(insertSqlCmd,"@ssForeignKeyEntityId",DbType.String,insertForeignKeyEntityIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessInput (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProcessIdList.IsEmpty() || !updateInputDefinitionIdList.IsEmpty() || !updateInputDefinitionKeyList.IsEmpty() || !updateNameList.IsEmpty() || !updateDataTypeList.IsEmpty() || !updateInputValueList.IsEmpty() || !updateForeignKeyEntityIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessId",DbType.Int64,updateProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInputDefinitionId",DbType.String,updateInputDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInputDefinitionKey",DbType.String,updateInputDefinitionKeyList);
executionService.CreateParameter(updateSqlCmd,"@ssName",DbType.String,updateNameList);
executionService.CreateParameter(updateSqlCmd,"@ssDataType",DbType.String,updateDataTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssInputValue",DbType.String,updateInputValueList);
executionService.CreateParameter(updateSqlCmd,"@ssForeignKeyEntityId",DbType.String,updateForeignKeyEntityIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessInput (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessInput
/// </summary>

public static async Task DeleteProcessInput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessInput", "6d9a582f-603a-486a-9df7-d4064fc1149a.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessInput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessInput
/// </summary>

public static async Task<RC_d43fed74d1678e954ae3786a22cd1029> GetProcessInput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d43fed74d1678e954ae3786a22cd1029 outParamRecord = default;
outParamRecord = new RC_d43fed74d1678e954ae3786a22cd1029();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessInput", "6d9a582f-603a-486a-9df7-d4064fc1149a.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processid\"" +
", \"inputdefinitionid\"" +
", \"inputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"inputvalue\"" +
", \"foreignkeyentityid\"" +
" FROM " + ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessInput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessInputForUpdate
/// </summary>

public static async Task<RC_d43fed74d1678e954ae3786a22cd1029> GetProcessInputForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d43fed74d1678e954ae3786a22cd1029 outParamRecord = default;
outParamRecord = new RC_d43fed74d1678e954ae3786a22cd1029();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessInputForUpdate", "6d9a582f-603a-486a-9df7-d4064fc1149a.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processid\"" +
", \"inputdefinitionid\"" +
", \"inputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"inputvalue\"" +
", \"foreignkeyentityid\"" +
"FROM " + ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessInputForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessInput
/// </summary>

public static async Task UpdateProcessInput(IRequestContext requestContext,BitArray usedFields,RC_d43fed74d1678e954ae3786a22cd1029 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessInput", "6d9a582f-603a-486a-9df7-d4064fc1149a.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInputEntityRecord ssENProcessInput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProcessInputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processid\" = @ssProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inputdefinitionid\" = @ssInputDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inputdefinitionkey\" = @ssInputDefinitionKey"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inputvalue\" = @ssInputValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessInput_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"inputdefinitionid\" = \"inputdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessInput.ssProcessId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssInputDefinitionId", DbType.String, ssENProcessInput.ssInputDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssInputDefinitionKey", DbType.String, ssENProcessInput.ssInputDefinitionKey);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessInput.ssName);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessInput.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssInputValue", DbType.String, ssENProcessInput.ssInputValue);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessInput.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessInput_ssId_", DbType.Int64, ssENProcessInput.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessInput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessInput", ssENProcessInput.ssId.ToString()); }}
}
return;
}

}
}
