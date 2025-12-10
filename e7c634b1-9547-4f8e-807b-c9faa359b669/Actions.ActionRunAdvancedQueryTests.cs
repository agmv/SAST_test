namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvRunAdvancedQueryTests : VarsBag {
/// <summary>
/// Variable <code>Employee</code> that represents the Service Studio Employee <code>Employee</code>
///  <p>Description: </p>
/// </summary>
public EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord varLcEmployee = new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();

public RL_fef6094efec9c05411063d34335d4327 queryResSelect_outParamList = new RL_fef6094efec9c05411063d34335d4327();
public long queryResSelect_outParamCount = 0L;

public long resCreateOrUpdateEmployee_outParamId = 0L;

public lcvRunAdvancedQueryTests() {
}
}
/// <summary>
/// Action <code>RunAdvancedQueryTests</code> that represents the Service Studio action
///  <code>RunAdvancedQueryTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunAdvancedQueryTests(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvRunAdvancedQueryTests localVars = new lcvRunAdvancedQueryTests();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RunAdvancedQueryTests", "85647887-4f94-4044-9cdf-8c97d39a864d", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// Employee
// Employee.Id = 4
localVars.varLcEmployee.ssId = Convert.ToInt64(4);

// Employee.Name = "Ethan"
localVars.varLcEmployee.ssName = "Ethan";

// Employee.Age = "45"
localVars.varLcEmployee.ssAge = "45";
// CreateOrUpdateEmployee
localVars.resCreateOrUpdateEmployee_outParamId = await ExtendedActions.CreateOrUpdateEmployee(requestContext,localVars.varLcEmployee.ChangedAttributes,(((RC_3b55179c5be20c3d1041cf4a1dcf3f76)localVars.varLcEmployee)),cancellationToken);

// Query QuerySelect
cancellationToken.ThrowIfCancellationRequested();
int QuerySelect_maxRecords = 0;
int QuerySelect_startIndex = 0;(localVars.queryResSelect_outParamList,localVars.queryResSelect_outParamCount) = await FuncActionRunAdvancedQueryTests.QuerySelect(requestContext,QuerySelect_maxRecords,QuerySelect_startIndex,IterationMultiplicity.Never,cancellationToken);

// AssertTrue
await Actions.ActionAssertTrue(requestContext,(localVars.queryResSelect_outParamList.CurrentRec.ssSTEmployeeName.ssName=="Ethan"),"Wrong employee name returned from sql query",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionRunAdvancedQueryTests {

// Query Function "Select" CWTHZQ+L_0ePlIqjwlDiGA of Action "RunAdvancedQueryTests"
public static async Task<(RL_fef6094efec9c05411063d34335d4327,long)> QuerySelect(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateSqlQueryActivity("RunAdvancedQueryTests.Select", "65c76409-8b0f-47ff-8f94-8aa3c250e218", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityEmployee = AppUtils.Instance.RuntimeEntityReplace("Employee", requestContext);
string sql = "";
string advSql = "SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEmployee,".\"name\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEmployee,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEmployee,".\"age\"") + "='45'";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_fef6094efec9c05411063d34335d4327 outParamList = new RL_fef6094efec9c05411063d34335d4327();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RunAdvancedQueryTests.Select.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fef6094efec9c05411063d34335d4327 _tmp = new RL_fef6094efec9c05411063d34335d4327();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RunAdvancedQueryTests.Select.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fef6094efec9c05411063d34335d4327)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("Select in RunAdvancedQueryTests in RuntimeDestroyer (SELECT {Employee}.[Name] FROM {Employee} WHERE {Employee}.[Age]='45'): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("Select in RunAdvancedQueryTests in RuntimeDestroyer (SELECT {Employee}.[Name] FROM {Employee} WHERE {Employee}.[Age]='45'): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("Select in RunAdvancedQueryTests in RuntimeDestroyer (SELECT {Employee}.[Name] FROM {Employee} WHERE {Employee}.[Age]='45'): " + aqExcep.Message));
}
}
}



}


}
