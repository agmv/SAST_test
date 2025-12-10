using System.Diagnostics;

namespace ssRuntimeDestroyerLib;
public partial class Actions {
private static readonly ActivitySource activitySource = new(typeof(Actions).Namespace);
protected static string GetString(string key, string defaultValue) {
	return AppUtils.GetStringResource(key, defaultValue);
}
}
