using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityInstance
/// </summary>

public static async Task<long> CreateActivityInstance(IRequestContext requestContext,RC_faf38c2d2aeee71f293ad23cd32fa7e2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityInstance", "d33a0e86-24e8-41d1-b331-14c594405339.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityInstanceEntityRecord ssENActivityInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityInstanceEntity.LocalViewName(null, null) + " (" +
" \"activitydefinitionid\"" +
", \"processinstanceid\"" +
", \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"hasexpired\"" +
" ) VALUES (" +
" @ssActivityDefinitionId" +
", @ssProcessInstanceId" +
", @ssProcessDefinitionId" +
", @ssStatus" +
", @ssStartedOn" +
", @ssLastModifiedOn" +
", @ssHasExpired" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityInstance.ssActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssProcessInstanceId", DbType.Int64, ssENActivityInstance.ssProcessInstanceId);
if ((ssENActivityInstance.ssProcessDefinitionId==0)) {
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityInstance.ssProcessDefinitionId);

}
insertSqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENActivityInstance.ssStatus);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActivityInstance.ssStartedOn);
insertSqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENActivityInstance.ssLastModifiedOn);
insertSqlCmd.CreateParameter("@ssHasExpired", DbType.Boolean, ssENActivityInstance.ssHasExpired);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityInstance
/// </summary>

public static async Task<long> CreateOrUpdateActivityInstance(IRequestContext requestContext,BitArray usedFields,RC_faf38c2d2aeee71f293ad23cd32fa7e2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityInstance", "d33a0e86-24e8-41d1-b331-14c594405339.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityInstanceEntityRecord ssENActivityInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processinstanceid\" = @ssProcessInstanceId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"status\" = @ssStatus"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"startedon\" = @ssStartedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"lastmodifiedon\" = @ssLastModifiedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"hasexpired\" = @ssHasExpired"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityInstance_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"hasexpired\" = \"hasexpired\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityInstance.ssActivityDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProcessInstanceId", DbType.Int64, ssENActivityInstance.ssProcessInstanceId);
}
if(usedFields[3]) {
if ((ssENActivityInstance.ssProcessDefinitionId==0)) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityInstance.ssProcessDefinitionId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENActivityInstance.ssStatus);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActivityInstance.ssStartedOn);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENActivityInstance.ssLastModifiedOn);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssHasExpired", DbType.Boolean, ssENActivityInstance.ssHasExpired);
}
sqlCmd.CreateParameter("@idparam_ssENActivityInstance_ssId_", DbType.Int64, ssENActivityInstance.ssId);
int counter = 0;
if(ssENActivityInstance.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityInstance (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityInstanceEntity.LocalViewName(null, null) + " (" +
" \"activitydefinitionid\"" +
", \"processinstanceid\"" +
", \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"hasexpired\"" +
" ) VALUES (" +
" @ssActivityDefinitionId" +
", @ssProcessInstanceId" +
", @ssProcessDefinitionId" +
", @ssStatus" +
", @ssStartedOn" +
", @ssLastModifiedOn" +
", @ssHasExpired" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityInstance.ssActivityDefinitionId);
insertSqlCmd.CreateParameter("@ssProcessInstanceId", DbType.Int64, ssENActivityInstance.ssProcessInstanceId);
if ((ssENActivityInstance.ssProcessDefinitionId==0)) {
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityInstance.ssProcessDefinitionId);

}
insertSqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENActivityInstance.ssStatus);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActivityInstance.ssStartedOn);
insertSqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENActivityInstance.ssLastModifiedOn);
insertSqlCmd.CreateParameter("@ssHasExpired", DbType.Boolean, ssENActivityInstance.ssHasExpired);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityInstance.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityInstance
/// </summary>

