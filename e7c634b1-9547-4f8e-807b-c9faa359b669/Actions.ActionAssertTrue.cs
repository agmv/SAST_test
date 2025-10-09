namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>ActionAssertTrue</code> that represents the Service Studio reference action
///  <code>AssertTrue</code> <p> Description: </p>
/// </summary>
public static async Task ActionAssertTrue(IRequestContext requestContext,bool inParamResult,string inParamMessage,CancellationToken cancellationToken) {
await RsseSpaceRuntimeDestroyerLib.MssAssertTrue(requestContext,inParamResult,inParamMessage,cancellationToken);
return;
}

}
