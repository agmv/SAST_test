namespace ssRuntimeDestroyerLib;

public partial class Actions {
/// <summary>
/// Action <code>DataConversion</code> that represents the Service Studio action
///  <code>DataConversion</code> <p> Description: </p>
/// </summary>
public static async Task ActionDataConversion(IRequestContext requestContext,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DataConversion", "a344eb06-826e-487e-b59e-743dee9c07fc", "RuntimeDestroyerLib", "70e88f84-20c0-496b-bde5-9831530a09d3") : null){
// BooleanToInteger
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.BooleanToInteger (true)==1),"BuiltIn_DataConversion BooleanToInteger",cancellationToken);

// BooleanToText
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.BooleanToText (true)=="True"),"BuiltIn_DataConversion BooleanToText",cancellationToken);

// DateTimeToDate
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.DateTimeToDate ((new DateTime (2013, 11, 30, 22, 20, 30, DateTimeKind.Utc)))==(new DateTime (2013, 11, 30, 0, 0, 0, DateTimeKind.Utc))),"BuiltIn_DataConversion DateTimeToDate",cancellationToken);

// DateTimeToText
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.DateTimeToText ((new DateTime (2015, 5, 21, 22, 20, 30, DateTimeKind.Utc)))=="2015-05-21 22:20:30")&&(BuiltInFunction.DateTimeToText ((new DateTime (2015, 5, 21, 0, 0, 0, DateTimeKind.Utc)))=="2015-05-21 00:00:00"))&&(BuiltInFunction.DateTimeToText ((new DateTime (1900, 1, 1, 22, 20, 30, DateTimeKind.Utc)))=="1900-01-01 22:20:30")),"BuiltIn_DataConversion DateTimeToText",cancellationToken);

// DateTimeToTime
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.DateTimeToTime ((new DateTime (1982, 5, 21, 22, 20, 30, DateTimeKind.Utc)))==(new DateTime (1900, 1, 1, 22, 20, 30, DateTimeKind.Utc))),"BuiltIn_DataConversion DateTimeToTime",cancellationToken);

// DateToDateTime
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.DateToDateTime ((new DateTime (2001, 9, 14, 0, 0, 0, DateTimeKind.Utc)))==(new DateTime (2001, 9, 14, 0, 0, 0, DateTimeKind.Utc))),"BuiltIn_DataConversion DateToDateTime",cancellationToken);

// DateToText
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.DateToText ((new DateTime (2010, 5, 17, 0, 0, 0, DateTimeKind.Utc)))=="2010-05-17")&&(BuiltInFunction.DateToText (BuiltInFunction.DateTimeToDate((new DateTime (2010, 5, 17, 22, 30, 32, DateTimeKind.Utc))))=="2010-05-17")),"BuiltIn_DataConversion DateToText",cancellationToken);

// DecimalToBoolean
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.DecimalToBoolean (0.0m)==false)&&(BuiltInFunction.DecimalToBoolean (0.05m)==true)),"BuiltIn_DataConversion DecimalToBoolean",cancellationToken);

// DecimalToInteger
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.DecimalToInteger (134.2m)==134)&&(BuiltInFunction.DecimalToInteger (134.5m)==134))&&(BuiltInFunction.DecimalToInteger (133.5m)==134))&&(BuiltInFunction.DecimalToInteger (134.7m)==135))&&(BuiltInFunction.DecimalToInteger ((((decimal)134)))==134))&&(BuiltInFunction.DecimalToInteger (12345678999.9m)==0)),"BuiltIn_DataConversion DecimalToInteger",cancellationToken);

// DecimalToIntegerValidate
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.DecimalToIntegerValidate (134.2m)==true)&&(BuiltInFunction.DecimalToIntegerValidate (134.5m)==true))&&(BuiltInFunction.DecimalToIntegerValidate (133.5m)==true))&&(BuiltInFunction.DecimalToIntegerValidate (134.7m)==true))&&(BuiltInFunction.DecimalToIntegerValidate ((((decimal)134)))==true))&&(BuiltInFunction.DecimalToIntegerValidate (12345678999.9m)==false)),"BuiltIn_DataConversion DecimalToIntegerValidate",cancellationToken);

// DecimalToLongInteger
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.DecimalToLongInteger (134.2m)==Convert.ToInt64(134))&&(BuiltInFunction.DecimalToLongInteger (134.5m)==Convert.ToInt64(134)))&&(BuiltInFunction.DecimalToLongInteger (133.5m)==Convert.ToInt64(134)))&&(BuiltInFunction.DecimalToLongInteger (134.7m)==Convert.ToInt64(135)))&&(BuiltInFunction.DecimalToLongInteger ((((decimal)134)))==Convert.ToInt64(134)))&&(BuiltInFunction.DecimalToLongInteger (157898999999988844444.2m)==Convert.ToInt64(0))),"BuiltIn_DataConversion DecimalToLongInteger",cancellationToken);