public static async Task CreateOrUpdateSomeActivityInstance(IRequestContext requestContext,RL_e4683611f40e200d3ecdb101fca93d6d inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityInstance", "d33a0e86-24e8-41d1-b331-14c594405339.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityInstanceEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"activitydefinitionid\", \"processinstanceid\", \"processdefinitionid\", \"status\", \"startedon\", \"lastmodifiedon\", \"hasexpired\") VALUES ( unnest(@ssActivityDefinitionId),  unnest(@ssProcessInstanceId),  unnest(@ssProcessDefinitionId),  unnest(@ssStatus),  unnest(@ssStartedOn),  unnest(@ssLastModifiedOn),  unnest(@ssHasExpired)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"activitydefinitionid\" = updateTable.\"activitydefinitionid\", \"processinstanceid\" = updateTable.\"processinstanceid\", \"processdefinitionid\" = updateTable.\"processdefinitionid\", \"status\" = updateTable.\"status\", \"startedon\" = updateTable.\"startedon\", \"lastmodifiedon\" = updateTable.\"lastmodifiedon\", \"hasexpired\" = updateTable.\"hasexpired\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssActivityDefinitionId) as \"activitydefinitionid\",  unnest(@ssProcessInstanceId) as \"processinstanceid\",  unnest(@ssProcessDefinitionId) as \"processdefinitionid\",  unnest(@ssStatus) as \"status\",  unnest(@ssStartedOn) as \"startedon\",  unnest(@ssLastModifiedOn) as \"lastmodifiedon\",  unnest(@ssHasExpired) as \"hasexpired\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertActivityDefinitionIdList = new List<object>();
List<object> insertProcessInstanceIdList = new List<object>();
List<object> insertProcessDefinitionIdList = new List<object>();
List<object> insertStatusList = new List<object>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertLastModifiedOnList = new List<DateTime>();
List<bool> insertHasExpiredList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateActivityDefinitionIdList = new List<object>();
List<object> updateProcessInstanceIdList = new List<object>();
List<object> updateProcessDefinitionIdList = new List<object>();
List<object> updateStatusList = new List<object>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateLastModifiedOnList = new List<DateTime>();
List<bool> updateHasExpiredList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_faf38c2d2aeee71f293ad23cd32fa7e2)inParamSourceList.Current).ssENActivityInstance;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
updateProcessInstanceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProcessInstanceId));
if ((record.ssProcessDefinitionId==0)) {
updateProcessDefinitionIdList.Add(null);
} else {
updateProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
}
updateStatusList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStatus));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateLastModifiedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssLastModifiedOn));
updateHasExpiredList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasExpired));
} else {
insertActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
insertProcessInstanceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProcessInstanceId));
if ((record.ssProcessDefinitionId==0)) {
insertProcessDefinitionIdList.Add(null);
} else {
insertProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
}
insertStatusList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStatus));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertLastModifiedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssLastModifiedOn));
insertHasExpiredList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasExpired));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertActivityDefinitionIdList.IsEmpty() || !insertProcessInstanceIdList.IsEmpty() || !insertProcessDefinitionIdList.IsEmpty() || !insertStatusList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertLastModifiedOnList.IsEmpty() || !insertHasExpiredList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssActivityDefinitionId",DbType.Int32,insertActivityDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessInstanceId",DbType.Int64,insertProcessInstanceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessDefinitionId",DbType.Int32,insertProcessDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssStatus",DbType.Int64,insertStatusList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssLastModifiedOn",DbType.DateTime,insertLastModifiedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssHasExpired",DbType.Boolean,insertHasExpiredList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityInstance (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateActivityDefinitionIdList.IsEmpty() || !updateProcessInstanceIdList.IsEmpty() || !updateProcessDefinitionIdList.IsEmpty() || !updateStatusList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateLastModifiedOnList.IsEmpty() || !updateHasExpiredList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssActivityDefinitionId",DbType.Int32,updateActivityDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessInstanceId",DbType.Int64,updateProcessInstanceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessDefinitionId",DbType.Int32,updateProcessDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssStatus",DbType.Int64,updateStatusList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssLastModifiedOn",DbType.DateTime,updateLastModifiedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssHasExpired",DbType.Boolean,updateHasExpiredList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityInstance (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityInstance
/// </summary>

public static async Task DeleteActivityInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityInstance", "d33a0e86-24e8-41d1-b331-14c594405339.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityInstance
/// </summary>

public static async Task<RC_faf38c2d2aeee71f293ad23cd32fa7e2> GetActivityInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_faf38c2d2aeee71f293ad23cd32fa7e2 outParamRecord = default;
outParamRecord = new RC_faf38c2d2aeee71f293ad23cd32fa7e2();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityInstance", "d33a0e86-24e8-41d1-b331-14c594405339.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"activitydefinitionid\"" +
", \"processinstanceid\"" +
", \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"hasexpired\"" +
" FROM " + ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityInstanceForUpdate
/// </summary>

public static async Task<RC_faf38c2d2aeee71f293ad23cd32fa7e2> GetActivityInstanceForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_faf38c2d2aeee71f293ad23cd32fa7e2 outParamRecord = default;
outParamRecord = new RC_faf38c2d2aeee71f293ad23cd32fa7e2();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityInstanceForUpdate", "d33a0e86-24e8-41d1-b331-14c594405339.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"activitydefinitionid\"" +
", \"processinstanceid\"" +
", \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"hasexpired\"" +
"FROM " + ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityInstanceForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityInstance
/// </summary>

public static async Task UpdateActivityInstance(IRequestContext requestContext,BitArray usedFields,RC_faf38c2d2aeee71f293ad23cd32fa7e2 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityInstance", "d33a0e86-24e8-41d1-b331-14c594405339.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityInstanceEntityRecord ssENActivityInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENActivityInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processinstanceid\" = @ssProcessInstanceId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"status\" = @ssStatus"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"startedon\" = @ssStartedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"lastmodifiedon\" = @ssLastModifiedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"hasexpired\" = @ssHasExpired"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityInstance_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"hasexpired\" = \"hasexpired\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityInstance.ssActivityDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProcessInstanceId", DbType.Int64, ssENActivityInstance.ssProcessInstanceId);
}
if(usedFields[3]) {
if ((ssENActivityInstance.ssProcessDefinitionId==0)) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENActivityInstance.ssProcessDefinitionId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENActivityInstance.ssStatus);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActivityInstance.ssStartedOn);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENActivityInstance.ssLastModifiedOn);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssHasExpired", DbType.Boolean, ssENActivityInstance.ssHasExpired);
}
sqlCmd.CreateParameter("@idparam_ssENActivityInstance_ssId_", DbType.Int64, ssENActivityInstance.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityInstance", ssENActivityInstance.ssId.ToString()); }}
}
return;
}

}
}
