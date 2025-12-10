namespace ssRuntimeDestroyer;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIGetDay</code> that represents a client request call <code>GetDay</code>
///  <p> Description: </p>
/// </summary>
public static async Task<string> ServiceAPIGetDay(IRequestContext requestContext,int inParamIndex,CancellationToken cancellationToken) {
string outParamWeekday = default;
outParamWeekday = await RsseSpaceRuntimeDestroyerProducer.GetDay(requestContext,inParamIndex,cancellationToken);
return outParamWeekday;
}

}
