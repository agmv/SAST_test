using System.Diagnostics;
using Pair = OutSystems.RuntimeCommon.Pair;

namespace ssSystem_;
public partial class ExtendedActions {
private static readonly ActivitySource activitySource = new(typeof(ExtendedActions).Namespace);
/// <summary>
/// Extended Action: HumanActivityRelease
/// </summary>

public static async Task HumanActivityRelease(IRequestContext requestContext,long inParamActivityInstanceId,CancellationToken cancellationToken) {
await GenericExtendedActions.HumanActivityReleaseAsync(requestContext, inParamActivityInstanceId, cancellationToken);
return;
}

/// <summary>
/// Extended Action: AbortTransaction
/// </summary>

public static async Task AbortTransaction(IRequestContext requestContext,CancellationToken cancellationToken) {
#pragma warning disable 612,618 
DatabaseAccess.RollbackAllTransactions();
#pragma warning restore 612,618 
return;
}

/// <summary>
/// Extended Action: Logout
/// </summary>

public static async Task Logout(IRequestContext requestContext,CancellationToken cancellationToken) {
return;
}

/// <summary>
/// Extended Action: HumanActivityOpen
/// </summary>

public static async Task HumanActivityOpen(IRequestContext requestContext,long inParamActivityInstanceId,CancellationToken cancellationToken) {
await GenericExtendedActions.HumanActivityOpenAsync(requestContext, inParamActivityInstanceId, cancellationToken);
return;
}

/// <summary>
/// Extended Action: ListAll
/// </summary>

public static async Task<bool> ListAll<T>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<bool>> inParamCondition,CancellationToken cancellationToken) {
bool outParamResult = default;
outParamResult = false;

outParamResult = await inParamList.AllAsync(inParamCondition, cancellationToken);return outParamResult;
}

/// <summary>
/// Extended Action: LogMessage
/// </summary>

public static async Task LogMessage(IRequestContext requestContext,string inParamMessage,string inParamCategory,CancellationToken cancellationToken) {
GenericExtendedActions.LogMessage(requestContext, inParamMessage, inParamCategory);
return;
}

/// <summary>
/// Extended Action: StartUpdateEmail
/// </summary>

public static async Task<ST_f4b6c6eeb122dfa3165aeece838fd077Structure> StartUpdateEmail(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
ST_f4b6c6eeb122dfa3165aeece838fd077Structure outParamStartUpdateEmailResult = default;
outParamStartUpdateEmailResult = new ST_f4b6c6eeb122dfa3165aeece838fd077Structure();

(outParamStartUpdateEmailResult.ssSuccess, outParamStartUpdateEmailResult.ssVerificationCode, outParamStartUpdateEmailResult.ssStartUpdateEmailFailureReason.ssInvalidEmail) = await GenericExtendedActions.StartUpdateEmailAsync(requestContext, inParamEmail, cancellationToken);
return outParamStartUpdateEmailResult;
}

/// <summary>
/// Extended Action: ListIndexOf
/// </summary>

public static async Task<int> ListIndexOf<T>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<bool>> inParamCondition,CancellationToken cancellationToken) {
int outParamPosition = default;
outParamPosition = 0;

outParamPosition = await inParamList.IndexOfAsync(inParamCondition, cancellationToken);return outParamPosition;
}

/// <summary>
/// Extended Action: ProcessTerminate
/// </summary>

public static async Task ProcessTerminate(IRequestContext requestContext,long inParamProcessInstanceId,CancellationToken cancellationToken) {
await GenericExtendedActions.ProcessTerminateAsync(requestContext, inParamProcessInstanceId, cancellationToken);
return;
}

/// <summary>
/// Extended Action: ListSort
/// </summary>

public static async Task ListSort<T,T2>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<T2>> inParamBy,bool inParamAscending,CancellationToken cancellationToken) {
await inParamList.SortAsync(inParamBy, inParamAscending, cancellationToken);return;
}

/// <summary>
/// Extended Action: StartResetPassword
/// </summary>

public static async Task<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> StartResetPassword(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
ST_7df0b593cd1052614bf3d2f66d1ab2efStructure outParamStartResetPasswordResult = default;
outParamStartResetPasswordResult = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();

(outParamStartResetPasswordResult.ssSuccess, outParamStartResetPasswordResult.ssVerificationCode) = await GenericExtendedActions.StartResetPasswordAsync(requestContext, inParamEmail, cancellationToken);
return outParamStartResetPasswordResult;
}

/// <summary>
/// Extended Action: GenerateGuid
/// </summary>

public static async Task<string> GenerateGuid(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamGuid = default;
outParamGuid = "";

outParamGuid = GenericExtendedActions.GenerateGuid(requestContext);
return outParamGuid;
}

/// <summary>
/// Extended Action: ListRemove
/// </summary>

public static async Task ListRemove<T>(IRequestContext requestContext,OSList<T> inParamList,int inParamPosition,CancellationToken cancellationToken) {
inParamList.Remove(inParamPosition);return;
}


/// <summary>
/// Extended Action: ListInsert
/// </summary>