// DecimalToLongIntegerValidate
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.DecimalToLongIntegerValidate (134.2m)==true)&&(BuiltInFunction.DecimalToLongIntegerValidate (134.5m)==true))&&(BuiltInFunction.DecimalToLongIntegerValidate (133.5m)==true))&&(BuiltInFunction.DecimalToLongIntegerValidate (134.7m)==true))&&(BuiltInFunction.DecimalToLongIntegerValidate ((((decimal)134)))==true))&&(BuiltInFunction.DecimalToLongIntegerValidate (157898999999988844444.2m)==false)),"BuiltIn_DataConversion DecimalToLongIntegerValidate",cancellationToken);

// DecimalToText
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.DecimalToText (200.482m)=="200.482")&&(BuiltInFunction.DecimalToText ((((decimal)200)))=="200")),"BuiltIn_DataConversion DecimalToText",cancellationToken);

// LongIntegerToInteger
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.LongIntegerToInteger (Convert.ToInt64(3000))==3000)&&(BuiltInFunction.LongIntegerToInteger (5645245584135987412L)==0)),"BuiltIn_DataConversion LongIntegerToInteger",cancellationToken);

// LongIntegerToIntegerValidate
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.LongIntegerToIntegerValidate (Convert.ToInt64(3000))==true)&&(BuiltInFunction.LongIntegerToIntegerValidate (5645245584135987412L)==false)),"BuiltIn_DataConversion LongIntegerToIntegerValidate",cancellationToken);

// LongIntegerToText
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.LongIntegerToText (5092039102L)=="5092039102"),"BuiltIn_DataConversion LongIntegerToText",cancellationToken);

// IntegerToBoolean
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.IntegerToBoolean (10)==true)&&(BuiltInFunction.IntegerToBoolean ((-10))==true))&&(BuiltInFunction.IntegerToBoolean (0)==false)),"BuiltIn_DataConversion IntegerToBoolean",cancellationToken);

// IntegerToDecimal
await Actions.ActionAssertTrue(requestContext,(((BuiltInFunction.IntegerToBoolean (10)==true)&&(BuiltInFunction.IntegerToBoolean ((-10))==true))&&(BuiltInFunction.IntegerToBoolean (0)==false)),"BuiltIn_DataConversion IntegerToDecimal",cancellationToken);

// IntegerToText
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.IntegerToText (200)=="200"),"BuiltIn_DataConversion IntegerToText",cancellationToken);

// NullDate
await Actions.ActionAssertTrue(requestContext,(BuiltInFunction.NullDate ()==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))),"BuiltIn_DataConversion NullDate",cancellationToken);

