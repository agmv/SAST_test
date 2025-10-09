using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] Role (NuqV5Rtc2D6TqrunUsf4kg) <code>ENRoleEntityRecord</code> that represents
///  <code>Role</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Role","NuqV5Rtc2D6TqrunUsf4kg","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: Role
public partial struct ENRoleEntityRecord : ITypedRecord<ENRoleEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*_DJ_uUlSl4pvOGCY3MUm7g");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",100,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENRoleEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssId = "";
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
ssId = r.ReadText(index++, "Role.Id", "");
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(ENRoleEntityRecord r) {
this = r;
}


public static bool operator == (ENRoleEntityRecord a, ENRoleEntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (ENRoleEntityRecord a, ENRoleEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENRoleEntityRecord)) return false;
return (this == (ENRoleEntityRecord)o);
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


public ENRoleEntityRecord Duplicate() {
ENRoleEntityRecord t;
t._ssId = this._ssId;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
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
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
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
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
}
} // ENRoleEntityRecord

/// <summary>
/// RecordList type <code>RoleList</code> that represents a record list of <code>Role</code>
/// </summary>
public partial class RLRoleList : GenericRecordList<ENRoleEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENRoleEntityRecord GetElementDefaultValue() {
return new ENRoleEntityRecord();
}

public T[] ToArray<T>(Func<ENRoleEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLRoleList recordList, Func<ENRoleEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLRoleList(ENRoleEntityRecord[] array) {
  RLRoleList result = new RLRoleList();
result.InnerFromArray(array);
    return result;
}

public static RLRoleList ToList<T>(T[] array, Func <T, ENRoleEntityRecord> converter) {
  RLRoleList result = new RLRoleList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLRoleList FromRestList<T>(RestList<T> restList, Func <T, ENRoleEntityRecord> converter) {
  RLRoleList result = new RLRoleList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLRoleList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENRoleEntityRecord> NewList() {
return new RLRoleList();
}


} // RLRoleList
}
