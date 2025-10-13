using System.Diagnostics;
namespace ssSystem_ {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProcessOutputDefinition
/// </summary>

public static async Task<string> CreateProcessOutputDefinition(IRequestContext requestContext,RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProcessOutputDefinition", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#CreateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessOutputDefinitionEntityRecord ssENProcessOutputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProcessOutputDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssDescription" +
", @ssProcessDefinitionId" +
", @ssIsActive" +
", @ssDataType" +
", @ssDefaultValue" +
", @ssForeignKeyEntityId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENProcessOutputDefinition.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutputDefinition.ssName);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessOutputDefinition.ssDescription);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessOutputDefinition.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessOutputDefinition.ssIsActive);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutputDefinition.ssDataType);
insertSqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessOutputDefinition.ssDefaultValue);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutputDefinition.ssForeignKeyEntityId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProcessOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessOutputDefinition.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProcessOutputDefinition
/// </summary>

public static async Task<string> CreateOrUpdateProcessOutputDefinition(IRequestContext requestContext,BitArray usedFields,RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 inParamSource,CancellationToken cancellationToken) {
string outParamId = default;
outParamId = "";

using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProcessOutputDefinition", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#CreateOrUpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessOutputDefinitionEntityRecord ssENProcessOutputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"description\" = @ssDescription"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"defaultvalue\" = @ssDefaultValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessOutputDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutputDefinition.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessOutputDefinition.ssDescription);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessOutputDefinition.ssProcessDefinitionId);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessOutputDefinition.ssIsActive);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutputDefinition.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessOutputDefinition.ssDefaultValue);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutputDefinition.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessOutputDefinition_ssId_", DbType.String, ssENProcessOutputDefinition.ssId);
int counter = 0;
if(ssENProcessOutputDefinition.ssId != "") {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessOutputDefinition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProcessOutputDefinitionEntity.LocalViewName(null, null) + " (" +
" \"id\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
" ) VALUES (" +
" @ssId" +
", @ssName" +
", @ssDescription" +
", @ssProcessDefinitionId" +
", @ssIsActive" +
", @ssDataType" +
", @ssDefaultValue" +
", @ssForeignKeyEntityId" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.String, ssENProcessOutputDefinition.ssId);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutputDefinition.ssName);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessOutputDefinition.ssDescription);
insertSqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessOutputDefinition.ssProcessDefinitionId);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessOutputDefinition.ssIsActive);
insertSqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutputDefinition.ssDataType);
insertSqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessOutputDefinition.ssDefaultValue);
insertSqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutputDefinition.ssForeignKeyEntityId);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProcessOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENProcessOutputDefinition.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProcessOutputDefinition.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProcessOutputDefinition
/// </summary>

