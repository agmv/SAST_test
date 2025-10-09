using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateApplication
/// </summary>

public static async Task<string> CreateApplication(IRequestContext requestContext,RC_a702e171772a9b89c17e2544ab6d1d29 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateApplication", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENApplicationEntityRecord ssENApplication = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENApplicationEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"type\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssType" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENApplication.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENApplication.ssName);
if ((ssENApplication.ssType=="")) {
insertSqlCmd.CreateParameter("@ssType", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssType", DbType.String, ssENApplication.ssType);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateApplication", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENApplication.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateApplication
/// </summary>

public static async Task<string> CreateOrUpdateApplication(IRequestContext requestContext,BitArray usedFields,RC_a702e171772a9b89c17e2544ab6d1d29 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateApplication", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENApplicationEntityRecord ssENApplication = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"type\" = @ssType"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENApplication_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"name\" = \"name\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENApplication.ssName);
}
if(usedFields[2]) {
if ((ssENApplication.ssType=="")) {
sqlCmd.CreateParameter("@ssType", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssType", DbType.String, ssENApplication.ssType);

}
}
sqlCmd.CreateParameter("@idparam_ssENApplication_ssId_", DbType.String, ssENApplication.ssId);
int counter = 0;
if(ssENApplication.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateApplication (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENApplicationEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"type\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssType" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENApplication.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENApplication.ssName);
if ((ssENApplication.ssType=="")) {
insertSqlCmd.CreateParameter("@ssType", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssType", DbType.String, ssENApplication.ssType);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateApplication", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENApplication.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENApplication.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeApplication
/// </summary>

public static async Task CreateOrUpdateSomeApplication(IRequestContext requestContext,RL_77de0cb9f6a169c5c7917faf23aa1522 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeApplication", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENApplicationEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"name\", \"type\") VALUES ( unnest(@ssId),  unnest(@ssName),  unnest(@ssType)) ON CONFLICT(\"id\") do update set \"name\" = EXCLUDED.\"name\", \"type\" = EXCLUDED.\"type\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<string> insertNameList = new List<string>();
List<object> insertTypeList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_a702e171772a9b89c17e2544ab6d1d29)inParamSourceList.Current).ssENApplication;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
if ((record.ssType=="")) {
insertTypeList.Add(null);
} else {
insertTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssType));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertNameList.IsEmpty() || !insertTypeList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssType",DbType.String,insertTypeList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeApplication (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteApplication
/// </summary>

public static async Task DeleteApplication(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteApplication", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteApplication", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetApplication
/// </summary>

public static async Task<RC_a702e171772a9b89c17e2544ab6d1d29> GetApplication(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a702e171772a9b89c17e2544ab6d1d29 outParamRecord = default;
outParamRecord = new RC_a702e171772a9b89c17e2544ab6d1d29();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetApplication", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"type\"" +
" FROM " + ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetApplication", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetApplicationForUpdate
/// </summary>

public static async Task<RC_a702e171772a9b89c17e2544ab6d1d29> GetApplicationForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a702e171772a9b89c17e2544ab6d1d29 outParamRecord = default;
outParamRecord = new RC_a702e171772a9b89c17e2544ab6d1d29();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetApplicationForUpdate", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"type\"" +
"FROM " + ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetApplicationForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateApplication
/// </summary>

public static async Task UpdateApplication(IRequestContext requestContext,BitArray usedFields,RC_a702e171772a9b89c17e2544ab6d1d29 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateApplication", "eaade63d-8037-2ea1-e4d2-18145aeffb37.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENApplicationEntityRecord ssENApplication = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENApplicationEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"type\" = @ssType"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENApplication_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"name\" = \"name\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENApplication.ssName);
}
if(usedFields[2]) {
if ((ssENApplication.ssType=="")) {
sqlCmd.CreateParameter("@ssType", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssType", DbType.String, ssENApplication.ssType);

}
}
sqlCmd.CreateParameter("@idparam_ssENApplication_ssId_", DbType.String, ssENApplication.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateApplication", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Application", ssENApplication.ssId.ToString()); }}
}
return;
}

}
}
