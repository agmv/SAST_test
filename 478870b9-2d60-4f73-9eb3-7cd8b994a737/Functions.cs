namespace ssSystem_;
public class Functions {
/// <summary>
/// Function <code>GenerateGuid</code> that represents the Service Studio function
///  <code>GenerateGuid</code> <p> Description: Generates and returns a new GUID.</p>
/// </summary>

public static async Task<string> GenerateGuid(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamGuid;
outParamGuid = await ExtendedActions.GenerateGuid(requestContext,cancellationToken);

return outParamGuid;
}

/// <summary>
/// Function <code>GetActivityDefinitionLink</code> that represents the Service Studio function
///  <code>GetActivityDefinitionLink</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c97a9c0cb896c874168b02efa3e48866> ssGetActivityDefinitionLink(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c97a9c0cb896c874168b02efa3e48866.EnsureInitialized();
RC_c97a9c0cb896c874168b02efa3e48866 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityDefinitionLink(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRuntimeType</code> that represents the Service Studio function
///  <code>GetRuntimeType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3251af6c799b185d408b7cad31be3454> ssGetRuntimeType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3251af6c799b185d408b7cad31be3454.EnsureInitialized();
RC_3251af6c799b185d408b7cad31be3454 outParamRecord;
outParamRecord = await ExtendedActions.GetRuntimeType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityOutput</code> that represents the Service Studio function
///  <code>GetActivityOutput</code> <p> Description: </p>
/// </summary>

public static async Task<RC_24e87e1f1de297ca8a691099e40c22ed> ssGetActivityOutput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_24e87e1f1de297ca8a691099e40c22ed.EnsureInitialized();
RC_24e87e1f1de297ca8a691099e40c22ed outParamRecord;
outParamRecord = await ExtendedActions.GetActivityOutput(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessOutputDefinition</code> that represents the Service Studio function
///  <code>GetProcessOutputDefinition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> ssGetProcessOutputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4.EnsureInitialized();
RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessOutputDefinition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessInstance</code> that represents the Service Studio function
///  <code>GetProcessInstance</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c2c51a49c601586c1a143904ac6893f9> ssGetProcessInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c2c51a49c601586c1a143904ac6893f9.EnsureInitialized();
RC_c2c51a49c601586c1a143904ac6893f9 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessInstance(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessInputDefinition</code> that represents the Service Studio function
///  <code>GetProcessInputDefinition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_cbc07de8251245064bd8f80b6b35c7f6> ssGetProcessInputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_cbc07de8251245064bd8f80b6b35c7f6.EnsureInitialized();
RC_cbc07de8251245064bd8f80b6b35c7f6 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessInputDefinition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessStatus</code> that represents the Service Studio function
///  <code>GetProcessStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a7be5795c4af08fa8098110e55d36aff> ssGetProcessStatus(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a7be5795c4af08fa8098110e55d36aff.EnsureInitialized();
RC_a7be5795c4af08fa8098110e55d36aff outParamRecord;
outParamRecord = await ExtendedActions.GetProcessStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityDefinition</code> that represents the Service Studio function
///  <code>GetActivityDefinition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a04f94cfd410c813b8dee156f64b6537> ssGetActivityDefinition(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a04f94cfd410c813b8dee156f64b6537.EnsureInitialized();
RC_a04f94cfd410c813b8dee156f64b6537 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityDefinition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetHumanActivityInstance</code> that represents the Service Studio function
///  <code>GetHumanActivityInstance</code> <p> Description: </p>
/// </summary>

public static async Task<RC_880f0b08a77c1575f19f408e1fddc8c6> ssGetHumanActivityInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_880f0b08a77c1575f19f408e1fddc8c6.EnsureInitialized();
RC_880f0b08a77c1575f19f408e1fddc8c6 outParamRecord;
outParamRecord = await ExtendedActions.GetHumanActivityInstance(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessDefinition</code> that represents the Service Studio function
///  <code>GetProcessDefinition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_80c865ccf1b0df95391817b0ddc45e18> ssGetProcessDefinition(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_80c865ccf1b0df95391817b0ddc45e18.EnsureInitialized();
RC_80c865ccf1b0df95391817b0ddc45e18 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessDefinition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityStatus</code> that represents the Service Studio function
///  <code>GetActivityStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> ssGetActivityStatus(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_36a7d48575a55c39ace8b7f6b0cd3ac4.EnsureInitialized();
RC_36a7d48575a55c39ace8b7f6b0cd3ac4 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityOutputDefinition</code> that represents the Service Studio function
///  <code>GetActivityOutputDefinition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> ssGetActivityOutputDefinition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8535fa70cf0bfd6fa50f69a53d3b4ae1.EnsureInitialized();
RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityOutputDefinition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessInput</code> that represents the Service Studio function
///  <code>GetProcessInput</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d43fed74d1678e954ae3786a22cd1029> ssGetProcessInput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d43fed74d1678e954ae3786a22cd1029.EnsureInitialized();
RC_d43fed74d1678e954ae3786a22cd1029 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessInput(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessOutput</code> that represents the Service Studio function
///  <code>GetProcessOutput</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d5e6f13d187b5006f9f88b20f576700b> ssGetProcessOutput(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d5e6f13d187b5006f9f88b20f576700b.EnsureInitialized();
RC_d5e6f13d187b5006f9f88b20f576700b outParamRecord;
outParamRecord = await ExtendedActions.GetProcessOutput(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUser</code> that represents the Service Studio function <code>GetUser</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_ced013358a82a813f1d9a5108f17ce79> ssGetUser(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ced013358a82a813f1d9a5108f17ce79.EnsureInitialized();
RC_ced013358a82a813f1d9a5108f17ce79 outParamRecord;
outParamRecord = await ExtendedActions.GetUser(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetTenant</code> that represents the Service Studio function <code>GetTenant</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_40d0f5c5ba630b105850cead15ae2223> ssGetTenant(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_40d0f5c5ba630b105850cead15ae2223.EnsureInitialized();
RC_40d0f5c5ba630b105850cead15ae2223 outParamRecord;
outParamRecord = await ExtendedActions.GetTenant(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityInstance</code> that represents the Service Studio function
///  <code>GetActivityInstance</code> <p> Description: </p>
/// </summary>

public static async Task<RC_faf38c2d2aeee71f293ad23cd32fa7e2> ssGetActivityInstance(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_faf38c2d2aeee71f293ad23cd32fa7e2.EnsureInitialized();
RC_faf38c2d2aeee71f293ad23cd32fa7e2 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityInstance(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityDefinitionLanguage</code> that represents the Service Studio function
///  <code>GetActivityDefinitionLanguage</code> <p> Description: </p>
/// </summary>

public static async Task<RC_eb90da5b34724818e84008409205001c> ssGetActivityDefinitionLanguage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_eb90da5b34724818e84008409205001c.EnsureInitialized();
RC_eb90da5b34724818e84008409205001c outParamRecord;
outParamRecord = await ExtendedActions.GetActivityDefinitionLanguage(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessDefinitionLanguage</code> that represents the Service Studio function
///  <code>GetProcessDefinitionLanguage</code> <p> Description: </p>
/// </summary>

public static async Task<RC_b1f889a35d23518bfa5ab890a96efb52> ssGetProcessDefinitionLanguage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_b1f889a35d23518bfa5ab890a96efb52.EnsureInitialized();
RC_b1f889a35d23518bfa5ab890a96efb52 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessDefinitionLanguage(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityKind</code> that represents the Service Studio function
///  <code>GetActivityKind</code> <p> Description: </p>
/// </summary>

public static async Task<RC_99e7afb0bae555fcf70d1cd06f23ae14> ssGetActivityKind(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_99e7afb0bae555fcf70d1cd06f23ae14.EnsureInitialized();
RC_99e7afb0bae555fcf70d1cd06f23ae14 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityKind(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityDefinitionRole</code> that represents the Service Studio function
///  <code>GetActivityDefinitionRole</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> ssGetActivityDefinitionRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae.EnsureInitialized();
RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae outParamRecord;
outParamRecord = await ExtendedActions.GetActivityDefinitionRole(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEmail</code> that represents the Service Studio function <code>GetEmail</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_c25115a84bc21f80350d8ea6536353ed> ssGetEmail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c25115a84bc21f80350d8ea6536353ed.EnsureInitialized();
RC_c25115a84bc21f80350d8ea6536353ed outParamRecord;
outParamRecord = await ExtendedActions.GetEmail(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEntityAttribute</code> that represents the Service Studio function
///  <code>GetEntityAttribute</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2efffbee03fccc31484e893e007e6c9a> ssGetEntityAttribute(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_2efffbee03fccc31484e893e007e6c9a.EnsureInitialized();
RC_2efffbee03fccc31484e893e007e6c9a outParamRecord;
outParamRecord = await ExtendedActions.GetEntityAttribute(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRole</code> that represents the Service Studio function <code>GetRole</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_13630884b629a3a59e929e1cdea42eb1> ssGetRole(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_13630884b629a3a59e929e1cdea42eb1.EnsureInitialized();
RC_13630884b629a3a59e929e1cdea42eb1 outParamRecord;
outParamRecord = await ExtendedActions.GetRole(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApplication</code> that represents the Service Studio function
///  <code>GetApplication</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a702e171772a9b89c17e2544ab6d1d29> ssGetApplication(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a702e171772a9b89c17e2544ab6d1d29.EnsureInitialized();
RC_a702e171772a9b89c17e2544ab6d1d29 outParamRecord;
outParamRecord = await ExtendedActions.GetApplication(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEntity</code> that represents the Service Studio function <code>GetEntity</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_05f199cf8f734662fa6eaa91568947ff> ssGetEntity(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_05f199cf8f734662fa6eaa91568947ff.EnsureInitialized();
RC_05f199cf8f734662fa6eaa91568947ff outParamRecord;
outParamRecord = await ExtendedActions.GetEntity(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

}
