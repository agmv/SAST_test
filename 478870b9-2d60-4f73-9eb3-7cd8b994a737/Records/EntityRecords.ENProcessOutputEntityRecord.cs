using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessOutput (UUSklClK2UKNHDmfYU_dig) <code>ENProcessOutputEntityRecord</code> that
///  represents <code>ProcessOutput</code> <p>Description: Process instances output effectiv
/// e value.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessOutput","UUSklClK2UKNHDmfYU_dig","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessOutput
public partial struct ENProcessOutputEntityRecord : ITypedRecord<ENProcessOutputEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*NPPmyrsVTkyWaZ8kDL9vsA");
internal static readonly GlobalObjectKey IdProcessId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*ybBpipWYXkGnyqTElOQEkg");
internal static readonly GlobalObjectKey IdOutputDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*LLdoZnQtQEixQ0cqT7FZ8g");
internal static readonly GlobalObjectKey IdOutputDefinitionKey = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*w8fIH6qhck6iWXxAr6z5Lw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*sp+in5K+REWm7exdj69E_w");
internal static readonly GlobalObjectKey IdDataType = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*93uJvw89k0m3RvoHVJiWQQ");
internal static readonly GlobalObjectKey IdOutputValue = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*C1cmwBHquEmYOyzdez2KTQ");
internal static readonly GlobalObjectKey IdForeignKeyEntityId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*26J3RMGFw0CqiqZSOyZKyw");

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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSID",0,false,false,true,false)]
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("OUTPUTDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("OutputDefinitionId")]
private string _ssOutputDefinitionId;
public string ssOutputDefinitionId{
  get{
      return _ssOutputDefinitionId;
  }
  set{
      if((_ssOutputDefinitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOutputDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("OUTPUTDEFINITIONKEY",100,false,false,false,true)]
[System.Xml.Serialization.XmlElement("OutputDefinitionKey")]
private string _ssOutputDefinitionKey;
public string ssOutputDefinitionKey{
  get{
      return _ssOutputDefinitionKey;
  }
  set{
      if((_ssOutputDefinitionKey!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOutputDefinitionKey = value;
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("OUTPUTVALUE",2000,false,false,false,false)]
[System.Xml.Serialization.XmlElement("OutputValue")]
private string _ssOutputValue;
public string ssOutputValue{
  get{
      return _ssOutputValue;
  }
  set{
      if((_ssOutputValue!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssOutputValue = value;
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

public ENProcessOutputEntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssProcessId = 0L;
_ssOutputDefinitionId = "";
_ssOutputDefinitionKey = "";
_ssName = "";
_ssDataType = "";
_ssOutputValue = "";
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
ssId = r.ReadLongInteger(index++, "ProcessOutput.Id", 0L);
ssProcessId = r.ReadEntityReferenceLongInteger(index++, "ProcessOutput.ProcessId", 0L);
ssOutputDefinitionId = r.ReadEntityReferenceText(index++, "ProcessOutput.OutputDefinitionId", "");
ssOutputDefinitionKey = r.ReadText(index++, "ProcessOutput.OutputDefinitionKey", "");
ssName = r.ReadText(index++, "ProcessOutput.Name", "");
ssDataType = r.ReadText(index++, "ProcessOutput.DataType", "");
ssOutputValue = r.ReadText(index++, "ProcessOutput.OutputValue", "");
ssForeignKeyEntityId = r.ReadEntityReferenceText(index++, "ProcessOutput.ForeignKeyEntityId", "");
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
public void ReadIM(ENProcessOutputEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessOutputEntityRecord a, ENProcessOutputEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessId != b.ssProcessId) return false;
if (a.ssOutputDefinitionId != b.ssOutputDefinitionId) return false;
if (a.ssOutputDefinitionKey != b.ssOutputDefinitionKey) return false;
if (a.ssName != b.ssName) return false;
if (a.ssDataType != b.ssDataType) return false;
if (a.ssOutputValue != b.ssOutputValue) return false;
if (a.ssForeignKeyEntityId != b.ssForeignKeyEntityId) return false;
return true;
}

public static bool operator != (ENProcessOutputEntityRecord a, ENProcessOutputEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessOutputEntityRecord)) return false;
return (this == (ENProcessOutputEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessId.GetHashCode()
 ^ ssOutputDefinitionId.GetHashCode()
 ^ ssOutputDefinitionKey.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssDataType.GetHashCode()
 ^ ssOutputValue.GetHashCode()
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


public ENProcessOutputEntityRecord Duplicate() {
ENProcessOutputEntityRecord t;
t._ssId = this._ssId;
t._ssProcessId = this._ssProcessId;
t._ssOutputDefinitionId = this._ssOutputDefinitionId;
t._ssOutputDefinitionKey = this._ssOutputDefinitionKey;
t._ssName = this._ssName;
t._ssDataType = this._ssDataType;
t._ssOutputValue = this._ssOutputValue;
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
} else if (head == "outputdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OutputDefinitionId")) variable.Value = ssOutputDefinitionId; else variable.Optimized = true;
} else if (head == "outputdefinitionkey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OutputDefinitionKey")) variable.Value = ssOutputDefinitionKey; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "datatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DataType")) variable.Value = ssDataType; else variable.Optimized = true;
} else if (head == "outputvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OutputValue")) variable.Value = ssOutputValue; else variable.Optimized = true;
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
if (key.Equals(IdOutputDefinitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOutputDefinitionKey)) {
return ChangedAttributes[3];
}
if (key.Equals(IdName)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDataType)) {
return ChangedAttributes[5];
}
if (key.Equals(IdOutputValue)) {
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
if (key.Equals(IdOutputDefinitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOutputDefinitionKey)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDataType)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdOutputValue)) {
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
if (key == IdOutputDefinitionId) {
return ssOutputDefinitionId;
}
if (key == IdOutputDefinitionKey) {
return ssOutputDefinitionKey;
}
if (key == IdName) {
return ssName;
}
if (key == IdDataType) {
return ssDataType;
}
if (key == IdOutputValue) {
return ssOutputValue;
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
if (attributeKey == IdOutputDefinitionId.Key.AsGuid) {
return ssOutputDefinitionId;
}
if (attributeKey == IdOutputDefinitionKey.Key.AsGuid) {
return ssOutputDefinitionKey;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdDataType.Key.AsGuid) {
return ssDataType;
}
if (attributeKey == IdOutputValue.Key.AsGuid) {
return ssOutputValue;
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
ssOutputDefinitionId = (string) other.AttributeGet(IdOutputDefinitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOutputDefinitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOutputDefinitionId);
ssOutputDefinitionKey = (string) other.AttributeGet(IdOutputDefinitionKey);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOutputDefinitionKey);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOutputDefinitionKey);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[4] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdName);
ssDataType = (string) other.AttributeGet(IdDataType);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDataType);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDataType);
ssOutputValue = (string) other.AttributeGet(IdOutputValue);
ChangedAttributes[6] = other.ChangedAttributeGet(IdOutputValue);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdOutputValue);
ssForeignKeyEntityId = (string) other.AttributeGet(IdForeignKeyEntityId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdForeignKeyEntityId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdForeignKeyEntityId);
}
} // ENProcessOutputEntityRecord

/// <summary>
/// RecordList type <code>ProcessOutputList</code> that represents a record list of
///  <code>ProcessOutput</code>
/// </summary>
public partial class RLProcessOutputList : GenericRecordList<ENProcessOutputEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessOutputEntityRecord GetElementDefaultValue() {
return new ENProcessOutputEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessOutputEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessOutputList recordList, Func<ENProcessOutputEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessOutputList(ENProcessOutputEntityRecord[] array) {
  RLProcessOutputList result = new RLProcessOutputList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessOutputList ToList<T>(T[] array, Func <T, ENProcessOutputEntityRecord> converter) {
  RLProcessOutputList result = new RLProcessOutputList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessOutputList FromRestList<T>(RestList<T> restList, Func <T, ENProcessOutputEntityRecord> converter) {
  RLProcessOutputList result = new RLProcessOutputList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessOutputList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessOutputEntityRecord> NewList() {
return new RLProcessOutputList();
}


} // RLProcessOutputList
}
