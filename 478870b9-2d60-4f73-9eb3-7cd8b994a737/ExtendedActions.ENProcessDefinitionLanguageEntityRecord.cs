using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessDefinitionLanguage
/// </summary>

public static async Task<long> CreateProcessDefinitionLanguage(IRequestContext requestContext,RC_b1f889a35d23518bfa5ab890a96efb52 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessDefinitionLanguage", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessDefinitionLanguageEntityRecord ssENProcessDefinitionLanguage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessDefinitionLanguageEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"processdefinitionid\"" +
", \"locale\"" +
", \"label\"" +
" ) VALUES (" +
" @ssId" +
", @ssProcessDefinitionId" +
", @ssLocale" +
", @ssLabel" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENProcessDefinitionLanguage.ssId);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessDefinitionLanguage.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssLocale", DbType.String, ssENProcessDefinitionLanguage.ssLocale);
insertSqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessDefinitionLanguage.ssLabel);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessDefinitionLanguage.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessDefinitionLanguage
/// </summary>

public static async Task<long> CreateOrUpdateProcessDefinitionLanguage(IRequestContext requestContext,BitArray usedFields,RC_b1f889a35d23518bfa5ab890a96efb52 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessDefinitionLanguage", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessDefinitionLanguageEntityRecord ssENProcessDefinitionLanguage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"locale\" = @ssLocale"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"label\" = @ssLabel"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessDefinitionLanguage_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"processdefinitionid\" = \"processdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessDefinitionLanguage.ssProcessDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLocale", DbType.String, ssENProcessDefinitionLanguage.ssLocale);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessDefinitionLanguage.ssLabel);
}
sqlCmd.CreateParameter("@idparam_ssENProcessDefinitionLanguage_ssId_", DbType.Int64, ssENProcessDefinitionLanguage.ssId);
int counter = 0;
if(ssENProcessDefinitionLanguage.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessDefinitionLanguage (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessDefinitionLanguageEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"processdefinitionid\"" +
", \"locale\"" +
", \"label\"" +
" ) VALUES (" +
" @ssId" +
", @ssProcessDefinitionId" +
", @ssLocale" +
", @ssLabel" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENProcessDefinitionLanguage.ssId);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessDefinitionLanguage.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssLocale", DbType.String, ssENProcessDefinitionLanguage.ssLocale);
insertSqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessDefinitionLanguage.ssLabel);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessDefinitionLanguage.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessDefinitionLanguage.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessDefinitionLanguage
/// </summary>

public static async Task CreateOrUpdateSomeProcessDefinitionLanguage(IRequestContext requestContext,RL_4bc987bb2bbc5a9c083569aa81631f7e inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessDefinitionLanguage", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessDefinitionLanguageEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"processdefinitionid\", \"locale\", \"label\") VALUES ( unnest(@ssId),  unnest(@ssProcessDefinitionId),  unnest(@ssLocale),  unnest(@ssLabel)) ON CONFLICT(\"id\") do update set \"processdefinitionid\" = EXCLUDED.\"processdefinitionid\", \"locale\" = EXCLUDED.\"locale\", \"label\" = EXCLUDED.\"label\" ";
insertSql+= "";


List<long> insertIdList = new List<long>();
List<object> insertProcessDefinitionIdList = new List<object>();
List<string> insertLocaleList = new List<string>();
List<string> insertLabelList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_b1f889a35d23518bfa5ab890a96efb52)inParamSourceList.Current).ssENProcessDefinitionLanguage;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
insertLocaleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLocale));
insertLabelList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLabel));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertProcessDefinitionIdList.IsEmpty() || !insertLocaleList.IsEmpty() || !insertLabelList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessDefinitionId",DbType.Int32,insertProcessDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLocale",DbType.String,insertLocaleList);
executionService.CreateParameter(insertSqlCmd,"@ssLabel",DbType.String,insertLabelList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessDefinitionLanguage (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessDefinitionLanguage
/// </summary>

public static async Task DeleteProcessDefinitionLanguage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessDefinitionLanguage", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessDefinitionLanguage
/// </summary>

public static async Task<RC_b1f889a35d23518bfa5ab890a96efb52> GetProcessDefinitionLanguage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_b1f889a35d23518bfa5ab890a96efb52 outParamRecord = default;
outParamRecord = new RC_b1f889a35d23518bfa5ab890a96efb52();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessDefinitionLanguage", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processdefinitionid\"" +
", \"locale\"" +
", \"label\"" +
" FROM " + ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessDefinitionLanguageForUpdate
/// </summary>

public static async Task<RC_b1f889a35d23518bfa5ab890a96efb52> GetProcessDefinitionLanguageForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_b1f889a35d23518bfa5ab890a96efb52 outParamRecord = default;
outParamRecord = new RC_b1f889a35d23518bfa5ab890a96efb52();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessDefinitionLanguageForUpdate", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processdefinitionid\"" +
", \"locale\"" +
", \"label\"" +
"FROM " + ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessDefinitionLanguageForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessDefinitionLanguage
/// </summary>

public static async Task UpdateProcessDefinitionLanguage(IRequestContext requestContext,BitArray usedFields,RC_b1f889a35d23518bfa5ab890a96efb52 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessDefinitionLanguage", "d9b345b4-d90e-4580-990a-67bca8eb6ea4.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessDefinitionLanguageEntityRecord ssENProcessDefinitionLanguage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENProcessDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"locale\" = @ssLocale"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"label\" = @ssLabel"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessDefinitionLanguage_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"processdefinitionid\" = \"processdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessDefinitionLanguage.ssProcessDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLocale", DbType.String, ssENProcessDefinitionLanguage.ssLocale);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessDefinitionLanguage.ssLabel);
}
sqlCmd.CreateParameter("@idparam_ssENProcessDefinitionLanguage_ssId_", DbType.Int64, ssENProcessDefinitionLanguage.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessDefinitionLanguage", ssENProcessDefinitionLanguage.ssId.ToString()); }}
}
return;
}

}
}
