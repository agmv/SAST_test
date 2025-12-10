// Proxy for reference eSpace with name RuntimeDestroyerLib and key FCVWNHKzS0a+geuD+zlC3w
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssRuntimeDestroyer;
using ssRuntimeDestroyer.ReferencesProxy;
namespace ssRuntimeDestroyer.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssRuntimeDestroyer {
/// <summary>
/// Class: RsseSpaceRuntimeDestroyerLib
/// </summary>
public partial class RsseSpaceRuntimeDestroyerLib {
private static readonly ActivitySource source = new("ssRuntimeDestroyer.RsseSpaceRuntimeDestroyerLib");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("70e88f84-20c0-496b-bde5-9831530a09d3");
       }
   }
public static async Task MssRunBuiltinTests(IRequestContext requestContext,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("70e88f84-20c0-496b-bde5-9831530a09d3");
await ssRuntimeDestroyerLib.Actions.ActionRunBuiltinTests(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<string> MssGetMethodFunction(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
string outParamLabel = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("70e88f84-20c0-496b-bde5-9831530a09d3");
outParamLabel = await ssRuntimeDestroyerLib.Actions.ActionGetMethodFunction(requestContext,inParamId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamLabel;
}


public static async Task MssRunActionTests(IRequestContext requestContext,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("70e88f84-20c0-496b-bde5-9831530a09d3");
await ssRuntimeDestroyerLib.Actions.ActionRunActionTests(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task MssAssertTrue(IRequestContext requestContext,bool inParamResult,string inParamMessage,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("70e88f84-20c0-496b-bde5-9831530a09d3");
await ssRuntimeDestroyerLib.Actions.ActionAssertTrue(requestContext,inParamResult,inParamMessage,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task MssRunJsonTests(IRequestContext requestContext,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("70e88f84-20c0-496b-bde5-9831530a09d3");
await ssRuntimeDestroyerLib.Actions.ActionRunJsonTests(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}



public class Factory {
}
public class DefaultValues {
}
}
}