public static async Task CreateOrUpdateSomeProcessOutputDefinition(IRequestContext requestContext,RL_52acedf8b6208b104cbd689064facc6a inParamSourceList,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProcessOutputDefinition", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#CreateOrUpdateAllEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
string entityTableName = ENProcessOutputDefinitionEntity.LocalViewName(null, null);
string insertSql ="INSERT INTO " + entityTableName + " (\"id\", \"name\", \"description\", \"processdefinitionid\", \"isactive\", \"datatype\", \"defaultvalue\", \"foreignkeyentityid\") VALUES ( unnest(@ssId),  unnest(@ssName),  unnest(@ssDescription),  unnest(@ssProcessDefinitionId),  unnest(@ssIsActive),  unnest(@ssDataType),  unnest(@ssDefaultValue),  unnest(@ssForeignKeyEntityId)) ON CONFLICT(\"id\") do update set \"name\" = EXCLUDED.\"name\", \"description\" = EXCLUDED.\"description\", \"processdefinitionid\" = EXCLUDED.\"processdefinitionid\", \"isactive\" = EXCLUDED.\"isactive\", \"datatype\" = EXCLUDED.\"datatype\", \"defaultvalue\" = EXCLUDED.\"defaultvalue\", \"foreignkeyentityid\" = EXCLUDED.\"foreignkeyentityid\" ";
insertSql+= "";


List<string> insertIdList = new List<string>();
List<string> insertNameList = new List<string>();
List<string> insertDescriptionList = new List<string>();
List<object> insertProcessDefinitionIdList = new List<object>();
List<bool> insertIsActiveList = new List<bool>();
List<string> insertDataTypeList = new List<string>();
List<string> insertDefaultValueList = new List<string>();
List<object> insertForeignKeyEntityIdList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4)inParamSourceList.Current).ssENProcessOutputDefinition;
insertIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssId));
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertProcessDefinitionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessDefinitionId));
insertIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
insertDataTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDataType));
insertDefaultValueList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDefaultValue));
insertForeignKeyEntityIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssForeignKeyEntityId));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertNameList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertProcessDefinitionIdList.IsEmpty() || !insertIsActiveList.IsEmpty() || !insertDataTypeList.IsEmpty() || !insertDefaultValueList.IsEmpty() || !insertForeignKeyEntityIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.String,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessDefinitionId",DbType.Int32,insertProcessDefinitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsActive",DbType.Boolean,insertIsActiveList);
executionService.CreateParameter(insertSqlCmd,"@ssDataType",DbType.String,insertDataTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssDefaultValue",DbType.String,insertDefaultValueList);
executionService.CreateParameter(insertSqlCmd,"@ssForeignKeyEntityId",DbType.String,insertForeignKeyEntityIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProcessOutputDefinition (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProcessOutputDefinition
/// </summary>

public static async Task DeleteProcessOutputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProcessOutputDefinition", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#DeleteEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProcessOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProcessOutputDefinition
/// </summary>

public static async Task<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> GetProcessOutputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 outParamRecord = default;
outParamRecord = new RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessOutputDefinition", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#GetEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
" FROM " + ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProcessOutputDefinitionForUpdate
/// </summary>

public static async Task<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> GetProcessOutputDefinitionForUpdate(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 outParamRecord = default;
outParamRecord = new RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessOutputDefinitionForUpdate", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#GetEntityForUpdate", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" \"id\"" +
", \"name\"" +
", \"description\"" +
", \"processdefinitionid\"" +
", \"isactive\"" +
", \"datatype\"" +
", \"defaultvalue\"" +
", \"foreignkeyentityid\"" +
"FROM " + ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE \"id\" = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessOutputDefinitionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProcessOutputDefinition
/// </summary>

public static async Task UpdateProcessOutputDefinition(IRequestContext requestContext,BitArray usedFields,RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 inParamSource,CancellationToken cancellationToken) {
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProcessOutputDefinition", "211668b8-5b33-4ba2-ab15-fb86f73c5b4b.#UpdateEntity", "System_", "478870b9-2d60-4f73-9eb3-7cd8b994a737");
ENProcessOutputDefinitionEntityRecord ssENProcessOutputDefinition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProcessOutputDefinitionEntity.LocalViewName(null, BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"name\" = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"description\" = @ssDescription"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"processdefinitionid\" = @ssProcessDefinitionId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"isactive\" = @ssIsActive"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"datatype\" = @ssDataType"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"defaultvalue\" = @ssDefaultValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "\"foreignkeyentityid\" = @ssForeignKeyEntityId"): parameters);
string whereCondition = " WHERE \"id\" = @idparam_ssENProcessOutputDefinition_ssId_";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "\"isactive\" = \"isactive\"";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProcessOutputDefinition.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENProcessOutputDefinition.ssDescription);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessDefinitionId", DbType.Int32, ssENProcessOutputDefinition.ssProcessDefinitionId);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENProcessOutputDefinition.ssIsActive);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDataType", DbType.String, ssENProcessOutputDefinition.ssDataType);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssDefaultValue", DbType.String, ssENProcessOutputDefinition.ssDefaultValue);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssForeignKeyEntityId", DbType.String, ssENProcessOutputDefinition.ssForeignKeyEntityId);
}
sqlCmd.CreateParameter("@idparam_ssENProcessOutputDefinition_ssId_", DbType.String, ssENProcessOutputDefinition.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProcessOutputDefinition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProcessOutputDefinition", ssENProcessOutputDefinition.ssId.ToString()); }}
}
return;
}

}
}
