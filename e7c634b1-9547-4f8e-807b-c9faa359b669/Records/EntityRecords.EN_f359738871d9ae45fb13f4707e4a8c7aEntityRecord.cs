using System.Diagnostics;
namespace ssRuntimeDestroyer {

/// <summary>
/// [Entity] HttpRequest (YxelLwkNYkeSOrgJ6mkbQQ)
///  <code>EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord</code> that represent
/// s <code>HttpRequest</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("HttpRequest","YxelLwkNYkeSOrgJ6mkbQQ","sTTG50eVjk+Ae8n6o1m2aQ", 0,"httpr_jf1oovmiqpmvxyhsczut6_72", null, false)]
// Name: HttpRequest
public partial struct EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord : ITypedRecord<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*AzvYflju_UeUODedPxcJCA");
internal static readonly GlobalObjectKey IdHttpMethod = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*jxCWmniqf0SNtgDu2ysdYA");
internal static readonly GlobalObjectKey IdBody = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*SEJt0g2BwEu5WU_1qa5lyg");

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
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("HTTPMETHOD",50,false,false,false,true)]
[System.Xml.Serialization.XmlElement("HttpMethod")]
private string _ssHttpMethod;
public string ssHttpMethod{
  get{
      return _ssHttpMethod;
  }
  set{
      if((_ssHttpMethod!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssHttpMethod = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("BODY",2000,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Body")]
private string _ssBody;
public string ssBody{
  get{
      return _ssBody;
  }
  set{
      if((_ssBody!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssBody = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssHttpMethod = "";
_ssBody = "";
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
ssId = r.ReadLongInteger(index++, "HttpRequest.Id", 0L);
ssHttpMethod = r.ReadText(index++, "HttpRequest.HttpMethod", "");
ssBody = r.ReadText(index++, "HttpRequest.Body", "");
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
public void ReadIM(EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord r) {
this = r;
}


public static bool operator == (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord a, EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssHttpMethod != b.ssHttpMethod) return false;
if (a.ssBody != b.ssBody) return false;
return true;
}

public static bool operator != (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord a, EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord)) return false;
return (this == (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssHttpMethod.GetHashCode()
 ^ ssBody.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord Duplicate() {
EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord t;
t._ssId = this._ssId;
t._ssHttpMethod = this._ssHttpMethod;
t._ssBody = this._ssBody;
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
} else if (head == "httpmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpMethod")) variable.Value = ssHttpMethod; else variable.Optimized = true;
} else if (head == "body") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Body")) variable.Value = ssBody; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdHttpMethod)) {
return ChangedAttributes[1];
}
if (key.Equals(IdBody)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdHttpMethod)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdBody)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdHttpMethod) {
return ssHttpMethod;
}
if (key == IdBody) {
return ssBody;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdHttpMethod.Key.AsGuid) {
return ssHttpMethod;
}
if (attributeKey == IdBody.Key.AsGuid) {
return ssBody;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssHttpMethod = (string) other.AttributeGet(IdHttpMethod);
ChangedAttributes[1] = other.ChangedAttributeGet(IdHttpMethod);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdHttpMethod);
ssBody = (string) other.AttributeGet(IdBody);
ChangedAttributes[2] = other.ChangedAttributeGet(IdBody);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdBody);
}
} // EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord

/// <summary>
/// RecordList type <code>HttpRequestList</code> that represents a record list of
///  <code>HttpRequest</code>
/// </summary>
public partial class RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 : GenericRecordList<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord GetElementDefaultValue() {
return new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord();
}

public T[] ToArray<T>(Func<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 recordList, Func<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5(EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord[] array) {
  RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 result = new RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5();
result.InnerFromArray(array);
    return result;
}

public static RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 ToList<T>(T[] array, Func <T, EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> converter) {
  RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 result = new RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 FromRestList<T>(RestList<T> restList, Func <T, EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> converter) {
  RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5 result = new RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord> NewList() {
return new RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5();
}


} // RL_5bd7dd4aa1722e5ba9cf8e1c0438ecf5
}
