using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ActivityOutputDefinition (jlQ+T5pS90ee6D+GaPAo5g)
///  <code>ENActivityOutputDefinitionEntityRecord</code> that represent
/// s <code>ActivityOutputDefinition</code> <p>Description: Process activity output parameter, as
///  defined in Service Studio. Older output definitions are inactive.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ActivityOutputDefinition","jlQ+T5pS90ee6D+GaPAo5g","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ActivityOutputDefinition
public partial struct ENActivityOutputDefinitionEntityRecord : ITypedRecord<ENActivityOutputDefinitionEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*kYckeLdAdkKPJ2py1w5Cqg");
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*z2usNNhXWE+LnIOJlblEBQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*UD8zLquInESqpFbNnOPnVA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*xAnf5HzAXUmxYUSM9DiYrA");
internal static readonly GlobalObjectKey IdActivityDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*y6dERSmbM0W7WX691VspMQ");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Eru5DlwsL0mI+K6l+dq7aA");
internal static readonly GlobalObjectKey IdDataType = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*7fOyTSOp3kmpk2F_JdDBqA");
internal static readonly GlobalObjectKey IdIsInput = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*+ArUB3D68kSpEQIvmVkrHA");
internal static readonly GlobalObjectKey IdIsMandatory = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*FWo9rGcTSEmgZTIkaz6zpw");
internal static readonly GlobalObjectKey IdDefaultValue = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*pQffZkJ6ZEuo4hBRI_lGFg");
internal static readonly GlobalObjectKey IdForeignKeyEntityId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*P0mMUVNbpkOGA1+mH5RyxA");

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
          ChangedAttributes = new BitArray(11,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("KEY",100,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Key")]
private string _ssKey;
public string ssKey{
  get{
      return _ssKey;
  }
  set{
      if((_ssKey!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssKey = value;
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
      if((_ssName!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
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
      if((_ssDescription!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssDescription = value;
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
      if((_ssActivityDefinitionId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssActivityDefinitionId = value;
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
      if((_ssIsActive!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssDataType!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssDataType = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ISINPUT",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("IsInput")]
private bool _ssIsInput;
public bool ssIsInput{
  get{
      return _ssIsInput;
  }
  set{
      if((_ssIsInput!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsInput = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ISMANDATORY",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("IsMandatory")]
private bool _ssIsMandatory;
public bool ssIsMandatory{
  get{
      return _ssIsMandatory;
  }
  set{
      if((_ssIsMandatory!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsMandatory = value;
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
      if((_ssDefaultValue!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssDefaultValue = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FOREIGNKEYENTITYID",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("ForeignKeyEntityId")]
private string _ssForeignKeyEntityId;
public string ssForeignKeyEntityId{
  get{
      return _ssForeignKeyEntityId;
  }
  set{
      if((_ssForeignKeyEntityId!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssForeignKeyEntityId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENActivityOutputDefinitionEntityRecord() {
ChangedAttributes = new BitArray(11,true);
OptimizedAttributes = new BitArray(11,false);
_ssId = "";
_ssKey = "";
_ssName = "";
_ssDescription = "";
_ssActivityDefinitionId = 0;
_ssIsActive = false;
_ssDataType = "";
_ssIsInput = false;
_ssIsMandatory = false;
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
ssId = r.ReadText(index++, "ActivityOutputDefinition.Id", "");
ssKey = r.ReadText(index++, "ActivityOutputDefinition.Key", "");
ssName = r.ReadText(index++, "ActivityOutputDefinition.Name", "");
ssDescription = r.ReadText(index++, "ActivityOutputDefinition.Description", "");
ssActivityDefinitionId = r.ReadEntityReference(index++, "ActivityOutputDefinition.ActivityDefinitionId", 0);
ssIsActive = r.ReadBoolean(index++, "ActivityOutputDefinition.IsActive", false);
ssDataType = r.ReadText(index++, "ActivityOutputDefinition.DataType", "");
ssIsInput = r.ReadBoolean(index++, "ActivityOutputDefinition.IsInput", false);
ssIsMandatory = r.ReadBoolean(index++, "ActivityOutputDefinition.IsMandatory", false);
ssDefaultValue = r.ReadText(index++, "ActivityOutputDefinition.DefaultValue", "");
ssForeignKeyEntityId = r.ReadEntityReferenceText(index++, "ActivityOutputDefinition.ForeignKeyEntityId", "");
ChangedAttributes = new BitArray(11,false);
OptimizedAttributes = new BitArray(11,false);
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
public void ReadIM(ENActivityOutputDefinitionEntityRecord r) {
this = r;
}


public static bool operator == (ENActivityOutputDefinitionEntityRecord a, ENActivityOutputDefinitionEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssKey != b.ssKey) return false;
if (a.ssName != b.ssName) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssActivityDefinitionId != b.ssActivityDefinitionId) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssDataType != b.ssDataType) return false;
if (a.ssIsInput != b.ssIsInput) return false;
if (a.ssIsMandatory != b.ssIsMandatory) return false;
if (a.ssDefaultValue != b.ssDefaultValue) return false;
if (a.ssForeignKeyEntityId != b.ssForeignKeyEntityId) return false;
return true;
}

public static bool operator != (ENActivityOutputDefinitionEntityRecord a, ENActivityOutputDefinitionEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENActivityOutputDefinitionEntityRecord)) return false;
return (this == (ENActivityOutputDefinitionEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssActivityDefinitionId.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssDataType.GetHashCode()
 ^ ssIsInput.GetHashCode()
 ^ ssIsMandatory.GetHashCode()
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


public ENActivityOutputDefinitionEntityRecord Duplicate() {
ENActivityOutputDefinitionEntityRecord t;
t._ssId = this._ssId;
t._ssKey = this._ssKey;
t._ssName = this._ssName;
t._ssDescription = this._ssDescription;
t._ssActivityDefinitionId = this._ssActivityDefinitionId;
t._ssIsActive = this._ssIsActive;
t._ssDataType = this._ssDataType;
t._ssIsInput = this._ssIsInput;
t._ssIsMandatory = this._ssIsMandatory;
t._ssDefaultValue = this._ssDefaultValue;
t._ssForeignKeyEntityId = this._ssForeignKeyEntityId;
t.ChangedAttributes = new BitArray(11);
t.OptimizedAttributes = new BitArray(11);
for(int i = 0; i < 11; i++){
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
} else if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "activitydefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionId")) variable.Value = ssActivityDefinitionId; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "datatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DataType")) variable.Value = ssDataType; else variable.Optimized = true;
} else if (head == "isinput") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsInput")) variable.Value = ssIsInput; else variable.Optimized = true;
} else if (head == "ismandatory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsMandatory")) variable.Value = ssIsMandatory; else variable.Optimized = true;
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
if (key.Equals(IdKey)) {
return ChangedAttributes[1];
}
if (key.Equals(IdName)) {
return ChangedAttributes[2];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[3];
}
if (key.Equals(IdActivityDefinitionId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDataType)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsInput)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIsMandatory)) {
return ChangedAttributes[8];
}
if (key.Equals(IdDefaultValue)) {
return ChangedAttributes[9];
}
if (key.Equals(IdForeignKeyEntityId)) {
return ChangedAttributes[10];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdKey)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdActivityDefinitionId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDataType)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsInput)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIsMandatory)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdDefaultValue)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdForeignKeyEntityId)) {
return OptimizedAttributes[10];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdKey) {
return ssKey;
}
if (key == IdName) {
return ssName;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdActivityDefinitionId) {
return ssActivityDefinitionId;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdDataType) {
return ssDataType;
}
if (key == IdIsInput) {
return ssIsInput;
}
if (key == IdIsMandatory) {
return ssIsMandatory;
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
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdActivityDefinitionId.Key.AsGuid) {
return ssActivityDefinitionId;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdDataType.Key.AsGuid) {
return ssDataType;
}
if (attributeKey == IdIsInput.Key.AsGuid) {
return ssIsInput;
}
if (attributeKey == IdIsMandatory.Key.AsGuid) {
return ssIsMandatory;
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
ChangedAttributes = new BitArray(11);
OptimizedAttributes = new BitArray(11);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssKey = (string) other.AttributeGet(IdKey);
ChangedAttributes[1] = other.ChangedAttributeGet(IdKey);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdKey);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[2] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdName);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[3] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDescription);
ssActivityDefinitionId = (int) other.AttributeGet(IdActivityDefinitionId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdActivityDefinitionId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdActivityDefinitionId);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsActive);
ssDataType = (string) other.AttributeGet(IdDataType);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDataType);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDataType);
ssIsInput = (bool) other.AttributeGet(IdIsInput);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsInput);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsInput);
ssIsMandatory = (bool) other.AttributeGet(IdIsMandatory);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsMandatory);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsMandatory);
ssDefaultValue = (string) other.AttributeGet(IdDefaultValue);
ChangedAttributes[9] = other.ChangedAttributeGet(IdDefaultValue);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdDefaultValue);
ssForeignKeyEntityId = (string) other.AttributeGet(IdForeignKeyEntityId);
ChangedAttributes[10] = other.ChangedAttributeGet(IdForeignKeyEntityId);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdForeignKeyEntityId);
}
} // ENActivityOutputDefinitionEntityRecord

