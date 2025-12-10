namespace ssRuntimeDestroyer;

public partial class Actions {
public class lcvEntityActionInExpression : VarsBag {
/// <summary>
/// Variable <code>Employee</code> that represents the Service Studio Employee <code>Employee</code>
///  <p>Description: </p>
/// </summary>
public EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord varLcEmployee = new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();

public long resCreateOrUpdateEmployee_outParamId = 0L;

public lcvEntityActionInExpression() {
}
}
/// <summary>
/// Action <code>EntityActionInExpression</code> that represents the Service Studio action
///  <code>EntityActionInExpression</code> <p> Description: </p>
/// </summary>
public static async Task ActionEntityActionInExpression(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvEntityActionInExpression localVars = new lcvEntityActionInExpression();
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntityActionInExpression", "b45314e3-2d92-4107-a927-078f0077473c", "RuntimeDestroyer", "e7c634b1-9547-4f8e-807b-c9faa359b669") : null){
// Employee
// Employee.Id = IntegerToIdentifier
localVars.varLcEmployee.ssId = Convert.ToInt64(BuiltInFunction.IntegerToIdentifier (5));

// Employee.Name = "Dan"
localVars.varLcEmployee.ssName = "Dan";

// Employee.Age = "40"
localVars.varLcEmployee.ssAge = "40";
// CreateOrUpdateEmployee
localVars.resCreateOrUpdateEmployee_outParamId = await ExtendedActions.CreateOrUpdateEmployee(requestContext,localVars.varLcEmployee.ChangedAttributes,(((RC_3b55179c5be20c3d1041cf4a1dcf3f76)localVars.varLcEmployee)),cancellationToken);

// AssertTrue
await Actions.ActionAssertTrue(requestContext,((await Functions.ssGetEmployee(requestContext,Convert.ToInt64(BuiltInFunction.IntegerToIdentifier (5)),cancellationToken)).ssENEmployee.ssName=="Dan"),"Wrong employee name returned",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionEntityActionInExpression {



}


}
