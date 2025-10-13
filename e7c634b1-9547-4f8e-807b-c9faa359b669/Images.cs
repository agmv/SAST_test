namespace ssRuntimeDestroyer {
public static class Images {
private static string GetString(string key, string defaultValue) {
	return AppUtils.GetStringResource(key, defaultValue);
}
public const int Capture_Height = 740;
public const int Capture_Width = 554;
public static string Capture_Source() { return "img/RuntimeDestroyer.Capture.PNG"; }
}
}
