using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateSampleListEntity
/// </summary>

public static async Task<long> CreateSampleListEntity(IRequestContext requestContext,RC_f58af668359cdeaaa540e4e6dadabd34 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#CreateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord ssENSampleListEntity = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENSampleListEntityEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
" ) VALUES (" +
" @ssId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENSampleListEntity.ssId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateSampleListEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENSampleListEntity.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSampleListEntity
/// </summary>

public static async Task<long> CreateOrUpdateSampleListEntity(IRequestContext requestContext,BitArray usedFields,RC_f58af668359cdeaaa540e4e6dadabd34 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#CreateOrUpdateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord ssENSampleListEntity = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string updateSet = "UPDATE " + ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
string whereCondition = " WHERE \"id\" = @idparam_ssENSampleistEntity_ssId_sampl_jf1oovmiqpmts9oi7sezxyk3";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@idparam_ssENSampleistEntity_ssId_sampl_jf1oovmiqpmts9oi7sezxyk3", DbType.Int64, ssENSampleListEntity.ssId);
int counter = 0;
if(ssENSampleListEntity.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSampleListEntity (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENSampleListEntityEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
" ) VALUES (" +
" @ssId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENSampleListEntity.ssId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSampleListEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENSampleListEntity.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENSampleListEntity.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeSampleListEntity
/// </summary>

public static async Task CreateOrUpdateSomeSampleListEntity(IRequestContext requestContext,RL_677b1053a44870339ea33453b927fdea inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#CreateOrUpdateAllEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
string entityTableName = ENSampleListEntityEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\") VALUES ( unnest(@ssId)) ON CONFLICT(\"id\") do update set  ";
insertSql+= "";


List<long> insertIdList = new List<long>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_f58af668359cdeaaa540e4e6dadabd34)inParamSourceList.Current).ssENSampleListEntity;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeSampleListEntity (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteSampleListEntity
/// </summary>

public static async Task DeleteSampleListEntity(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#DeleteEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteSampleListEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllSampleListEntity
/// </summary>

public static async Task DeleteAllSampleListEntity(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#DeleteAllEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteSampleListEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetSampleListEntity
/// </summary>

public static async Task<RC_f58af668359cdeaaa540e4e6dadabd34> GetSampleListEntity(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f58af668359cdeaaa540e4e6dadabd34 outParamRecord = default;
outParamRecord = new RC_f58af668359cdeaaa540e4e6dadabd34();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
" FROM " + ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSampleListEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(1,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetSampleListEntityForUpdate
/// </summary>

public static async Task<RC_f58af668359cdeaaa540e4e6dadabd34> GetSampleListEntityForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f58af668359cdeaaa540e4e6dadabd34 outParamRecord = default;
outParamRecord = new RC_f58af668359cdeaaa540e4e6dadabd34();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSampleListEntityForUpdate", "5a325915-958c-4d82-bad1-452947a6d0d0.#GetEntityForUpdate", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
"FROM " + ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSampleListEntityForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(1,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateSampleListEntity
/// </summary>

public static async Task UpdateSampleListEntity(IRequestContext requestContext,BitArray usedFields,RC_f58af668359cdeaaa540e4e6dadabd34 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateSampleListEntity", "5a325915-958c-4d82-bad1-452947a6d0d0.#UpdateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord ssENSampleListEntity = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string updateSet = "UPDATE " + ENSampleListEntityEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
string whereCondition = " WHERE \"id\" = @idparam_ssENSampleistEntity_ssId_sampl_jf1oovmiqpmts9oi7sezxyk3";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"id\" = \"id\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@idparam_ssENSampleistEntity_ssId_sampl_jf1oovmiqpmts9oi7sezxyk3", DbType.Int64, ssENSampleListEntity.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateSampleListEntity", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("SampleListEntity", ssENSampleListEntity.ssId.ToString()); }}
}
return;
}

}
}
