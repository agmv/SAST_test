using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessInstance
/// </summary>

public static async Task<long> CreateProcessInstance(IRequestContext requestContext,RC_c2c51a49c601586c1a143904ac6893f9 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInstanceEntityRecord ssENProcessInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessInstanceEntity.LocalViewName(null, null) + " (" +
" \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"label\"" +
" ) VALUES (" +
" @ssProcessDefinitionId" +
", @ssStatus" +
", @ssStartedOn" +
", @ssLastModifiedOn" +
", @ssLabel" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInstance.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENProcessInstance.ssStatus);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProcessInstance.ssStartedOn);
insertSqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENProcessInstance.ssLastModifiedOn);
insertSqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessInstance.ssLabel);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessInstance
/// </summary>

public static async Task<long> CreateOrUpdateProcessInstance(IRequestContext requestContext,BitArray usedFields,RC_c2c51a49c601586c1a143904ac6893f9 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInstanceEntityRecord ssENProcessInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"status\" = @ssStatus"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"startedon\" = @ssStartedOn"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"lastmodifiedon\" = @ssLastModifiedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"label\" = @ssLabel"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessInstance_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"processdefinitionid\" = \"processdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInstance.ssProcessDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENProcessInstance.ssStatus);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProcessInstance.ssStartedOn);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENProcessInstance.ssLastModifiedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessInstance.ssLabel);
}
sqlCmd.CreateParameter("@idparam_ssENProcessInstance_ssId_", DbType.Int64, ssENProcessInstance.ssId);
int counter = 0;
if(ssENProcessInstance.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessInstance (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessInstanceEntity.LocalViewName(null, null) + " (" +
" \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"label\"" +
" ) VALUES (" +
" @ssProcessDefinitionId" +
", @ssStatus" +
", @ssStartedOn" +
", @ssLastModifiedOn" +
", @ssLabel" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInstance.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENProcessInstance.ssStatus);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProcessInstance.ssStartedOn);
insertSqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENProcessInstance.ssLastModifiedOn);
insertSqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessInstance.ssLabel);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessInstance.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessInstance
/// </summary>

public static async Task CreateOrUpdateSomeProcessInstance(IRequestContext requestContext,RL_247a9c7809b4893cc7a21d0914d69e61 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessInstanceEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"processdefinitionid\", \"status\", \"startedon\", \"lastmodifiedon\", \"label\") VALUES ( unnest(@ssProcessDefinitionId),  unnest(@ssStatus),  unnest(@ssStartedOn),  unnest(@ssLastModifiedOn),  unnest(@ssLabel)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"processdefinitionid\" = updateTable.\"processdefinitionid\", \"status\" = updateTable.\"status\", \"startedon\" = updateTable.\"startedon\", \"lastmodifiedon\" = updateTable.\"lastmodifiedon\", \"label\" = updateTable.\"label\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssProcessDefinitionId) as \"processdefinitionid\",  unnest(@ssStatus) as \"status\",  unnest(@ssStartedOn) as \"startedon\",  unnest(@ssLastModifiedOn) as \"lastmodifiedon\",  unnest(@ssLabel) as \"label\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertProcessDefinitionIdList = new List<object>();
List<object> insertStatusList = new List<object>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertLastModifiedOnList = new List<DateTime>();
List<string> insertLabelList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateProcessDefinitionIdList = new List<object>();
List<object> updateStatusList = new List<object>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateLastModifiedOnList = new List<DateTime>();
List<string> updateLabelList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_c2c51a49c601586c1a143904ac6893f9)inParamSourceList.Current).ssENProcessInstance;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
updateStatusList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStatus));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateLastModifiedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssLastModifiedOn));
updateLabelList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLabel));
} else {
insertProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
insertStatusList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStatus));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertLastModifiedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssLastModifiedOn));
insertLabelList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLabel));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProcessDefinitionIdList.IsEmpty() || !insertStatusList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertLastModifiedOnList.IsEmpty() || !insertLabelList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProcessDefinitionId",DbType.Int32,insertProcessDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssStatus",DbType.Int64,insertStatusList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssLastModifiedOn",DbType.DateTime,insertLastModifiedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssLabel",DbType.String,insertLabelList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessInstance (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProcessDefinitionIdList.IsEmpty() || !updateStatusList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateLastModifiedOnList.IsEmpty() || !updateLabelList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessDefinitionId",DbType.Int32,updateProcessDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssStatus",DbType.Int64,updateStatusList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssLastModifiedOn",DbType.DateTime,updateLastModifiedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssLabel",DbType.String,updateLabelList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessInstance (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessInstance
/// </summary>

public static async Task DeleteProcessInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProcessInstance
/// </summary>

public static async Task DeleteAllProcessInstance(IRequestContext requestContext,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#DeleteAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessInstance
/// </summary>

public static async Task<RC_c2c51a49c601586c1a143904ac6893f9> GetProcessInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c2c51a49c601586c1a143904ac6893f9 outParamRecord = default;
outParamRecord = new RC_c2c51a49c601586c1a143904ac6893f9();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"label\"" +
" FROM " + ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessInstanceForUpdate
/// </summary>

public static async Task<RC_c2c51a49c601586c1a143904ac6893f9> GetProcessInstanceForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c2c51a49c601586c1a143904ac6893f9 outParamRecord = default;
outParamRecord = new RC_c2c51a49c601586c1a143904ac6893f9();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessInstanceForUpdate", "245a4dae-efd0-4272-93f7-51f180268eeb.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"processdefinitionid\"" +
", \"status\"" +
", \"startedon\"" +
", \"lastmodifiedon\"" +
", \"label\"" +
"FROM " + ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessInstanceForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessInstance
/// </summary>

public static async Task UpdateProcessInstance(IRequestContext requestContext,BitArray usedFields,RC_c2c51a49c601586c1a143904ac6893f9 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessInstance", "245a4dae-efd0-4272-93f7-51f180268eeb.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessInstanceEntityRecord ssENProcessInstance = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENProcessInstanceEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"status\" = @ssStatus"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"startedon\" = @ssStartedOn"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"lastmodifiedon\" = @ssLastModifiedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"label\" = @ssLabel"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessInstance_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"processdefinitionid\" = \"processdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessInstance.ssProcessDefinitionId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssStatus", DbType.Int64, ssENProcessInstance.ssStatus);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProcessInstance.ssStartedOn);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssLastModifiedOn", DbType.DateTime, ssENProcessInstance.ssLastModifiedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssLabel", DbType.String, ssENProcessInstance.ssLabel);
}
sqlCmd.CreateParameter("@idparam_ssENProcessInstance_ssId_", DbType.Int64, ssENProcessInstance.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessInstance", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessInstance", ssENProcessInstance.ssId.ToString()); }}
}
return;
}

}
}
