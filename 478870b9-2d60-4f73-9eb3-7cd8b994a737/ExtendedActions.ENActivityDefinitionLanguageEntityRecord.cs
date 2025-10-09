using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityDefinitionLanguage
/// </summary>

public static async Task<long> CreateActivityDefinitionLanguage(IRequestContext requestContext,RC_eb90da5b34724818e84008409205001c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityDefinitionLanguage", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionLanguageEntityRecord ssENActivityDefinitionLanguage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionLanguageEntity.LocalViewName(null, null) + " (" +
" \"activitydefinitionid\"" +
", \"locale\"" +
", \"label\"" +
", \"inboxinstructions\"" +
" ) VALUES (" +
" @ssActivityDefinitionId" +
", @ssLocale" +
", @ssLabel" +
", @ssInboxInstructions" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENActivityDefinitionLanguage.ssActivityDefinitionId==0)) {
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLanguage.ssActivityDefinitionId);

}
insertSqlCmd.CreateParameter("@ssLocale", DbType.String, ssENActivityDefinitionLanguage.ssLocale);
insertSqlCmd.CreateParameter("@ssLabel", DbType.String, ssENActivityDefinitionLanguage.ssLabel);
insertSqlCmd.CreateParameter("@ssInboxInstructions", DbType.String, ssENActivityDefinitionLanguage.ssInboxInstructions);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityDefinitionLanguage
/// </summary>

public static async Task<long> CreateOrUpdateActivityDefinitionLanguage(IRequestContext requestContext,BitArray usedFields,RC_eb90da5b34724818e84008409205001c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityDefinitionLanguage", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionLanguageEntityRecord ssENActivityDefinitionLanguage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"locale\" = @ssLocale"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"label\" = @ssLabel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inboxinstructions\" = @ssInboxInstructions"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinitionLanguage_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"activitydefinitionid\" = \"activitydefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENActivityDefinitionLanguage.ssActivityDefinitionId==0)) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLanguage.ssActivityDefinitionId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLocale", DbType.String, ssENActivityDefinitionLanguage.ssLocale);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssLabel", DbType.String, ssENActivityDefinitionLanguage.ssLabel);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssInboxInstructions", DbType.String, ssENActivityDefinitionLanguage.ssInboxInstructions);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinitionLanguage_ssId_", DbType.Int64, ssENActivityDefinitionLanguage.ssId);
int counter = 0;
if(ssENActivityDefinitionLanguage.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinitionLanguage (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityDefinitionLanguageEntity.LocalViewName(null, null) + " (" +
" \"activitydefinitionid\"" +
", \"locale\"" +
", \"label\"" +
", \"inboxinstructions\"" +
" ) VALUES (" +
" @ssActivityDefinitionId" +
", @ssLocale" +
", @ssLabel" +
", @ssInboxInstructions" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENActivityDefinitionLanguage.ssActivityDefinitionId==0)) {
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLanguage.ssActivityDefinitionId);

}
insertSqlCmd.CreateParameter("@ssLocale", DbType.String, ssENActivityDefinitionLanguage.ssLocale);
insertSqlCmd.CreateParameter("@ssLabel", DbType.String, ssENActivityDefinitionLanguage.ssLabel);
insertSqlCmd.CreateParameter("@ssInboxInstructions", DbType.String, ssENActivityDefinitionLanguage.ssInboxInstructions);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityDefinitionLanguage.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityDefinitionLanguage
/// </summary>

