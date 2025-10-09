using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessOutput
/// </summary>

public static async Task<long> CreateProcessOutput(IRequestContext requestContext,RC_d5e6f13d187b5006f9f88b20f576700b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessOutput", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessOutputEntityRecord ssENProcessOutput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessOutputEntity.LocalViewName(null, null) + " (" +
" \"processid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssProcessId" +
", @ssOutputDefinitionId" +
", @ssOutputDefinitionKey" +
", @ssName" +
", @ssDataType" +
", @ssOutputValue" +
", @ssForeignKeyEntityId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProcessOutput.ssProcessId==0L)) {
insertSqlCmd.CreateParameter("@ssProcessId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessOutput.ssProcessId);

}
insertSqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENProcessOutput.ssOutputDefinitionId);
insertSqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENProcessOutput.ssOutputDefinitionKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutput.ssName);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutput.ssDataType);
insertSqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENProcessOutput.ssOutputValue);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutput.ssForeignKeyEntityId);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessOutput
/// </summary>

public static async Task<long> CreateOrUpdateProcessOutput(IRequestContext requestContext,BitArray usedFields,RC_d5e6f13d187b5006f9f88b20f576700b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessOutput", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessOutputEntityRecord ssENProcessOutput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processid\" = @ssProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionid\" = @ssOutputDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionkey\" = @ssOutputDefinitionKey"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputvalue\" = @ssOutputValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessOutput_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"outputdefinitionid\" = \"outputdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProcessOutput.ssProcessId==0L)) {
sqlCmd.CreateParameter("@ssProcessId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessOutput.ssProcessId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENProcessOutput.ssOutputDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENProcessOutput.ssOutputDefinitionKey);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutput.ssName);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutput.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENProcessOutput.ssOutputValue);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutput.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessOutput_ssId_", DbType.Int64, ssENProcessOutput.ssId);
int counter = 0;
if(ssENProcessOutput.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessOutput (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessOutputEntity.LocalViewName(null, null) + " (" +
" \"processid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssProcessId" +
", @ssOutputDefinitionId" +
", @ssOutputDefinitionKey" +
", @ssName" +
", @ssDataType" +
", @ssOutputValue" +
", @ssForeignKeyEntityId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProcessOutput.ssProcessId==0L)) {
insertSqlCmd.CreateParameter("@ssProcessId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessOutput.ssProcessId);

}
insertSqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENProcessOutput.ssOutputDefinitionId);
insertSqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENProcessOutput.ssOutputDefinitionKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutput.ssName);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutput.ssDataType);
insertSqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENProcessOutput.ssOutputValue);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutput.ssForeignKeyEntityId);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessOutput.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessOutput
/// </summary>

