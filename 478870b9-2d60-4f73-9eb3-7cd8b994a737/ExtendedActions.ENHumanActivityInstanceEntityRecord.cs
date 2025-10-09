using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateHumanActivityInstance
/// </summary>

public static async Task<long> CreateHumanActivityInstance(IRequestContext requestContext,RC_880f0b08a77c1575f19f408e1fddc8c6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENHumanActivityInstanceEntityRecord ssENHumanActivityInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENHumanActivityInstanceEntity.LocalViewName(null, null) + " (" +
" \"activityinstanceid\"" +
", \"assigneduserid\"" +
", \"message\"" +
", \"url\"" +
" ) VALUES (" +
" @ssActivityInstanceId" +
", @ssAssignedUserId" +
", @ssMessage" +
", @ssURL" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssActivityInstanceId", DbType.Int64, ssENHumanActivityInstance.ssActivityInstanceId);
if ((ssENHumanActivityInstance.ssAssignedUserId=="")) {
insertSqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, ssENHumanActivityInstance.ssAssignedUserId);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENHumanActivityInstance.ssMessage);
insertSqlCmd.CreateParameter("@ssURL", DbType.String, ssENHumanActivityInstance.ssURL);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateHumanActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENHumanActivityInstance.ssActivityInstanceId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateHumanActivityInstance
/// </summary>

