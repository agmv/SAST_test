using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActivityOutput
/// </summary>

public static async Task<long> CreateActivityOutput(IRequestContext requestContext,RC_24e87e1f1de297ca8a691099e40c22ed inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActivityOutput", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityOutputEntityRecord ssENActivityOutput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActivityOutputEntity.LocalViewName(null, null) + " (" +
" \"activityid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssActivityId" +
", @ssOutputDefinitionId" +
", @ssOutputDefinitionKey" +
", @ssName" +
", @ssDataType" +
", @ssOutputValue" +
", @ssForeignKeyEntityId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENActivityOutput.ssActivityId==0L)) {
insertSqlCmd.CreateParameter("@ssActivityId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssActivityId", DbType.Int64, ssENActivityOutput.ssActivityId);

}
insertSqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENActivityOutput.ssOutputDefinitionId);
insertSqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENActivityOutput.ssOutputDefinitionKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutput.ssName);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutput.ssDataType);
insertSqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENActivityOutput.ssOutputValue);
if ((ssENActivityOutput.ssForeignKeyEntityId=="")) {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutput.ssForeignKeyEntityId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActivityOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActivityOutput
/// </summary>

public static async Task<long> CreateOrUpdateActivityOutput(IRequestContext requestContext,BitArray usedFields,RC_24e87e1f1de297ca8a691099e40c22ed inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActivityOutput", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityOutputEntityRecord ssENActivityOutput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activityid\" = @ssActivityId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionid\" = @ssOutputDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionkey\" = @ssOutputDefinitionKey"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputvalue\" = @ssOutputValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityOutput_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"outputdefinitionid\" = \"outputdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENActivityOutput.ssActivityId==0L)) {
sqlCmd.CreateParameter("@ssActivityId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssActivityId", DbType.Int64, ssENActivityOutput.ssActivityId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENActivityOutput.ssOutputDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENActivityOutput.ssOutputDefinitionKey);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutput.ssName);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutput.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENActivityOutput.ssOutputValue);
}
if(usedFields[7]) {
if ((ssENActivityOutput.ssForeignKeyEntityId=="")) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutput.ssForeignKeyEntityId);

}
}
sqlCmd.CreateParameter("@idparam_ssENActivityOutput_ssId_", DbType.Int64, ssENActivityOutput.ssId);
int counter = 0;
if(ssENActivityOutput.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityOutput (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActivityOutputEntity.LocalViewName(null, null) + " (" +
" \"activityid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssActivityId" +
", @ssOutputDefinitionId" +
", @ssOutputDefinitionKey" +
", @ssName" +
", @ssDataType" +
", @ssOutputValue" +
", @ssForeignKeyEntityId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENActivityOutput.ssActivityId==0L)) {
insertSqlCmd.CreateParameter("@ssActivityId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssActivityId", DbType.Int64, ssENActivityOutput.ssActivityId);

}
insertSqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENActivityOutput.ssOutputDefinitionId);
insertSqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENActivityOutput.ssOutputDefinitionKey);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutput.ssName);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutput.ssDataType);
insertSqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENActivityOutput.ssOutputValue);
if ((ssENActivityOutput.ssForeignKeyEntityId=="")) {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutput.ssForeignKeyEntityId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActivityOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActivityOutput.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActivityOutput
/// </summary>

public static async Task CreateOrUpdateSomeActivityOutput(IRequestContext requestContext,RL_28fc2381cbc1135b5eb41ae627dcd287 inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActivityOutput", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENActivityOutputEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"activityid\", \"outputdefinitionid\", \"outputdefinitionkey\", \"name\", \"datatype\", \"outputvalue\", \"foreignkeyentityid\") VALUES ( unnest(@ssActivityId),  unnest(@ssOutputDefinitionId),  unnest(@ssOutputDefinitionKey),  unnest(@ssName),  unnest(@ssDataType),  unnest(@ssOutputValue),  unnest(@ssForeignKeyEntityId)) ";
insertSql+= "";

string updateSql =
"UPDATE " + entityTableName + " SET \"activityid\" = updateTable.\"activityid\", \"outputdefinitionid\" = updateTable.\"outputdefinitionid\", \"outputdefinitionkey\" = updateTable.\"outputdefinitionkey\", \"name\" = updateTable.\"name\", \"datatype\" = updateTable.\"datatype\", \"outputvalue\" = updateTable.\"outputvalue\", \"foreignkeyentityid\" = updateTable.\"foreignkeyentityid\" from ( select  unnest(@ssId) as \"id\",  unnest(@ssActivityId) as \"activityid\",  unnest(@ssOutputDefinitionId) as \"outputdefinitionid\",  unnest(@ssOutputDefinitionKey) as \"outputdefinitionkey\",  unnest(@ssName) as \"name\",  unnest(@ssDataType) as \"datatype\",  unnest(@ssOutputValue) as \"outputvalue\",  unnest(@ssForeignKeyEntityId) as \"foreignkeyentityid\" ) as updateTable where " + entityTableName + ".\"id\" = updateTable.\"id\" ";
updateSql+= "";

List<object> insertActivityIdList = new List<object>();
List<object> insertOutputDefinitionIdList = new List<object>();
List<string> insertOutputDefinitionKeyList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertDataTypeList = new List<string>();
List<string> insertOutputValueList = new List<string>();
List<object> insertForeignKeyEntityIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateActivityIdList = new List<object>();
List<object> updateOutputDefinitionIdList = new List<object>();
List<string> updateOutputDefinitionKeyList = new List<string>();
List<string> updateNameList = new List<string>();
List<string> updateDataTypeList = new List<string>();
List<string> updateOutputValueList = new List<string>();
List<object> updateForeignKeyEntityIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_24e87e1f1de297ca8a691099e40c22ed)inParamSourceList.Current).ssENActivityOutput;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssActivityId==0L)) {
updateActivityIdList.Add(null);
} else {
updateActivityIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssActivityId));
}
updateOutputDefinitionIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionId));
updateOutputDefinitionKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionKey));
updateNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
updateDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
updateOutputValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputValue));
if ((record.ssForeignKeyEntityId=="")) {
updateForeignKeyEntityIdList.Add(null);
} else {
updateForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
}
} else {
if ((record.ssActivityId==0L)) {
insertActivityIdList.Add(null);
} else {
insertActivityIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssActivityId));
}
insertOutputDefinitionIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionId));
insertOutputDefinitionKeyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputDefinitionKey));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
insertOutputValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOutputValue));
if ((record.ssForeignKeyEntityId=="")) {
insertForeignKeyEntityIdList.Add(null);
} else {
insertForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertActivityIdList.IsEmpty() || !insertOutputDefinitionIdList.IsEmpty() || !insertOutputDefinitionKeyList.IsEmpty() || !insertNameList.IsEmpty() || !insertDataTypeList.IsEmpty() || !insertOutputValueList.IsEmpty() || !insertForeignKeyEntityIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssActivityId",DbType.Int64,insertActivityIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOutputDefinitionId",DbType.String,insertOutputDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOutputDefinitionKey",DbType.String,insertOutputDefinitionKeyList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssDataType",DbType.String,insertDataTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssOutputValue",DbType.String,insertOutputValueList);
executionService.CreateParameter(insertSqlCmd,"@ssForeignKeyEntityId",DbType.String,insertForeignKeyEntityIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityOutput (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateActivityIdList.IsEmpty() || !updateOutputDefinitionIdList.IsEmpty() || !updateOutputDefinitionKeyList.IsEmpty() || !updateNameList.IsEmpty() || !updateDataTypeList.IsEmpty() || !updateOutputValueList.IsEmpty() || !updateForeignKeyEntityIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssActivityId",DbType.Int64,updateActivityIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOutputDefinitionId",DbType.String,updateOutputDefinitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOutputDefinitionKey",DbType.String,updateOutputDefinitionKeyList);
executionService.CreateParameter(updateSqlCmd,"@ssName",DbType.String,updateNameList);
executionService.CreateParameter(updateSqlCmd,"@ssDataType",DbType.String,updateDataTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssOutputValue",DbType.String,updateOutputValueList);
executionService.CreateParameter(updateSqlCmd,"@ssForeignKeyEntityId",DbType.String,updateForeignKeyEntityIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActivityOutput (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActivityOutput
/// </summary>

public static async Task DeleteActivityOutput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActivityOutput", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActivityOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActivityOutput
/// </summary>

public static async Task<RC_24e87e1f1de297ca8a691099e40c22ed> GetActivityOutput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_24e87e1f1de297ca8a691099e40c22ed outParamRecord = default;
outParamRecord = new RC_24e87e1f1de297ca8a691099e40c22ed();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityOutput", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"activityid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
" FROM " + ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActivityOutputForUpdate
/// </summary>

public static async Task<RC_24e87e1f1de297ca8a691099e40c22ed> GetActivityOutputForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_24e87e1f1de297ca8a691099e40c22ed outParamRecord = default;
outParamRecord = new RC_24e87e1f1de297ca8a691099e40c22ed();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActivityOutputForUpdate", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"activityid\"" +
", \"outputdefinitionid\"" +
", \"outputdefinitionkey\"" +
", \"name\"" +
", \"datatype\"" +
", \"outputvalue\"" +
", \"foreignkeyentityid\"" +
"FROM " + ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActivityOutputForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActivityOutput
/// </summary>

public static async Task UpdateActivityOutput(IRequestContext requestContext,BitArray usedFields,RC_24e87e1f1de297ca8a691099e40c22ed inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActivityOutput", "0fbe83f1-7a78-4e69-9f6d-50b6dc4bb00a.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENActivityOutputEntityRecord ssENActivityOutput = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENActivityOutputEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"activityid\" = @ssActivityId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionid\" = @ssOutputDefinitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputdefinitionkey\" = @ssOutputDefinitionKey"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"outputvalue\" = @ssOutputValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENActivityOutput_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"outputdefinitionid\" = \"outputdefinitionid\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENActivityOutput.ssActivityId==0L)) {
sqlCmd.CreateParameter("@ssActivityId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssActivityId", DbType.Int64, ssENActivityOutput.ssActivityId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssOutputDefinitionId", DbType.String, ssENActivityOutput.ssOutputDefinitionId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOutputDefinitionKey", DbType.String, ssENActivityOutput.ssOutputDefinitionKey);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENActivityOutput.ssName);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENActivityOutput.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssOutputValue", DbType.String, ssENActivityOutput.ssOutputValue);
}
if(usedFields[7]) {
if ((ssENActivityOutput.ssForeignKeyEntityId=="")) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENActivityOutput.ssForeignKeyEntityId);

}
}
sqlCmd.CreateParameter("@idparam_ssENActivityOutput_ssId_", DbType.Int64, ssENActivityOutput.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActivityOutput", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActivityOutput", ssENActivityOutput.ssId.ToString()); }}
}
return;
}

}
}
