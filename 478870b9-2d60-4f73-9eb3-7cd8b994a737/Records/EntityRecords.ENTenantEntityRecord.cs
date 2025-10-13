using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] Tenant (WQMM07oXpk63b_WESl+a5Q) <code>ENTenantEntityRecord</code> that represents
///  <code>Tenant</code> <p>Description: [Internal] Disjoint set of users, processes, and applicatio
/// n data. Tenants are shared across modules with the same user provider (defined in Service Studio).
///  Used to segment data, users, and processes in a multi-tenant scenario.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Tenant","WQMM07oXpk63b_WESl+a5Q","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: Tenant
public partial struct ENTenantEntityRecord : ITypedRecord<ENTenantEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*pXKdBM_ei0S3a7L523GyVA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*UQ1IpGL0OkPRTvRQ64sRHw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,false,true,false,true)]
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",35,false,false,false,true)]
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

public ENTenantEntityRecord() {
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
ssId = r.ReadLongInteger(index++, "Tenant.Id", 0L);
ssName = r.ReadText(index++, "Tenant.Name", "");
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
public void ReadIM(ENTenantEntityRecord r) {
this = r;
}


public static bool operator == (ENTenantEntityRecord a, ENTenantEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (ENTenantEntityRecord a, ENTenantEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENTenantEntityRecord)) return false;
return (this == (ENTenantEntityRecord)o);
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


public ENTenantEntityRecord Duplicate() {
ENTenantEntityRecord t;
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
} // ENTenantEntityRecord

/// <summary>
/// RecordList type <code>TenantList</code> that represents a record list of <code>Tenant</code>
/// </summary>
public partial class RLTenantList : GenericRecordList<ENTenantEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENTenantEntityRecord GetElementDefaultValue() {
return new ENTenantEntityRecord();
}

public T[] ToArray<T>(Func<ENTenantEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLTenantList recordList, Func<ENTenantEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLTenantList(ENTenantEntityRecord[] array) {
  RLTenantList result = new RLTenantList();
result.InnerFromArray(array);
    return result;
}

public static RLTenantList ToList<T>(T[] array, Func <T, ENTenantEntityRecord> converter) {
  RLTenantList result = new RLTenantList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLTenantList FromRestList<T>(RestList<T> restList, Func <T, ENTenantEntityRecord> converter) {
  RLTenantList result = new RLTenantList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLTenantList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENTenantEntityRecord> NewList() {
return new RLTenantList();
}


} // RLTenantList
}
