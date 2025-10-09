using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] Application (Peat6jeAoS7k0hgUWu_7Nw) <code>ENApplicationEntityRecord</code> that
///  represents <code>Application</code> <p>Description: Applications defined in Service Studio. Onl
/// y active applications are retained.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Application","Peat6jeAoS7k0hgUWu_7Nw","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: Application
public partial struct ENApplicationEntityRecord : ITypedRecord<ENApplicationEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*nT2tk5kOGl5OtMd+chGs0A");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*AZLlE1D6fXPxiJTnJvAQ8Q");
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*LeaWFofOy0qLt_5AQidrmw");

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
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",50,false,false,false,true)]
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TYPE",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("Type")]
private string _ssType;
public string ssType{
  get{
      return _ssType;
  }
  set{
      if((_ssType!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssType = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENApplicationEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = "";
_ssName = "";
_ssType = "";
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
ssId = r.ReadText(index++, "Application.Id", "");
ssName = r.ReadText(index++, "Application.Name", "");
ssType = r.ReadEntityReferenceText(index++, "Application.Type", "");
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(ENApplicationEntityRecord r) {
this = r;
}


public static bool operator == (ENApplicationEntityRecord a, ENApplicationEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssType != b.ssType) return false;
return true;
}

public static bool operator != (ENApplicationEntityRecord a, ENApplicationEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENApplicationEntityRecord)) return false;
return (this == (ENApplicationEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENApplicationEntityRecord Duplicate() {
ENApplicationEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssType = this._ssType;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
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
} else if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
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
if (key.Equals(IdType)) {
return ChangedAttributes[2];
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
if (key.Equals(IdType)) {
return OptimizedAttributes[2];
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
if (key == IdType) {
return ssType;
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
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssType = (string) other.AttributeGet(IdType);
ChangedAttributes[2] = other.ChangedAttributeGet(IdType);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdType);
}
} // ENApplicationEntityRecord

/// <summary>
/// RecordList type <code>ApplicationList</code> that represents a record list of
///  <code>Application</code>
/// </summary>
public partial class RLApplicationList : GenericRecordList<ENApplicationEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENApplicationEntityRecord GetElementDefaultValue() {
return new ENApplicationEntityRecord();
}

public T[] ToArray<T>(Func<ENApplicationEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLApplicationList recordList, Func<ENApplicationEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLApplicationList(ENApplicationEntityRecord[] array) {
  RLApplicationList result = new RLApplicationList();
result.InnerFromArray(array);
    return result;
}

public static RLApplicationList ToList<T>(T[] array, Func <T, ENApplicationEntityRecord> converter) {
  RLApplicationList result = new RLApplicationList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLApplicationList FromRestList<T>(RestList<T> restList, Func <T, ENApplicationEntityRecord> converter) {
  RLApplicationList result = new RLApplicationList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLApplicationList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENApplicationEntityRecord> NewList() {
return new RLApplicationList();
}


} // RLApplicationList
}
