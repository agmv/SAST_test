using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateTenant
/// </summary>

public static async Task<long> CreateTenant(IRequestContext requestContext,RC_40d0f5c5ba630b105850cead15ae2223 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateTenant", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENTenantEntityRecord ssENTenant = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENTenantEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENTenant.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENTenant.ssName);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateTenant", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENTenant.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateTenant
/// </summary>

public static async Task<long> CreateOrUpdateTenant(IRequestContext requestContext,BitArray usedFields,RC_40d0f5c5ba630b105850cead15ae2223 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateTenant", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENTenantEntityRecord ssENTenant = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(2,true);
}
string updateSet = "UPDATE " + ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENTenant_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"name\" = \"name\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENTenant.ssName);
}
sqlCmd.CreateParameter("@idparam_ssENTenant_ssId_", DbType.Int64, ssENTenant.ssId);
int counter = 0;
if(ssENTenant.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateTenant (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENTenantEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENTenant.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENTenant.ssName);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateTenant", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENTenant.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENTenant.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeTenant
/// </summary>

public static async Task CreateOrUpdateSomeTenant(IRequestContext requestContext,RL_1021a34c12afbc1ae6d31ca4929b6091 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeTenant", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENTenantEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"name\") VALUES ( unnest(@ssId),  unnest(@ssName)) ON CONFLICT(\"id\") do update set \"name\" = EXCLUDED.\"name\" ";
insertSql+= "";


List<long> insertIdList = new List<long>();
List<string> insertNameList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_40d0f5c5ba630b105850cead15ae2223)inParamSourceList.Current).ssENTenant;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertNameList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeTenant (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteTenant
/// </summary>

public static async Task DeleteTenant(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteTenant", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteTenant", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetTenant
/// </summary>

public static async Task<RC_40d0f5c5ba630b105850cead15ae2223> GetTenant(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_40d0f5c5ba630b105850cead15ae2223 outParamRecord = default;
outParamRecord = new RC_40d0f5c5ba630b105850cead15ae2223();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetTenant", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
" FROM " + ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetTenant", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(2,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetTenantForUpdate
/// </summary>

public static async Task<RC_40d0f5c5ba630b105850cead15ae2223> GetTenantForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_40d0f5c5ba630b105850cead15ae2223 outParamRecord = default;
outParamRecord = new RC_40d0f5c5ba630b105850cead15ae2223();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetTenantForUpdate", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
"FROM " + ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetTenantForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(2,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateTenant
/// </summary>

public static async Task UpdateTenant(IRequestContext requestContext,BitArray usedFields,RC_40d0f5c5ba630b105850cead15ae2223 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateTenant", "d30c0359-17ba-4ea6-b76f-f5844a5f9ae5.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENTenantEntityRecord ssENTenant = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(2,true);
}
string updateSet = "UPDATE " + ENTenantEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENTenant_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"name\" = \"name\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENTenant.ssName);
}
sqlCmd.CreateParameter("@idparam_ssENTenant_ssId_", DbType.Int64, ssENTenant.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateTenant", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Tenant", ssENTenant.ssId.ToString()); }}
}
return;
}

}
}
