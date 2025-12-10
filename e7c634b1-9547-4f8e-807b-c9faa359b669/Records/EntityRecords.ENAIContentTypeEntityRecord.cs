using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [SystemStaticEntity] AIContentType (tdEO0rQLm0GQxLCnIg1jog)
///  <code>ENAIContentTypeEntityRecord</code> that represents <code>AIContentType</code> <p>Description
/// : </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("AIContentType","tdEO0rQLm0GQxLCnIg1jog","sTTG50eVjk+Ae8n6o1m2aQ", 0,"osvue_ai_content_type", null, false)]
// Name: AIContentType
public partial struct ENAIContentTypeEntityRecord : ITypedRecord<ENAIContentTypeEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q7RTbOMVa0294HGDgNbQcg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gZqhOhe1IUG6dv0iO5N1uw");

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

public ENAIContentTypeEntityRecord() {
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
ssId = r.ReadLongInteger(index++, "AIContentType.Id", 0L);
ssName = r.ReadText(index++, "AIContentType.Name", "");
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
public void ReadIM(ENAIContentTypeEntityRecord r) {
this = r;
}


public static bool operator == (ENAIContentTypeEntityRecord a, ENAIContentTypeEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (ENAIContentTypeEntityRecord a, ENAIContentTypeEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENAIContentTypeEntityRecord)) return false;
return (this == (ENAIContentTypeEntityRecord)o);
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


public ENAIContentTypeEntityRecord Duplicate() {
ENAIContentTypeEntityRecord t;
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
} // ENAIContentTypeEntityRecord

/// <summary>
/// RecordList type <code>AIContentTypeList</code> that represents a record list of
///  <code>AIContentType</code>
/// </summary>
public partial class RLAIContentTypeList : GenericRecordList<ENAIContentTypeEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENAIContentTypeEntityRecord GetElementDefaultValue() {
return new ENAIContentTypeEntityRecord();
}

public T[] ToArray<T>(Func<ENAIContentTypeEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIContentTypeList recordList, Func<ENAIContentTypeEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIContentTypeList(ENAIContentTypeEntityRecord[] array) {
  RLAIContentTypeList result = new RLAIContentTypeList();
result.InnerFromArray(array);
    return result;
}

public static RLAIContentTypeList ToList<T>(T[] array, Func <T, ENAIContentTypeEntityRecord> converter) {
  RLAIContentTypeList result = new RLAIContentTypeList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIContentTypeList FromRestList<T>(RestList<T> restList, Func <T, ENAIContentTypeEntityRecord> converter) {
  RLAIContentTypeList result = new RLAIContentTypeList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIContentTypeList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENAIContentTypeEntityRecord> NewList() {
return new RLAIContentTypeList();
}


} // RLAIContentTypeList
}
