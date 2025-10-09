using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessInput (L1iabTpgakid99QGT8EUmg) <code>ENProcessInputEntityRecord</code> that
///  represents <code>ProcessInput</code> <p>Description: Process instances input value.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessInput","L1iabTpgakid99QGT8EUmg","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessInput
public partial struct ENProcessInputEntityRecord : ITypedRecord<ENProcessInputEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*M+i1Grx41UCUEHRohsYrqA");
internal static readonly GlobalObjectKey IdProcessId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*iFXF33d28kWpZcrNBgBbTw");
internal static readonly GlobalObjectKey IdInputDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*PNgw7Fzy0EC8HHjMLW6bCQ");
internal static readonly GlobalObjectKey IdInputDefinitionKey = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*CnsCdesSK06K7291JEcAcA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*BjwI5qq7SkCR+k6T4DT2Dw");
internal static readonly GlobalObjectKey IdDataType = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Z_mjYuIVO0euHnQQhF6nbA");
internal static readonly GlobalObjectKey IdInputValue = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*c7Au3J3T8kKBrNSqk5EWZw");
internal static readonly GlobalObjectKey IdForeignKeyEntityId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*iJc+tf5+3keRM2UhtcZBKA");

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
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ProcessId")]
private long _ssProcessId;
public long ssProcessId{
  get{
      return _ssProcessId;
  }
  set{
      if((_ssProcessId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProcessId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("INPUTDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("InputDefinitionId")]
private string _ssInputDefinitionId;
public string ssInputDefinitionId{
  get{
      return _ssInputDefinitionId;
  }
  set{
      if((_ssInputDefinitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInputDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("INPUTDEFINITIONKEY",100,false,false,false,true)]
[System.Xml.Serialization.XmlElement("InputDefinitionKey")]
private string _ssInputDefinitionKey;
public string ssInputDefinitionKey{
  get{
      return _ssInputDefinitionKey;
  }
  set{
      if((_ssInputDefinitionKey!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssInputDefinitionKey = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",100,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Name")]
private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssName = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DATATYPE",50,false,false,false,true)]
[System.Xml.Serialization.XmlElement("DataType")]
private string _ssDataType;
public string ssDataType{
  get{
      return _ssDataType;
  }
  set{
      if((_ssDataType!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDataType = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("INPUTVALUE",2000,false,false,false,false)]
[System.Xml.Serialization.XmlElement("InputValue")]
private string _ssInputValue;
public string ssInputValue{
  get{
      return _ssInputValue;
  }
  set{
      if((_ssInputValue!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssInputValue = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FOREIGNKEYENTITYID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ForeignKeyEntityId")]
private string _ssForeignKeyEntityId;
public string ssForeignKeyEntityId{
  get{
      return _ssForeignKeyEntityId;
  }
  set{
      if((_ssForeignKeyEntityId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssForeignKeyEntityId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENProcessInputEntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssProcessId = 0L;
_ssInputDefinitionId = "";
_ssInputDefinitionKey = "";
_ssName = "";
_ssDataType = "";
_ssInputValue = "";
_ssForeignKeyEntityId = "";
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
ssId = r.ReadLongInteger(index++, "ProcessInput.Id", 0L);
ssProcessId = r.ReadEntityReferenceLongInteger(index++, "ProcessInput.ProcessId", 0L);
ssInputDefinitionId = r.ReadEntityReferenceText(index++, "ProcessInput.InputDefinitionId", "");
ssInputDefinitionKey = r.ReadText(index++, "ProcessInput.InputDefinitionKey", "");
ssName = r.ReadText(index++, "ProcessInput.Name", "");
ssDataType = r.ReadText(index++, "ProcessInput.DataType", "");
ssInputValue = r.ReadText(index++, "ProcessInput.InputValue", "");
ssForeignKeyEntityId = r.ReadEntityReferenceText(index++, "ProcessInput.ForeignKeyEntityId", "");
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(ENProcessInputEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessInputEntityRecord a, ENProcessInputEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessId != b.ssProcessId) return false;
if (a.ssInputDefinitionId != b.ssInputDefinitionId) return false;
if (a.ssInputDefinitionKey != b.ssInputDefinitionKey) return false;
if (a.ssName != b.ssName) return false;
if (a.ssDataType != b.ssDataType) return false;
if (a.ssInputValue != b.ssInputValue) return false;
if (a.ssForeignKeyEntityId != b.ssForeignKeyEntityId) return false;
return true;
}

public static bool operator != (ENProcessInputEntityRecord a, ENProcessInputEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessInputEntityRecord)) return false;
return (this == (ENProcessInputEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessId.GetHashCode()
 ^ ssInputDefinitionId.GetHashCode()
 ^ ssInputDefinitionKey.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssDataType.GetHashCode()
 ^ ssInputValue.GetHashCode()
 ^ ssForeignKeyEntityId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENProcessInputEntityRecord Duplicate() {
ENProcessInputEntityRecord t;
t._ssId = this._ssId;
t._ssProcessId = this._ssProcessId;
t._ssInputDefinitionId = this._ssInputDefinitionId;
t._ssInputDefinitionKey = this._ssInputDefinitionKey;
t._ssName = this._ssName;
t._ssDataType = this._ssDataType;
t._ssInputValue = this._ssInputValue;
t._ssForeignKeyEntityId = this._ssForeignKeyEntityId;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "processid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessId")) variable.Value = ssProcessId; else variable.Optimized = true;
} else if (head == "inputdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InputDefinitionId")) variable.Value = ssInputDefinitionId; else variable.Optimized = true;
} else if (head == "inputdefinitionkey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InputDefinitionKey")) variable.Value = ssInputDefinitionKey; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "datatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DataType")) variable.Value = ssDataType; else variable.Optimized = true;
} else if (head == "inputvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InputValue")) variable.Value = ssInputValue; else variable.Optimized = true;
} else if (head == "foreignkeyentityid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ForeignKeyEntityId")) variable.Value = ssForeignKeyEntityId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProcessId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdInputDefinitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdInputDefinitionKey)) {
return ChangedAttributes[3];
}
if (key.Equals(IdName)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDataType)) {
return ChangedAttributes[5];
}
if (key.Equals(IdInputValue)) {
return ChangedAttributes[6];
}
if (key.Equals(IdForeignKeyEntityId)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProcessId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdInputDefinitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdInputDefinitionKey)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDataType)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdInputValue)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdForeignKeyEntityId)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProcessId) {
return ssProcessId;
}
if (key == IdInputDefinitionId) {
return ssInputDefinitionId;
}
if (key == IdInputDefinitionKey) {
return ssInputDefinitionKey;
}
if (key == IdName) {
return ssName;
}
if (key == IdDataType) {
return ssDataType;
}
if (key == IdInputValue) {
return ssInputValue;
}
if (key == IdForeignKeyEntityId) {
return ssForeignKeyEntityId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProcessId.Key.AsGuid) {
return ssProcessId;
}
if (attributeKey == IdInputDefinitionId.Key.AsGuid) {
return ssInputDefinitionId;
}
if (attributeKey == IdInputDefinitionKey.Key.AsGuid) {
return ssInputDefinitionKey;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdDataType.Key.AsGuid) {
return ssDataType;
}
if (attributeKey == IdInputValue.Key.AsGuid) {
return ssInputValue;
}
if (attributeKey == IdForeignKeyEntityId.Key.AsGuid) {
return ssForeignKeyEntityId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProcessId = (long) other.AttributeGet(IdProcessId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProcessId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProcessId);
ssInputDefinitionId = (string) other.AttributeGet(IdInputDefinitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInputDefinitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInputDefinitionId);
ssInputDefinitionKey = (string) other.AttributeGet(IdInputDefinitionKey);
ChangedAttributes[3] = other.ChangedAttributeGet(IdInputDefinitionKey);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInputDefinitionKey);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[4] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdName);
ssDataType = (string) other.AttributeGet(IdDataType);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDataType);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDataType);
ssInputValue = (string) other.AttributeGet(IdInputValue);
ChangedAttributes[6] = other.ChangedAttributeGet(IdInputValue);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdInputValue);
ssForeignKeyEntityId = (string) other.AttributeGet(IdForeignKeyEntityId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdForeignKeyEntityId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdForeignKeyEntityId);
}
} // ENProcessInputEntityRecord

/// <summary>
/// RecordList type <code>ProcessInputList</code> that represents a record list of
///  <code>ProcessInput</code>
/// </summary>
public partial class RLProcessInputList : GenericRecordList<ENProcessInputEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessInputEntityRecord GetElementDefaultValue() {
return new ENProcessInputEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessInputEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessInputList recordList, Func<ENProcessInputEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessInputList(ENProcessInputEntityRecord[] array) {
  RLProcessInputList result = new RLProcessInputList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessInputList ToList<T>(T[] array, Func <T, ENProcessInputEntityRecord> converter) {
  RLProcessInputList result = new RLProcessInputList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessInputList FromRestList<T>(RestList<T> restList, Func <T, ENProcessInputEntityRecord> converter) {
  RLProcessInputList result = new RLProcessInputList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessInputList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessInputEntityRecord> NewList() {
return new RLProcessInputList();
}


} // RLProcessInputList
}
