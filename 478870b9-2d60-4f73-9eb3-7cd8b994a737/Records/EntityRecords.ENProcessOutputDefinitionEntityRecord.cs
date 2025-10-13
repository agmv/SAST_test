using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessOutputDefinition (uGgWITNbokurFfuG9zxbSw)
///  <code>ENProcessOutputDefinitionEntityRecord</code> that represent
/// s <code>ProcessOutputDefinition</code> <p>Description: Process output as defined in Service Studio.
///  Old process output definitions are kept as inactive.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessOutputDefinition","uGgWITNbokurFfuG9zxbSw","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessOutputDefinition
public partial struct ENProcessOutputDefinitionEntityRecord : ITypedRecord<ENProcessOutputDefinitionEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*8qKbOMnkRkKdeLH2Yu8sNQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*fO4WgM8Exk6XphObHrHrUg");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*4nrdECtvAk6_ZTm2N2I1Iw");
internal static readonly GlobalObjectKey IdProcessDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*haUAiidRukO+7kchiVMJlg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Z+MM4PyRwk6bKbSU50F5BQ");
internal static readonly GlobalObjectKey IdDataType = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*uXbbFaD2_0yQyvlWuMcbgQ");
internal static readonly GlobalObjectKey IdDefaultValue = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*VOgDKG+HVUO04P79HOxfSQ");
internal static readonly GlobalObjectKey IdForeignKeyEntityId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*9GFI73eXtUe8m0L7wvUDjQ");

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
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
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
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DESCRIPTION",2000,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Description")]
private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDescription = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ProcessDefinitionId")]
private int _ssProcessDefinitionId;
public int ssProcessDefinitionId{
  get{
      return _ssProcessDefinitionId;
  }
  set{
      if((_ssProcessDefinitionId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssProcessDefinitionId = value;
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
      if((_ssIsActive!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsActive = value;
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DEFAULTVALUE",2000,false,false,false,false)]
[System.Xml.Serialization.XmlElement("DefaultValue")]
private string _ssDefaultValue;
public string ssDefaultValue{
  get{
      return _ssDefaultValue;
  }
  set{
      if((_ssDefaultValue!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssDefaultValue = value;
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

public ENProcessOutputDefinitionEntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = "";
_ssName = "";
_ssDescription = "";
_ssProcessDefinitionId = 0;
_ssIsActive = false;
_ssDataType = "";
_ssDefaultValue = "";
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
ssId = r.ReadText(index++, "ProcessOutputDefinition.Id", "");
ssName = r.ReadText(index++, "ProcessOutputDefinition.Name", "");
ssDescription = r.ReadText(index++, "ProcessOutputDefinition.Description", "");
ssProcessDefinitionId = r.ReadEntityReference(index++, "ProcessOutputDefinition.ProcessDefinitionId", 0);
ssIsActive = r.ReadBoolean(index++, "ProcessOutputDefinition.IsActive", false);
ssDataType = r.ReadText(index++, "ProcessOutputDefinition.DataType", "");
ssDefaultValue = r.ReadText(index++, "ProcessOutputDefinition.DefaultValue", "");
ssForeignKeyEntityId = r.ReadEntityReferenceText(index++, "ProcessOutputDefinition.ForeignKeyEntityId", "");
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
public void ReadIM(ENProcessOutputDefinitionEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessOutputDefinitionEntityRecord a, ENProcessOutputDefinitionEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssProcessDefinitionId != b.ssProcessDefinitionId) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssDataType != b.ssDataType) return false;
if (a.ssDefaultValue != b.ssDefaultValue) return false;
if (a.ssForeignKeyEntityId != b.ssForeignKeyEntityId) return false;
return true;
}

public static bool operator != (ENProcessOutputDefinitionEntityRecord a, ENProcessOutputDefinitionEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessOutputDefinitionEntityRecord)) return false;
return (this == (ENProcessOutputDefinitionEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssProcessDefinitionId.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssDataType.GetHashCode()
 ^ ssDefaultValue.GetHashCode()
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


public ENProcessOutputDefinitionEntityRecord Duplicate() {
ENProcessOutputDefinitionEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssDescription = this._ssDescription;
t._ssProcessDefinitionId = this._ssProcessDefinitionId;
t._ssIsActive = this._ssIsActive;
t._ssDataType = this._ssDataType;
t._ssDefaultValue = this._ssDefaultValue;
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "processdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinitionId")) variable.Value = ssProcessDefinitionId; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "datatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DataType")) variable.Value = ssDataType; else variable.Optimized = true;
} else if (head == "defaultvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DefaultValue")) variable.Value = ssDefaultValue; else variable.Optimized = true;
} else if (head == "foreignkeyentityid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ForeignKeyEntityId")) variable.Value = ssForeignKeyEntityId; else variable.Optimized = true;
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
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProcessDefinitionId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDataType)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDefaultValue)) {
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
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProcessDefinitionId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDataType)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDefaultValue)) {
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
if (key == IdName) {
return ssName;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdProcessDefinitionId) {
return ssProcessDefinitionId;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdDataType) {
return ssDataType;
}
if (key == IdDefaultValue) {
return ssDefaultValue;
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
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdProcessDefinitionId.Key.AsGuid) {
return ssProcessDefinitionId;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdDataType.Key.AsGuid) {
return ssDataType;
}
if (attributeKey == IdDefaultValue.Key.AsGuid) {
return ssDefaultValue;
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
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssProcessDefinitionId = (int) other.AttributeGet(IdProcessDefinitionId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProcessDefinitionId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProcessDefinitionId);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsActive);
ssDataType = (string) other.AttributeGet(IdDataType);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDataType);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDataType);
ssDefaultValue = (string) other.AttributeGet(IdDefaultValue);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDefaultValue);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDefaultValue);
ssForeignKeyEntityId = (string) other.AttributeGet(IdForeignKeyEntityId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdForeignKeyEntityId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdForeignKeyEntityId);
}
} // ENProcessOutputDefinitionEntityRecord

/// <summary>
/// RecordList type <code>ProcessOutputDefinitionList</code> that represents a record list of
///  <code>ProcessOutputDefinition</code>
/// </summary>
public partial class RLProcessOutputDefinitionList : GenericRecordList<ENProcessOutputDefinitionEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessOutputDefinitionEntityRecord GetElementDefaultValue() {
return new ENProcessOutputDefinitionEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessOutputDefinitionEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessOutputDefinitionList recordList, Func<ENProcessOutputDefinitionEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessOutputDefinitionList(ENProcessOutputDefinitionEntityRecord[] array) {
  RLProcessOutputDefinitionList result = new RLProcessOutputDefinitionList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessOutputDefinitionList ToList<T>(T[] array, Func <T, ENProcessOutputDefinitionEntityRecord> converter) {
  RLProcessOutputDefinitionList result = new RLProcessOutputDefinitionList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessOutputDefinitionList FromRestList<T>(RestList<T> restList, Func <T, ENProcessOutputDefinitionEntityRecord> converter) {
  RLProcessOutputDefinitionList result = new RLProcessOutputDefinitionList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessOutputDefinitionList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessOutputDefinitionEntityRecord> NewList() {
return new RLProcessOutputDefinitionList();
}


} // RLProcessOutputDefinitionList
}
