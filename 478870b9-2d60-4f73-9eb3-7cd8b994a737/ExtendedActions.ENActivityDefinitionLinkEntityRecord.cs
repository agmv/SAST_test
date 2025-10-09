using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityDefinitionLink
/// </summary>

public static async Task<string> CreateActivityDefinitionLink(IRequestContext requestContext,RC_c97a9c0cb896c874168b02efa3e48866 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityDefinitionLink", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionLinkEntityRecord ssENActivityDefinitionLink = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionLinkEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"sourceactivitydefinitionid\"" +
", \"targetactivitydefinitionid\"" +
", \"isactive\"" +
", \"outcome\"" +
" ) VALUES (" +
" @ssId" +
", @ssSourceActivityDefinitionId" +
", @ssTargetActivityDefinitionId" +
", @ssIsActive" +
", @ssOutcome" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENActivityDefinitionLink.ssId);
insertSqlCmd.CreateParameter("@ssSourceActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssSourceActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssTargetActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssTargetActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityDefinitionLink.ssIsActive);
insertSqlCmd.CreateParameter("@ssOutcome", DbType.String, ssENActivityDefinitionLink.ssOutcome);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityDefinitionLink", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENActivityDefinitionLink.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityDefinitionLink
/// </summary>

public static async Task<string> CreateOrUpdateActivityDefinitionLink(IRequestContext requestContext,BitArray usedFields,RC_c97a9c0cb896c874168b02efa3e48866 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityDefinitionLink", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionLinkEntityRecord ssENActivityDefinitionLink = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"sourceactivitydefinitionid\" = @ssSourceActivityDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"targetactivitydefinitionid\" = @ssTargetActivityDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outcome\" = @ssOutcome"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinitionLink_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssSourceActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssSourceActivityDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssTargetActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssTargetActivityDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityDefinitionLink.ssIsActive);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssOutcome", DbType.String, ssENActivityDefinitionLink.ssOutcome);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinitionLink_ssId_", DbType.String, ssENActivityDefinitionLink.ssId);
int counter = 0;
if(ssENActivityDefinitionLink.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinitionLink (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionLinkEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"sourceactivitydefinitionid\"" +
", \"targetactivitydefinitionid\"" +
", \"isactive\"" +
", \"outcome\"" +
" ) VALUES (" +
" @ssId" +
", @ssSourceActivityDefinitionId" +
", @ssTargetActivityDefinitionId" +
", @ssIsActive" +
", @ssOutcome" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENActivityDefinitionLink.ssId);
insertSqlCmd.CreateParameter("@ssSourceActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssSourceActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssTargetActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssTargetActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityDefinitionLink.ssIsActive);
insertSqlCmd.CreateParameter("@ssOutcome", DbType.String, ssENActivityDefinitionLink.ssOutcome);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinitionLink", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENActivityDefinitionLink.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityDefinitionLink.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityDefinitionLink
/// </summary>

public static async Task CreateOrUpdateSomeActivityDefinitionLink(IRequestContext requestContext,RL_9587436fe4e8f406175a43d163260035 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityDefinitionLink", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityDefinitionLinkEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"sourceactivitydefinitionid\", \"targetactivitydefinitionid\", \"isactive\", \"outcome\") VALUES ( unnest(@ssId),  unnest(@ssSourceActivityDefinitionId),  unnest(@ssTargetActivityDefinitionId),  unnest(@ssIsActive),  unnest(@ssOutcome)) ON CONFLICT(\"id\") do update set \"sourceactivitydefinitionid\" = EXCLUDED.\"sourceactivitydefinitionid\", \"targetactivitydefinitionid\" = EXCLUDED.\"targetactivitydefinitionid\", \"isactive\" = EXCLUDED.\"isactive\", \"outcome\" = EXCLUDED.\"outcome\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<object> insertSourceActivityDefinitionIdList = new List<object>();
List<object> insertTargetActivityDefinitionIdList = new List<object>();
List<bool> insertIsActiveList = new List<bool>();
List<string> insertOutcomeList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_c97a9c0cb896c874168b02efa3e48866)inParamSourceList.Current).ssENActivityDefinitionLink;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertSourceActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssSourceActivityDefinitionId));
insertTargetActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssTargetActivityDefinitionId));
insertIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
insertOutcomeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutcome));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertSourceActivityDefinitionIdList.IsEmpty() || !insertTargetActivityDefinitionIdList.IsEmpty() || !insertIsActiveList.IsEmpty() || !insertOutcomeList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSourceActivityDefinitionId",DbType.Int32,insertSourceActivityDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTargetActivityDefinitionId",DbType.Int32,insertTargetActivityDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsActive",DbType.Boolean,insertIsActiveList);
executionService.CreateParameter(insertSqlCmd,"@ssOutcome",DbType.String,insertOutcomeList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityDefinitionLink (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityDefinitionLink
/// </summary>

public static async Task DeleteActivityDefinitionLink(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityDefinitionLink", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityDefinitionLink", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityDefinitionLink
/// </summary>

public static async Task<RC_c97a9c0cb896c874168b02efa3e48866> GetActivityDefinitionLink(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c97a9c0cb896c874168b02efa3e48866 outParamRecord = default;
outParamRecord = new RC_c97a9c0cb896c874168b02efa3e48866();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionLink", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"sourceactivitydefinitionid\"" +
", \"targetactivitydefinitionid\"" +
", \"isactive\"" +
", \"outcome\"" +
" FROM " + ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionLink", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityDefinitionLinkForUpdate
/// </summary>

public static async Task<RC_c97a9c0cb896c874168b02efa3e48866> GetActivityDefinitionLinkForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c97a9c0cb896c874168b02efa3e48866 outParamRecord = default;
outParamRecord = new RC_c97a9c0cb896c874168b02efa3e48866();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionLinkForUpdate", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"sourceactivitydefinitionid\"" +
", \"targetactivitydefinitionid\"" +
", \"isactive\"" +
", \"outcome\"" +
"FROM " + ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionLinkForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityDefinitionLink
/// </summary>

public static async Task UpdateActivityDefinitionLink(IRequestContext requestContext,BitArray usedFields,RC_c97a9c0cb896c874168b02efa3e48866 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityDefinitionLink", "03b269cd-51fc-806b-c0b4-b8bc690510f2.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionLinkEntityRecord ssENActivityDefinitionLink = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionLinkEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"sourceactivitydefinitionid\" = @ssSourceActivityDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"targetactivitydefinitionid\" = @ssTargetActivityDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outcome\" = @ssOutcome"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinitionLink_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssSourceActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssSourceActivityDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssTargetActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLink.ssTargetActivityDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENActivityDefinitionLink.ssIsActive);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssOutcome", DbType.String, ssENActivityDefinitionLink.ssOutcome);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinitionLink_ssId_", DbType.String, ssENActivityDefinitionLink.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityDefinitionLink", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityDefinitionLink", ssENActivityDefinitionLink.ssId.ToString()); }}
}
return;
}

}
}
