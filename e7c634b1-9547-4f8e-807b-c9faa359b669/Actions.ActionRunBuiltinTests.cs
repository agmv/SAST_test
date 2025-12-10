namespace ssRuntimeDestroyer;

public partial class Actions {
/// <summary>
/// Action <code>ActionRunBuiltinTests</code> that represents the Service Studio reference action
///  <code>RunBuiltinTests</code> <p> Description: </p>
/// </summary>
public static async Task ActionRunBuiltinTests(IRequestContext requestContext,CancellationToken cancellationToken) {
await RsseSpaceRuntimeDestroyerLib.MssRunBuiltinTests(requestContext,cancellationToken);
return;
}

}
