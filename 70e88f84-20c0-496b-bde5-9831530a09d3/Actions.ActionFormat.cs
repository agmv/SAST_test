namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>Format</code> that represents the Service Studio action <code>Format</code> <p>
///  Description: </p>
/// </summary>
public static async Task ActionFormat(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Format", "f39f5600-5575-4702-914f-3a961bdbd6d0", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// FormatCurrency
await Actions.ActionAssertTrue(requestContext,((((((((BuiltInFunction.FormatCurrency (1.2m, "$", 1, "#", ".")=="$1#2")&&(BuiltInFunction.FormatCurrency (1.2m, "$", 3, ",", ".")=="$1,200"))&&(BuiltInFunction.FormatCurrency (1.24m, "$", 1, ",", ".")=="$1,2"))&&(BuiltInFunction.FormatCurrency (1.25m, "$", 1, ",", ".")=="$1,3"))&&(BuiltInFunction.FormatCurrency (1.251m, "$", 1, ",", ".")=="$1,3"))&&(BuiltInFunction.FormatCurrency (1.35m, "$", 1, ",", ".")=="$1,4"))&&(BuiltInFunction.FormatCurrency (12345.67m, "$", 2, ",", ".")=="$12.345,67"))&&(BuiltInFunction.FormatCurrency ((-12345.67m), "$", 2, ",", ".")=="$-12.345,67")),"BuiltIn_Format FormatCurrency",cancellationToken);

// FormatDecimal
await Actions.ActionAssertTrue(requestContext,((((((((BuiltInFunction.FormatDecimal (1.2m, 1, "#", ".")=="1#2")&&(BuiltInFunction.FormatDecimal (1.2m, 3, ",", ".")=="1,200"))&&(BuiltInFunction.FormatDecimal (1.24m, 1, ",", ".")=="1,2"))&&(BuiltInFunction.FormatDecimal (1.25m, 1, ",", ".")=="1,3"))&&(BuiltInFunction.FormatDecimal (1.251m, 1, ",", ".")=="1,3"))&&(BuiltInFunction.FormatDecimal (1.35m, 1, ",", ".")=="1,4"))&&(BuiltInFunction.FormatDecimal (12345.67m, 2, ",", ".")=="12.345,67"))&&(BuiltInFunction.FormatDecimal ((-12345.67m), 2, ",", ".")=="-12.345,67")),"BuiltIn_Format FormatDecimal",cancellationToken);

// FormatPercent
await Actions.ActionAssertTrue(requestContext,(((((((BuiltInFunction.FormatPercent (0.12m, 3, "#")=="12#000%")&&(BuiltInFunction.FormatPercent (0.124m, 0, ",")=="12%"))&&(BuiltInFunction.FormatPercent (0.125m, 0, ",")=="13%"))&&(BuiltInFunction.FormatPercent (0.1251m, 0, ",")=="13%"))&&(BuiltInFunction.FormatPercent (0.135m, 0, ",")=="14%"))&&(BuiltInFunction.FormatPercent (12345.6789m, 2, ",")=="1234567,89%"))&&(BuiltInFunction.FormatPercent ((-12345.6789m), 2, ",")=="-1234567,89%")),"BuiltIn_Format FormatPercent",cancellationToken);

// FormatPhoneNumber
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.FormatPhoneNumber ("351214153737", 3, 2, 7, "+", "-", ".")=="+351-21.4153737"),"BuiltIn_Format FormatPhoneNumber",cancellationToken);

// FormatText
await Actions.ActionAssertTrue(requestContext,(((((BuiltInFunction.FormatTextSC ("123456789", 3, 9, true, "#")=="123456789")&&(BuiltInFunction.FormatTextSC ("123456789876", 3, 9, true, "#")=="456789876"))&&(BuiltInFunction.FormatTextSC ("123456789876", 3, 9, false, "#")=="123456789"))&&(BuiltInFunction.FormatTextSC ("12345", 10, 20, true, "#")=="#####12345"))&&(BuiltInFunction.FormatTextSC ("12345", 10, 20, false, "#")=="12345#####")),"BuiltIn_Format FormatText",cancellationToken);

// FormatDateTime
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.FormatDateTime ((new DateTime (2015, 6, 9, 10, 5, 20, DateTimeKind.Utc)), "ddd, dd MMM yyyy")=="Tue, 09 Jun 2015"),"BuiltIn_Format FormatDateTime",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionFormat {



}


}
