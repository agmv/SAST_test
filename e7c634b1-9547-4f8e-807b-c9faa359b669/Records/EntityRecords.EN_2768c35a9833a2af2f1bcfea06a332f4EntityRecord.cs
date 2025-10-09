using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [Entity] Employee (vveL5Hud5k6hByqjemU1GA)
///  <code>EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord</code> that represents <code>Employee</code
/// > <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Employee","vveL5Hud5k6hByqjemU1GA","sTTG50eVjk+Ae8n6o1m2aQ", 0,"emplo_jf1oovmiqpmq7ahjd1zol050", null, false)]
// Name: Employee
public partial struct EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord : ITypedRecord<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*obhiaDdgGk+uzwaBkl6KGQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*QocO9s4QvEW17oneWcBrfw");
internal static readonly GlobalObjectKey IdAge = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*irDody81Z0inLTilj4HcTg");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",50,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Name")]
private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("AGE",50,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Age")]
private string _ssAge;
public string ssAge{
  get{
      return _ssAge;
  }
  set{
      if((_ssAge!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAge = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssName = "";
_ssAge = "";
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
ssId = r.ReadLongInteger(index++, "Employee.Id", 0L);
ssName = r.ReadText(index++, "Employee.Name", "");
ssAge = r.ReadText(index++, "Employee.Age", "");
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord r) {
this = r;
}


public static bool operator == (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord a, EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssAge != b.ssAge) return false;
return true;
}

public static bool operator != (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord a, EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord)) return false;
return (this == (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssAge.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord Duplicate() {
EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssAge = this._ssAge;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "age") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Age")) variable.Value = ssAge; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdAge)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdAge)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdAge) {
return ssAge;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdAge.Key.AsGuid) {
return ssAge;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssAge = (string) other.AttributeGet(IdAge);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAge);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAge);
}
} // EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord

/// <summary>
/// RecordList type <code>EmployeeList</code> that represents a record list of <code>Employee</code>
/// </summary>
public partial class RL_2cc0a97674d168277d40d31b4056bb04 : GenericRecordList<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord GetElementDefaultValue() {
return new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();
}

public T[] ToArray<T>(Func<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2cc0a97674d168277d40d31b4056bb04 recordList, Func<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2cc0a97674d168277d40d31b4056bb04(EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord[] array) {
  RL_2cc0a97674d168277d40d31b4056bb04 result = new RL_2cc0a97674d168277d40d31b4056bb04();
result.InnerFromArray(array);
    return result;
}

public static RL_2cc0a97674d168277d40d31b4056bb04 ToList<T>(T[] array, Func <T, EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> converter) {
  RL_2cc0a97674d168277d40d31b4056bb04 result = new RL_2cc0a97674d168277d40d31b4056bb04();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2cc0a97674d168277d40d31b4056bb04 FromRestList<T>(RestList<T> restList, Func <T, EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> converter) {
  RL_2cc0a97674d168277d40d31b4056bb04 result = new RL_2cc0a97674d168277d40d31b4056bb04();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2cc0a97674d168277d40d31b4056bb04() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord> NewList() {
return new RL_2cc0a97674d168277d40d31b4056bb04();
}


} // RL_2cc0a97674d168277d40d31b4056bb04
}
