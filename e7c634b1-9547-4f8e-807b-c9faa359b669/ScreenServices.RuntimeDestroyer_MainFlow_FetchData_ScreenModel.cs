using System.Diagnostics;

using ssRuntimeDestroyer;


namespace ssRuntimeDestroyer.ScreenServices;

public class RuntimeDestroyer_MainFlow_FetchData_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(RuntimeDestroyer_MainFlow_FetchData_ScreenModel).Namespace);

    public RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model varLcGetWeekday;


    public RuntimeDestroyer_MainFlow_FetchData_ScreenModel() {
}



    public RuntimeDestroyer_MainFlow_FetchData_ScreenModel(RuntimeDestroyer_MainFlow_FetchData_DataActionGetWeekday_Model varLcGetWeekday) {
Init(new string[] {"GetWeekday"}, new string[] {"varLcGetWeekday"});
this.varLcGetWeekday = varLcGetWeekday;
}



    

    public class lcvGetWeekday : VarsBag {
public RL_ae79e5863abde88cf07babd0361db7a4 queryResGetWeekdays_outParamList = new RL_ae79e5863abde88cf07babd0361db7a4();
public long queryResGetWeekdays_outParamCount = 0L;

public lcvGetWeekday() {
}
}
public class lcoGetWeekday : VarsBag {
public string outParamOut1 = "";

public lcoGetWeekday() {
}
}
/// <summary>
/// Action <code>GetWeekday</code> that represents the Service Studio action <code>GetWeekday</code>
///  <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetWeekday(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamOut1 = default;
lcoGetWeekday result = new lcoGetWeekday();
lcvGetWeekday localVars = new lcvGetWeekday();
try {
cancellationToken.ThrowIfCancellationRequested();
using (activitySource.CreateScreenDataActionActivity("FetchData", "GetWeekday")){
// Query datasetGetWeekdays
cancellationToken.ThrowIfCancellationRequested();
int datasetGetWeekdays_maxRecords = 0;
int datasetGetWeekdays_startIndex = 0;(localVars.queryResGetWeekdays_outParamList,localVars.queryResGetWeekdays_outParamCount) = await FuncDataActionGetWeekday.datasetGetWeekdays(requestContext,datasetGetWeekdays_maxRecords,datasetGetWeekdays_startIndex,IterationMultiplicity.Never,cancellationToken);

// Set Out1
// Out1 = GetWeekdays.List.Current.Weekday.Label
result.outParamOut1=localVars.queryResGetWeekdays_outParamList.CurrentRec.ssENWeekday.ssLabel;
} //close CreateActionActivity using block
} //try

finally {
outParamOut1 = result.outParamOut1;
}
RETURN_STATEMENT:
return outParamOut1;
}


    public static class FuncDataActionGetWeekday {

// Query Function "GetWeekdays" zHZ+wa+a3EieSOz8nPS4NA of Action "GetWeekday"
public static async Task<(RL_ae79e5863abde88cf07babd0361db7a4,long)> datasetGetWeekdays(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("MainFlow.FetchData.GetWeekday.GetWeekdays", "c17e76cc-9aaf-48dc-9e48-ecfc9cf4b834", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
// Query Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Ru9hEwmDCEGyselb1EYX4g/NodesShownInESpaceTree.LV1c1H2hfUSmsryjDqthsQ/DataActions.bM2CVFOgRUqzMghZPQsYQg/NodesNotShownInESpaceTree.zHZ+wa+a3EieSOz8nPS4NA, e7c634b1-9547-4f8e-807b-c9faa359b669 RuntimeDestroyer */");
selectBuilder.Append("SELECT NULL o0, \"enweekday\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Weekday} \"enweekday\"");
whereBuilder.Append(" WHERE (\"enweekday\".\"id\" = 2)");
orderByBuilder.Append(" ORDER BY \"enweekday\".\"order\" ASC ");
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
RL_ae79e5863abde88cf07babd0361db7a4 outParamList = new RL_ae79e5863abde88cf07babd0361db7a4();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query MainFlow.FetchData.GetWeekday.GetWeekdays.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae79e5863abde88cf07babd0361db7a4 _tmp = new RL_ae79e5863abde88cf07babd0361db7a4();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query MainFlow.FetchData.GetWeekday.GetWeekdays.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ae79e5863abde88cf07babd0361db7a4)_tmp;
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


}