// TextToDate
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.TextToDate ("2002-01-01")==(new DateTime (2002, 1, 1, 0, 0, 0, DateTimeKind.Utc)))&&(BuiltInFunction.TextToDate ("2002/01/01")==(new DateTime (2002, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDate ("2002.01.01")==(new DateTime (2002, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDate ("2002-25-01")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDate ("2002/02/31")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDate ("10000.01.01")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DataConversion TextToDate",cancellationToken);

// TextToDateTime
await Actions.ActionAssertTrue(requestContext,((((((((BuiltInFunction.TextToDateTime ("2002-01-01 01:01:01")==(new DateTime (2002, 1, 1, 1, 1, 1, DateTimeKind.Utc)))&&(BuiltInFunction.TextToDateTime ("2002/01/01 01:01:01")==(new DateTime (2002, 1, 1, 1, 1, 1, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDateTime ("2002.01.01 01:01:01")==(new DateTime (2002, 1, 1, 1, 1, 1, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDateTime ("20-01-01 01:01:01")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDateTime ("date time")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDateTime ("2002.1.1 1-1-1")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDateTime ("2002-01-01")==(new DateTime (2002, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToDateTime ("01-01-01")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DataConversion TextToDateTime",cancellationToken);

// TextToDateTimeValidate
await Actions.ActionAssertTrue(requestContext,((((((((BuiltInFunction.TextToDateTimeValidate ("2002-01-01 01:01:01")==true)&&(BuiltInFunction.TextToDateTimeValidate ("2002/01/01 01:01:01")==true))&&(BuiltInFunction.TextToDateTimeValidate ("2002.01.01 01:01:01")==true))&&(BuiltInFunction.TextToDateTimeValidate ("20-01-01 01:01:01")==false))&&(BuiltInFunction.TextToDateTimeValidate ("date time")==false))&&(BuiltInFunction.TextToDateTimeValidate ("2002.1.1 1-1-1")==false))&&(BuiltInFunction.TextToDateTimeValidate ("2002-01-01")==true))&&(BuiltInFunction.TextToDateTimeValidate ("01-01-01")==false)),"BuiltIn_DataConversion TextToDateTimeValidate",cancellationToken);

// TextToDateValidate
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.TextToDateValidate ("2002-01-01")==true)&&(BuiltInFunction.TextToDateValidate ("2002/01/01")==true))&&(BuiltInFunction.TextToDateValidate ("2002.01.01")==true))&&(BuiltInFunction.TextToDateValidate ("2002-25-01")==false))&&(BuiltInFunction.TextToDateValidate ("2002/02/31")==false))&&(BuiltInFunction.TextToDateValidate ("10000.01.01")==false)),"BuiltIn_DataConversion TextToDateValidate",cancellationToken);

// TextToDecimal
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.TextToDecimal ("200")==(((decimal)200)))&&(BuiltInFunction.TextToDecimal ("-200")==(((decimal)(-200)))))&&(BuiltInFunction.TextToDecimal ("200.482")==200.482m))&&(BuiltInFunction.TextToDecimal ("-200.482")==(-200.482m)))&&(BuiltInFunction.TextToDecimal ("0.99999999")==0.99999999m))&&(BuiltInFunction.TextToDecimal ("abc")==(((decimal)0)))),"BuiltIn_DataConversion TextToDecimal",cancellationToken);

// TextToDecimalValidate
await Actions.ActionAssertTrue(requestContext,((((((BuiltInFunction.TextToDecimalValidate ("200")==true)&&(BuiltInFunction.TextToDecimalValidate ("-200")==true))&&(BuiltInFunction.TextToDecimalValidate ("200.482")==true))&&(BuiltInFunction.TextToDecimalValidate ("-200.482")==true))&&(BuiltInFunction.TextToDecimalValidate ("0.99999999")==true))&&(BuiltInFunction.TextToDecimalValidate ("abc")==false)),"BuiltIn_DataConversion TextToDecimalValidate",cancellationToken);

// TextToInteger
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.TextToInteger ("200")==200)&&(BuiltInFunction.TextToInteger ("-200")==(-200)))&&(BuiltInFunction.TextToInteger ("200.482")==0))&&(BuiltInFunction.TextToInteger ("not a number")==0)),"BuiltIn_DataConversion TextToIdentifier",cancellationToken);

// TextToLongInteger
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.TextToLongInteger ("200")==Convert.ToInt64(200))&&(BuiltInFunction.TextToLongInteger ("-200")==Convert.ToInt64((-200))))&&(BuiltInFunction.TextToLongInteger ("56452455841359874121")==Convert.ToInt64(0)))&&(BuiltInFunction.TextToLongInteger ("not a number")==Convert.ToInt64(0))),"BuiltIn_DataConversion TextToLongInteger",cancellationToken);

// TextToIntegerValidate
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.TextToIntegerValidate ("200")==true)&&(BuiltInFunction.TextToIntegerValidate ("-200")==true))&&(BuiltInFunction.TextToIntegerValidate ("200.482")==false))&&(BuiltInFunction.TextToIntegerValidate ("not a number")==false)),"BuiltIn_DataConversion TextToIntegerValidate",cancellationToken);

// TextToLongIntegerValidate
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.TextToLongIntegerValidate ("200")==true)&&(BuiltInFunction.TextToLongIntegerValidate ("-200")==true))&&(BuiltInFunction.TextToLongIntegerValidate ("56452455841359874121")==false))&&(BuiltInFunction.TextToLongIntegerValidate ("not a number")==false)),"BuiltIn_DataConversion TextToLongIntegerValidate",cancellationToken);

// TextToTime
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.TextToTime ("12:12:12")==(new DateTime (1900, 1, 1, 12, 12, 12, DateTimeKind.Utc)))&&(BuiltInFunction.TextToTime ("23:68:12")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToTime ("0-0-0")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc))))&&(BuiltInFunction.TextToTime ("abc")==(new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)))),"BuiltIn_DataConversion TextToTime",cancellationToken);

// TextToTimeValidate
await Actions.ActionAssertTrue(requestContext,((((BuiltInFunction.TextToTimeValidate ("12:12:12")==true)&&(BuiltInFunction.TextToTimeValidate ("23:68:12")==false))&&(BuiltInFunction.TextToTimeValidate ("0-0-0")==false))&&(BuiltInFunction.TextToTimeValidate ("abc")==false)),"BuiltIn_DataConversion TextToTimeValidate",cancellationToken);

// TimeToText
await Actions.ActionAssertTrue(requestContext,((BuiltInFunction.TimeToText ((new DateTime (1900, 1, 1, 12, 30, 24, DateTimeKind.Utc)))=="12:30:24")&&(BuiltInFunction.TimeToText (BuiltInFunction.DateTimeToTime((new DateTime (2015, 7, 2, 12, 30, 34, DateTimeKind.Utc))))=="12:30:34")),"BuiltIn_DataConversion TimeToText",cancellationToken);

} //close CreateActionActivity using block
RETURN_STATEMENT:
return;
}

public static class FuncActionDataConversion {



}


}
