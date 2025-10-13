using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] RuntimeType (64ECB3l5wUuxUhWl1Ubk4A) <code>ENRuntimeTypeEntityRecord</code> that
///  represents <code>RuntimeType</code> <p>Description: Module and application type.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("RuntimeType","64ECB3l5wUuxUhWl1Ubk4A","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: RuntimeType
public partial struct ENRuntimeTypeEntityRecord : ITypedRecord<ENRuntimeTypeEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*WrPiFCohh02Yx3q3oWfiaw");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*g7Cqf71lKkeSWgWSoJpzpQ");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*9QwV_Eqg_0qHELoqpIq31Q");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*RkWlwdJfOUePkF+YJo3JLA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL",50,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Label")]
private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssLabel = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ORDER",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Order")]
private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrder = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ISACTIVE",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("IsActive")]
private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsActive = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENRuntimeTypeEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = "";
_ssLabel = "";
_ssOrder = 0;
_ssIsActive = false;
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
ssId = r.ReadText(index++, "RuntimeType.Id", "");
ssLabel = r.ReadText(index++, "RuntimeType.Label", "");
ssOrder = r.ReadInteger(index++, "RuntimeType.Order", 0);
ssIsActive = r.ReadBoolean(index++, "RuntimeType.IsActive", false);
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(ENRuntimeTypeEntityRecord r) {
this = r;
}


public static bool operator == (ENRuntimeTypeEntityRecord a, ENRuntimeTypeEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIsActive != b.ssIsActive) return false;
return true;
}

public static bool operator != (ENRuntimeTypeEntityRecord a, ENRuntimeTypeEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENRuntimeTypeEntityRecord)) return false;
return (this == (ENRuntimeTypeEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIsActive.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENRuntimeTypeEntityRecord Duplicate() {
ENRuntimeTypeEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIsActive = this._ssIsActive;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdIsActive) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
}
} // ENRuntimeTypeEntityRecord

/// <summary>
/// RecordList type <code>RuntimeTypeList</code> that represents a record list of
///  <code>RuntimeType</code>
/// </summary>
public partial class RLRuntimeTypeList : GenericRecordList<ENRuntimeTypeEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENRuntimeTypeEntityRecord GetElementDefaultValue() {
return new ENRuntimeTypeEntityRecord();
}

public T[] ToArray<T>(Func<ENRuntimeTypeEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLRuntimeTypeList recordList, Func<ENRuntimeTypeEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLRuntimeTypeList(ENRuntimeTypeEntityRecord[] array) {
  RLRuntimeTypeList result = new RLRuntimeTypeList();
result.InnerFromArray(array);
    return result;
}

public static RLRuntimeTypeList ToList<T>(T[] array, Func <T, ENRuntimeTypeEntityRecord> converter) {
  RLRuntimeTypeList result = new RLRuntimeTypeList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLRuntimeTypeList FromRestList<T>(RestList<T> restList, Func <T, ENRuntimeTypeEntityRecord> converter) {
  RLRuntimeTypeList result = new RLRuntimeTypeList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLRuntimeTypeList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENRuntimeTypeEntityRecord> NewList() {
return new RLRuntimeTypeList();
}


} // RLRuntimeTypeList
}
