// Proxy for reference eSpace with name RuntimeDestroyerProducer and key jxRVbj6BNUG_ayqMZIRu3g
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssRuntimeDestroyer;
using ssRuntimeDestroyer.ReferencesProxy;
namespace ssRuntimeDestroyer.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssRuntimeDestroyer {
/// <summary>
/// Class: RsseSpaceRuntimeDestroyerProducer
/// </summary>
public partial class RsseSpaceRuntimeDestroyerProducer {
private static readonly ActivitySource source = new("ssRuntimeDestroyer.RsseSpaceRuntimeDestroyerProducer");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("24d2d33a-c3d6-4f27-b39a-cb3c0e2adda4");
       }
   }
public static async Task<string> GetDay(IRequestContext requestContext,int inParamIndex,CancellationToken cancellationToken) {
string outParamWeekday = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("24d2d33a-c3d6-4f27-b39a-cb3c0e2adda4");
outParamWeekday = await RuntimeDestroyerProducerServiceAPIClients.GetDay(requestContext,inParamIndex,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamWeekday;
}


public sealed partial class ENWeekdayEntity {
public static string ViewName(long? tenant, string locale) {
return "\"runtime\".\"weekd_2jhmh9kn2941g92kugwqdvh4\"";
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("24d2d33a-c3d6-4f27-b39a-cb3c0e2adda4");
} // ENWeekdayEntity
public interface IRC_37793b7d6834fb46c2d504f9d8c91d4aTypeFactory {
IRecord CreateRsseSpaceRuntimeDestroyerProducerRC_37793b7d6834fb46c2d504f9d8c91d4a();
}
public interface IEN_3b62c1d17ede66b1bf553024dad1119eEntityRecordTypeFactory {
IRecord CreateRsseSpaceRuntimeDestroyerProducerEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord();
}

public class Factory {
public static IEN_3b62c1d17ede66b1bf553024dad1119eEntityRecordTypeFactory FactoryEN_3b62c1d17ede66b1bf553024dad1119eEntityRecordSingleton;
public static IRC_37793b7d6834fb46c2d504f9d8c91d4aTypeFactory FactoryRC_37793b7d6834fb46c2d504f9d8c91d4aSingleton;
}
public class DefaultValues {
}
}
}
