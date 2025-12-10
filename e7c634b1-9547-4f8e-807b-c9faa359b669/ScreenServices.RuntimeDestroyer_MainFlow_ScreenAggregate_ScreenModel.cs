using System.Diagnostics;

using ssRuntimeDestroyer;


namespace ssRuntimeDestroyer.ScreenServices;

public class RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel).Namespace);

    public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_3be1495f5fc898e41acd45a19b4ddd3b> ScreenDataSetGetEmployees;


    public RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel() {
}



    public RuntimeDestroyer_MainFlow_ScreenAggregate_ScreenModel(string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_3be1495f5fc898e41acd45a19b4ddd3b> ScreenDataSetGetEmployees) {
Init(new string[] {"TableSort", "StartIndex", "MaxRecords", "GetEmployees"}, new string[] {"varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetGetEmployees"});
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetEmployees = ScreenDataSetGetEmployees;
}



    
// Query Function "GetEmployees" T_ishpAzAUuXzHtURwEpWg of Action "ScreenAggregate"
public static async Task<(RL_3be1495f5fc898e41acd45a19b4ddd3b,long)> datasetGetEmployees(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ScreenAggregate","MainFlow.ScreenAggregate.GetEmployees");
// Query Iterations: Multiple
// Refresh Query ZzWImn_TGU6tpgu4c1_e4w Iterations: Multiple
// Refresh Query 6nKLx+7xPUmnB3NxMaMN+A Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Ru9hEwmDCEGyselb1EYX4g/NodesShownInESpaceTree.mLhijT2ca0aMo34daSjjiQ/ScreenDataSets.T_ishpAzAUuXzHtURwEpWg, e7c634b1-9547-4f8e-807b-c9faa359b669 RuntimeDestroyer */");
selectBuilder.Append("SELECT NULL o0, \"enemployee\".\"name\" o1, \"enemployee\".\"age\" o2");
fromBuilder.Append(" FROM {Employee} \"enemployee\"");
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Employee" }, new string[] { "ENEmployee" }, new System.Collections.Generic.Dictionary<string, string>[] { ENEmployeeEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_3be1495f5fc898e41acd45a19b4ddd3b outParamList = new RL_3be1495f5fc898e41acd45a19b4ddd3b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query MainFlow.ScreenAggregate.GetEmployees.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3be1495f5fc898e41acd45a19b4ddd3b _tmp = new RL_3be1495f5fc898e41acd45a19b4ddd3b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query MainFlow.ScreenAggregate.GetEmployees.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3be1495f5fc898e41acd45a19b4ddd3b)_tmp;
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