/// <summary>
/// RecordList type <code>ActivityOutputDefinitionList</code> that represents a record list of
///  <code>ActivityOutputDefinition</code>
/// </summary>
public partial class RLActivityOutputDefinitionList : GenericRecordList<ENActivityOutputDefinitionEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENActivityOutputDefinitionEntityRecord GetElementDefaultValue() {
return new ENActivityOutputDefinitionEntityRecord();
}

public T[] ToArray<T>(Func<ENActivityOutputDefinitionEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLActivityOutputDefinitionList recordList, Func<ENActivityOutputDefinitionEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLActivityOutputDefinitionList(ENActivityOutputDefinitionEntityRecord[] array) {
  RLActivityOutputDefinitionList result = new RLActivityOutputDefinitionList();
result.InnerFromArray(array);
    return result;
}

public static RLActivityOutputDefinitionList ToList<T>(T[] array, Func <T, ENActivityOutputDefinitionEntityRecord> converter) {
  RLActivityOutputDefinitionList result = new RLActivityOutputDefinitionList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLActivityOutputDefinitionList FromRestList<T>(RestList<T> restList, Func <T, ENActivityOutputDefinitionEntityRecord> converter) {
  RLActivityOutputDefinitionList result = new RLActivityOutputDefinitionList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLActivityOutputDefinitionList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENActivityOutputDefinitionEntityRecord> NewList() {
return new RLActivityOutputDefinitionList();
}


} // RLActivityOutputDefinitionList
}
