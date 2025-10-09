namespace ssRuntimeDestroyer {
/// <summary>
/// [CustomStructure] SampleListStruct (cv7HsC1TfUKTwlUyuNyEdg)
///  <code>ST_00ba72a41660161c6373af90c87d0979Structure</code> that represent
/// s <code>SampleListStruct</code> <p>Description: </p>
/// </summary>
// Name: SampleListStruct
public partial struct ST_00ba72a41660161c6373af90c87d0979Structure : ITypedRecord<ST_00ba72a41660161c6373af90c87d0979Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*cnERHQJH0UeobgzjaCsIHA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Id")]
public string ssId;


public BitArray OptimizedAttributes;

public ST_00ba72a41660161c6373af90c87d0979Structure() {
OptimizedAttributes = null;
ssId = "";
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
ssId = r.ReadText(index++, "SampleListStruct.Id", "");
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
public void ReadIM(ST_00ba72a41660161c6373af90c87d0979Structure r) {
this = r;
}


public static bool operator == (ST_00ba72a41660161c6373af90c87d0979Structure a, ST_00ba72a41660161c6373af90c87d0979Structure b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (ST_00ba72a41660161c6373af90c87d0979Structure a, ST_00ba72a41660161c6373af90c87d0979Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_00ba72a41660161c6373af90c87d0979Structure)) return false;
return (this == (ST_00ba72a41660161c6373af90c87d0979Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_00ba72a41660161c6373af90c87d0979Structure Duplicate() {
ST_00ba72a41660161c6373af90c87d0979Structure t;
t.ssId = this.ssId;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
}
} // ST_00ba72a41660161c6373af90c87d0979Structure
/// <summary>
/// RecordList type <code>SampleListStructList</code> that represents a record list of
///  <code>SampleListStruct</code>
/// </summary>
public partial class RL_82f541a6a3f8132f7af4a58873bc9078 : GenericRecordList<ST_00ba72a41660161c6373af90c87d0979Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_00ba72a41660161c6373af90c87d0979Structure GetElementDefaultValue() {
return new ST_00ba72a41660161c6373af90c87d0979Structure();
}

public T[] ToArray<T>(Func<ST_00ba72a41660161c6373af90c87d0979Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_82f541a6a3f8132f7af4a58873bc9078 recordList, Func<ST_00ba72a41660161c6373af90c87d0979Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_82f541a6a3f8132f7af4a58873bc9078(ST_00ba72a41660161c6373af90c87d0979Structure[] array) {
  RL_82f541a6a3f8132f7af4a58873bc9078 result = new RL_82f541a6a3f8132f7af4a58873bc9078();
result.InnerFromArray(array);
    return result;
}

public static RL_82f541a6a3f8132f7af4a58873bc9078 ToList<T>(T[] array, Func <T, ST_00ba72a41660161c6373af90c87d0979Structure> converter) {
  RL_82f541a6a3f8132f7af4a58873bc9078 result = new RL_82f541a6a3f8132f7af4a58873bc9078();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_82f541a6a3f8132f7af4a58873bc9078 FromRestList<T>(RestList<T> restList, Func <T, ST_00ba72a41660161c6373af90c87d0979Structure> converter) {
  RL_82f541a6a3f8132f7af4a58873bc9078 result = new RL_82f541a6a3f8132f7af4a58873bc9078();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_82f541a6a3f8132f7af4a58873bc9078() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_00ba72a41660161c6373af90c87d0979Structure> NewList() {
return new RL_82f541a6a3f8132f7af4a58873bc9078();
}


} // RL_82f541a6a3f8132f7af4a58873bc9078
}


namespace ssRuntimeDestroyer {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTSampleListStruct {
[JsonProperty("Id")]
public string restId;

public RESTSampleListStruct() { }

public RESTSampleListStruct(ST_00ba72a41660161c6373af90c87d0979Structure s) {
restId = s.ssId == "" ? null : s.ssId;
}

public static ST_00ba72a41660161c6373af90c87d0979Structure ToStructure(RESTSampleListStruct obj) { 
  ST_00ba72a41660161c6373af90c87d0979Structure s = new ST_00ba72a41660161c6373af90c87d0979Structure();
  if(obj != null) {
  s.ssId = obj.restId == null ? "" : obj.restId;
  }
  return s;
}

public static RESTSampleListStruct FromStructure(ST_00ba72a41660161c6373af90c87d0979Structure s) { 
  return new RESTSampleListStruct(s);
}

}
}
