using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ActivityDefinitionLink (zWmyA_xRa4DAtLi8aQUQ8g)
///  <code>ENActivityDefinitionLinkEntityRecord</code> that represent
/// s <code>ActivityDefinitionLink</code> <p>Description: Process activity as defined in Service Studio
///  containing only links for current model.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ActivityDefinitionLink","zWmyA_xRa4DAtLi8aQUQ8g","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ActivityDefinitionLink
public partial struct ENActivityDefinitionLinkEntityRecord : ITypedRecord<ENActivityDefinitionLinkEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*hrnmTzqZH01NJamxJUAkOw");
internal static readonly GlobalObjectKey IdSourceActivityDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*vU_8GfWCyX_NsjOWkQ86CA");
internal static readonly GlobalObjectKey IdTargetActivityDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*XVR_BIEFKTfFwsFiEQ94qQ");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*hVwhiO5o28RFdq_FjlNSDA");
internal static readonly GlobalObjectKey IdOutcome = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*yvTm7oxCUX0b1ZnCpWhZVA");

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
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SOURCEACTIVITYDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("SourceActivityDefinitionId")]
private int _ssSourceActivityDefinitionId;
public int ssSourceActivityDefinitionId{
  get{
      return _ssSourceActivityDefinitionId;
  }
  set{
      if((_ssSourceActivityDefinitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSourceActivityDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TARGETACTIVITYDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("TargetActivityDefinitionId")]
private int _ssTargetActivityDefinitionId;
public int ssTargetActivityDefinitionId{
  get{
      return _ssTargetActivityDefinitionId;
  }
  set{
      if((_ssTargetActivityDefinitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssTargetActivityDefinitionId = value;
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("OUTCOME",50,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Outcome")]
private string _ssOutcome;
public string ssOutcome{
  get{
      return _ssOutcome;
  }
  set{
      if((_ssOutcome!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssOutcome = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENActivityDefinitionLinkEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = "";
_ssSourceActivityDefinitionId = 0;
_ssTargetActivityDefinitionId = 0;
_ssIsActive = false;
_ssOutcome = "";
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
ssId = r.ReadText(index++, "ActivityDefinitionLink.Id", "");
ssSourceActivityDefinitionId = r.ReadEntityReference(index++, "ActivityDefinitionLink.SourceActivityDefinitionId", 0);
ssTargetActivityDefinitionId = r.ReadEntityReference(index++, "ActivityDefinitionLink.TargetActivityDefinitionId", 0);
ssIsActive = r.ReadBoolean(index++, "ActivityDefinitionLink.IsActive", false);
ssOutcome = r.ReadText(index++, "ActivityDefinitionLink.Outcome", "");
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(ENActivityDefinitionLinkEntityRecord r) {
this = r;
}


public static bool operator == (ENActivityDefinitionLinkEntityRecord a, ENActivityDefinitionLinkEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSourceActivityDefinitionId != b.ssSourceActivityDefinitionId) return false;
if (a.ssTargetActivityDefinitionId != b.ssTargetActivityDefinitionId) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssOutcome != b.ssOutcome) return false;
return true;
}

public static bool operator != (ENActivityDefinitionLinkEntityRecord a, ENActivityDefinitionLinkEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENActivityDefinitionLinkEntityRecord)) return false;
return (this == (ENActivityDefinitionLinkEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSourceActivityDefinitionId.GetHashCode()
 ^ ssTargetActivityDefinitionId.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssOutcome.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENActivityDefinitionLinkEntityRecord Duplicate() {
ENActivityDefinitionLinkEntityRecord t;
t._ssId = this._ssId;
t._ssSourceActivityDefinitionId = this._ssSourceActivityDefinitionId;
t._ssTargetActivityDefinitionId = this._ssTargetActivityDefinitionId;
t._ssIsActive = this._ssIsActive;
t._ssOutcome = this._ssOutcome;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "sourceactivitydefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SourceActivityDefinitionId")) variable.Value = ssSourceActivityDefinitionId; else variable.Optimized = true;
} else if (head == "targetactivitydefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TargetActivityDefinitionId")) variable.Value = ssTargetActivityDefinitionId; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "outcome") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Outcome")) variable.Value = ssOutcome; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSourceActivityDefinitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdTargetActivityDefinitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[3];
}
if (key.Equals(IdOutcome)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSourceActivityDefinitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdTargetActivityDefinitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdOutcome)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSourceActivityDefinitionId) {
return ssSourceActivityDefinitionId;
}
if (key == IdTargetActivityDefinitionId) {
return ssTargetActivityDefinitionId;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdOutcome) {
return ssOutcome;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSourceActivityDefinitionId.Key.AsGuid) {
return ssSourceActivityDefinitionId;
}
if (attributeKey == IdTargetActivityDefinitionId.Key.AsGuid) {
return ssTargetActivityDefinitionId;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdOutcome.Key.AsGuid) {
return ssOutcome;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSourceActivityDefinitionId = (int) other.AttributeGet(IdSourceActivityDefinitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSourceActivityDefinitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSourceActivityDefinitionId);
ssTargetActivityDefinitionId = (int) other.AttributeGet(IdTargetActivityDefinitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdTargetActivityDefinitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTargetActivityDefinitionId);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
ssOutcome = (string) other.AttributeGet(IdOutcome);
ChangedAttributes[4] = other.ChangedAttributeGet(IdOutcome);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdOutcome);
}
} // ENActivityDefinitionLinkEntityRecord

/// <summary>
/// RecordList type <code>ActivityDefinitionLinkList</code> that represents a record list of
///  <code>ActivityDefinitionLink</code>
/// </summary>
public partial class RLActivityDefinitionLinkList : GenericRecordList<ENActivityDefinitionLinkEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENActivityDefinitionLinkEntityRecord GetElementDefaultValue() {
return new ENActivityDefinitionLinkEntityRecord();
}

public T[] ToArray<T>(Func<ENActivityDefinitionLinkEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLActivityDefinitionLinkList recordList, Func<ENActivityDefinitionLinkEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLActivityDefinitionLinkList(ENActivityDefinitionLinkEntityRecord[] array) {
  RLActivityDefinitionLinkList result = new RLActivityDefinitionLinkList();
result.InnerFromArray(array);
    return result;
}

public static RLActivityDefinitionLinkList ToList<T>(T[] array, Func <T, ENActivityDefinitionLinkEntityRecord> converter) {
  RLActivityDefinitionLinkList result = new RLActivityDefinitionLinkList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLActivityDefinitionLinkList FromRestList<T>(RestList<T> restList, Func <T, ENActivityDefinitionLinkEntityRecord> converter) {
  RLActivityDefinitionLinkList result = new RLActivityDefinitionLinkList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLActivityDefinitionLinkList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENActivityDefinitionLinkEntityRecord> NewList() {
return new RLActivityDefinitionLinkList();
}


} // RLActivityDefinitionLinkList
}
