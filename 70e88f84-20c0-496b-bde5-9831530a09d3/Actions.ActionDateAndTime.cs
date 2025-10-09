namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>DateAndTime</code> that represents the Service Studio action <code>DateAndTime</code>
///  <p> Description: </p>
/// </summary>
public static async Task ActionDateAndTime(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DateAndTime", "93cb3de1-c931-4707-953b-4311c3999a71", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// AddDays
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.AddDays ((new DateTime (2015, 9, 14, 0, 0, 0, DateTimeKind.Utc)), 15)==(new DateTime (2015, 9, 29, 0, 0, 0, DateTimeKind.Utc)))&&(BuiltInFunction.AddDays ((new DateTime (2015, 12, 31, 0, 0, 0, DateTimeKind.Utc)), 1)==(new DateTime (2016, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.AddDays ((new DateTime (2015, 2, 28, 0, 0, 0, DateTimeKind.Utc)), 1)==(new DateTime (2015, 3, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.AddDays ((new DateTime (2016, 2, 28, 0, 0, 0, DateTimeKind.Utc)), 1)==(new DateTime (2016, 2, 29, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DateAndTime AddDays",cancellationToken);

// AddHours
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.AddHours ((new DateTime (1982, 5, 21, 22, 20, 30, DateTimeKind.Utc)), 1)==(new DateTime (1982, 5, 21, 23, 20, 30, DateTimeKind.Utc)))&&(BuiltInFunction.AddHours ((new DateTime (2001, 10, 12, 23, 20, 0, DateTimeKind.Utc)), 5)==(new DateTime (2001, 10, 13, 4, 20, 0, DateTimeKind.Utc)))),"BuiltIn_DateAndTime AddHours",cancellationToken);

// AddMinutes
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.AddMinutes ((new DateTime (1982, 5, 21, 22, 20, 30, DateTimeKind.Utc)), 1)==(new DateTime (1982, 5, 21, 22, 21, 30, DateTimeKind.Utc)))&&(BuiltInFunction.AddMinutes ((new DateTime (2001, 10, 12, 23, 55, 0, DateTimeKind.Utc)), 5)==(new DateTime (2001, 10, 13, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DateAndTime AddMinutes",cancellationToken);

// AddMonths
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.AddMonths ((new DateTime (2001, 9, 14, 0, 0, 0, DateTimeKind.Utc)), 2)==(new DateTime (2001, 11, 14, 0, 0, 0, DateTimeKind.Utc)))&&(BuiltInFunction.AddMonths ((new DateTime (2001, 12, 14, 0, 0, 0, DateTimeKind.Utc)), 2)==(new DateTime (2002, 2, 14, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.AddMonths ((new DateTime (2003, 1, 31, 0, 0, 0, DateTimeKind.Utc)), 1)==(new DateTime (2003, 2, 28, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.AddMonths ((new DateTime (2004, 1, 31, 0, 0, 0, DateTimeKind.Utc)), 1)==(new DateTime (2004, 2, 29, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DateAndTime AddMonths",cancellationToken);

// AddSeconds
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.AddSeconds ((new DateTime (2015, 5, 21, 22, 20, 30, DateTimeKind.Utc)), 60)==(new DateTime (2015, 5, 21, 22, 21, 30, DateTimeKind.Utc)))&&(BuiltInFunction.AddSeconds ((new DateTime (2003, 10, 21, 23, 59, 50, DateTimeKind.Utc)), 11)==(new DateTime (2003, 10, 22, 0, 0, 1, DateTimeKind.Utc)))),"BuiltIn_DateAndTime AddSeconds",cancellationToken);

// AddYears
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.AddYears ((new DateTime (2001, 9, 14, 0, 0, 0, DateTimeKind.Utc)), 3)==(new DateTime (2004, 9, 14, 0, 0, 0, DateTimeKind.Utc)))&&(BuiltInFunction.AddYears ((new DateTime (2004, 2, 29, 0, 0, 0, DateTimeKind.Utc)), 1)==(new DateTime (2005, 2, 28, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.AddYears ((new DateTime (2004, 2, 29, 0, 0, 0, DateTimeKind.Utc)), 4)==(new DateTime (2008, 2, 29, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DateAndTime AddYears",cancellationToken);

// BuildDateTime
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.BuildDateTime ((new DateTime (2015, 7, 14, 0, 0, 0, DateTimeKind.Utc)), (new DateTime (1900, 1, 1, 12, 30, 34, DateTimeKind.Utc)))==(new DateTime (2015, 7, 14, 12, 30, 34, DateTimeKind.Utc))),"BuiltIn_DateAndTime BuildDateTime",cancellationToken);

// Day
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Day ((new DateTime (2015, 7, 14, 0, 0, 0, DateTimeKind.Utc)))==14),"BuiltIn_DateAndTime Day",cancellationToken);

// DayOfWeek
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.DayOfWeek ((new DateTime (2001, 9, 14, 0, 0, 0, DateTimeKind.Utc)))==5),"BuiltIn_DateAndTime DayOfWeek",cancellationToken);

// Hour
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Hour ((new DateTime (1982, 5, 21, 22, 20, 30, DateTimeKind.Utc)))==22),"BuiltIn_DateAndTime Hour",cancellationToken);

// Minute
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Minute ((new DateTime (1982, 5, 21, 22, 20, 30, DateTimeKind.Utc)))==20),"BuiltIn_DateAndTime Minute",cancellationToken);

// Month
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Month ((new DateTime (2001, 9, 14, 0, 0, 0, DateTimeKind.Utc)))==9),"BuiltIn_DateAndTime Month",cancellationToken);

// NewDate
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.NewDate (2002, 6, 3)==(new DateTime (2002, 6, 3, 0, 0, 0, DateTimeKind.Utc))),"BuiltIn_DateAndTime NewDate",cancellationToken);

// NewDateTime
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.NewDateTime (2002, 6, 3, 22, 0, 59)==(new DateTime (2002, 6, 3, 22, 0, 59, DateTimeKind.Utc))),"BuiltIn_DateAndTime NewDateTime",cancellationToken);

// NewTime
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.NewTime (22, 0, 59)==(new DateTime (1900, 1, 1, 22, 0, 59, DateTimeKind.Utc))),"BuiltIn_DateAndTime NewTime",cancellationToken);

// Second
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.NewTime (22, 0, 59)==(new DateTime (1900, 1, 1, 22, 0, 59, DateTimeKind.Utc))),"BuiltIn_DateAndTime Second",cancellationToken);

// Year
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.Year ((new DateTime (2015, 7, 14, 0, 0, 0, DateTimeKind.Utc)))==2015),"BuiltIn_DateAndTime Year",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionDateAndTime {



}


}
