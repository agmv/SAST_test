namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (633453BYv0yn3fCYvt8oow)
///  <code>RC_390a8f0cc1a357081cd0fa77862d946e</code> that represent
/// s <code>URLQueryParameterRecord</code> <p>Description: </p>
/// </summary>
// Name: URLQueryParameterRecord
public partial struct RC_390a8f0cc1a357081cd0fa77862d946e : ITypedRecord<RC_390a8f0cc1a357081cd0fa77862d946e> {
internal static readonly GlobalObjectKey IdURLQueryParameter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DI8KOaPBCFcc0Pp3hi2Ubg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("URLQueryParameter")]
public ST_67c9532b700300cd02996c0d658856f8Structure ssSTURLQueryParameter;


public static implicit operator ST_67c9532b700300cd02996c0d658856f8Structure( RC_390a8f0cc1a357081cd0fa77862d946e r) {
return r.ssSTURLQueryParameter;
}

public static implicit operator RC_390a8f0cc1a357081cd0fa77862d946e (ST_67c9532b700300cd02996c0d658856f8Structure r) {
RC_390a8f0cc1a357081cd0fa77862d946e res = new RC_390a8f0cc1a357081cd0fa77862d946e ();
res.ssSTURLQueryParameter = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_390a8f0cc1a357081cd0fa77862d946e() {
OptimizedAttributes = null;
ssSTURLQueryParameter = new ST_67c9532b700300cd02996c0d658856f8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTURLQueryParameter.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTURLQueryParameter.Read( r, ref index);
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
public void ReadIM(RC_390a8f0cc1a357081cd0fa77862d946e r) {
this = r;
}


public static bool operator == (RC_390a8f0cc1a357081cd0fa77862d946e a, RC_390a8f0cc1a357081cd0fa77862d946e b) {
if (a.ssSTURLQueryParameter != b.ssSTURLQueryParameter) return false;
return true;
}

public static bool operator != (RC_390a8f0cc1a357081cd0fa77862d946e a, RC_390a8f0cc1a357081cd0fa77862d946e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_390a8f0cc1a357081cd0fa77862d946e)) return false;
return (this == (RC_390a8f0cc1a357081cd0fa77862d946e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTURLQueryParameter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTURLQueryParameter.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTURLQueryParameter.InternalRecursiveSave();
}


public RC_390a8f0cc1a357081cd0fa77862d946e Duplicate() {
RC_390a8f0cc1a357081cd0fa77862d946e t;
t.ssSTURLQueryParameter = (ST_67c9532b700300cd02996c0d658856f8Structure)this.ssSTURLQueryParameter.Duplicate();
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
if (head == "urlqueryparameter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URLQueryParameter")) variable.Value = ssSTURLQueryParameter; else variable.Optimized = true;
variable.SetFieldName("urlqueryparameter");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdURLQueryParameter) {
return ssSTURLQueryParameter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdURLQueryParameter.Key.AsGuid) {
return ssSTURLQueryParameter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTURLQueryParameter.FillFromOther((IRecord) other.AttributeGet(IdURLQueryParameter));
}
} // RC_390a8f0cc1a357081cd0fa77862d946e
/// <summary>
/// RecordList type <code>URLQueryParameterRecordList</code> that represents a record list of
///  <code>URLQueryParameter</code>
/// </summary>
public partial class RL_17096ec8727fbe1491389b8a2148fcff : GenericRecordList<RC_390a8f0cc1a357081cd0fa77862d946e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_390a8f0cc1a357081cd0fa77862d946e GetElementDefaultValue() {
return new RC_390a8f0cc1a357081cd0fa77862d946e();
}

public T[] ToArray<T>(Func<RC_390a8f0cc1a357081cd0fa77862d946e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_17096ec8727fbe1491389b8a2148fcff recordList, Func<RC_390a8f0cc1a357081cd0fa77862d946e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_17096ec8727fbe1491389b8a2148fcff(RC_390a8f0cc1a357081cd0fa77862d946e[] array) {
  RL_17096ec8727fbe1491389b8a2148fcff result = new RL_17096ec8727fbe1491389b8a2148fcff();
result.InnerFromArray(array);
    return result;
}

public static RL_17096ec8727fbe1491389b8a2148fcff ToList<T>(T[] array, Func <T, RC_390a8f0cc1a357081cd0fa77862d946e> converter) {
  RL_17096ec8727fbe1491389b8a2148fcff result = new RL_17096ec8727fbe1491389b8a2148fcff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_17096ec8727fbe1491389b8a2148fcff FromRestList<T>(RestList<T> restList, Func <T, RC_390a8f0cc1a357081cd0fa77862d946e> converter) {
  RL_17096ec8727fbe1491389b8a2148fcff result = new RL_17096ec8727fbe1491389b8a2148fcff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_17096ec8727fbe1491389b8a2148fcff() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_390a8f0cc1a357081cd0fa77862d946e> NewList() {
return new RL_17096ec8727fbe1491389b8a2148fcff();
}


} // RL_17096ec8727fbe1491389b8a2148fcff
}

