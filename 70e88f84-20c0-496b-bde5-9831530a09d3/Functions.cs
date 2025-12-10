namespace ssRuntimeDestroyerLib;
public class Functions {
/// <summary>
/// Function <code>FibonacciRecursive</code> that represents the Service Studio function
///  <code>FibonacciRecursive</code> <p> Description: </p>
/// </summary>

public static async Task<long> ActionFibonacciRecursive(IRequestContext requestContext,int inParamIn,CancellationToken cancellationToken) {
long outParamResult;
outParamResult = await Actions.ActionFibonacciRecursive(requestContext,inParamIn,cancellationToken);

return outParamResult;
}

/// <summary>
/// Function <code>GetMethodFunction</code> that represents the Service Studio function
///  <code>GetMethodFunction</code> <p> Description: </p>
/// </summary>

public static async Task<string> ActionGetMethodFunction(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
string outParamLabel;
outParamLabel = await Actions.ActionGetMethodFunction(requestContext,inParamId,cancellationToken);

return outParamLabel;
}

/// <summary>
/// Function <code>GetHttpMethod</code> that represents the Service Studio function
///  <code>GetHttpMethod</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f7a56746c7bb090f072113e146ed4d38> ssGetHttpMethod(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_f7a56746c7bb090f072113e146ed4d38.EnsureInitialized();
RC_f7a56746c7bb090f072113e146ed4d38 outParamRecord;
outParamRecord = await ExtendedActions.GetHttpMethod(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

}
