using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityDefinition
/// </summary>

public static async Task<int> CreateActivityDefinition(IRequestContext requestContext,RC_a04f94cfd410c813b8dee156f64b6537 inParamSource,CancellationToken cancellationToken) {
int outParamId = default;
outParamId = 0;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityDefinition", "3281c7ef-b335-ae23-327f-e22de6d18b53.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionEntityRecord ssENActivityDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"processdefinitionid\"" +
", \"name\"" +
", \"kind\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssProcessDefinitionId" +
", @ssName" +
", @ssKind" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int32, ssENActivityDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityDefinition.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityDefinition.ssName);
insertSqlCmd.CreateParameter("@ssKind", DbType.Int64, ssENActivityDefinition.ssKind);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENActivityDefinition.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityDefinition
/// </summary>

public static async Task<int> CreateOrUpdateActivityDefinition(IRequestContext requestContext,BitArray usedFields,RC_a04f94cfd410c813b8dee156f64b6537 inParamSource,CancellationToken cancellationToken) {
int outParamId = default;
outParamId = 0;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityDefinition", "3281c7ef-b335-ae23-327f-e22de6d18b53.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionEntityRecord ssENActivityDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"kind\" = @ssKind"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityDefinition.ssProcessDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityDefinition.ssName);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssKind", DbType.Int64, ssENActivityDefinition.ssKind);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinition_ssId_", DbType.Int32, ssENActivityDefinition.ssId);
int counter = 0;
if(ssENActivityDefinition.ssId != 0) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"key\"" +
", \"processdefinitionid\"" +
", \"name\"" +
", \"kind\"" +
" ) VALUES (" +
" @ssId" +
", @ssKey" +
", @ssProcessDefinitionId" +
", @ssName" +
", @ssKind" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int32, ssENActivityDefinition.ssId);
insertSqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityDefinition.ssKey);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityDefinition.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityDefinition.ssName);
insertSqlCmd.CreateParameter("@ssKind", DbType.Int64, ssENActivityDefinition.ssKind);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENActivityDefinition.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityDefinition.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityDefinition
/// </summary>

public static async Task CreateOrUpdateSomeActivityDefinition(IRequestContext requestContext,RL_3e3c312f4b244ea01713a0fa4a15518a inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityDefinition", "3281c7ef-b335-ae23-327f-e22de6d18b53.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityDefinitionEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"key\", \"processdefinitionid\", \"name\", \"kind\") VALUES ( unnest(@ssId),  unnest(@ssKey),  unnest(@ssProcessDefinitionId),  unnest(@ssName),  unnest(@ssKind)) ON CONFLICT(\"id\") do update set \"key\" = EXCLUDED.\"key\", \"processdefinitionid\" = EXCLUDED.\"processdefinitionid\", \"name\" = EXCLUDED.\"name\", \"kind\" = EXCLUDED.\"kind\" ";
insertSql+= "";


List<int> insertIdList = new List<int>();
List<string> insertKeyList = new List<string>();
List<object> insertProcessDefinitionIdList = new List<object>();
List<string> insertNameList = new List<string>();
List<object> insertKindList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_a04f94cfd410c813b8dee156f64b6537)inParamSourceList.Current).ssENActivityDefinition;
insertIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssId));
insertKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssKey));
insertProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertKindList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssKind));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertKeyList.IsEmpty() || !insertProcessDefinitionIdList.IsEmpty() || !insertNameList.IsEmpty() || !insertKindList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int32,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssKey",DbType.String,insertKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessDefinitionId",DbType.Int32,insertProcessDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssKind",DbType.Int64,insertKindList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityDefinition (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityDefinition
/// </summary>

public static async Task DeleteActivityDefinition(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityDefinition", "3281c7ef-b335-ae23-327f-e22de6d18b53.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityDefinition
/// </summary>

public static async Task<RC_a04f94cfd410c813b8dee156f64b6537> GetActivityDefinition(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a04f94cfd410c813b8dee156f64b6537 outParamRecord = default;
outParamRecord = new RC_a04f94cfd410c813b8dee156f64b6537();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinition", "3281c7ef-b335-ae23-327f-e22de6d18b53.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"processdefinitionid\"" +
", \"name\"" +
", \"kind\"" +
" FROM " + ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityDefinitionForUpdate
/// </summary>

public static async Task<RC_a04f94cfd410c813b8dee156f64b6537> GetActivityDefinitionForUpdate(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a04f94cfd410c813b8dee156f64b6537 outParamRecord = default;
outParamRecord = new RC_a04f94cfd410c813b8dee156f64b6537();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionForUpdate", "3281c7ef-b335-ae23-327f-e22de6d18b53.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"key\"" +
", \"processdefinitionid\"" +
", \"name\"" +
", \"kind\"" +
"FROM " + ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityDefinition
/// </summary>

public static async Task UpdateActivityDefinition(IRequestContext requestContext,BitArray usedFields,RC_a04f94cfd410c813b8dee156f64b6537 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityDefinition", "3281c7ef-b335-ae23-327f-e22de6d18b53.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionEntityRecord ssENActivityDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"key\" = @ssKey"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"kind\" = @ssKind"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssKey", DbType.String, ssENActivityDefinition.ssKey);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityDefinition.ssProcessDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityDefinition.ssName);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssKind", DbType.Int64, ssENActivityDefinition.ssKind);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinition_ssId_", DbType.Int32, ssENActivityDefinition.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityDefinition", ssENActivityDefinition.ssId.ToString()); }}
}
return;
}

}
}
