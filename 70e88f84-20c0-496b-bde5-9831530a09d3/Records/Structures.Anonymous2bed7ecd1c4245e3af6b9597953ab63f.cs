namespace ssRuntimeDestroyerLib {
/// <summary>
/// [AnonymousStructure] Record (zX7tK0Ic40Wva5WXlTq2Pw)
///  <code>RC_f7a56746c7bb090f072113e146ed4d38</code> that represents <code>HttpMethodRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HttpMethodRecord
public partial struct RC_f7a56746c7bb090f072113e146ed4d38 : ITypedRecord<RC_f7a56746c7bb090f072113e146ed4d38> {
internal static readonly GlobalObjectKey IdHttpMethod = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Rmel97vHDwkHIRPhRu1NOA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HttpMethod")]
public EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord ssENHttpMethod;


public static implicit operator EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord( RC_f7a56746c7bb090f072113e146ed4d38 r) {
return r.ssENHttpMethod;
}

public static implicit operator RC_f7a56746c7bb090f072113e146ed4d38 (EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord r) {
RC_f7a56746c7bb090f072113e146ed4d38 res = new RC_f7a56746c7bb090f072113e146ed4d38 ();
res.ssENHttpMethod = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENHttpMethod.ChangedAttributes = value;
}
get {
    return ssENHttpMethod.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f7a56746c7bb090f072113e146ed4d38() {
OptimizedAttributes = null;
ssENHttpMethod = new EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENHttpMethod.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENHttpMethod.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENHttpMethod.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENHttpMethod.Read( r, ref index);
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
public void ReadIM(RC_f7a56746c7bb090f072113e146ed4d38 r) {
this = r;
}


public static bool operator == (RC_f7a56746c7bb090f072113e146ed4d38 a, RC_f7a56746c7bb090f072113e146ed4d38 b) {
if (a.ssENHttpMethod != b.ssENHttpMethod) return false;
return true;
}

public static bool operator != (RC_f7a56746c7bb090f072113e146ed4d38 a, RC_f7a56746c7bb090f072113e146ed4d38 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f7a56746c7bb090f072113e146ed4d38)) return false;
return (this == (RC_f7a56746c7bb090f072113e146ed4d38)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENHttpMethod.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENHttpMethod.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENHttpMethod.InternalRecursiveSave();
}


public RC_f7a56746c7bb090f072113e146ed4d38 Duplicate() {
RC_f7a56746c7bb090f072113e146ed4d38 t;
t.ssENHttpMethod = (EN_8d13b751bc4c837ba8efa0ae00949a86EntityRecord)this.ssENHttpMethod.Duplicate();
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
if (head == "httpmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpMethod")) variable.Value = ssENHttpMethod; else variable.Optimized = true;
variable.SetFieldName("httpmethod");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENHttpMethod.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENHttpMethod.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdHttpMethod) {
return ssENHttpMethod;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHttpMethod.Key.AsGuid) {
return ssENHttpMethod;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENHttpMethod.FillFromOther((IRecord) other.AttributeGet(IdHttpMethod));
}
} // RC_f7a56746c7bb090f072113e146ed4d38
/// <summary>
/// RecordList type <code>HttpMethodRecordList</code> that represents a record list of
///  <code>HttpMethod</code>
/// </summary>
public partial class RL_f7ca2b56602678a70ad4fa1040602f6c : GenericRecordList<RC_f7a56746c7bb090f072113e146ed4d38>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f7a56746c7bb090f072113e146ed4d38 GetElementDefaultValue() {
return new RC_f7a56746c7bb090f072113e146ed4d38();
}

public T[] ToArray<T>(Func<RC_f7a56746c7bb090f072113e146ed4d38, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f7ca2b56602678a70ad4fa1040602f6c recordList, Func<RC_f7a56746c7bb090f072113e146ed4d38, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f7ca2b56602678a70ad4fa1040602f6c(RC_f7a56746c7bb090f072113e146ed4d38[] array) {
  RL_f7ca2b56602678a70ad4fa1040602f6c result = new RL_f7ca2b56602678a70ad4fa1040602f6c();
result.InnerFromArray(array);
    return result;
}

public static RL_f7ca2b56602678a70ad4fa1040602f6c ToList<T>(T[] array, Func <T, RC_f7a56746c7bb090f072113e146ed4d38> converter) {
  RL_f7ca2b56602678a70ad4fa1040602f6c result = new RL_f7ca2b56602678a70ad4fa1040602f6c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f7ca2b56602678a70ad4fa1040602f6c FromRestList<T>(RestList<T> restList, Func <T, RC_f7a56746c7bb090f072113e146ed4d38> converter) {
  RL_f7ca2b56602678a70ad4fa1040602f6c result = new RL_f7ca2b56602678a70ad4fa1040602f6c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f7ca2b56602678a70ad4fa1040602f6c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f7a56746c7bb090f072113e146ed4d38> NewList() {
return new RL_f7ca2b56602678a70ad4fa1040602f6c();
}


} // RL_f7ca2b56602678a70ad4fa1040602f6c
}

