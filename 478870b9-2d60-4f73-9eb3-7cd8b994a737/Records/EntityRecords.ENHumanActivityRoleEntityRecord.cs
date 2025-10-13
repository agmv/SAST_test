using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] HumanActivityRole (EdDHubQ18Uuct9STZ5+3KQ) <code>ENHumanActivityRoleEntityRecord</code>
///  that represents <code>HumanActivityRole</code> <p>Description: Entity that stores th
/// e ActivityInstanceId and the RoleId each time a human activity is assigned to a role.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("HumanActivityRole","EdDHubQ18Uuct9STZ5+3KQ","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: HumanActivityRole
public partial struct ENHumanActivityRoleEntityRecord : ITypedRecord<ENHumanActivityRoleEntityRecord> {
internal static readonly GlobalObjectKey IdActivityInstanceId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*dhg7x+ns+EaxSkR+ggRpbA");
internal static readonly GlobalObjectKey IdRoleId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*LmH82+DvVkCdfDPqlePFNQ");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ACTIVITYINSTANCEID",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("ActivityInstanceId")]
private long _ssActivityInstanceId;
public long ssActivityInstanceId{
  get{
      return _ssActivityInstanceId;
  }
  set{
      if((_ssActivityInstanceId!=value) || OptimizedAttributes[0]){
          ChangedAttributes[0] = true;
          _ssActivityInstanceId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ROLEID",0,false,false,true,false)]
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


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENHumanActivityRoleEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssActivityInstanceId = 0L;
_ssRoleId = "";
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
ssActivityInstanceId = r.ReadEntityReferenceLongInteger(index++, "HumanActivityRole.ActivityInstanceId", 0L);
ssRoleId = r.ReadEntityReferenceText(index++, "HumanActivityRole.RoleId", "");
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(ENHumanActivityRoleEntityRecord r) {
this = r;
}


public static bool operator == (ENHumanActivityRoleEntityRecord a, ENHumanActivityRoleEntityRecord b) {
if (a.ssActivityInstanceId != b.ssActivityInstanceId) return false;
if (a.ssRoleId != b.ssRoleId) return false;
return true;
}

public static bool operator != (ENHumanActivityRoleEntityRecord a, ENHumanActivityRoleEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENHumanActivityRoleEntityRecord)) return false;
return (this == (ENHumanActivityRoleEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssActivityInstanceId.GetHashCode()
 ^ ssRoleId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENHumanActivityRoleEntityRecord Duplicate() {
ENHumanActivityRoleEntityRecord t;
t._ssActivityInstanceId = this._ssActivityInstanceId;
t._ssRoleId = this._ssRoleId;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
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
if (head == "activityinstanceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityInstanceId")) variable.Value = ssActivityInstanceId; else variable.Optimized = true;
} else if (head == "roleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleId")) variable.Value = ssRoleId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdActivityInstanceId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRoleId)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdActivityInstanceId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRoleId)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityInstanceId) {
return ssActivityInstanceId;
}
if (key == IdRoleId) {
return ssRoleId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityInstanceId.Key.AsGuid) {
return ssActivityInstanceId;
}
if (attributeKey == IdRoleId.Key.AsGuid) {
return ssRoleId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssActivityInstanceId = (long) other.AttributeGet(IdActivityInstanceId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdActivityInstanceId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdActivityInstanceId);
ssRoleId = (string) other.AttributeGet(IdRoleId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRoleId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRoleId);
}
} // ENHumanActivityRoleEntityRecord

/// <summary>
/// RecordList type <code>HumanActivityRoleList</code> that represents a record list of
///  <code>HumanActivityRole</code>
/// </summary>
public partial class RLHumanActivityRoleList : GenericRecordList<ENHumanActivityRoleEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENHumanActivityRoleEntityRecord GetElementDefaultValue() {
return new ENHumanActivityRoleEntityRecord();
}

public T[] ToArray<T>(Func<ENHumanActivityRoleEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLHumanActivityRoleList recordList, Func<ENHumanActivityRoleEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLHumanActivityRoleList(ENHumanActivityRoleEntityRecord[] array) {
  RLHumanActivityRoleList result = new RLHumanActivityRoleList();
result.InnerFromArray(array);
    return result;
}

public static RLHumanActivityRoleList ToList<T>(T[] array, Func <T, ENHumanActivityRoleEntityRecord> converter) {
  RLHumanActivityRoleList result = new RLHumanActivityRoleList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLHumanActivityRoleList FromRestList<T>(RestList<T> restList, Func <T, ENHumanActivityRoleEntityRecord> converter) {
  RLHumanActivityRoleList result = new RLHumanActivityRoleList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLHumanActivityRoleList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENHumanActivityRoleEntityRecord> NewList() {
return new RLHumanActivityRoleList();
}


} // RLHumanActivityRoleList
}
