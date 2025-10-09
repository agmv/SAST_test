namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (gDOxM+GZU0mbb4+6igOb7Q)
///  <code>RC_40d0f5c5ba630b105850cead15ae2223</code> that represents <code>TenantRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TenantRecord
public partial struct RC_40d0f5c5ba630b105850cead15ae2223 : ITypedRecord<RC_40d0f5c5ba630b105850cead15ae2223> {
internal static readonly GlobalObjectKey IdTenant = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xfXQQGO6EAtYUM6tFa4iIw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Tenant")]
public ENTenantEntityRecord ssENTenant;


public static implicit operator ENTenantEntityRecord( RC_40d0f5c5ba630b105850cead15ae2223 r) {
return r.ssENTenant;
}

public static implicit operator RC_40d0f5c5ba630b105850cead15ae2223 (ENTenantEntityRecord r) {
RC_40d0f5c5ba630b105850cead15ae2223 res = new RC_40d0f5c5ba630b105850cead15ae2223 ();
res.ssENTenant = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENTenant.ChangedAttributes = value;
}
get {
    return ssENTenant.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_40d0f5c5ba630b105850cead15ae2223() {
OptimizedAttributes = null;
ssENTenant = new ENTenantEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENTenant.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENTenant.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENTenant.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENTenant.Read( r, ref index);
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
public void ReadIM(RC_40d0f5c5ba630b105850cead15ae2223 r) {
this = r;
}


public static bool operator == (RC_40d0f5c5ba630b105850cead15ae2223 a, RC_40d0f5c5ba630b105850cead15ae2223 b) {
if (a.ssENTenant != b.ssENTenant) return false;
return true;
}

public static bool operator != (RC_40d0f5c5ba630b105850cead15ae2223 a, RC_40d0f5c5ba630b105850cead15ae2223 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_40d0f5c5ba630b105850cead15ae2223)) return false;
return (this == (RC_40d0f5c5ba630b105850cead15ae2223)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENTenant.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENTenant.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENTenant.InternalRecursiveSave();
}


public RC_40d0f5c5ba630b105850cead15ae2223 Duplicate() {
RC_40d0f5c5ba630b105850cead15ae2223 t;
t.ssENTenant = (ENTenantEntityRecord)this.ssENTenant.Duplicate();
t.OptimizedAttributes = null;
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
if (head == "tenant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tenant")) variable.Value = ssENTenant; else variable.Optimized = true;
variable.SetFieldName("tenant");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENTenant.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENTenant.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTenant) {
return ssENTenant;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTenant.Key.AsGuid) {
return ssENTenant;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENTenant.FillFromOther((IRecord) other.AttributeGet(IdTenant));
}
} // RC_40d0f5c5ba630b105850cead15ae2223
/// <summary>
/// RecordList type <code>TenantRecordList</code> that represents a record list of <code>Tenant</code>
/// </summary>
public partial class RL_1021a34c12afbc1ae6d31ca4929b6091 : GenericRecordList<RC_40d0f5c5ba630b105850cead15ae2223>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_40d0f5c5ba630b105850cead15ae2223 GetElementDefaultValue() {
return new RC_40d0f5c5ba630b105850cead15ae2223();
}

public T[] ToArray<T>(Func<RC_40d0f5c5ba630b105850cead15ae2223, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1021a34c12afbc1ae6d31ca4929b6091 recordList, Func<RC_40d0f5c5ba630b105850cead15ae2223, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1021a34c12afbc1ae6d31ca4929b6091(RC_40d0f5c5ba630b105850cead15ae2223[] array) {
  RL_1021a34c12afbc1ae6d31ca4929b6091 result = new RL_1021a34c12afbc1ae6d31ca4929b6091();
result.InnerFromArray(array);
    return result;
}

public static RL_1021a34c12afbc1ae6d31ca4929b6091 ToList<T>(T[] array, Func <T, RC_40d0f5c5ba630b105850cead15ae2223> converter) {
  RL_1021a34c12afbc1ae6d31ca4929b6091 result = new RL_1021a34c12afbc1ae6d31ca4929b6091();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1021a34c12afbc1ae6d31ca4929b6091 FromRestList<T>(RestList<T> restList, Func <T, RC_40d0f5c5ba630b105850cead15ae2223> converter) {
  RL_1021a34c12afbc1ae6d31ca4929b6091 result = new RL_1021a34c12afbc1ae6d31ca4929b6091();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1021a34c12afbc1ae6d31ca4929b6091() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_40d0f5c5ba630b105850cead15ae2223> NewList() {
return new RL_1021a34c12afbc1ae6d31ca4929b6091();
}


} // RL_1021a34c12afbc1ae6d31ca4929b6091
}

