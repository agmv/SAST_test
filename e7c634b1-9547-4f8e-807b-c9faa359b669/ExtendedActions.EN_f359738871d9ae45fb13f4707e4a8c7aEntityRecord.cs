using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateHttpRequest
/// </summary>

public static async Task<long> CreateHttpRequest(IRequestContext requestContext,RC_1ba5183fe935decff47a51e639a147ac inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#CreateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord ssENHttpRequest = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENHttpRequestEntity.LocalViewName(null, null) + " (" +
" \"httpmethod\"" +
", \"body\"" +
" ) VALUES (" +
" @ssHttpMethod" +
", @ssBody" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssHttpMethod", DbType.String, ssENHttpRequest.ssHttpMethod);
insertSqlCmd.CreateParameter("@ssBody", DbType.String, ssENHttpRequest.ssBody);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateHttpRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateHttpRequest
/// </summary>

public static async Task<long> CreateOrUpdateHttpRequest(IRequestContext requestContext,BitArray usedFields,RC_1ba5183fe935decff47a51e639a147ac inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#CreateOrUpdateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord ssENHttpRequest = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"httpmethod\" = @ssHttpMethod"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"body\" = @ssBody"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENHttpRequest_ssId_httpr_jf1oovmiqpmvxyhsczut6_72";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"httpmethod\" = \"httpmethod\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssHttpMethod", DbType.String, ssENHttpRequest.ssHttpMethod);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssBody", DbType.String, ssENHttpRequest.ssBody);
}
sqlCmd.CreateParameter("@idparam_ssENHttpRequest_ssId_httpr_jf1oovmiqpmvxyhsczut6_72", DbType.Int64, ssENHttpRequest.ssId);
int counter = 0;
if(ssENHttpRequest.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateHttpRequest (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENHttpRequestEntity.LocalViewName(null, null) + " (" +
" \"httpmethod\"" +
", \"body\"" +
" ) VALUES (" +
" @ssHttpMethod" +
", @ssBody" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssHttpMethod", DbType.String, ssENHttpRequest.ssHttpMethod);
insertSqlCmd.CreateParameter("@ssBody", DbType.String, ssENHttpRequest.ssBody);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateHttpRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENHttpRequest.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeHttpRequest
/// </summary>

public static async Task CreateOrUpdateSomeHttpRequest(IRequestContext requestContext,RL_cb90b4d276d47c120cb334b7b28342e2 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#CreateOrUpdateAllEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
string entityTableName = ENHttpRequestEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"httpmethod\", \"body\") VALUES ( unnest(@ssHttpMethod),  unnest(@ssBody)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"httpmethod\" = updateTable.\"httpmethod\", \"body\" = updateTable.\"body\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssHttpMethod) as \"httpmethod\",  unnest(@ssBody) as \"body\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<string> insertHttpMethodList = new List<string>();
List<string> insertBodyList = new List<string>();

List<long> updateIdList = new List<long>();
List<string> updateHttpMethodList = new List<string>();
List<string> updateBodyList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_1ba5183fe935decff47a51e639a147ac)inParamSourceList.Current).ssENHttpRequest;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateHttpMethodList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssHttpMethod));
updateBodyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBody));
} else {
insertHttpMethodList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssHttpMethod));
insertBodyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBody));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertHttpMethodList.IsEmpty() || !insertBodyList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssHttpMethod",DbType.String,insertHttpMethodList);
executionService.CreateParameter(insertSqlCmd,"@ssBody",DbType.String,insertBodyList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeHttpRequest (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateHttpMethodList.IsEmpty() || !updateBodyList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssHttpMethod",DbType.String,updateHttpMethodList);
executionService.CreateParameter(updateSqlCmd,"@ssBody",DbType.String,updateBodyList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeHttpRequest (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteHttpRequest
/// </summary>

public static async Task DeleteHttpRequest(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#DeleteEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteHttpRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllHttpRequest
/// </summary>

public static async Task DeleteAllHttpRequest(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#DeleteAllEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteHttpRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetHttpRequest
/// </summary>

public static async Task<RC_1ba5183fe935decff47a51e639a147ac> GetHttpRequest(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1ba5183fe935decff47a51e639a147ac outParamRecord = default;
outParamRecord = new RC_1ba5183fe935decff47a51e639a147ac();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"httpmethod\"" +
", \"body\"" +
" FROM " + ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetHttpRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetHttpRequestForUpdate
/// </summary>

public static async Task<RC_1ba5183fe935decff47a51e639a147ac> GetHttpRequestForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1ba5183fe935decff47a51e639a147ac outParamRecord = default;
outParamRecord = new RC_1ba5183fe935decff47a51e639a147ac();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetHttpRequestForUpdate", "2fa51763-0d09-4762-923a-b809ea691b41.#GetEntityForUpdate", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"httpmethod\"" +
", \"body\"" +
"FROM " + ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetHttpRequestForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateHttpRequest
/// </summary>

public static async Task UpdateHttpRequest(IRequestContext requestContext,BitArray usedFields,RC_1ba5183fe935decff47a51e639a147ac inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateHttpRequest", "2fa51763-0d09-4762-923a-b809ea691b41.#UpdateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord ssENHttpRequest = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENHttpRequestEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"httpmethod\" = @ssHttpMethod"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"body\" = @ssBody"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENHttpRequest_ssId_httpr_jf1oovmiqpmvxyhsczut6_72";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"httpmethod\" = \"httpmethod\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssHttpMethod", DbType.String, ssENHttpRequest.ssHttpMethod);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssBody", DbType.String, ssENHttpRequest.ssBody);
}
sqlCmd.CreateParameter("@idparam_ssENHttpRequest_ssId_httpr_jf1oovmiqpmvxyhsczut6_72", DbType.Int64, ssENHttpRequest.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateHttpRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("HttpRequest", ssENHttpRequest.ssId.ToString()); }}
}
return;
}

}
}
