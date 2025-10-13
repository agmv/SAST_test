using System.Diagnostics;
namespace ssRuntimeDestroyer {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateEmployee
/// </summary>

public static async Task<long> CreateEmployee(IRequestContext requestContext,RC_3b55179c5be20c3d1041cf4a1dcf3f76 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#CreateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord ssENEmployee = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENEmployeeEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"age\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssAge" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENEmployee.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENEmployee.ssName);
insertSqlCmd.CreateParameter("@ssAge", DbType.String, ssENEmployee.ssAge);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateEmployee", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENEmployee.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateEmployee
/// </summary>

public static async Task<long> CreateOrUpdateEmployee(IRequestContext requestContext,BitArray usedFields,RC_3b55179c5be20c3d1041cf4a1dcf3f76 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#CreateOrUpdateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord ssENEmployee = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"age\" = @ssAge"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENEmployee_ssId_emplo_jf1oovmiqpmq7ahjd1zol050";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"name\" = \"name\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENEmployee.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAge", DbType.String, ssENEmployee.ssAge);
}
sqlCmd.CreateParameter("@idparam_ssENEmployee_ssId_emplo_jf1oovmiqpmq7ahjd1zol050", DbType.Int64, ssENEmployee.ssId);
int counter = 0;
if(ssENEmployee.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateEmployee (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENEmployeeEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"age\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssAge" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENEmployee.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENEmployee.ssName);
insertSqlCmd.CreateParameter("@ssAge", DbType.String, ssENEmployee.ssAge);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateEmployee", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENEmployee.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENEmployee.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeEmployee
/// </summary>

public static async Task CreateOrUpdateSomeEmployee(IRequestContext requestContext,RL_3be1495f5fc898e41acd45a19b4ddd3b inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#CreateOrUpdateAllEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
string entityTableName = ENEmployeeEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"name\", \"age\") VALUES ( unnest(@ssId),  unnest(@ssName),  unnest(@ssAge)) ON CONFLICT(\"id\") do update set \"name\" = EXCLUDED.\"name\", \"age\" = EXCLUDED.\"age\" ";
insertSql+= "";


List<long> insertIdList = new List<long>();
List<string> insertNameList = new List<string>();
List<string> insertAgeList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_3b55179c5be20c3d1041cf4a1dcf3f76)inParamSourceList.Current).ssENEmployee;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertAgeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAge));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertNameList.IsEmpty() || !insertAgeList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssAge",DbType.String,insertAgeList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeEmployee (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteEmployee
/// </summary>

public static async Task DeleteEmployee(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#DeleteEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteEmployee", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllEmployee
/// </summary>

public static async Task DeleteAllEmployee(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#DeleteAllEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteEmployee", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetEmployee
/// </summary>

public static async Task<RC_3b55179c5be20c3d1041cf4a1dcf3f76> GetEmployee(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3b55179c5be20c3d1041cf4a1dcf3f76 outParamRecord = default;
outParamRecord = new RC_3b55179c5be20c3d1041cf4a1dcf3f76();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#GetEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"age\"" +
" FROM " + ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEmployee", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetEmployeeForUpdate
/// </summary>

public static async Task<RC_3b55179c5be20c3d1041cf4a1dcf3f76> GetEmployeeForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3b55179c5be20c3d1041cf4a1dcf3f76 outParamRecord = default;
outParamRecord = new RC_3b55179c5be20c3d1041cf4a1dcf3f76();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEmployeeForUpdate", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#GetEntityForUpdate", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"age\"" +
"FROM " + ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEmployeeForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateEmployee
/// </summary>

public static async Task UpdateEmployee(IRequestContext requestContext,BitArray usedFields,RC_3b55179c5be20c3d1041cf4a1dcf3f76 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateEmployee", "e48bf7be-9d7b-4ee6-a107-2aa37a653518.#UpdateEntity", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord ssENEmployee = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENEmployeeEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"age\" = @ssAge"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENEmployee_ssId_emplo_jf1oovmiqpmq7ahjd1zol050";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"name\" = \"name\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENEmployee.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAge", DbType.String, ssENEmployee.ssAge);
}
sqlCmd.CreateParameter("@idparam_ssENEmployee_ssId_emplo_jf1oovmiqpmq7ahjd1zol050", DbType.Int64, ssENEmployee.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateEmployee", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Employee", ssENEmployee.ssId.ToString()); }}
}
return;
}

}
}
