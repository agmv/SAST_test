using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateUser
/// </summary>

public static async Task<string> CreateUser(IRequestContext requestContext,RC_ced013358a82a813f1d9a5108f17ce79 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateUser", "a416822d-845f-46cb-a270-70f5e383544c.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENUserEntityRecord ssENUser = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENUserEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"email\"" +
", \"photourl\"" +
", \"username\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssEmail" +
", @ssPhotoUrl" +
", @ssUsername" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENUser.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENUser.ssName);
insertSqlCmd.CreateParameter("@ssEmail", DbType.String, ssENUser.ssEmail);
insertSqlCmd.CreateParameter("@ssPhotoUrl", DbType.String, ssENUser.ssPhotoUrl);
insertSqlCmd.CreateParameter("@ssUsername", DbType.String, ssENUser.ssUsername);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateUser", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENUser.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateUser
/// </summary>

public static async Task<string> CreateOrUpdateUser(IRequestContext requestContext,BitArray usedFields,RC_ced013358a82a813f1d9a5108f17ce79 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateUser", "a416822d-845f-46cb-a270-70f5e383544c.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENUserEntityRecord ssENUser = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"email\" = @ssEmail"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"photourl\" = @ssPhotoUrl"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"username\" = @ssUsername"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENUser_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENUser.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssEmail", DbType.String, ssENUser.ssEmail);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssPhotoUrl", DbType.String, ssENUser.ssPhotoUrl);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssUsername", DbType.String, ssENUser.ssUsername);
}
sqlCmd.CreateParameter("@idparam_ssENUser_ssId_", DbType.String, ssENUser.ssId);
int counter = 0;
if(ssENUser.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateUser (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENUserEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"email\"" +
", \"photourl\"" +
", \"username\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssEmail" +
", @ssPhotoUrl" +
", @ssUsername" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENUser.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENUser.ssName);
insertSqlCmd.CreateParameter("@ssEmail", DbType.String, ssENUser.ssEmail);
insertSqlCmd.CreateParameter("@ssPhotoUrl", DbType.String, ssENUser.ssPhotoUrl);
insertSqlCmd.CreateParameter("@ssUsername", DbType.String, ssENUser.ssUsername);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateUser", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENUser.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENUser.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeUser
/// </summary>

public static async Task CreateOrUpdateSomeUser(IRequestContext requestContext,RL_8430333e95ceffc00def96d8abb01f75 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeUser", "a416822d-845f-46cb-a270-70f5e383544c.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENUserEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"name\", \"email\", \"photourl\", \"username\") VALUES ( unnest(@ssId),  unnest(@ssName),  unnest(@ssEmail),  unnest(@ssPhotoUrl),  unnest(@ssUsername)) ON CONFLICT(\"id\") do update set \"name\" = EXCLUDED.\"name\", \"email\" = EXCLUDED.\"email\", \"photourl\" = EXCLUDED.\"photourl\", \"username\" = EXCLUDED.\"username\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertEmailList = new List<string>();
List<string> insertPhotoUrlList = new List<string>();
List<string> insertUsernameList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_ced013358a82a813f1d9a5108f17ce79)inParamSourceList.Current).ssENUser;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertEmailList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEmail));
insertPhotoUrlList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPhotoUrl));
insertUsernameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUsername));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertNameList.IsEmpty() || !insertEmailList.IsEmpty() || !insertPhotoUrlList.IsEmpty() || !insertUsernameList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssEmail",DbType.String,insertEmailList);
executionService.CreateParameter(insertSqlCmd,"@ssPhotoUrl",DbType.String,insertPhotoUrlList);
executionService.CreateParameter(insertSqlCmd,"@ssUsername",DbType.String,insertUsernameList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeUser (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteUser
/// </summary>

public static async Task DeleteUser(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteUser", "a416822d-845f-46cb-a270-70f5e383544c.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteUser", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetUser
/// </summary>

public static async Task<RC_ced013358a82a813f1d9a5108f17ce79> GetUser(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ced013358a82a813f1d9a5108f17ce79 outParamRecord = default;
outParamRecord = new RC_ced013358a82a813f1d9a5108f17ce79();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUser", "a416822d-845f-46cb-a270-70f5e383544c.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"email\"" +
", \"photourl\"" +
", \"username\"" +
" FROM " + ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUser", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetUserForUpdate
/// </summary>

public static async Task<RC_ced013358a82a813f1d9a5108f17ce79> GetUserForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ced013358a82a813f1d9a5108f17ce79 outParamRecord = default;
outParamRecord = new RC_ced013358a82a813f1d9a5108f17ce79();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUserForUpdate", "a416822d-845f-46cb-a270-70f5e383544c.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"email\"" +
", \"photourl\"" +
", \"username\"" +
"FROM " + ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUserForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateUser
/// </summary>

public static async Task UpdateUser(IRequestContext requestContext,BitArray usedFields,RC_ced013358a82a813f1d9a5108f17ce79 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateUser", "a416822d-845f-46cb-a270-70f5e383544c.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENUserEntityRecord ssENUser = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENUserEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"email\" = @ssEmail"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"photourl\" = @ssPhotoUrl"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"username\" = @ssUsername"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENUser_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENUser.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssEmail", DbType.String, ssENUser.ssEmail);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssPhotoUrl", DbType.String, ssENUser.ssPhotoUrl);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssUsername", DbType.String, ssENUser.ssUsername);
}
sqlCmd.CreateParameter("@idparam_ssENUser_ssId_", DbType.String, ssENUser.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateUser", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("User", ssENUser.ssId.ToString()); }}
}
return;
}

}
}