public static async Task CreateOrUpdateSomeProcessOutput(IRequestContext requestContext,RL_bc43d11ed6e576c35db6fd694bd47a1e inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessOutput", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessOutputEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"processid\", \"outputdefinitionid\", \"outputdefinitionkey\", \"name\", \"datatype\", \"outputvalue\", \"foreignkeyentityid\") VALUES ( unnest(@ssProcessId),  unnest(@ssOutputDefinitionId),  unnest(@ssOutputDefinitionKey),  unnest(@ssName),  unnest(@ssDataType),  unnest(@ssOutputValue),  unnest(@ssForeignKeyEntityId)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"processid\" = updateTable.\"processid\", \"outputdefinitionid\" = updateTable.\"outputdefinitionid\", \"outputdefinitionkey\" = updateTable.\"outputdefinitionkey\", \"name\" = updateTable.\"name\", \"datatype\" = updateTable.\"datatype\", \"outputvalue\" = updateTable.\"outputvalue\", \"foreignkeyentityid\" = updateTable.\"foreignkeyentityid\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssProcessId) as \"processid\",  unnest(@ssOutputDefinitionId) as \"outputdefinitionid\",  unnest(@ssOutputDefinitionKey) as \"outputdefinitionkey\",  unnest(@ssName) as \"name\",  unnest(@ssDataType) as \"datatype\",  unnest(@ssOutputValue) as \"outputvalue\",  unnest(@ssForeignKeyEntityId) as \"foreignkeyentityid\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertProcessIdList = new List<object>();
List<object> insertOutputDefinitionIdList = new List<object>();
List<string> insertOutputDefinitionKeyList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertDataTypeList = new List<string>();
List<string> insertOutputValueList = new List<string>();
List<object> insertForeignKeyEntityIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateProcessIdList = new List<object>();
List<object> updateOutputDefinitionIdList = new List<object>();
List<string> updateOutputDefinitionKeyList = new List<string>();
List<string> updateNameList = new List<string>();
List<string> updateDataTypeList = new List<string>();
List<string> updateOutputValueList = new List<string>();
List<object> updateForeignKeyEntityIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_d5e6f13d187b5006f9f88b20f576700b)inParamSourceList.Current).ssENProcessOutput;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssProcessId==0L)) {
updateProcessIdList.Add(null);
} else {
updateProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProcessId));
}
updateOutputDefinitionIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionId));
updateOutputDefinitionKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionKey));
updateNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
updateDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
updateOutputValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputValue));
updateForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
} else {
if ((record.ssProcessId==0L)) {
insertProcessIdList.Add(null);
} else {
insertProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProcessId));
}
insertOutputDefinitionIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionId));
insertOutputDefinitionKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionKey));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
insertOutputValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputValue));
insertForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProcessIdList.IsEmpty() || !insertOutputDefinitionIdList.IsEmpty() || !insertOutputDefinitionKeyList.IsEmpty() || !insertNameList.IsEmpty() || !insertDataTypeList.IsEmpty() || !insertOutputValueList.IsEmpty() || !insertForeignKeyEntityIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProcessId",DbType.Int64,insertProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOutputDefinitionId",DbType.String,insertOutputDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOutputDefinitionKey",DbType.String,insertOutputDefinitionKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssDataType",DbType.String,insertDataTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssOutputValue",DbType.String,insertOutputValueList);
executionService.CreateParameter(insertSqlCmd,"@ssForeignKeyEntityId",DbType.String,insertForeignKeyEntityIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessOutput (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProcessIdList.IsEmpty() || !updateOutputDefinitionIdList.IsEmpty() || !updateOutputDefinitionKeyList.IsEmpty() || !updateNameList.IsEmpty() || !updateDataTypeList.IsEmpty() || !updateOutputValueList.IsEmpty() || !updateForeignKeyEntityIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessId",DbType.Int64,updateProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOutputDefinitionId",DbType.String,updateOutputDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOutputDefinitionKey",DbType.String,updateOutputDefinitionKeyList);
executionService.CreateParameter(updateSqlCmd,"@ssName",DbType.String,updateNameList);
executionService.CreateParameter(updateSqlCmd,"@ssDataType",DbType.String,updateDataTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssOutputValue",DbType.String,updateOutputValueList);
executionService.CreateParameter(updateSqlCmd,"@ssForeignKeyEntityId",DbType.String,updateForeignKeyEntityIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessOutput (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessOutput
/// </summary>

public static async Task DeleteProcessOutput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessOutput", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessOutput
/// </summary>

public static async Task<RC_d5e6f13d187b5006f9f88b20f576700b> GetProcessOutput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d5e6f13d187b5006f9f88b20f576700b outParamRecord = default;
outParamRecord = new RC_d5e6f13d187b5006f9f88b20f576700b();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessOutput", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
" FROM " + ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessOutputForUpdate
/// </summary>

public static async Task<RC_d5e6f13d187b5006f9f88b20f576700b> GetProcessOutputForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d5e6f13d187b5006f9f88b20f576700b outParamRecord = default;
outParamRecord = new RC_d5e6f13d187b5006f9f88b20f576700b();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessOutputForUpdate", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
"FROM " + ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessOutputForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessOutput
/// </summary>

public static async Task UpdateProcessOutput(IRequestContext requestContext,BitArray usedFields,RC_d5e6f13d187b5006f9f88b20f576700b inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessOutput", "94a44451-4a29-42d9-8d1c-399f614fdd8a.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessOutputEntityRecord ssENProcessOutput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProcessOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processid\" = @ssProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionid\" = @ssOutputDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionkey\" = @ssOutputDefinitionKey"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputvalue\" = @ssOutputValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessOutput_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"outputdefinitionid\" = \"outputdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProcessOutput.ssProcessId==0L)) {
sqlCmd.CreateParameter("@ssProcessId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProcessId", DbType.Int64, ssENProcessOutput.ssProcessId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENProcessOutput.ssOutputDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENProcessOutput.ssOutputDefinitionKey);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutput.ssName);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutput.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENProcessOutput.ssOutputValue);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutput.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessOutput_ssId_", DbType.Int64, ssENProcessOutput.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessOutput", ssENProcessOutput.ssId.ToString()); }}
}
return;
}

}
}