public static async Task ListInsert<T>(IRequestContext requestContext,OSList<T> inParamList,T inParamElement,int inParamPosition,CancellationToken cancellationToken) {
inParamList.Insert(inParamElement, inParamPosition);return;
}

/// <summary>
/// Extended Action: SetCurrentLocale
/// </summary>

public static async Task SetCurrentLocale(IRequestContext requestContext,string inParamLocale,CancellationToken cancellationToken) {
GenericExtendedActions.SetCurrentLocale( requestContext, inParamLocale);
return;
}

/// <summary>
/// Extended Action: CommitTransaction
/// </summary>

public static async Task CommitTransaction(IRequestContext requestContext,CancellationToken cancellationToken) {
#pragma warning disable 612,618 
DatabaseAccess.CommitAllTransactions();
#pragma warning restore 612,618 
return;
}


/// <summary>
/// Extended Action: ListAppend
/// </summary>

public static async Task ListAppend<T>(IRequestContext requestContext,OSList<T> inParamList,T inParamElement,CancellationToken cancellationToken) {
inParamList.Append(inParamElement);return;
}

/// <summary>
/// Extended Action: ListAny
/// </summary>

public static async Task<bool> ListAny<T>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<bool>> inParamCondition,CancellationToken cancellationToken) {
bool outParamResult = default;
outParamResult = false;

outParamResult = await inParamList.AnyAsync(inParamCondition, cancellationToken);return outParamResult;
}

/// <summary>
/// Extended Action: ApplicationInvalidateCache
/// </summary>

public static async Task ApplicationInvalidateCache(IRequestContext requestContext,CancellationToken cancellationToken) {
GenericExtendedActions.ApplicationInvalidate(requestContext);
return;
}

/// <summary>
/// Extended Action: StartUserRegistration
/// </summary>

public static async Task<ST_b465768a49759f20ddd40d498521c3aeStructure> StartUserRegistration(IRequestContext requestContext,ST_401f0448f59979847b24ebdd2db9e1ebStructure inParamUser,CancellationToken cancellationToken) {
ST_b465768a49759f20ddd40d498521c3aeStructure outParamUserRegistrationResult = default;
outParamUserRegistrationResult = new ST_b465768a49759f20ddd40d498521c3aeStructure();

Guid userIdGuid;
(outParamUserRegistrationResult.ssSuccess, userIdGuid, outParamUserRegistrationResult.ssVerificationCode, outParamUserRegistrationResult.ssStartUserRegistrationFailureReason.ssInvalidEmail, outParamUserRegistrationResult.ssStartUserRegistrationFailureReason.ssInvalidName, outParamUserRegistrationResult.ssStartUserRegistrationFailureReason.ssUserAlreadyRegistered) = await GenericExtendedActions.StartUserRegistrationAsync(requestContext, inParamUser.ssName, inParamUser.ssEmail, cancellationToken);
outParamUserRegistrationResult.ssUserId = userIdGuid.ToString();
return outParamUserRegistrationResult;
}

/// <summary>
/// Extended Action: ListClear
/// </summary>

public static async Task ListClear<T>(IRequestContext requestContext,OSList<T> inParamList,CancellationToken cancellationToken) {
inParamList.Clear();return;
}

/// <summary>
/// Extended Action: GetDefaultDomain
/// </summary>

public static async Task<string> GetDefaultDomain(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamDefaultDomain = default;
outParamDefaultDomain = "";

outParamDefaultDomain = GenericExtendedActions.GetDefaultDomain(requestContext);
return outParamDefaultDomain;
}

/// <summary>
/// Extended Action: ListAppendAll
/// </summary>

public static async Task ListAppendAll<T>(IRequestContext requestContext,OSList<T> inParamList,OSList<T> inParamSourceList,CancellationToken cancellationToken) {
inParamList.AppendAll(inParamSourceList);return;
}

/// <summary>
/// Extended Action: HumanActivityAssign
/// </summary>

public static async Task HumanActivityAssign(IRequestContext requestContext,long inParamActivityInstanceId,string inParamUserId,CancellationToken cancellationToken) {
await GenericExtendedActions.HumanActivityAssignAsync(requestContext, inParamActivityInstanceId, Guid.Parse(inParamUserId), cancellationToken);
return;
}

/// <summary>
/// Extended Action: Sleep
/// </summary>

public static async Task Sleep(IRequestContext requestContext,int inParamTime,CancellationToken cancellationToken) {
await GenericExtendedActions.SleepAsync(requestContext, inParamTime, cancellationToken);
return;
}


/// <summary>
/// Extended Action: UpdateUserProfile
/// </summary>

public static async Task<ST_c57cc6bedbdc9e62046393fa735672cfStructure> UpdateUserProfile(IRequestContext requestContext,ST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo,CancellationToken cancellationToken) {
ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult = default;
outParamUpdateUserResult = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();

outParamUpdateUserResult.ssSuccess = GenericExtendedActions.UpdateUserProfile(requestContext, inParamUserUpdateInfo.ssName, inParamUserUpdateInfo.ssPhotoURL, out outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidCredentials, out outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidName, out outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidPhotoURL);
return outParamUpdateUserResult;
}

}
