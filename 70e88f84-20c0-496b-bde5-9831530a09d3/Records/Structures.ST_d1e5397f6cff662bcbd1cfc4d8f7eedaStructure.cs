namespace ssRuntimeDestroyerLib {
/// <summary>
/// [Structure] HttpResponseStruct (nHRTBUJlFE6j5O5FSN_wMA)
///  <code>ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure</code> that represent
/// s <code>HttpResponseStruct</code> <p>Description: </p>
/// </summary>
// Name: HttpResponseStruct
public partial struct ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure : ITypedRecord<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure> {
internal static readonly GlobalObjectKey IdStatusCode = GlobalObjectKey.Parse("hI_ocMAga0m95ZgxUwoJ0w*_1RXGsR7okyOAVDGqvxLCg");
internal static readonly GlobalObjectKey IdBody = GlobalObjectKey.Parse("hI_ocMAga0m95ZgxUwoJ0w*y+3elPDmh0WWMcDcm4+NNg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StatusCode")]
public int ssStatusCode;

[System.Xml.Serialization.XmlElement("Body")]
public string ssBody;


public BitArray OptimizedAttributes;

public ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure() {
OptimizedAttributes = null;
ssStatusCode = 0;
ssBody = "";
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
ssStatusCode = r.ReadInteger(index++, "HttpResponseStruct.StatusCode", 0);
ssBody = r.ReadText(index++, "HttpResponseStruct.Body", "");
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
public void ReadIM(ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure r) {
this = r;
}


public static bool operator == (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure a, ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure b) {
if (a.ssStatusCode != b.ssStatusCode) return false;
if (a.ssBody != b.ssBody) return false;
return true;
}

public static bool operator != (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure a, ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure)) return false;
return (this == (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssStatusCode.GetHashCode()
 ^ ssBody.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure Duplicate() {
ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure t;
t.ssStatusCode = this.ssStatusCode;
t.ssBody = this.ssBody;
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
if (head == "statuscode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StatusCode")) variable.Value = ssStatusCode; else variable.Optimized = true;
} else if (head == "body") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Body")) variable.Value = ssBody; else variable.Optimized = true;
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
if (key == IdStatusCode) {
return ssStatusCode;
}
if (key == IdBody) {
return ssBody;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStatusCode.Key.AsGuid) {
return ssStatusCode;
}
if (attributeKey == IdBody.Key.AsGuid) {
return ssBody;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssStatusCode = (int) other.AttributeGet(IdStatusCode);
ssBody = (string) other.AttributeGet(IdBody);
}
} // ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure
/// <summary>
/// RecordList type <code>HttpResponseStructList</code> that represents a record list of
///  <code>HttpResponseStruct</code>
/// </summary>
public partial class RL_2880e032d42d323d0078e0205374ff85 : GenericRecordList<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure GetElementDefaultValue() {
return new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure();
}

public T[] ToArray<T>(Func<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2880e032d42d323d0078e0205374ff85 recordList, Func<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2880e032d42d323d0078e0205374ff85(ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure[] array) {
  RL_2880e032d42d323d0078e0205374ff85 result = new RL_2880e032d42d323d0078e0205374ff85();
result.InnerFromArray(array);
    return result;
}

public static RL_2880e032d42d323d0078e0205374ff85 ToList<T>(T[] array, Func <T, ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure> converter) {
  RL_2880e032d42d323d0078e0205374ff85 result = new RL_2880e032d42d323d0078e0205374ff85();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2880e032d42d323d0078e0205374ff85 FromRestList<T>(RestList<T> restList, Func <T, ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure> converter) {
  RL_2880e032d42d323d0078e0205374ff85 result = new RL_2880e032d42d323d0078e0205374ff85();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2880e032d42d323d0078e0205374ff85() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure> NewList() {
return new RL_2880e032d42d323d0078e0205374ff85();
}


} // RL_2880e032d42d323d0078e0205374ff85
}

