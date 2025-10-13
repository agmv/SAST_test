using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateEntity
/// </summary>

public static async Task<string> CreateEntity(IRequestContext requestContext,RC_05f199cf8f734662fa6eaa91568947ff inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateEntity", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENEntityEntityRecord ssENEntity = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENEntityEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"applicationid\"" +
", \"isstatic\"" +
", \"primarykeyattribute\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssApplicationId" +
", @ssIsStatic" +
", @ssPrimaryKeyAttribute" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENEntity.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENEntity.ssName);
if ((ssENEntity.ssApplicationId=="")) {
insertSqlCmd.CreateParameter("@ssApplicationId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationId", DbType.String, ssENEntity.ssApplicationId);

}
insertSqlCmd.CreateParameter("@ssIsStatic", DbType.Boolean, ssENEntity.ssIsStatic);
if ((ssENEntity.ssPrimaryKeyAttribute=="")) {
insertSqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, ssENEntity.ssPrimaryKeyAttribute);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENEntity.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateEntity
/// </summary>

public static async Task<string> CreateOrUpdateEntity(IRequestContext requestContext,BitArray usedFields,RC_05f199cf8f734662fa6eaa91568947ff inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateEntity", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENEntityEntityRecord ssENEntity = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"applicationid\" = @ssApplicationId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isstatic\" = @ssIsStatic"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"primarykeyattribute\" = @ssPrimaryKeyAttribute"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENEntity_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isstatic\" = \"isstatic\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENEntity.ssName);
}
if(usedFields[2]) {
if ((ssENEntity.ssApplicationId=="")) {
sqlCmd.CreateParameter("@ssApplicationId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationId", DbType.String, ssENEntity.ssApplicationId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsStatic", DbType.Boolean, ssENEntity.ssIsStatic);
}
if(usedFields[4]) {
if ((ssENEntity.ssPrimaryKeyAttribute=="")) {
sqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, ssENEntity.ssPrimaryKeyAttribute);

}
}
sqlCmd.CreateParameter("@idparam_ssENEntity_ssId_", DbType.String, ssENEntity.ssId);
int counter = 0;
if(ssENEntity.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateEntity (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENEntityEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"applicationid\"" +
", \"isstatic\"" +
", \"primarykeyattribute\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssApplicationId" +
", @ssIsStatic" +
", @ssPrimaryKeyAttribute" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENEntity.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENEntity.ssName);
if ((ssENEntity.ssApplicationId=="")) {
insertSqlCmd.CreateParameter("@ssApplicationId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationId", DbType.String, ssENEntity.ssApplicationId);

}
insertSqlCmd.CreateParameter("@ssIsStatic", DbType.Boolean, ssENEntity.ssIsStatic);
if ((ssENEntity.ssPrimaryKeyAttribute=="")) {
insertSqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, ssENEntity.ssPrimaryKeyAttribute);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENEntity.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENEntity.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeEntity
/// </summary>

public static async Task CreateOrUpdateSomeEntity(IRequestContext requestContext,RL_eba0e3b376adecb3137463bf4c64acb3 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeEntity", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENEntityEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"name\", \"applicationid\", \"isstatic\", \"primarykeyattribute\") VALUES ( unnest(@ssId),  unnest(@ssName),  unnest(@ssApplicationId),  unnest(@ssIsStatic),  unnest(@ssPrimaryKeyAttribute)) ON CONFLICT(\"id\") do update set \"name\" = EXCLUDED.\"name\", \"applicationid\" = EXCLUDED.\"applicationid\", \"isstatic\" = EXCLUDED.\"isstatic\", \"primarykeyattribute\" = EXCLUDED.\"primarykeyattribute\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<string> insertNameList = new List<string>();
List<object> insertApplicationIdList = new List<object>();
List<bool> insertIsStaticList = new List<bool>();
List<object> insertPrimaryKeyAttributeList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_05f199cf8f734662fa6eaa91568947ff)inParamSourceList.Current).ssENEntity;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
if ((record.ssApplicationId=="")) {
insertApplicationIdList.Add(null);
} else {
insertApplicationIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicationId));
}
insertIsStaticList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsStatic));
if ((record.ssPrimaryKeyAttribute=="")) {
insertPrimaryKeyAttributeList.Add(null);
} else {
insertPrimaryKeyAttributeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPrimaryKeyAttribute));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertNameList.IsEmpty() || !insertApplicationIdList.IsEmpty() || !insertIsStaticList.IsEmpty() || !insertPrimaryKeyAttributeList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationId",DbType.String,insertApplicationIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsStatic",DbType.Boolean,insertIsStaticList);
executionService.CreateParameter(insertSqlCmd,"@ssPrimaryKeyAttribute",DbType.String,insertPrimaryKeyAttributeList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeEntity (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteEntity
/// </summary>

public static async Task DeleteEntity(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteEntity", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetEntity
/// </summary>

public static async Task<RC_05f199cf8f734662fa6eaa91568947ff> GetEntity(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_05f199cf8f734662fa6eaa91568947ff outParamRecord = default;
outParamRecord = new RC_05f199cf8f734662fa6eaa91568947ff();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEntity", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"applicationid\"" +
", \"isstatic\"" +
", \"primarykeyattribute\"" +
" FROM " + ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetEntityForUpdate
/// </summary>

public static async Task<RC_05f199cf8f734662fa6eaa91568947ff> GetEntityForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_05f199cf8f734662fa6eaa91568947ff outParamRecord = default;
outParamRecord = new RC_05f199cf8f734662fa6eaa91568947ff();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEntityForUpdate", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"applicationid\"" +
", \"isstatic\"" +
", \"primarykeyattribute\"" +
"FROM " + ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEntityForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateEntity
/// </summary>

public static async Task UpdateEntity(IRequestContext requestContext,BitArray usedFields,RC_05f199cf8f734662fa6eaa91568947ff inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateEntity", "f8f52822-47d5-b232-0777-79d47c6f5ffb.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENEntityEntityRecord ssENEntity = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"applicationid\" = @ssApplicationId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isstatic\" = @ssIsStatic"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"primarykeyattribute\" = @ssPrimaryKeyAttribute"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENEntity_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isstatic\" = \"isstatic\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENEntity.ssName);
}
if(usedFields[2]) {
if ((ssENEntity.ssApplicationId=="")) {
sqlCmd.CreateParameter("@ssApplicationId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationId", DbType.String, ssENEntity.ssApplicationId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsStatic", DbType.Boolean, ssENEntity.ssIsStatic);
}
if(usedFields[4]) {
if ((ssENEntity.ssPrimaryKeyAttribute=="")) {
sqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPrimaryKeyAttribute", DbType.String, ssENEntity.ssPrimaryKeyAttribute);

}
}
sqlCmd.CreateParameter("@idparam_ssENEntity_ssId_", DbType.String, ssENEntity.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Entity", ssENEntity.ssId.ToString()); }}
}
return;
}

}
}
