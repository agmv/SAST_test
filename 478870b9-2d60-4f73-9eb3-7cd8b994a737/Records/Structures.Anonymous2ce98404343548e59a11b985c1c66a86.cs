namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (BITpLDU05UiaEbmFwcZqhg)
///  <code>RC_3251af6c799b185d408b7cad31be3454</code> that represents <code>RuntimeTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RuntimeTypeRecord
public partial struct RC_3251af6c799b185d408b7cad31be3454 : ITypedRecord<RC_3251af6c799b185d408b7cad31be3454> {
internal static readonly GlobalObjectKey IdRuntimeType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bK9RMpt5XRhAi3ytMb40VA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RuntimeType")]
public ENRuntimeTypeEntityRecord ssENRuntimeType;


public static implicit operator ENRuntimeTypeEntityRecord( RC_3251af6c799b185d408b7cad31be3454 r) {
return r.ssENRuntimeType;
}

public static implicit operator RC_3251af6c799b185d408b7cad31be3454 (ENRuntimeTypeEntityRecord r) {
RC_3251af6c799b185d408b7cad31be3454 res = new RC_3251af6c799b185d408b7cad31be3454 ();
res.ssENRuntimeType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRuntimeType.ChangedAttributes = value;
}
get {
    return ssENRuntimeType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3251af6c799b185d408b7cad31be3454() {
OptimizedAttributes = null;
ssENRuntimeType = new ENRuntimeTypeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRuntimeType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRuntimeType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRuntimeType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRuntimeType.Read( r, ref index);
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
public void ReadIM(RC_3251af6c799b185d408b7cad31be3454 r) {
this = r;
}


public static bool operator == (RC_3251af6c799b185d408b7cad31be3454 a, RC_3251af6c799b185d408b7cad31be3454 b) {
if (a.ssENRuntimeType != b.ssENRuntimeType) return false;
return true;
}

public static bool operator != (RC_3251af6c799b185d408b7cad31be3454 a, RC_3251af6c799b185d408b7cad31be3454 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3251af6c799b185d408b7cad31be3454)) return false;
return (this == (RC_3251af6c799b185d408b7cad31be3454)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRuntimeType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRuntimeType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRuntimeType.InternalRecursiveSave();
}


public RC_3251af6c799b185d408b7cad31be3454 Duplicate() {
RC_3251af6c799b185d408b7cad31be3454 t;
t.ssENRuntimeType = (ENRuntimeTypeEntityRecord)this.ssENRuntimeType.Duplicate();
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
if (head == "runtimetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RuntimeType")) variable.Value = ssENRuntimeType; else variable.Optimized = true;
variable.SetFieldName("runtimetype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRuntimeType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRuntimeType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRuntimeType) {
return ssENRuntimeType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRuntimeType.Key.AsGuid) {
return ssENRuntimeType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRuntimeType.FillFromOther((IRecord) other.AttributeGet(IdRuntimeType));
}
} // RC_3251af6c799b185d408b7cad31be3454
/// <summary>
/// RecordList type <code>RuntimeTypeRecordList</code> that represents a record list of
///  <code>RuntimeType</code>
/// </summary>
public partial class RL_599ab6c06883c99851f6aa769853530c : GenericRecordList<RC_3251af6c799b185d408b7cad31be3454>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3251af6c799b185d408b7cad31be3454 GetElementDefaultValue() {
return new RC_3251af6c799b185d408b7cad31be3454();
}

public T[] ToArray<T>(Func<RC_3251af6c799b185d408b7cad31be3454, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_599ab6c06883c99851f6aa769853530c recordList, Func<RC_3251af6c799b185d408b7cad31be3454, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_599ab6c06883c99851f6aa769853530c(RC_3251af6c799b185d408b7cad31be3454[] array) {
  RL_599ab6c06883c99851f6aa769853530c result = new RL_599ab6c06883c99851f6aa769853530c();
result.InnerFromArray(array);
    return result;
}

public static RL_599ab6c06883c99851f6aa769853530c ToList<T>(T[] array, Func <T, RC_3251af6c799b185d408b7cad31be3454> converter) {
  RL_599ab6c06883c99851f6aa769853530c result = new RL_599ab6c06883c99851f6aa769853530c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_599ab6c06883c99851f6aa769853530c FromRestList<T>(RestList<T> restList, Func <T, RC_3251af6c799b185d408b7cad31be3454> converter) {
  RL_599ab6c06883c99851f6aa769853530c result = new RL_599ab6c06883c99851f6aa769853530c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_599ab6c06883c99851f6aa769853530c() : base() {
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
protected override OSList<RC_3251af6c799b185d408b7cad31be3454> NewList() {
return new RL_599ab6c06883c99851f6aa769853530c();
}


} // RL_599ab6c06883c99851f6aa769853530c
}

