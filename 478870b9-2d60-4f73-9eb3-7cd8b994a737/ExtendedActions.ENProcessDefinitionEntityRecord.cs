using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessDefinition
/// </summary>

public static async Task<int> CreateProcessDefinition(IRequestContext requestContext,RC_80c865ccf1b0df95391817b0ddc45e18 inParamSource,CancellationToken cancellationToken) {
int outParamId = default;
outParamId = 0;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessDefinition", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessDefinitionEntityRecord ssENProcessDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"revision\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssName" +
", @ssRevision" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int32, ssENProcessDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessDefinition.ssName);
insertSqlCmd.CreateParameter("@ssRevision", DbType.Int32, ssENProcessDefinition.ssRevision);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessDefinition.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessDefinition
/// </summary>

public static async Task<int> CreateOrUpdateProcessDefinition(IRequestContext requestContext,BitArray usedFields,RC_80c865ccf1b0df95391817b0ddc45e18 inParamSource,CancellationToken cancellationToken) {
int outParamId = default;
outParamId = 0;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessDefinition", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessDefinitionEntityRecord ssENProcessDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"revision\" = @ssRevision"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessDefinition.ssName);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssRevision", DbType.Int32, ssENProcessDefinition.ssRevision);
}
sqlCmd.CreateParameter("@idparam_ssENProcessDefinition_ssId_", DbType.Int32, ssENProcessDefinition.ssId);
int counter = 0;
if(ssENProcessDefinition.ssId != 0) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessDefinition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"revision\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssName" +
", @ssRevision" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int32, ssENProcessDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessDefinition.ssName);
insertSqlCmd.CreateParameter("@ssRevision", DbType.Int32, ssENProcessDefinition.ssRevision);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessDefinition.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessDefinition.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessDefinition
/// </summary>

public static async Task CreateOrUpdateSomeProcessDefinition(IRequestContext requestContext,RL_d68e5346549cf39dd97c26423ec75146 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessDefinition", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessDefinitionEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"key\", \"name\", \"revision\") VALUES ( unnest(@ssId),  unnest(@ssKey),  unnest(@ssName),  unnest(@ssRevision)) ON CONFLICT(\"id\") do update set \"key\" = EXCLUDED.\"key\", \"name\" = EXCLUDED.\"name\", \"revision\" = EXCLUDED.\"revision\" ";
insertSql+= "";


List<int> insertIdList = new List<int>();
List<string> insertKeyList = new List<string>();
List<string> insertNameList = new List<string>();
List<int> insertRevisionList = new List<int>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_80c865ccf1b0df95391817b0ddc45e18)inParamSourceList.Current).ssENProcessDefinition;
insertIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssId));
insertKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssKey));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertRevisionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssRevision));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertKeyList.IsEmpty() || !insertNameList.IsEmpty() || !insertRevisionList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int32,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssKey",DbType.String,insertKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssRevision",DbType.Int32,insertRevisionList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessDefinition (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessDefinition
/// </summary>

public static async Task DeleteProcessDefinition(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessDefinition", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessDefinition
/// </summary>

public static async Task<RC_80c865ccf1b0df95391817b0ddc45e18> GetProcessDefinition(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_80c865ccf1b0df95391817b0ddc45e18 outParamRecord = default;
outParamRecord = new RC_80c865ccf1b0df95391817b0ddc45e18();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessDefinition", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"revision\"" +
" FROM " + ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessDefinitionForUpdate
/// </summary>

public static async Task<RC_80c865ccf1b0df95391817b0ddc45e18> GetProcessDefinitionForUpdate(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_80c865ccf1b0df95391817b0ddc45e18 outParamRecord = default;
outParamRecord = new RC_80c865ccf1b0df95391817b0ddc45e18();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessDefinitionForUpdate", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"name\"" +
", \"revision\"" +
"FROM " + ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessDefinitionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessDefinition
/// </summary>

public static async Task UpdateProcessDefinition(IRequestContext requestContext,BitArray usedFields,RC_80c865ccf1b0df95391817b0ddc45e18 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessDefinition", "334ffbf7-fe6a-d509-6a22-5f250ad47bf7.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessDefinitionEntityRecord ssENProcessDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENProcessDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"revision\" = @ssRevision"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENProcessDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessDefinition.ssName);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssRevision", DbType.Int32, ssENProcessDefinition.ssRevision);
}
sqlCmd.CreateParameter("@idparam_ssENProcessDefinition_ssId_", DbType.Int32, ssENProcessDefinition.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessDefinition", ssENProcessDefinition.ssId.ToString()); }}
}
return;
}

}
}
