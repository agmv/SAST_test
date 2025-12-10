namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvEntityToExcelToEntity : VarsBag {
/// <summary>
/// Variable <code>ExpectedHttpRequest</code> that represents the Service Studio HttpRequest
///  <code>ExpectedHttpRequest</code> <p>Description: </p>
/// </summary>
public EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord varLcExpectedHttpRequest = new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord();

public long resCreateHttpRequest_outParamId = 0L;

public RL_cb90b4d276d47c120cb334b7b28342e2 resExcelToRecordList1_outParamOut = new RL_cb90b4d276d47c120cb334b7b28342e2();
public RL_cb90b4d276d47c120cb334b7b28342e2 queryResGetHttpRequests_outParamList = new RL_cb90b4d276d47c120cb334b7b28342e2();
public long queryResGetHttpRequests_outParamCount = 0L;

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public lcvEntityToExcelToEntity() {
}
}
/// <summary>
/// Action <code>EntityToExcelToEntity</code> that represents the Service Studio action
///  <code>EntityToExcelToEntity</code> <p> Description: </p>
/// </summary>
public static async Task ActionEntityToExcelToEntity(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvEntityToExcelToEntity localVars = new lcvEntityToExcelToEntity();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntityToExcelToEntity", "802a4dd3-fe63-4c46-b97b-c4ab93ebeb7b", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// ExpectedHttpRequest
// ExpectedHttpRequest.HttpMethod = DELETE
localVars.varLcExpectedHttpRequest.ssHttpMethod = (ENHttpMethodEntity.GetRecordByKey(ObjectKey.Parse("Hrru19tC0UaNx9VNz1Pnhw"))).ssId;

// ExpectedHttpRequest.Body = "{ ""body"": ""my body""}"
localVars.varLcExpectedHttpRequest.ssBody = "{ \"body\": \"my body\"}";
// CreateHttpRequest
localVars.resCreateHttpRequest_outParamId = await ExtendedActions.CreateHttpRequest(requestContext,(((RC_1ba5183fe935decff47a51e639a147ac)localVars.varLcExpectedHttpRequest)),cancellationToken);

// Query datasetGetHttpRequests
cancellationToken.ThrowIfCancellationRequested();
int datasetGetHttpRequests_maxRecords = 0;
int datasetGetHttpRequests_startIndex = 0;(localVars.queryResGetHttpRequests_outParamList,localVars.queryResGetHttpRequests_outParamCount) = await FuncActionEntityToExcelToEntity.datasetGetHttpRequests(requestContext,datasetGetHttpRequests_maxRecords,datasetGetHttpRequests_startIndex,IterationMultiplicity.Single,cancellationToken);

// RecordListToExcel RLToExcelEntityToExcelToEntityRecordListToExcel1
FuncActionEntityToExcelToEntity.RLToExcelEntityToExcelToEntityRecordListToExcel1( requestContext, localVars.queryResGetHttpRequests_outParamList, out localVars.resRecordListToExcel1_outParamOut);

// ExcelToRecordList ExcelToRLEntityToExcelToEntityExcelToRecordList1
FuncActionEntityToExcelToEntity.ExcelToRLEntityToExcelToEntityExcelToRecordList1( requestContext, localVars.resRecordListToExcel1_outParamOut, "",  out localVars.resExcelToRecordList1_outParamOut);
// DeleteHttpRequest
await ExtendedActions.DeleteHttpRequest(requestContext,localVars.resCreateHttpRequest_outParamId,cancellationToken);

// AssertTrue
await Actions.ActionAssertTrue(requestContext,((localVars.varLcExpectedHttpRequest.ssHttpMethod==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssENHttpRequest.ssHttpMethod)&&(localVars.varLcExpectedHttpRequest.ssBody==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssENHttpRequest.ssBody)),"EntityToExcelToEntity",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionEntityToExcelToEntity {

// Query Function "GetHttpRequests" olfvmnd83kS2pAsv4Izs2A of Action "EntityToExcelToEntity"
public static async Task<(RL_cb90b4d276d47c120cb334b7b28342e2,long)> datasetGetHttpRequests(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntityToExcelToEntity.GetHttpRequests", "9aef57a2-7c77-44de-b6a4-0b2fe08cecd8", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
StringBuilder selectBuilder = new StringBuilder();
StringBuilder fromBuilder = new StringBuilder();
StringBuilder whereBuilder = new StringBuilder();
StringBuilder orderByBuilder = new StringBuilder();
StringBuilder groupByBuilder = new StringBuilder();
StringBuilder havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.000qgGP+Rky5e8Srk+vrew/NodesNotShownInESpaceTree.olfvmnd83kS2pAsv4Izs2A, e7c634b1-9547-4f8e-807b-c9faa359b669 RuntimeDestroyer */");
selectBuilder.Append("SELECT \"enhttprequest\".\"id\" o0, \"enhttprequest\".\"httpmethod\" o1, \"enhttprequest\".\"body\" o2");
fromBuilder.Append(" FROM {HttpRequest} \"enhttprequest\"");
orderByBuilder.Append(" ORDER BY \"enhttprequest\".\"httpmethod\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_cb90b4d276d47c120cb334b7b28342e2 outParamList = new RL_cb90b4d276d47c120cb334b7b28342e2();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntityToExcelToEntity.GetHttpRequests.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cb90b4d276d47c120cb334b7b28342e2 _tmp = new RL_cb90b4d276d47c120cb334b7b28342e2();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntityToExcelToEntity.GetHttpRequests.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cb90b4d276d47c120cb334b7b28342e2)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}


/// <summary>
/// Excel To RecordList : ExcelToRLEntityToExcelToEntityExcelToRecordList1 (KKsECkMG7ZUK1mOBDQSiXOg) 
///  of Action "EntityToExcelToEntity"
/// </summary>
public static void ExcelToRLEntityToExcelToEntityExcelToRecordList1 (IRequestContext requestContext, byte[] excelContent, string tableName, out RL_cb90b4d276d47c120cb334b7b28342e2 outParamOut) {

int totalColumns = 3;
if(excelContent.GetLength(0) == 0) {
    throw InvalidExcelErrorsHelper.EmptyExcelFile();
}
string userTableName = tableName; // for error msg
var reader = new OutSystems.Spreadsheet.ExcelService().CreateReader(
    excelContent, 
    tableName, 
    totalColumns,
    new string[] {
        typeof(long).Name, 
typeof(string).Name, 
typeof(string).Name
    },
    new string[] {
        "Id", 
"HttpMethod", 
"Body"
    },
    new string[] {
        "Id", 
"Http Method", 
"Body"
    },
    new string[] {
        "Id", 
"HttpMethod", 
"Body"
    },
    new string[] {
        "Id", 
"Http Method", 
"Body"
    });

string errorMsg;
if (!reader.DataTypesValid(out errorMsg)) {
    throw InvalidExcelErrorsHelper.InvalidFileType(errorMsg);
}

RL_cb90b4d276d47c120cb334b7b28342e2 tmp = new();
tmp.Reader = reader;

outParamOut = (RL_cb90b4d276d47c120cb334b7b28342e2)tmp;

reader.Close();
}

/// <summary>
/// RecordList To Excel: RLToExcelEntityToExcelToEntityRecordListToExcel1 (Kavm_4yPlo0ys5dAuuOlwow)  of
///  Action "EntityToExcelToEntity"
/// </summary>
public static void RLToExcelEntityToExcelToEntityRecordListToExcel1 (IRequestContext requestContext, RL_cb90b4d276d47c120cb334b7b28342e2 ssRecordList, out byte[] outParamOut) {
bool xlsSetting = RuntimePlatformSettings.Misc.GenerateLegacyExcell2003.GetValue();
OutSystems.Spreadsheet.IExcelWriter excel = new OutSystems.Spreadsheet.ExcelService().CreateWriter(useXls: xlsSetting, sanitizeFormulas: true);

//Column headers
excel.CreateRow(0);
excel.CreateCell("Id");
excel.CreateCell("Http Method");
excel.CreateCell("Body");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
        DateTime nullDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		for (int i = 1; !ssRecordList.Eof; i++) {
            excel.CreateRow(i);
            excel.CreateCell( ssRecordList.CurrentRec.ssENHttpRequest.ssId);
excel.CreateCell( ssRecordList.CurrentRec.ssENHttpRequest.ssHttpMethod);
excel.CreateCell( ssRecordList.CurrentRec.ssENHttpRequest.ssBody);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

outParamOut = excel.Save();
}


}


}
