using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRole
/// </summary>

public static async Task<string> CreateRole(IRequestContext requestContext,RC_13630884b629a3a59e929e1cdea42eb1 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENRoleEntityRecord ssENRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRoleEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
" ) VALUES (" +
" @ssId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENRole.ssId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENRole.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRole
/// </summary>

public static async Task<string> CreateOrUpdateRole(IRequestContext requestContext,BitArray usedFields,RC_13630884b629a3a59e929e1cdea42eb1 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENRoleEntityRecord ssENRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string updateSet = "UPDATE " + ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
string whereCondition = " WHERE \"id\" = @idparam_ssENRole_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@idparam_ssENRole_ssId_", DbType.String, ssENRole.ssId);
int counter = 0;
if(ssENRole.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRole (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRoleEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
" ) VALUES (" +
" @ssId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENRole.ssId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENRole.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRole.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRole
/// </summary>

public static async Task CreateOrUpdateSomeRole(IRequestContext requestContext,RL_db06c2b916049d1c72db56f953d2667f inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENRoleEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\") VALUES ( unnest(@ssId)) ON CONFLICT(\"id\") do update set  ";
insertSql+= "";


List<string> insertIdList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_13630884b629a3a59e929e1cdea42eb1)inParamSourceList.Current).ssENRole;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRole (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRole
/// </summary>

public static async Task DeleteRole(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRole
/// </summary>

public static async Task DeleteAllRole(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#DeleteAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRole
/// </summary>

public static async Task<RC_13630884b629a3a59e929e1cdea42eb1> GetRole(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_13630884b629a3a59e929e1cdea42eb1 outParamRecord = default;
outParamRecord = new RC_13630884b629a3a59e929e1cdea42eb1();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
" FROM " + ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(1,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRoleForUpdate
/// </summary>

public static async Task<RC_13630884b629a3a59e929e1cdea42eb1> GetRoleForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_13630884b629a3a59e929e1cdea42eb1 outParamRecord = default;
outParamRecord = new RC_13630884b629a3a59e929e1cdea42eb1();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRoleForUpdate", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
"FROM " + ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRoleForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(1,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRole
/// </summary>

public static async Task UpdateRole(IRequestContext requestContext,BitArray usedFields,RC_13630884b629a3a59e929e1cdea42eb1 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRole", "e595ea36-5c1b-3ed8-93aa-bba752c7f892.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENRoleEntityRecord ssENRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string updateSet = "UPDATE " + ENRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
string whereCondition = " WHERE \"id\" = @idparam_ssENRole_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@idparam_ssENRole_ssId_", DbType.String, ssENRole.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Role", ssENRole.ssId.ToString()); }}
}
return;
}

}
}
