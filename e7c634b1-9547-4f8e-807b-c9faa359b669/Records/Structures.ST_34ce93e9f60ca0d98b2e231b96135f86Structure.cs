namespace ssRuntimeDestroyer {
/// <summary>
/// [CustomStructure] HttpRequestStruct (Yyiwu4xtrkmHMv3GaF8R4A)
///  <code>ST_34ce93e9f60ca0d98b2e231b96135f86Structure</code> that represent
/// s <code>HttpRequestStruct</code> <p>Description: </p>
/// </summary>
// Name: HttpRequestStruct
public partial struct ST_34ce93e9f60ca0d98b2e231b96135f86Structure : ITypedRecord<ST_34ce93e9f60ca0d98b2e231b96135f86Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*3w+aLHVTAUuLR_k+keJTYA");
internal static readonly GlobalObjectKey IdHttpMethod = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*GT_Q8A2970yXNVBMuaqm7A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Id")]
public long ssId;

[System.Xml.Serialization.XmlElement("HttpMethod")]
public string ssHttpMethod;


public BitArray OptimizedAttributes;

public ST_34ce93e9f60ca0d98b2e231b96135f86Structure() {
OptimizedAttributes = null;
ssId = 0L;
ssHttpMethod = "";
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
ssId = r.ReadLongInteger(index++, "HttpRequestStruct.Id", 0L);
ssHttpMethod = r.ReadText(index++, "HttpRequestStruct.HttpMethod", "");
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
public void ReadIM(ST_34ce93e9f60ca0d98b2e231b96135f86Structure r) {
this = r;
}


public static bool operator == (ST_34ce93e9f60ca0d98b2e231b96135f86Structure a, ST_34ce93e9f60ca0d98b2e231b96135f86Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssHttpMethod != b.ssHttpMethod) return false;
return true;
}

public static bool operator != (ST_34ce93e9f60ca0d98b2e231b96135f86Structure a, ST_34ce93e9f60ca0d98b2e231b96135f86Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_34ce93e9f60ca0d98b2e231b96135f86Structure)) return false;
return (this == (ST_34ce93e9f60ca0d98b2e231b96135f86Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssHttpMethod.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_34ce93e9f60ca0d98b2e231b96135f86Structure Duplicate() {
ST_34ce93e9f60ca0d98b2e231b96135f86Structure t;
t.ssId = this.ssId;
t.ssHttpMethod = this.ssHttpMethod;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "httpmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpMethod")) variable.Value = ssHttpMethod; else variable.Optimized = true;
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
if (key == IdId) {
return ssId;
}
if (key == IdHttpMethod) {
return ssHttpMethod;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdHttpMethod.Key.AsGuid) {
return ssHttpMethod;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ssHttpMethod = (string) other.AttributeGet(IdHttpMethod);
}
} // ST_34ce93e9f60ca0d98b2e231b96135f86Structure
/// <summary>
/// RecordList type <code>HttpRequestStructList</code> that represents a record list of
///  <code>HttpRequestStruct</code>
/// </summary>
public partial class RL_45cdd2ed99a529499c43ca5937e1be14 : GenericRecordList<ST_34ce93e9f60ca0d98b2e231b96135f86Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_34ce93e9f60ca0d98b2e231b96135f86Structure GetElementDefaultValue() {
return new ST_34ce93e9f60ca0d98b2e231b96135f86Structure();
}

public T[] ToArray<T>(Func<ST_34ce93e9f60ca0d98b2e231b96135f86Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_45cdd2ed99a529499c43ca5937e1be14 recordList, Func<ST_34ce93e9f60ca0d98b2e231b96135f86Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_45cdd2ed99a529499c43ca5937e1be14(ST_34ce93e9f60ca0d98b2e231b96135f86Structure[] array) {
  RL_45cdd2ed99a529499c43ca5937e1be14 result = new RL_45cdd2ed99a529499c43ca5937e1be14();
result.InnerFromArray(array);
    return result;
}

public static RL_45cdd2ed99a529499c43ca5937e1be14 ToList<T>(T[] array, Func <T, ST_34ce93e9f60ca0d98b2e231b96135f86Structure> converter) {
  RL_45cdd2ed99a529499c43ca5937e1be14 result = new RL_45cdd2ed99a529499c43ca5937e1be14();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_45cdd2ed99a529499c43ca5937e1be14 FromRestList<T>(RestList<T> restList, Func <T, ST_34ce93e9f60ca0d98b2e231b96135f86Structure> converter) {
  RL_45cdd2ed99a529499c43ca5937e1be14 result = new RL_45cdd2ed99a529499c43ca5937e1be14();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_45cdd2ed99a529499c43ca5937e1be14() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_34ce93e9f60ca0d98b2e231b96135f86Structure> NewList() {
return new RL_45cdd2ed99a529499c43ca5937e1be14();
}


} // RL_45cdd2ed99a529499c43ca5937e1be14
}


namespace ssRuntimeDestroyer {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTHttpRequestStruct {
[JsonProperty("Id")]
public long? restId;

[JsonProperty("HttpMethod")]
public string restHttpMethod;

public RESTHttpRequestStruct() { }

public RESTHttpRequestStruct(ST_34ce93e9f60ca0d98b2e231b96135f86Structure s) {
restId = s.ssId == 0L ? null : (long?) s.ssId;
restHttpMethod = s.ssHttpMethod == "" ? null : s.ssHttpMethod;
}

public static ST_34ce93e9f60ca0d98b2e231b96135f86Structure ToStructure(RESTHttpRequestStruct obj) { 
  ST_34ce93e9f60ca0d98b2e231b96135f86Structure s = new ST_34ce93e9f60ca0d98b2e231b96135f86Structure();
  if(obj != null) {
  s.ssId = obj.restId == null ? 0L : obj.restId.Value;
  s.ssHttpMethod = obj.restHttpMethod == null ? "" : obj.restHttpMethod;
  }
  return s;
}

public static RESTHttpRequestStruct FromStructure(ST_34ce93e9f60ca0d98b2e231b96135f86Structure s) { 
  return new RESTHttpRequestStruct(s);
}

}
}
