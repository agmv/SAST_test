namespace ssRuntimeDestroyer {
/// <summary>
/// [CustomStructure] Employee2 (kxojS4qJEkSdEvMI_tmRrA)
///  <code>ST_c6c92e08cc1756053230783f07370fc0Structure</code> that represents <code>Employee2</code
/// > <p>Description: </p>
/// </summary>
// Name: Employee2
public partial struct ST_c6c92e08cc1756053230783f07370fc0Structure : ITypedRecord<ST_c6c92e08cc1756053230783f07370fc0Structure> {
internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*rGtxcAmsrk2TZ3Eo9dM2yg");
internal static readonly GlobalObjectKey Idname = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*+dIRIm9J1kGAADvih1hYEw");
internal static readonly GlobalObjectKey Idcolor = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*VhEU0vwP+EmqBnAu8hkjFw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("id")]
public string ssid;

[System.Xml.Serialization.XmlElement("name")]
public string ssname;

[System.Xml.Serialization.XmlElement("color")]
public string sscolor;


public BitArray OptimizedAttributes;

public ST_c6c92e08cc1756053230783f07370fc0Structure() {
OptimizedAttributes = null;
ssid = "";
ssname = "";
sscolor = (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue;
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
ssid = r.ReadText(index++, "Employee2.id", "");
ssname = r.ReadText(index++, "Employee2.name", "");
sscolor = r.ReadEntityReferenceText(index++, "Employee2.color", "");
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
public void ReadIM(ST_c6c92e08cc1756053230783f07370fc0Structure r) {
this = r;
}


public static bool operator == (ST_c6c92e08cc1756053230783f07370fc0Structure a, ST_c6c92e08cc1756053230783f07370fc0Structure b) {
if (a.ssid != b.ssid) return false;
if (a.ssname != b.ssname) return false;
if (a.sscolor != b.sscolor) return false;
return true;
}

public static bool operator != (ST_c6c92e08cc1756053230783f07370fc0Structure a, ST_c6c92e08cc1756053230783f07370fc0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c6c92e08cc1756053230783f07370fc0Structure)) return false;
return (this == (ST_c6c92e08cc1756053230783f07370fc0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssid.GetHashCode()
 ^ ssname.GetHashCode()
 ^ sscolor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_c6c92e08cc1756053230783f07370fc0Structure Duplicate() {
ST_c6c92e08cc1756053230783f07370fc0Structure t;
t.ssid = this.ssid;
t.ssname = this.ssname;
t.sscolor = this.sscolor;
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".name")) variable.Value = ssname; else variable.Optimized = true;
} else if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".color")) variable.Value = sscolor; else variable.Optimized = true;
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
if (key == Idid) {
return ssid;
}
if (key == Idname) {
return ssname;
}
if (key == Idcolor) {
return sscolor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idid.Key.AsGuid) {
return ssid;
}
if (attributeKey == Idname.Key.AsGuid) {
return ssname;
}
if (attributeKey == Idcolor.Key.AsGuid) {
return sscolor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssid = (string) other.AttributeGet(Idid);
ssname = (string) other.AttributeGet(Idname);
sscolor = (string) other.AttributeGet(Idcolor);
}
} // ST_c6c92e08cc1756053230783f07370fc0Structure
/// <summary>
/// RecordList type <code>Employee2List</code> that represents a record list of <code>Employee2</code>
/// </summary>
public partial class RL_3d3f6c2b51c648237437bbf55ca4e447 : GenericRecordList<ST_c6c92e08cc1756053230783f07370fc0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_c6c92e08cc1756053230783f07370fc0Structure GetElementDefaultValue() {
return new ST_c6c92e08cc1756053230783f07370fc0Structure();
}

public T[] ToArray<T>(Func<ST_c6c92e08cc1756053230783f07370fc0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d3f6c2b51c648237437bbf55ca4e447 recordList, Func<ST_c6c92e08cc1756053230783f07370fc0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d3f6c2b51c648237437bbf55ca4e447(ST_c6c92e08cc1756053230783f07370fc0Structure[] array) {
  RL_3d3f6c2b51c648237437bbf55ca4e447 result = new RL_3d3f6c2b51c648237437bbf55ca4e447();
result.InnerFromArray(array);
    return result;
}

public static RL_3d3f6c2b51c648237437bbf55ca4e447 ToList<T>(T[] array, Func <T, ST_c6c92e08cc1756053230783f07370fc0Structure> converter) {
  RL_3d3f6c2b51c648237437bbf55ca4e447 result = new RL_3d3f6c2b51c648237437bbf55ca4e447();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d3f6c2b51c648237437bbf55ca4e447 FromRestList<T>(RestList<T> restList, Func <T, ST_c6c92e08cc1756053230783f07370fc0Structure> converter) {
  RL_3d3f6c2b51c648237437bbf55ca4e447 result = new RL_3d3f6c2b51c648237437bbf55ca4e447();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d3f6c2b51c648237437bbf55ca4e447() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_c6c92e08cc1756053230783f07370fc0Structure> NewList() {
return new RL_3d3f6c2b51c648237437bbf55ca4e447();
}


} // RL_3d3f6c2b51c648237437bbf55ca4e447
}


namespace ssRuntimeDestroyer {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTEmployee2 {
[JsonProperty("id")]
public string restid;

[JsonProperty("name")]
public string restname;

[JsonProperty("color")]
public string restcolor;

public RESTEmployee2() { }

public RESTEmployee2(ST_c6c92e08cc1756053230783f07370fc0Structure s) {
restid = s.ssid == "" ? null : s.ssid;
restname = s.ssname == "" ? null : s.ssname;
restcolor = s.sscolor == (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue ? null : s.sscolor;
}

public static ST_c6c92e08cc1756053230783f07370fc0Structure ToStructure(RESTEmployee2 obj) { 
  ST_c6c92e08cc1756053230783f07370fc0Structure s = new ST_c6c92e08cc1756053230783f07370fc0Structure();
  if(obj != null) {
  s.ssid = obj.restid == null ? "" : obj.restid;
  s.ssname = obj.restname == null ? "" : obj.restname;
  s.sscolor = obj.restcolor == null ? (ENEnum_colorEntity.GetRecordByKey(ObjectKey.Parse("S_YdImXjJECSohfJCzEYMw"))).ssValue : obj.restcolor;
  }
  return s;
}

public static RESTEmployee2 FromStructure(ST_c6c92e08cc1756053230783f07370fc0Structure s) { 
  return new RESTEmployee2(s);
}

}
}
