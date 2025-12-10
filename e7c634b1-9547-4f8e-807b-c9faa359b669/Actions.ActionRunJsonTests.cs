namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>ActionRunJsonTests</code> that represents the Service Studio reference action
///  <code>RunJsonTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunJsonTests(IRequestContext requestContext,CancellationToken cancellationToken) {
await RsseSpaceRuntimeDestroyerLib.MssRunJsonTests(requestContext,cancellationToken);
return;
}

}
