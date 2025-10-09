using System.Diagnostics;
using ssRuntimeDestroyer;

namespace ssRuntimeDestroyer.CsRESTExpose.CsTest;

public class CsTestControllerFlows {
    private static readonly ActivitySource activitySource = new(typeof(CsTestControllerFlows).Namespace);
public class lcvHttpMethodPOST : VarsBag {
public EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest;
public long resCreateHttpRequest_outParamId = 0L;

public lcvHttpMethodPOST(EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest) {
this.inParamHttpRequest = inParamHttpRequest;
}
}
/// <summary>
/// Action <code>HttpMethodPOST</code> that represents the Service Studio action
///  <code>HttpMethodPOST</code> <p> Description: </p>
/// </summary>
public static async Task FlowTestActionHttpMethodPOST(IRequestContext requestContext,EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest,CancellationToken cancellationToken) {
lcvHttpMethodPOST localVars = new lcvHttpMethodPOST(inParamHttpRequest);
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodPOST", "090427bc-c1a9-4cde-9374-457b93c788de", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// HttpRequest
// HttpRequest.HttpMethod = POST
localVars.inParamHttpRequest.ssHttpMethod = (ENHttpMethodEntity.GetRecordByKey(ObjectKey.Parse("tyuGOGC_XEKW7ooXPd7F9w"))).ssId;
// CreateHttpRequest
localVars.resCreateHttpRequest_outParamId = await ExtendedActions.CreateHttpRequest(requestContext,(((RC_1ba5183fe935decff47a51e639a147ac)localVars.inParamHttpRequest)),cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncFlowTestActionHttpMethodPOST {



}

public class lcvHttpMethodExcelEntityGET : VarsBag {
public RL_677b1053a44870339ea33453b927fdea queryResGetSampleListEntities_outParamList = new RL_677b1053a44870339ea33453b927fdea();
public long queryResGetSampleListEntities_outParamCount = 0L;

public lcvHttpMethodExcelEntityGET() {
}
}
public class lcoHttpMethodExcelEntityGET : VarsBag {
public RL_1e7b3d2125f39aa37d81e604b3a0a4fb outParamSampleList = new RL_1e7b3d2125f39aa37d81e604b3a0a4fb();

public lcoHttpMethodExcelEntityGET() {
}
}
/// <summary>
/// Action <code>HttpMethodExcelEntityGET</code> that represents the Service Studio action
///  <code>HttpMethodExcelEntityGET</code> <p> Description: </p>
/// </summary>
public static async Task<RL_1e7b3d2125f39aa37d81e604b3a0a4fb> FlowTestActionHttpMethodExcelEntityGET(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_1e7b3d2125f39aa37d81e604b3a0a4fb outParamSampleList = default;
lcoHttpMethodExcelEntityGET result = new lcoHttpMethodExcelEntityGET();
lcvHttpMethodExcelEntityGET localVars = new lcvHttpMethodExcelEntityGET();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodExcelEntityGET", "4b210964-0e5b-4372-ab44-d88c32d944bc", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// Query datasetGetSampleListEntities
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSampleListEntities_maxRecords = 0;
int datasetGetSampleListEntities_startIndex = 0;(localVars.queryResGetSampleListEntities_outParamList,localVars.queryResGetSampleListEntities_outParamCount) = await FuncFlowTestActionHttpMethodExcelEntityGET.datasetGetSampleListEntities(requestContext,datasetGetSampleListEntities_maxRecords,datasetGetSampleListEntities_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// SampleList = GetSampleListEntities.List
result.outParamSampleList=(await RL_1e7b3d2125f39aa37d81e604b3a0a4fb.ConvertAsync(localVars.queryResGetSampleListEntities_outParamList, new RL_1e7b3d2125f39aa37d81e604b3a0a4fb(), async (RC_f58af668359cdeaaa540e4e6dadabd34 source, EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} //try

finally {
outParamSampleList = result.outParamSampleList;
}
RETURN_STATEMENT:
return outParamSampleList;
}

public static class FuncFlowTestActionHttpMethodExcelEntityGET {

// Query Function "GetSampleListEntities" 3h8WQi9WZ0COuaqRhNOH3A of Action "HttpMethodExcelEntityGET"
public static async Task<(RL_677b1053a44870339ea33453b927fdea,long)> datasetGetSampleListEntities(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("Test.HttpMethodExcelEntityGET.GetSampleListEntities", "42161fde-562f-4067-8eb9-aa9184d387dc", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /CustomServices.jkTABllX80GjdJFnjOFx5A/CustomActionFlows.ZAkhS1sOckOrRNiMMtlEvA/NodesNotShownInESpaceTree.3h8WQi9WZ0COuaqRhNOH3A, e7c634b1-9547-4f8e-807b-c9faa359b669 RuntimeDestroyer */");
selectBuilder.Append("SELECT \"ensamplelistentity\".\"id\" o0");
fromBuilder.Append(" FROM {SampleListEntity} \"ensamplelistentity\"");
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
RL_677b1053a44870339ea33453b927fdea outParamList = new RL_677b1053a44870339ea33453b927fdea();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Test.HttpMethodExcelEntityGET.GetSampleListEntities.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_677b1053a44870339ea33453b927fdea _tmp = new RL_677b1053a44870339ea33453b927fdea();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Test.HttpMethodExcelEntityGET.GetSampleListEntities.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_677b1053a44870339ea33453b927fdea)_tmp;
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



}

public class lcvHttpMethodExcelPOST : VarsBag {
public byte[] inParamHttpRequest;
public RL_677b1053a44870339ea33453b927fdea resExcelToRecordList1_outParamOut = new RL_677b1053a44870339ea33453b927fdea();
public long resCreateOrUpdateSampleListEntity_outParamId = 0L;

public lcvHttpMethodExcelPOST(byte[] inParamHttpRequest) {
this.inParamHttpRequest = inParamHttpRequest;
}
}
/// <summary>
/// Action <code>HttpMethodExcelPOST</code> that represents the Service Studio action
///  <code>HttpMethodExcelPOST</code> <p> Description: </p>
/// </summary>
public static async Task FlowTestActionHttpMethodExcelPOST(IRequestContext requestContext,byte[] inParamHttpRequest,CancellationToken cancellationToken) {
lcvHttpMethodExcelPOST localVars = new lcvHttpMethodExcelPOST(inParamHttpRequest);
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodExcelPOST", "7444d9ca-90ce-47c2-9d00-1292df14aa28", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// ExcelToRecordList ExcelToRLHttpMethodExcelPOSTExcelToRecordList1
FuncFlowTestActionHttpMethodExcelPOST.ExcelToRLHttpMethodExcelPOSTExcelToRecordList1( requestContext, localVars.inParamHttpRequest, "",  out localVars.resExcelToRecordList1_outParamOut);
// Foreach ExcelToRecordList1
localVars.resExcelToRecordList1_outParamOut.StartIteration();
try {while (!((localVars.resExcelToRecordList1_outParamOut.Eof))) {
// CreateOrUpdateSampleListEntity
localVars.resCreateOrUpdateSampleListEntity_outParamId = await ExtendedActions.CreateOrUpdateSampleListEntity(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ChangedAttributes,localVars.resExcelToRecordList1_outParamOut.CurrentRec,cancellationToken);

localVars.resExcelToRecordList1_outParamOut.Advance();
}

} finally {
localVars.resExcelToRecordList1_outParamOut.EndIteration();
}

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncFlowTestActionHttpMethodExcelPOST {


/// <summary>
/// Excel To RecordList : ExcelToRLHttpMethodExcelPOSTExcelToRecordList1 (KgISTe15AJ0u5yaW0kMZdww)  of
///  Action "HttpMethodExcelPOST"
/// </summary>
public static void ExcelToRLHttpMethodExcelPOSTExcelToRecordList1 (IRequestContext requestContext, byte[] excelContent, string tableName, out RL_677b1053a44870339ea33453b927fdea outParamOut) {

int totalColumns = 1;
if(excelContent.GetLength(0) == 0) {
    throw InvalidExcelErrorsHelper.EmptyExcelFile();
}
string userTableName = tableName; // for error msg
var reader = new OutSystems.Spreadsheet.ExcelService().CreateReader(
    excelContent, 
    tableName, 
    totalColumns,
    new string[] {
        typeof(long).Name
    },
    new string[] {
        "Id"
    },
    new string[] {
        "Id"
    },
    new string[] {
        "Id"
    },
    new string[] {
        "Id"
    });

string errorMsg;
if (!reader.DataTypesValid(out errorMsg)) {
    throw InvalidExcelErrorsHelper.InvalidFileType(errorMsg);
}

RL_677b1053a44870339ea33453b927fdea tmp = new();
tmp.Reader = reader;

outParamOut = (RL_677b1053a44870339ea33453b927fdea)tmp;

reader.Close();
}


}

public class lcvHttpMethodDELETE : VarsBag {
public long inParamHttpRequestIdentifier;
public lcvHttpMethodDELETE(long inParamHttpRequestIdentifier) {
this.inParamHttpRequestIdentifier = inParamHttpRequestIdentifier;
}
}
/// <summary>
/// Action <code>HttpMethodDELETE</code> that represents the Service Studio action
///  <code>HttpMethodDELETE</code> <p> Description: </p>
/// </summary>
public static async Task FlowTestActionHttpMethodDELETE(IRequestContext requestContext,long inParamHttpRequestIdentifier,CancellationToken cancellationToken) {
lcvHttpMethodDELETE localVars = new lcvHttpMethodDELETE(inParamHttpRequestIdentifier);
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodDELETE", "79cd9c45-4616-4039-a394-0d34de78345c", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// DeleteHttpRequest
await ExtendedActions.DeleteHttpRequest(requestContext,localVars.inParamHttpRequestIdentifier,cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncFlowTestActionHttpMethodDELETE {



}

public class lcvHttpMethodPUT : VarsBag {
public EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest;
public lcvHttpMethodPUT(EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest) {
this.inParamHttpRequest = inParamHttpRequest;
}
}
/// <summary>
/// Action <code>HttpMethodPUT</code> that represents the Service Studio action
///  <code>HttpMethodPUT</code> <p> Description: </p>
/// </summary>
public static async Task FlowTestActionHttpMethodPUT(IRequestContext requestContext,EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord inParamHttpRequest,CancellationToken cancellationToken) {
lcvHttpMethodPUT localVars = new lcvHttpMethodPUT(inParamHttpRequest);
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodPUT", "9872ce55-bf88-4fad-a15c-34cb0426e6c8", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// UpdateHttpRequest
await ExtendedActions.UpdateHttpRequest(requestContext,localVars.inParamHttpRequest.ChangedAttributes,(((RC_1ba5183fe935decff47a51e639a147ac)localVars.inParamHttpRequest)),cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncFlowTestActionHttpMethodPUT {



}

public class lcvHttpMethodGET : VarsBag {
public RL_cb90b4d276d47c120cb334b7b28342e2 queryResGetHttpRequests_outParamList = new RL_cb90b4d276d47c120cb334b7b28342e2();
public long queryResGetHttpRequests_outParamCount = 0L;

public lcvHttpMethodGET() {
}
}
public class lcoHttpMethodGET : VarsBag {
public RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 outParamHttpRequestList = new RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5();

public lcoHttpMethodGET() {
}
}
/// <summary>
/// Action <code>HttpMethodGET</code> that represents the Service Studio action
///  <code>HttpMethodGET</code> <p> Description: </p>
/// </summary>
public static async Task<RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5> FlowTestActionHttpMethodGET(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 outParamHttpRequestList = default;
lcoHttpMethodGET result = new lcoHttpMethodGET();
lcvHttpMethodGET localVars = new lcvHttpMethodGET();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodGET", "b0946f50-c3dd-4d13-b879-00982a0c15a4", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// Query datasetGetHttpRequests
cancellationToken.ThrowIfCancellationRequested();
int datasetGetHttpRequests_maxRecords = 0;
int datasetGetHttpRequests_startIndex = 0;(localVars.queryResGetHttpRequests_outParamList,localVars.queryResGetHttpRequests_outParamCount) = await FuncFlowTestActionHttpMethodGET.datasetGetHttpRequests(requestContext,datasetGetHttpRequests_maxRecords,datasetGetHttpRequests_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// HttpRequestList = GetHttpRequests.List
result.outParamHttpRequestList=(await RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5.ConvertAsync(localVars.queryResGetHttpRequests_outParamList, new RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5(), async (RC_1ba5183fe935decff47a51e639a147ac source, EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} //try

finally {
outParamHttpRequestList = result.outParamHttpRequestList;
}
RETURN_STATEMENT:
return outParamHttpRequestList;
}

public static class FuncFlowTestActionHttpMethodGET {

// Query Function "GetHttpRequests" nNTwmM3hQEmB8ReH7mlpGw of Action "HttpMethodGET"
public static async Task<(RL_cb90b4d276d47c120cb334b7b28342e2,long)> datasetGetHttpRequests(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("Test.HttpMethodGET.GetHttpRequests", "98f0d49c-e1cd-4940-81f1-1787ee69691b", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /CustomServices.jkTABllX80GjdJFnjOFx5A/CustomActionFlows.UG+UsN3DE024eQCYKgwVpA/NodesNotShownInESpaceTree.nNTwmM3hQEmB8ReH7mlpGw, e7c634b1-9547-4f8e-807b-c9faa359b669 RuntimeDestroyer */");
selectBuilder.Append("SELECT \"enhttprequest1\".\"id\" o0, \"enhttprequest1\".\"httpmethod\" o1, \"enhttprequest1\".\"body\" o2");
fromBuilder.Append(" FROM {HttpRequest} \"enhttprequest1\"");
orderByBuilder.Append(" ORDER BY \"enhttprequest1\".\"httpmethod\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Test.HttpMethodGET.GetHttpRequests.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Test.HttpMethodGET.GetHttpRequests.List", cancellationToken: cancellationToken);
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



}

public class lcvHttpMethodExcelStaticGET : VarsBag {
public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public RL_3f06d244b0b5226052eebe4a6c0636e0 queryResGetSampleLists_outParamList = new RL_3f06d244b0b5226052eebe4a6c0636e0();
public long queryResGetSampleLists_outParamCount = 0L;

public lcvHttpMethodExcelStaticGET() {
}
}
public class lcoHttpMethodExcelStaticGET : VarsBag {
public byte[] outParamBinaryData = new byte[] {};

public lcoHttpMethodExcelStaticGET() {
}
}
/// <summary>
/// Action <code>HttpMethodExcelStaticGET</code> that represents the Service Studio action
///  <code>HttpMethodExcelStaticGET</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> FlowTestActionHttpMethodExcelStaticGET(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamBinaryData = default;
lcoHttpMethodExcelStaticGET result = new lcoHttpMethodExcelStaticGET();
lcvHttpMethodExcelStaticGET localVars = new lcvHttpMethodExcelStaticGET();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateCustomActionActivity("REST (Expose)", "HttpMethodExcelStaticGET", "d7806848-e89c-4240-8a74-3cf919b01f5c", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669")){
// Query datasetGetSampleLists
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSampleLists_maxRecords = 0;
int datasetGetSampleLists_startIndex = 0;(localVars.queryResGetSampleLists_outParamList,localVars.queryResGetSampleLists_outParamCount) = await FuncFlowTestActionHttpMethodExcelStaticGET.datasetGetSampleLists(requestContext,datasetGetSampleLists_maxRecords,datasetGetSampleLists_startIndex,IterationMultiplicity.Single,cancellationToken);

// RecordListToExcel RLToExcelHttpMethodExcelStaticGETRecordListToExcel1
FuncFlowTestActionHttpMethodExcelStaticGET.RLToExcelHttpMethodExcelStaticGETRecordListToExcel1( requestContext, localVars.queryResGetSampleLists_outParamList, out localVars.resRecordListToExcel1_outParamOut);

// BinaryData = RecordListToExcel1
result.outParamBinaryData=localVars.resRecordListToExcel1_outParamOut;
} //close CreateActionActivity using block
} //try

finally {
outParamBinaryData = result.outParamBinaryData;
}
RETURN_STATEMENT:
return outParamBinaryData;
}

public static class FuncFlowTestActionHttpMethodExcelStaticGET {

// Query Function "GetSampleLists" Bta3xSCSF0q4qFnSvOyKrw of Action "HttpMethodExcelStaticGET"
public static async Task<(RL_3f06d244b0b5226052eebe4a6c0636e0,long)> datasetGetSampleLists(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("Test.HttpMethodExcelStaticGET.GetSampleLists", "c5b7d606-9220-4a17-b8a8-59d2bcec8aaf", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
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
selectBuilder.Append("/* /CustomServices.jkTABllX80GjdJFnjOFx5A/CustomActionFlows.SGiA15zoQEKKdDz5GbAfXA/NodesNotShownInESpaceTree.Bta3xSCSF0q4qFnSvOyKrw, e7c634b1-9547-4f8e-807b-c9faa359b669 RuntimeDestroyer */");
selectBuilder.Append("SELECT \"ensamplelistget\".\"id\" o0");
fromBuilder.Append(" FROM {SampleListGet} \"ensamplelistget\"");
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
RL_3f06d244b0b5226052eebe4a6c0636e0 outParamList = new RL_3f06d244b0b5226052eebe4a6c0636e0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Test.HttpMethodExcelStaticGET.GetSampleLists.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3f06d244b0b5226052eebe4a6c0636e0 _tmp = new RL_3f06d244b0b5226052eebe4a6c0636e0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Test.HttpMethodExcelStaticGET.GetSampleLists.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3f06d244b0b5226052eebe4a6c0636e0)_tmp;
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
/// RecordList To Excel: RLToExcelHttpMethodExcelStaticGETRecordListToExcel1 (K3uyLxCt3MU2HWPzP0Eovfg) 
///  of Action "HttpMethodExcelStaticGET"
/// </summary>
public static void RLToExcelHttpMethodExcelStaticGETRecordListToExcel1 (IRequestContext requestContext, RL_3f06d244b0b5226052eebe4a6c0636e0 ssRecordList, out byte[] outParamOut) {
bool xlsSetting = RuntimePlatformSettings.Misc.GenerateLegacyExcell2003.GetValue();
OutSystems.Spreadsheet.IExcelWriter excel = new OutSystems.Spreadsheet.ExcelService().CreateWriter(useXls: xlsSetting, sanitizeFormulas: true);

//Column headers
excel.CreateRow(0);
excel.CreateCell("Id");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
        DateTime nullDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		for (int i = 1; !ssRecordList.Eof; i++) {
            excel.CreateRow(i);
            excel.CreateCell( ssRecordList.CurrentRec.ssENSampleListGet.ssId);

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
