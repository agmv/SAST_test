namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>ActionRunActionTests</code> that represents the Service Studio reference action
///  <code>RunActionTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunActionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
await RsseSpaceRuntimeDestroyerLib.MssRunActionTests(requestContext,cancellationToken);
return;
}

}
