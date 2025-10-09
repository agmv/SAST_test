using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] HumanActivityInstance (Kk0tMz4ko0OgDcYRswnCIg)
///  <code>ENHumanActivityInstanceEntityRecord</code> that represents <code>HumanActivityInstance</code
/// > <p>Description: Entity that stores a record for each human activity that occurs while a process
///  instance is active.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("HumanActivityInstance","Kk0tMz4ko0OgDcYRswnCIg","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: HumanActivityInstance
public partial struct ENHumanActivityInstanceEntityRecord : ITypedRecord<ENHumanActivityInstanceEntityRecord> {
internal static readonly GlobalObjectKey IdActivityInstanceId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*tZtO56aSjkiniW2Su3A8Iw");
internal static readonly GlobalObjectKey IdAssignedUserId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*_aui1SQ_TEGxtctqZID3sg");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*HCotkFZFrkmZR06aRfBN7g");
internal static readonly GlobalObjectKey IdURL = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*K8Og8pyvIEugr+3mRb_qpw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ACTIVITYINSTANCEID",0,false,true,true,true)]
[System.Xml.Serialization.XmlElement("ActivityInstanceId")]
private long _ssActivityInstanceId;
public long ssActivityInstanceId{
  get{
      return _ssActivityInstanceId;
  }
  set{
      if((_ssActivityInstanceId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssActivityInstanceId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ASSIGNEDUSERID",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("AssignedUserId")]
private string _ssAssignedUserId;
public string ssAssignedUserId{
  get{
      return _ssAssignedUserId;
  }
  set{
      if((_ssAssignedUserId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssAssignedUserId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MESSAGE",2000,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Message")]
private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssMessage = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("URL",2048,false,false,false,false)]
[System.Xml.Serialization.XmlElement("URL")]
private string _ssURL;
public string ssURL{
  get{
      return _ssURL;
  }
  set{
      if((_ssURL!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssURL = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENHumanActivityInstanceEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssActivityInstanceId = 0L;
_ssAssignedUserId = "";
_ssMessage = "";
_ssURL = "";
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
ssActivityInstanceId = r.ReadEntityReferenceLongInteger(index++, "HumanActivityInstance.ActivityInstanceId", 0L);
ssAssignedUserId = r.ReadEntityReferenceText(index++, "HumanActivityInstance.AssignedUserId", "");
ssMessage = r.ReadText(index++, "HumanActivityInstance.Message", "");
ssURL = r.ReadText(index++, "HumanActivityInstance.URL", "");
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
public void ReadIM(ENHumanActivityInstanceEntityRecord r) {
this = r;
}


public static bool operator == (ENHumanActivityInstanceEntityRecord a, ENHumanActivityInstanceEntityRecord b) {
if (a.ssActivityInstanceId != b.ssActivityInstanceId) return false;
if (a.ssAssignedUserId != b.ssAssignedUserId) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssURL != b.ssURL) return false;
return true;
}

public static bool operator != (ENHumanActivityInstanceEntityRecord a, ENHumanActivityInstanceEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENHumanActivityInstanceEntityRecord)) return false;
return (this == (ENHumanActivityInstanceEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssActivityInstanceId.GetHashCode()
 ^ ssAssignedUserId.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssURL.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENHumanActivityInstanceEntityRecord Duplicate() {
ENHumanActivityInstanceEntityRecord t;
t._ssActivityInstanceId = this._ssActivityInstanceId;
t._ssAssignedUserId = this._ssAssignedUserId;
t._ssMessage = this._ssMessage;
t._ssURL = this._ssURL;
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
if (head == "activityinstanceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityInstanceId")) variable.Value = ssActivityInstanceId; else variable.Optimized = true;
} else if (head == "assigneduserid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedUserId")) variable.Value = ssAssignedUserId; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "url") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URL")) variable.Value = ssURL; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdActivityInstanceId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdAssignedUserId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[2];
}
if (key.Equals(IdURL)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdActivityInstanceId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdAssignedUserId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdURL)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityInstanceId) {
return ssActivityInstanceId;
}
if (key == IdAssignedUserId) {
return ssAssignedUserId;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdURL) {
return ssURL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityInstanceId.Key.AsGuid) {
return ssActivityInstanceId;
}
if (attributeKey == IdAssignedUserId.Key.AsGuid) {
return ssAssignedUserId;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdURL.Key.AsGuid) {
return ssURL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssActivityInstanceId = (long) other.AttributeGet(IdActivityInstanceId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdActivityInstanceId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdActivityInstanceId);
ssAssignedUserId = (string) other.AttributeGet(IdAssignedUserId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdAssignedUserId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdAssignedUserId);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[2] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMessage);
ssURL = (string) other.AttributeGet(IdURL);
ChangedAttributes[3] = other.ChangedAttributeGet(IdURL);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdURL);
}
} // ENHumanActivityInstanceEntityRecord

/// <summary>
/// RecordList type <code>HumanActivityInstanceList</code> that represents a record list of
///  <code>HumanActivityInstance</code>
/// </summary>
public partial class RLHumanActivityInstanceList : GenericRecordList<ENHumanActivityInstanceEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENHumanActivityInstanceEntityRecord GetElementDefaultValue() {
return new ENHumanActivityInstanceEntityRecord();
}

public T[] ToArray<T>(Func<ENHumanActivityInstanceEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLHumanActivityInstanceList recordList, Func<ENHumanActivityInstanceEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLHumanActivityInstanceList(ENHumanActivityInstanceEntityRecord[] array) {
  RLHumanActivityInstanceList result = new RLHumanActivityInstanceList();
result.InnerFromArray(array);
    return result;
}

public static RLHumanActivityInstanceList ToList<T>(T[] array, Func <T, ENHumanActivityInstanceEntityRecord> converter) {
  RLHumanActivityInstanceList result = new RLHumanActivityInstanceList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLHumanActivityInstanceList FromRestList<T>(RestList<T> restList, Func <T, ENHumanActivityInstanceEntityRecord> converter) {
  RLHumanActivityInstanceList result = new RLHumanActivityInstanceList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLHumanActivityInstanceList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENHumanActivityInstanceEntityRecord> NewList() {
return new RLHumanActivityInstanceList();
}


} // RLHumanActivityInstanceList
}