public static async Task CreateOrUpdateSomeActivityDefinitionLanguage(IRequestContext requestContext,RL_84cf1463cd1d81cde9e2c5c4a48cc763 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityDefinitionLanguage", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityDefinitionLanguageEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"activitydefinitionid\", \"locale\", \"label\", \"inboxinstructions\") VALUES ( unnest(@ssActivityDefinitionId),  unnest(@ssLocale),  unnest(@ssLabel),  unnest(@ssInboxInstructions)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"activitydefinitionid\" = updateTable.\"activitydefinitionid\", \"locale\" = updateTable.\"locale\", \"label\" = updateTable.\"label\", \"inboxinstructions\" = updateTable.\"inboxinstructions\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssActivityDefinitionId) as \"activitydefinitionid\",  unnest(@ssLocale) as \"locale\",  unnest(@ssLabel) as \"label\",  unnest(@ssInboxInstructions) as \"inboxinstructions\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertActivityDefinitionIdList = new List<object>();
List<string> insertLocaleList = new List<string>();
List<string> insertLabelList = new List<string>();
List<string> insertInboxInstructionsList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateActivityDefinitionIdList = new List<object>();
List<string> updateLocaleList = new List<string>();
List<string> updateLabelList = new List<string>();
List<string> updateInboxInstructionsList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_eb90da5b34724818e84008409205001c)inParamSourceList.Current).ssENActivityDefinitionLanguage;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssActivityDefinitionId==0)) {
updateActivityDefinitionIdList.Add(null);
} else {
updateActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
}
updateLocaleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLocale));
updateLabelList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLabel));
updateInboxInstructionsList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInboxInstructions));
} else {
if ((record.ssActivityDefinitionId==0)) {
insertActivityDefinitionIdList.Add(null);
} else {
insertActivityDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssActivityDefinitionId));
}
insertLocaleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLocale));
insertLabelList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLabel));
insertInboxInstructionsList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInboxInstructions));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertActivityDefinitionIdList.IsEmpty() || !insertLocaleList.IsEmpty() || !insertLabelList.IsEmpty() || !insertInboxInstructionsList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssActivityDefinitionId",DbType.Int32,insertActivityDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLocale",DbType.String,insertLocaleList);
executionService.CreateParameter(insertSqlCmd,"@ssLabel",DbType.String,insertLabelList);
executionService.CreateParameter(insertSqlCmd,"@ssInboxInstructions",DbType.String,insertInboxInstructionsList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityDefinitionLanguage (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateActivityDefinitionIdList.IsEmpty() || !updateLocaleList.IsEmpty() || !updateLabelList.IsEmpty() || !updateInboxInstructionsList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssActivityDefinitionId",DbType.Int32,updateActivityDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssLocale",DbType.String,updateLocaleList);
executionService.CreateParameter(updateSqlCmd,"@ssLabel",DbType.String,updateLabelList);
executionService.CreateParameter(updateSqlCmd,"@ssInboxInstructions",DbType.String,updateInboxInstructionsList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityDefinitionLanguage (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityDefinitionLanguage
/// </summary>

public static async Task DeleteActivityDefinitionLanguage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityDefinitionLanguage", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityDefinitionLanguage
/// </summary>

public static async Task<RC_eb90da5b34724818e84008409205001c> GetActivityDefinitionLanguage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_eb90da5b34724818e84008409205001c outParamRecord = default;
outParamRecord = new RC_eb90da5b34724818e84008409205001c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionLanguage", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"activitydefinitionid\"" +
", \"locale\"" +
", \"label\"" +
", \"inboxinstructions\"" +
" FROM " + ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityDefinitionLanguageForUpdate
/// </summary>

public static async Task<RC_eb90da5b34724818e84008409205001c> GetActivityDefinitionLanguageForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_eb90da5b34724818e84008409205001c outParamRecord = default;
outParamRecord = new RC_eb90da5b34724818e84008409205001c();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityDefinitionLanguageForUpdate", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"activitydefinitionid\"" +
", \"locale\"" +
", \"label\"" +
", \"inboxinstructions\"" +
"FROM " + ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityDefinitionLanguageForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityDefinitionLanguage
/// </summary>

public static async Task UpdateActivityDefinitionLanguage(IRequestContext requestContext,BitArray usedFields,RC_eb90da5b34724818e84008409205001c inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityDefinitionLanguage", "d6b2b41a-65b4-47eb-835a-f9c8e96153f3.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityDefinitionLanguageEntityRecord ssENActivityDefinitionLanguage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENActivityDefinitionLanguageEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activitydefinitionid\" = @ssActivityDefinitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"locale\" = @ssLocale"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"label\" = @ssLabel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"inboxinstructions\" = @ssInboxInstructions"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityDefinitionLanguage_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"activitydefinitionid\" = \"activitydefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENActivityDefinitionLanguage.ssActivityDefinitionId==0)) {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssActivityDefinitionId", DbType.Int32, ssENActivityDefinitionLanguage.ssActivityDefinitionId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLocale", DbType.String, ssENActivityDefinitionLanguage.ssLocale);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssLabel", DbType.String, ssENActivityDefinitionLanguage.ssLabel);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssInboxInstructions", DbType.String, ssENActivityDefinitionLanguage.ssInboxInstructions);
}
sqlCmd.CreateParameter("@idparam_ssENActivityDefinitionLanguage_ssId_", DbType.Int64, ssENActivityDefinitionLanguage.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityDefinitionLanguage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityDefinitionLanguage", ssENActivityDefinitionLanguage.ssId.ToString()); }}
}
return;
}

}
}
