using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ActivityDefinitionRole (Nfnl27Uj0EdUb96bnubFyA)
///  <code>ENActivityDefinitionRoleEntityRecord</code> that represent
/// s <code>ActivityDefinitionRole</code> <p>Description: Process activity as defined in Service Studio
///  containing only roles for current model.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ActivityDefinitionRole","Nfnl27Uj0EdUb96bnubFyA","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ActivityDefinitionRole
public partial struct ENActivityDefinitionRoleEntityRecord : ITypedRecord<ENActivityDefinitionRoleEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*E+vxHmkI_fE1nCfYQ8SavA");
internal static readonly GlobalObjectKey IdRoleId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*avkrSfh7bYU13ulSjz+tDA");
internal static readonly GlobalObjectKey IdActivityDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*6RgWg+0vQTodmPFQj40nAA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,true,true,false,true)]
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ROLEID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("RoleId")]
private string _ssRoleId;
public string ssRoleId{
  get{
      return _ssRoleId;
  }
  set{
      if((_ssRoleId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRoleId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ACTIVITYDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ActivityDefinitionId")]
private int _ssActivityDefinitionId;
public int ssActivityDefinitionId{
  get{
      return _ssActivityDefinitionId;
  }
  set{
      if((_ssActivityDefinitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssActivityDefinitionId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENActivityDefinitionRoleEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssRoleId = "";
_ssActivityDefinitionId = 0;
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
ssId = r.ReadLongInteger(index++, "ActivityDefinitionRole.Id", 0L);
ssRoleId = r.ReadEntityReferenceText(index++, "ActivityDefinitionRole.RoleId", "");
ssActivityDefinitionId = r.ReadEntityReference(index++, "ActivityDefinitionRole.ActivityDefinitionId", 0);
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
public void ReadIM(ENActivityDefinitionRoleEntityRecord r) {
this = r;
}


public static bool operator == (ENActivityDefinitionRoleEntityRecord a, ENActivityDefinitionRoleEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRoleId != b.ssRoleId) return false;
if (a.ssActivityDefinitionId != b.ssActivityDefinitionId) return false;
return true;
}

public static bool operator != (ENActivityDefinitionRoleEntityRecord a, ENActivityDefinitionRoleEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENActivityDefinitionRoleEntityRecord)) return false;
return (this == (ENActivityDefinitionRoleEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRoleId.GetHashCode()
 ^ ssActivityDefinitionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENActivityDefinitionRoleEntityRecord Duplicate() {
ENActivityDefinitionRoleEntityRecord t;
t._ssId = this._ssId;
t._ssRoleId = this._ssRoleId;
t._ssActivityDefinitionId = this._ssActivityDefinitionId;
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
} else if (head == "roleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleId")) variable.Value = ssRoleId; else variable.Optimized = true;
} else if (head == "activitydefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionId")) variable.Value = ssActivityDefinitionId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRoleId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdActivityDefinitionId)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRoleId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdActivityDefinitionId)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRoleId) {
return ssRoleId;
}
if (key == IdActivityDefinitionId) {
return ssActivityDefinitionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRoleId.Key.AsGuid) {
return ssRoleId;
}
if (attributeKey == IdActivityDefinitionId.Key.AsGuid) {
return ssActivityDefinitionId;
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
ssRoleId = (string) other.AttributeGet(IdRoleId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRoleId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRoleId);
ssActivityDefinitionId = (int) other.AttributeGet(IdActivityDefinitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdActivityDefinitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdActivityDefinitionId);
}
} // ENActivityDefinitionRoleEntityRecord

/// <summary>
/// RecordList type <code>ActivityDefinitionRoleList</code> that represents a record list of
///  <code>ActivityDefinitionRole</code>
/// </summary>
public partial class RLActivityDefinitionRoleList : GenericRecordList<ENActivityDefinitionRoleEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENActivityDefinitionRoleEntityRecord GetElementDefaultValue() {
return new ENActivityDefinitionRoleEntityRecord();
}

public T[] ToArray<T>(Func<ENActivityDefinitionRoleEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLActivityDefinitionRoleList recordList, Func<ENActivityDefinitionRoleEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLActivityDefinitionRoleList(ENActivityDefinitionRoleEntityRecord[] array) {
  RLActivityDefinitionRoleList result = new RLActivityDefinitionRoleList();
result.InnerFromArray(array);
    return result;
}

public static RLActivityDefinitionRoleList ToList<T>(T[] array, Func <T, ENActivityDefinitionRoleEntityRecord> converter) {
  RLActivityDefinitionRoleList result = new RLActivityDefinitionRoleList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLActivityDefinitionRoleList FromRestList<T>(RestList<T> restList, Func <T, ENActivityDefinitionRoleEntityRecord> converter) {
  RLActivityDefinitionRoleList result = new RLActivityDefinitionRoleList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLActivityDefinitionRoleList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENActivityDefinitionRoleEntityRecord> NewList() {
return new RLActivityDefinitionRoleList();
}


} // RLActivityDefinitionRoleList
}
