namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>Text</code> that represents the Service Studio action <code>Text</code> <p>
///  Description: </p>
/// </summary>
public static async Task ActionText(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Text", "11b4a81f-692b-4383-a393-abca6b916e41", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// Chr
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Chr (88)=="X"),"BuiltIn_Text Chr",cancellationToken);

// EncodeHtml
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.EncodeHtml ("<>")=="&lt;&gt;")&&(BuiltInFunction.EncodeHtml ("another ' test")=="another &#39; test"))&&(BuiltInFunction.EncodeHtml ((("Hello"+"\r\n")+"World!"))=="Hello<br/>World!")),"BuiltIn_Text EncodeHtml",cancellationToken);

// EncodeJavaScript
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.EncodeJavascript ("another ' test")=="another \\x27 test")&&(BuiltInFunction.EncodeJavascript ("<>")=="\\x3c\\x3e")),"BuiltIn_Text EncodeHtml",cancellationToken);

// EncodeSql
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.EncodeSql ("another ' test")=="another '' test"),"BuiltIn_Text EncodeSql",cancellationToken);

// EncodeUrl
await Actions.ActionAssertTrue(requestContext,(((((BuiltInFunction.EncodeUrl (" test")=="+test")&&(BuiltInFunction.EncodeUrl ("another ' test")=="another+%27+test"))&&(BuiltInFunction.EncodeUrl ("<>")=="%3c%3e"))&&(BuiltInFunction.EncodeUrl ("1+2")=="1%2b2"))&&(BuiltInFunction.EncodeUrl ("Company A&A")=="Company+A%26A")),"BuiltIn_Text EncodeUrl",cancellationToken);

// Index
await Actions.ActionAssertTrue(requestContext,((((((((((((((BuiltInFunction.IndexSC ("First string", "F", 0, false, false)==0)&&(BuiltInFunction.IndexSC ("First string", "st", 0, false, false)==3))&&(BuiltInFunction.IndexSC ("First string", "xx", 0, false, false)==(-1)))&&(BuiltInFunction.IndexSC ("First string", "F", 5, false, false)==(-1)))&&(BuiltInFunction.IndexSC ("First string", "st", 5, false, false)==6))&&(BuiltInFunction.IndexSC ("First string", "xx", 5, false, false)==(-1)))&&(BuiltInFunction.IndexSC ("First string", "F", 0, true, false)==0))&&(BuiltInFunction.IndexSC ("First string", "st", 0, true, false)==6))&&(BuiltInFunction.IndexSC ("First string", "xx", 0, true, false)==(-1)))&&(BuiltInFunction.IndexSC ("First string", "f", 0, false, false)==(-1)))&&(BuiltInFunction.IndexSC ("First string", "f", 0, false, true)==0))&&(BuiltInFunction.IndexSC ("", "xx", 0, false, false)==(-1)))&&(BuiltInFunction.IndexSC ("First string", "", 0, false, false)==(-1)))&&(BuiltInFunction.IndexSC ("", "", 0, false, false)==(-1))),"BuiltIn_Text Index",cancellationToken);

// Length
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.LengthSC ("First string")==12)&&(BuiltInFunction.LengthSC ("")==0)),"BuiltIn_Text Length",cancellationToken);

// Replace
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.Replace ("First string", "xx", "")=="First string")&&(BuiltInFunction.Replace ("First string", "First", "Second")=="Second string"))&&(BuiltInFunction.Replace ("First string", "First", "")==" string")),"BuiltIn_Text Replace",cancellationToken);

// Substr
await Actions.ActionAssertTrue(requestContext,(((((BuiltInFunction.SubstrSC ("First string", 2, 4)=="rst ")&&(BuiltInFunction.SubstrSC ("First string", 0, 100)=="First string"))&&(BuiltInFunction.SubstrSC ("First string", 11, 3)=="g"))&&(BuiltInFunction.SubstrSC ("First string", BuiltInFunction.LengthSC ("First string"), 0)==""))&&(BuiltInFunction.SubstrSC ("First string", 2, 0)=="")),"BuiltIn_Text Substr",cancellationToken);

// ToLower
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.ToLower ("First string")=="first string"),"BuiltIn_Text ToLower",cancellationToken);

// ToUpper
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.ToUpper ("First string")=="FIRST STRING"),"BuiltIn_Text ToUpper",cancellationToken);

// Trim
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.Trim (" First string ")=="First string")&&(BuiltInFunction.Trim ("First string ")=="First string")),"BuiltIn_Text Trim",cancellationToken);

// TrimEnd
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.TrimEnd (" First string ")==" First string")&&(BuiltInFunction.TrimEnd ("First string ")=="First string")),"BuiltIn_Text TrimEnd",cancellationToken);

// TrimStart
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.TrimStart (" First string ")=="First string ")&&(BuiltInFunction.TrimStart ("First string ")=="First string ")),"BuiltIn_Text TrimStart",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionText {



}


}
