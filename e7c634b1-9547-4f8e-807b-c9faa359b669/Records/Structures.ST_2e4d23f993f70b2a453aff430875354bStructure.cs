namespace ssRuntimeDestroyer {
/// <summary>
/// [CustomStructure] HTTPRequest2 (zwxGLtTJJUa4OqGId7SEsw)
///  <code>ST_2e4d23f993f70b2a453aff430875354bStructure</code> that represents <code>HTTPRequest2</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPRequest2
public partial struct ST_2e4d23f993f70b2a453aff430875354bStructure : ITypedRecord<ST_2e4d23f993f70b2a453aff430875354bStructure> {
internal static readonly GlobalObjectKey IdBaseURL = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*jT7Nc0fAB0m+ra4I90OfLQ");
internal static readonly GlobalObjectKey IdURLPath = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*2AkLmGB0H0OeroM4rPCubA");
internal static readonly GlobalObjectKey IdURLQueryParameters = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*j7XV9wR6U0CkwGnWyTOj4Q");
internal static readonly GlobalObjectKey IdHTTPMethod = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*JMJIR71yBECbQtYNjj4zlw");
internal static readonly GlobalObjectKey IdHeaders = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*GY5GknQhqU+d3wngnR6hsQ");
internal static readonly GlobalObjectKey IdRequestText = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*bgKW+2_ns0qLsAZNBvgL1Q");
internal static readonly GlobalObjectKey IdRequestBinary = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*s9yfT24WHky6NkT4jrjbhg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("BaseURL")]
public string ssBaseURL;

[System.Xml.Serialization.XmlElement("URLPath")]
public string ssURLPath;

[System.Xml.Serialization.XmlElement("URLQueryParameters")]
public RL_f12ccf0a92533f516726b4232e2b352e ssURLQueryParameters;

[System.Xml.Serialization.XmlElement("HTTPMethod")]
public string ssHTTPMethod;

[System.Xml.Serialization.XmlElement("Headers")]
public RL_435011a192ffc5b6f97bc0a73c8501c1 ssHeaders;

[System.Xml.Serialization.XmlElement("RequestText")]
public string ssRequestText;

[System.Xml.Serialization.XmlElement("RequestBinary")]
public byte[] ssRequestBinary;


public BitArray OptimizedAttributes;

public ST_2e4d23f993f70b2a453aff430875354bStructure() {
OptimizedAttributes = null;
ssBaseURL = "";
ssURLPath = "";
ssURLQueryParameters = new RL_f12ccf0a92533f516726b4232e2b352e();
ssHTTPMethod = "";
ssHeaders = new RL_435011a192ffc5b6f97bc0a73c8501c1();
ssRequestText = "";
ssRequestBinary = new byte[] {};
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssBaseURL = r.ReadText(index++, "HTTPRequest2.BaseURL", "");
ssURLPath = r.ReadText(index++, "HTTPRequest2.URLPath", "");
ssHTTPMethod = r.ReadText(index++, "HTTPRequest2.HTTPMethod", "");
ssRequestText = r.ReadText(index++, "HTTPRequest2.RequestText", "");
ssRequestBinary = r.ReadBinaryData(index++, "HTTPRequest2.RequestBinary", new byte[] {});
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_2e4d23f993f70b2a453aff430875354bStructure r) {
this = r;
}


public static bool operator == (ST_2e4d23f993f70b2a453aff430875354bStructure a, ST_2e4d23f993f70b2a453aff430875354bStructure b) {
if (a.ssBaseURL != b.ssBaseURL) return false;
if (a.ssURLPath != b.ssURLPath) return false;
if (a.ssURLQueryParameters != b.ssURLQueryParameters) return false;
if (a.ssHTTPMethod != b.ssHTTPMethod) return false;
if (a.ssHeaders != b.ssHeaders) return false;
if (a.ssRequestText != b.ssRequestText) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssRequestBinary, b.ssRequestBinary)) return false;
return true;
}