public static async Task<long> CreateOrUpdateHumanActivityInstance(IRequestContext requestContext,BitArray usedFields,RC_880f0b08a77c1575f19f408e1fddc8c6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENHumanActivityInstanceEntityRecord ssENHumanActivityInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"assigneduserid\" = @ssAssignedUserId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"message\" = @ssMessage"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"url\" = @ssURL"): parameters);
string whereCondition = " WHERE \"activityinstanceid\" = @idparam_ssENHumanActivityInstance_ssActivityInstanceId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"message\" = \"message\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENHumanActivityInstance.ssAssignedUserId=="")) {
sqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, ssENHumanActivityInstance.ssAssignedUserId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENHumanActivityInstance.ssMessage);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssURL", DbType.String, ssENHumanActivityInstance.ssURL);
}
sqlCmd.CreateParameter("@idparam_ssENHumanActivityInstance_ssActivityInstanceId_", DbType.Int64, ssENHumanActivityInstance.ssActivityInstanceId);
int counter = 0;
if(ssENHumanActivityInstance.ssActivityInstanceId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateHumanActivityInstance (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENHumanActivityInstanceEntity.LocalViewName(null, null) + " (" +
" \"activityinstanceid\"" +
", \"assigneduserid\"" +
", \"message\"" +
", \"url\"" +
" ) VALUES (" +
" @ssActivityInstanceId" +
", @ssAssignedUserId" +
", @ssMessage" +
", @ssURL" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssActivityInstanceId", DbType.Int64, ssENHumanActivityInstance.ssActivityInstanceId);
if ((ssENHumanActivityInstance.ssAssignedUserId=="")) {
insertSqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, ssENHumanActivityInstance.ssAssignedUserId);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENHumanActivityInstance.ssMessage);
insertSqlCmd.CreateParameter("@ssURL", DbType.String, ssENHumanActivityInstance.ssURL);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateHumanActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENHumanActivityInstance.ssActivityInstanceId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENHumanActivityInstance.ssActivityInstanceId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeHumanActivityInstance
/// </summary>

public static async Task CreateOrUpdateSomeHumanActivityInstance(IRequestContext requestContext,RL_b1951e6718fee0cfdfe159a4bfc6a006 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENHumanActivityInstanceEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"activityinstanceid\", \"assigneduserid\", \"message\", \"url\") VALUES ( unnest(@ssActivityInstanceId),  unnest(@ssAssignedUserId),  unnest(@ssMessage),  unnest(@ssURL)) ON CONFLICT(\"activityinstanceid\") do update set \"assigneduserid\" = EXCLUDED.\"assigneduserid\", \"message\" = EXCLUDED.\"message\", \"url\" = EXCLUDED.\"url\" ";
insertSql+= "";


List<object> insertActivityInstanceIdList = new List<object>();
List<object> insertAssignedUserIdList = new List<object>();
List<string> insertMessageList = new List<string>();
List<string> insertURLList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_880f0b08a77c1575f19f408e1fddc8c6)inParamSourceList.Current).ssENHumanActivityInstance;
insertActivityInstanceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssActivityInstanceId));
if ((record.ssAssignedUserId=="")) {
insertAssignedUserIdList.Add(null);
} else {
insertAssignedUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedUserId));
}
insertMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
insertURLList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssURL));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertActivityInstanceIdList.IsEmpty() || !insertAssignedUserIdList.IsEmpty() || !insertMessageList.IsEmpty() || !insertURLList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssActivityInstanceId",DbType.Int64,insertActivityInstanceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedUserId",DbType.String,insertAssignedUserIdList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
executionService.CreateParameter(insertSqlCmd,"@ssURL",DbType.String,insertURLList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeHumanActivityInstance (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteHumanActivityInstance
/// </summary>

public static async Task DeleteHumanActivityInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"activityinstanceid\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteHumanActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllHumanActivityInstance
/// </summary>

public static async Task DeleteAllHumanActivityInstance(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#DeleteAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteHumanActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetHumanActivityInstance
/// </summary>

public static async Task<RC_880f0b08a77c1575f19f408e1fddc8c6> GetHumanActivityInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_880f0b08a77c1575f19f408e1fddc8c6 outParamRecord = default;
outParamRecord = new RC_880f0b08a77c1575f19f408e1fddc8c6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"activityinstanceid\"" +
", \"assigneduserid\"" +
", \"message\"" +
", \"url\"" +
" FROM " + ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"activityinstanceid\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetHumanActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetHumanActivityInstanceForUpdate
/// </summary>

public static async Task<RC_880f0b08a77c1575f19f408e1fddc8c6> GetHumanActivityInstanceForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_880f0b08a77c1575f19f408e1fddc8c6 outParamRecord = default;
outParamRecord = new RC_880f0b08a77c1575f19f408e1fddc8c6();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetHumanActivityInstanceForUpdate", "332d4d2a-243e-43a3-a00d-c611b309c222.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"activityinstanceid\"" +
", \"assigneduserid\"" +
", \"message\"" +
", \"url\"" +
"FROM " + ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"activityinstanceid\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetHumanActivityInstanceForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateHumanActivityInstance
/// </summary>

public static async Task UpdateHumanActivityInstance(IRequestContext requestContext,BitArray usedFields,RC_880f0b08a77c1575f19f408e1fddc8c6 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateHumanActivityInstance", "332d4d2a-243e-43a3-a00d-c611b309c222.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENHumanActivityInstanceEntityRecord ssENHumanActivityInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENHumanActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"assigneduserid\" = @ssAssignedUserId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"message\" = @ssMessage"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"url\" = @ssURL"): parameters);
string whereCondition = " WHERE \"activityinstanceid\" = @idparam_ssENHumanActivityInstance_ssActivityInstanceId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"message\" = \"message\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENHumanActivityInstance.ssAssignedUserId=="")) {
sqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedUserId", DbType.String, ssENHumanActivityInstance.ssAssignedUserId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENHumanActivityInstance.ssMessage);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssURL", DbType.String, ssENHumanActivityInstance.ssURL);
}
sqlCmd.CreateParameter("@idparam_ssENHumanActivityInstance_ssActivityInstanceId_", DbType.Int64, ssENHumanActivityInstance.ssActivityInstanceId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateHumanActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("HumanActivityInstance", ssENHumanActivityInstance.ssActivityInstanceId.ToString()); }}
}
return;
}

}
}
