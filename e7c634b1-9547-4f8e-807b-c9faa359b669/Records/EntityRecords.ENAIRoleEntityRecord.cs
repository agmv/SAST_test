using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [SystemStaticEntity] AIRole (dRQ_8vzNJUiQ1G6liGqWgg) <code>ENAIRoleEntityRecord</code> that
///  represents <code>AIRole</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("AIRole","dRQ_8vzNJUiQ1G6liGqWgg","sTTG50eVjk+Ae8n6o1m2aQ", 0,"osvue_ai_role", null, false)]
// Name: AIRole
public partial struct ENAIRoleEntityRecord : ITypedRecord<ENAIRoleEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AtDcix7KUy3G8jV8e+YRg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_5GONvh21ES5Orm0koffNg");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,false,true,false,false)]
[System.Xml.Serialization.XmlElement("Id")]
private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
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


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENAIRoleEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssId = 0L;
_ssName = "";
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
ssId = r.ReadLongInteger(index++, "AIRole.Id", 0L);
ssName = r.ReadText(index++, "AIRole.Name", "");
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
public void ReadIM(ENAIRoleEntityRecord r) {
this = r;
}


public static bool operator == (ENAIRoleEntityRecord a, ENAIRoleEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (ENAIRoleEntityRecord a, ENAIRoleEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENAIRoleEntityRecord)) return false;
return (this == (ENAIRoleEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENAIRoleEntityRecord Duplicate() {
ENAIRoleEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
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
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
}
} // ENAIRoleEntityRecord

/// <summary>
/// RecordList type <code>AIRoleList</code> that represents a record list of <code>AIRole</code>
/// </summary>
public partial class RLAIRoleList : GenericRecordList<ENAIRoleEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENAIRoleEntityRecord GetElementDefaultValue() {
return new ENAIRoleEntityRecord();
}

public T[] ToArray<T>(Func<ENAIRoleEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIRoleList recordList, Func<ENAIRoleEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIRoleList(ENAIRoleEntityRecord[] array) {
  RLAIRoleList result = new RLAIRoleList();
result.InnerFromArray(array);
    return result;
}

public static RLAIRoleList ToList<T>(T[] array, Func <T, ENAIRoleEntityRecord> converter) {
  RLAIRoleList result = new RLAIRoleList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIRoleList FromRestList<T>(RestList<T> restList, Func <T, ENAIRoleEntityRecord> converter) {
  RLAIRoleList result = new RLAIRoleList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIRoleList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENAIRoleEntityRecord> NewList() {
return new RLAIRoleList();
}


} // RLAIRoleList
}