public static bool operator != (ST_2e4d23f993f70b2a453aff430875354bStructure a, ST_2e4d23f993f70b2a453aff430875354bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2e4d23f993f70b2a453aff430875354bStructure)) return false;
return (this == (ST_2e4d23f993f70b2a453aff430875354bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssBaseURL.GetHashCode()
 ^ ssURLPath.GetHashCode()
 ^ ssURLQueryParameters.GetHashCode()
 ^ ssHTTPMethod.GetHashCode()
 ^ ssHeaders.GetHashCode()
 ^ ssRequestText.GetHashCode()
 ^ ssRequestBinary.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssURLQueryParameters.RecursiveReset();
ssHeaders.RecursiveReset();
}

public void InternalRecursiveSave() {
ssURLQueryParameters.InternalRecursiveSave();
ssHeaders.InternalRecursiveSave();
}


public ST_2e4d23f993f70b2a453aff430875354bStructure Duplicate() {
ST_2e4d23f993f70b2a453aff430875354bStructure t;
t.ssBaseURL = this.ssBaseURL;
t.ssURLPath = this.ssURLPath;
t.ssURLQueryParameters = (RL_f12ccf0a92533f516726b4232e2b352e)this.ssURLQueryParameters.Duplicate();
t.ssHTTPMethod = this.ssHTTPMethod;
t.ssHeaders = (RL_435011a192ffc5b6f97bc0a73c8501c1)this.ssHeaders.Duplicate();
t.ssRequestText = this.ssRequestText;
t.ssRequestBinary = this.ssRequestBinary;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "baseurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseURL")) variable.Value = ssBaseURL; else variable.Optimized = true;
} else if (head == "urlpath") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URLPath")) variable.Value = ssURLPath; else variable.Optimized = true;
} else if (head == "urlqueryparameters") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URLQueryParameters")) variable.Value = ssURLQueryParameters; else variable.Optimized = true;
variable.SetFieldName("urlqueryparameters");
} else if (head == "httpmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HTTPMethod")) variable.Value = ssHTTPMethod; else variable.Optimized = true;
} else if (head == "headers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Headers")) variable.Value = ssHeaders; else variable.Optimized = true;
variable.SetFieldName("headers");
} else if (head == "requesttext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequestText")) variable.Value = ssRequestText; else variable.Optimized = true;
} else if (head == "requestbinary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequestBinary")) variable.Value = ssRequestBinary; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBaseURL) {
return ssBaseURL;
}
if (key == IdURLPath) {
return ssURLPath;
}
if (key == IdURLQueryParameters) {
return ssURLQueryParameters;
}
if (key == IdHTTPMethod) {
return ssHTTPMethod;
}
if (key == IdHeaders) {
return ssHeaders;
}
if (key == IdRequestText) {
return ssRequestText;
}
if (key == IdRequestBinary) {
return ssRequestBinary;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBaseURL.Key.AsGuid) {
return ssBaseURL;
}
if (attributeKey == IdURLPath.Key.AsGuid) {
return ssURLPath;
}
if (attributeKey == IdURLQueryParameters.Key.AsGuid) {
return ssURLQueryParameters;
}
if (attributeKey == IdHTTPMethod.Key.AsGuid) {
return ssHTTPMethod;
}
if (attributeKey == IdHeaders.Key.AsGuid) {
return ssHeaders;
}
if (attributeKey == IdRequestText.Key.AsGuid) {
return ssRequestText;
}
if (attributeKey == IdRequestBinary.Key.AsGuid) {
return ssRequestBinary;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssBaseURL = (string) other.AttributeGet(IdBaseURL);
ssURLPath = (string) other.AttributeGet(IdURLPath);
ssURLQueryParameters = new RL_f12ccf0a92533f516726b4232e2b352e();
ssURLQueryParameters.FillFromOther((IOSList) other.AttributeGet(IdURLQueryParameters));
ssHTTPMethod = (string) other.AttributeGet(IdHTTPMethod);
ssHeaders = new RL_435011a192ffc5b6f97bc0a73c8501c1();
ssHeaders.FillFromOther((IOSList) other.AttributeGet(IdHeaders));
ssRequestText = (string) other.AttributeGet(IdRequestText);
ssRequestBinary = (byte[]) other.AttributeGet(IdRequestBinary);
}
} // ST_2e4d23f993f70b2a453aff430875354bStructure
/// <summary>
/// RecordList type <code>HTTPRequest2List</code> that represents a record list of
///  <code>HTTPRequest2</code>
/// </summary>
public partial class RL_1455d733e0a430d5576379ac607dbfcf : GenericRecordList<ST_2e4d23f993f70b2a453aff430875354bStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_2e4d23f993f70b2a453aff430875354bStructure GetElementDefaultValue() {
return new ST_2e4d23f993f70b2a453aff430875354bStructure();
}

public T[] ToArray<T>(Func<ST_2e4d23f993f70b2a453aff430875354bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1455d733e0a430d5576379ac607dbfcf recordList, Func<ST_2e4d23f993f70b2a453aff430875354bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1455d733e0a430d5576379ac607dbfcf(ST_2e4d23f993f70b2a453aff430875354bStructure[] array) {
  RL_1455d733e0a430d5576379ac607dbfcf result = new RL_1455d733e0a430d5576379ac607dbfcf();
result.InnerFromArray(array);
    return result;
}

public static RL_1455d733e0a430d5576379ac607dbfcf ToList<T>(T[] array, Func <T, ST_2e4d23f993f70b2a453aff430875354bStructure> converter) {
  RL_1455d733e0a430d5576379ac607dbfcf result = new RL_1455d733e0a430d5576379ac607dbfcf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1455d733e0a430d5576379ac607dbfcf FromRestList<T>(RestList<T> restList, Func <T, ST_2e4d23f993f70b2a453aff430875354bStructure> converter) {
  RL_1455d733e0a430d5576379ac607dbfcf result = new RL_1455d733e0a430d5576379ac607dbfcf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1455d733e0a430d5576379ac607dbfcf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2e4d23f993f70b2a453aff430875354bStructure> NewList() {
return new RL_1455d733e0a430d5576379ac607dbfcf();
}


} // RL_1455d733e0a430d5576379ac607dbfcf
}

