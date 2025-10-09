using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssRuntimeDestroyer.ReferencesProxy;

namespace ssRuntimeDestroyer {
    public partial class RsseSpaceRuntimeDestroyerProducer {
        public class RuntimeDestroyerProducerServiceAPIClients : AbstractServiceApiClient {
            private static readonly RuntimeDestroyerProducerServiceAPIClients Instance = new();
            private RuntimeDestroyerProducerServiceAPIClients() : base(
                ObjectKey.Parse("24d2d33a-c3d6-4f27-b39a-cb3c0e2adda4"),
                "RuntimeDestroyerProducer",
                "ssRuntimeDestroyer.RuntimeDestroyerProducerServiceAPIClients",
                ReadOnlyDictionary<string, Func<string, Exception>>.Empty
            ) { }

            public class S4PIGetDayInput {
[JsonProperty("Index")]
public int? inParamIndex;
public S4PIGetDayInput(int? inParamIndex) {
this.inParamIndex = inParamIndex;
}

}

public class S4PIGetDayOutput {
[JsonProperty("Weekday")]
public string outParamWeekday;
public S4PIGetDayOutput(string outParamWeekday) {
this.outParamWeekday = outParamWeekday;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: GetDay
/// </summary>
public static async Task<string> GetDay(IRequestContext requestContext,int? inParamIndex,CancellationToken cancellationToken) {
string outParamWeekday = default;
outParamWeekday = "";

var serviceActionName = "GetDay";
var serviceActionKey = "c709cc5f-3106-40cc-93a7-6ddd2ee3c4c9";
var inputs = new S4PIGetDayInput(inParamIndex);
var outputs = await Instance.InvokeServiceActionAsync<S4PIGetDayInput, S4PIGetDayOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamWeekday = outputs.outParamWeekday;
await Task.Yield();

return outParamWeekday;
}

        }
    }
}
