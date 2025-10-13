using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityDefinitionRole
/// </summary>

public static async Task<long> CreateActivityDefinitionRole(IRequestContext requestContext,RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityDefinitionRole", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionRoleEntityRecord ssENActivityDefinitionRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionRoleEntity.LocalViewName(null, null) + " (" +
" \"roleid\"" +
", \"activitydefinitionid\"" +
" ) VALUES (" +
" @ssRoleId" +
", @ssActivityDefinitionId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssRoleId", DbType.String, ssENActivityDefinitionRole.ssRoleId);
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionRole.ssActivityDefinitionId);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityDefinitionRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityDefinitionRole
/// </summary>

public static async Task<long> CreateOrUpdateActivityDefinitionRole(IRequestContext requestContext,BitArray usedFields,RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityDefinitionRole", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionRoleEntityRecord ssENActivityDefinitionRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"roleid\" = @ssRoleId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinitionRole_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"activitydefinitionid\" = \"activitydefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssRoleId", DbType.String, ssENActivityDefinitionRole.ssRoleId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionRole.ssActivityDefinitionId);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinitionRole_ssId_", DbType.Int64, ssENActivityDefinitionRole.ssId);
int counter = 0;
if(ssENActivityDefinitionRole.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinitionRole (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionRoleEntity.LocalViewName(null, null) + " (" +
" \"roleid\"" +
", \"activitydefinitionid\"" +
" ) VALUES (" +
" @ssRoleId" +
", @ssActivityDefinitionId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssRoleId", DbType.String, ssENActivityDefinitionRole.ssRoleId);
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionRole.ssActivityDefinitionId);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinitionRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityDefinitionRole.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityDefinitionRole
/// </summary>

public static async Task CreateOrUpdateSomeActivityDefinitionRole(IRequestContext requestContext,RL_998b7e962bf7fec9cf03c9baf25fb2da inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityDefinitionRole", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityDefinitionRoleEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"roleid\", \"activitydefinitionid\") VALUES ( unnest(@ssRoleId),  unnest(@ssActivityDefinitionId)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"roleid\" = updateTable.\"roleid\", \"activitydefinitionid\" = updateTable.\"activitydefinitionid\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssRoleId) as \"roleid\",  unnest(@ssActivityDefinitionId) as \"activitydefinitionid\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertRoleIdList = new List<object>();
List<object> insertActivityDefinitionIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateRoleIdList = new List<object>();
List<object> updateActivityDefinitionIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae)inParamSourceList.Current).ssENActivityDefinitionRole;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateRoleIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRoleId));
updateActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
} else {
insertRoleIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRoleId));
insertActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRoleIdList.IsEmpty() || !insertActivityDefinitionIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRoleId",DbType.String,insertRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssActivityDefinitionId",DbType.Int32,insertActivityDefinitionIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityDefinitionRole (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRoleIdList.IsEmpty() || !updateActivityDefinitionIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRoleId",DbType.String,updateRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssActivityDefinitionId",DbType.Int32,updateActivityDefinitionIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityDefinitionRole (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityDefinitionRole
/// </summary>

public static async Task DeleteActivityDefinitionRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityDefinitionRole", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityDefinitionRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityDefinitionRole
/// </summary>

public static async Task<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> GetActivityDefinitionRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae outParamRecord = default;
outParamRecord = new RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionRole", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"roleid\"" +
", \"activitydefinitionid\"" +
" FROM " + ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityDefinitionRoleForUpdate
/// </summary>

public static async Task<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> GetActivityDefinitionRoleForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae outParamRecord = default;
outParamRecord = new RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionRoleForUpdate", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"roleid\"" +
", \"activitydefinitionid\"" +
"FROM " + ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionRoleForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityDefinitionRole
/// </summary>

public static async Task UpdateActivityDefinitionRole(IRequestContext requestContext,BitArray usedFields,RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityDefinitionRole", "dbe5f935-23b5-47d0-546f-de9b9ee6c5c8.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionRoleEntityRecord ssENActivityDefinitionRole = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionRoleEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"roleid\" = @ssRoleId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinitionRole_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"activitydefinitionid\" = \"activitydefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssRoleId", DbType.String, ssENActivityDefinitionRole.ssRoleId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionRole.ssActivityDefinitionId);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinitionRole_ssId_", DbType.Int64, ssENActivityDefinitionRole.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityDefinitionRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityDefinitionRole", ssENActivityDefinitionRole.ssId.ToString()); }}
}
return;
}

}
}
