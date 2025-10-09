using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateEmail
/// </summary>

public static async Task<long> CreateEmail(IRequestContext requestContext,RC_c25115a84bc21f80350d8ea6536353ed inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateEmail", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENEmailEntityRecord ssENEmail = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENEmailEntity.LocalViewName(null, null) + " (" +
" \"size\"" +
" ) VALUES (" +
" @ssSize" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssSize", DbType.Int32, ssENEmail.ssSize);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateEmail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateEmail
/// </summary>

public static async Task<long> CreateOrUpdateEmail(IRequestContext requestContext,BitArray usedFields,RC_c25115a84bc21f80350d8ea6536353ed inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateEmail", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENEmailEntityRecord ssENEmail = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(2,true);
}
string updateSet = "UPDATE " + ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"size\" = @ssSize"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENEmail_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"size\" = \"size\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssSize", DbType.Int32, ssENEmail.ssSize);
}
sqlCmd.CreateParameter("@idparam_ssENEmail_ssId_", DbType.Int64, ssENEmail.ssId);
int counter = 0;
if(ssENEmail.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateEmail (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENEmailEntity.LocalViewName(null, null) + " (" +
" \"size\"" +
" ) VALUES (" +
" @ssSize" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssSize", DbType.Int32, ssENEmail.ssSize);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateEmail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENEmail.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeEmail
/// </summary>

public static async Task CreateOrUpdateSomeEmail(IRequestContext requestContext,RL_fd604259751c80eed887a8f5a0f5dc23 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeEmail", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENEmailEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"size\") VALUES ( unnest(@ssSize)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"size\" = updateTable.\"size\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssSize) as \"size\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<int> insertSizeList = new List<int>();

List<long> updateIdList = new List<long>();
List<int> updateSizeList = new List<int>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_c25115a84bc21f80350d8ea6536353ed)inParamSourceList.Current).ssENEmail;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateSizeList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssSize));
} else {
insertSizeList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssSize));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertSizeList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssSize",DbType.Int32,insertSizeList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeEmail (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateSizeList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSize",DbType.Int32,updateSizeList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeEmail (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteEmail
/// </summary>

public static async Task DeleteEmail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteEmail", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteEmail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetEmail
/// </summary>

public static async Task<RC_c25115a84bc21f80350d8ea6536353ed> GetEmail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c25115a84bc21f80350d8ea6536353ed outParamRecord = default;
outParamRecord = new RC_c25115a84bc21f80350d8ea6536353ed();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEmail", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"size\"" +
" FROM " + ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEmail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(2,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetEmailForUpdate
/// </summary>

public static async Task<RC_c25115a84bc21f80350d8ea6536353ed> GetEmailForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c25115a84bc21f80350d8ea6536353ed outParamRecord = default;
outParamRecord = new RC_c25115a84bc21f80350d8ea6536353ed();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEmailForUpdate", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"size\"" +
"FROM " + ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEmailForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(2,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateEmail
/// </summary>

public static async Task UpdateEmail(IRequestContext requestContext,BitArray usedFields,RC_c25115a84bc21f80350d8ea6536353ed inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateEmail", "ddfe6b09-0ad7-4e1e-9cb5-7809f35176b6.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENEmailEntityRecord ssENEmail = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(2,true);
}
string updateSet = "UPDATE " + ENEmailEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"size\" = @ssSize"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENEmail_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"size\" = \"size\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssSize", DbType.Int32, ssENEmail.ssSize);
}
sqlCmd.CreateParameter("@idparam_ssENEmail_ssId_", DbType.Int64, ssENEmail.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateEmail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Email", ssENEmail.ssId.ToString()); }}
}
return;
}

}
}
