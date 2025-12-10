namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetMethodFunction</code> that represents the Service Studio reference action
///  <code>GetMethodFunction</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetMethodFunction(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
string outParamLabel = default;
outParamLabel = await RsseSpaceRuntimeDestroyerLib.MssGetMethodFunction(requestContext,inParamId,cancellationToken);
return outParamLabel;
}

}
