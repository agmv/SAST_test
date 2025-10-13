namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (CCNpZRI1JUqjPLMezcp7Yw)
///  <code>RC_0cbd4d7610423d8899428a14f9ab38ee</code> that represent
/// s <code>StartUpdateEmailResultRecord</code> <p>Description: </p>
/// </summary>
// Name: StartUpdateEmailResultRecord
public partial struct RC_0cbd4d7610423d8899428a14f9ab38ee : ITypedRecord<RC_0cbd4d7610423d8899428a14f9ab38ee> {
internal static readonly GlobalObjectKey IdStartUpdateEmailResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dk29DEIQiD2ZQooU+as47g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StartUpdateEmailResult")]
public ST_f4b6c6eeb122dfa3165aeece838fd077Structure ssSTStartUpdateEmailResult;


public static implicit operator ST_f4b6c6eeb122dfa3165aeece838fd077Structure( RC_0cbd4d7610423d8899428a14f9ab38ee r) {
return r.ssSTStartUpdateEmailResult;
}

public static implicit operator RC_0cbd4d7610423d8899428a14f9ab38ee (ST_f4b6c6eeb122dfa3165aeece838fd077Structure r) {
RC_0cbd4d7610423d8899428a14f9ab38ee res = new RC_0cbd4d7610423d8899428a14f9ab38ee ();
res.ssSTStartUpdateEmailResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0cbd4d7610423d8899428a14f9ab38ee() {
OptimizedAttributes = null;
ssSTStartUpdateEmailResult = new ST_f4b6c6eeb122dfa3165aeece838fd077Structure();
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
    ssSTStartUpdateEmailResult.OptimizedAttributes = value[0];
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
ssSTStartUpdateEmailResult.Read( r, ref index);
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
public void ReadIM(RC_0cbd4d7610423d8899428a14f9ab38ee r) {
this = r;
}


public static bool operator == (RC_0cbd4d7610423d8899428a14f9ab38ee a, RC_0cbd4d7610423d8899428a14f9ab38ee b) {
if (a.ssSTStartUpdateEmailResult != b.ssSTStartUpdateEmailResult) return false;
return true;
}

public static bool operator != (RC_0cbd4d7610423d8899428a14f9ab38ee a, RC_0cbd4d7610423d8899428a14f9ab38ee b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0cbd4d7610423d8899428a14f9ab38ee)) return false;
return (this == (RC_0cbd4d7610423d8899428a14f9ab38ee)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStartUpdateEmailResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStartUpdateEmailResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStartUpdateEmailResult.InternalRecursiveSave();
}


public RC_0cbd4d7610423d8899428a14f9ab38ee Duplicate() {
RC_0cbd4d7610423d8899428a14f9ab38ee t;
t.ssSTStartUpdateEmailResult = (ST_f4b6c6eeb122dfa3165aeece838fd077Structure)this.ssSTStartUpdateEmailResult.Duplicate();
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
if (head == "startupdateemailresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartUpdateEmailResult")) variable.Value = ssSTStartUpdateEmailResult; else variable.Optimized = true;
variable.SetFieldName("startupdateemailresult");
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
if (key == IdStartUpdateEmailResult) {
return ssSTStartUpdateEmailResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStartUpdateEmailResult.Key.AsGuid) {
return ssSTStartUpdateEmailResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStartUpdateEmailResult.FillFromOther((IRecord) other.AttributeGet(IdStartUpdateEmailResult));
}
} // RC_0cbd4d7610423d8899428a14f9ab38ee
/// <summary>
/// RecordList type <code>StartUpdateEmailResultRecordList</code> that represents a record list of
///  <code>StartUpdateEmailResult</code>
/// </summary>
public partial class RL_1a05016affe8cb21dc717289084d3c4e : GenericRecordList<RC_0cbd4d7610423d8899428a14f9ab38ee>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0cbd4d7610423d8899428a14f9ab38ee GetElementDefaultValue() {
return new RC_0cbd4d7610423d8899428a14f9ab38ee();
}

public T[] ToArray<T>(Func<RC_0cbd4d7610423d8899428a14f9ab38ee, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1a05016affe8cb21dc717289084d3c4e recordList, Func<RC_0cbd4d7610423d8899428a14f9ab38ee, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1a05016affe8cb21dc717289084d3c4e(RC_0cbd4d7610423d8899428a14f9ab38ee[] array) {
  RL_1a05016affe8cb21dc717289084d3c4e result = new RL_1a05016affe8cb21dc717289084d3c4e();
result.InnerFromArray(array);
    return result;
}

public static RL_1a05016affe8cb21dc717289084d3c4e ToList<T>(T[] array, Func <T, RC_0cbd4d7610423d8899428a14f9ab38ee> converter) {
  RL_1a05016affe8cb21dc717289084d3c4e result = new RL_1a05016affe8cb21dc717289084d3c4e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1a05016affe8cb21dc717289084d3c4e FromRestList<T>(RestList<T> restList, Func <T, RC_0cbd4d7610423d8899428a14f9ab38ee> converter) {
  RL_1a05016affe8cb21dc717289084d3c4e result = new RL_1a05016affe8cb21dc717289084d3c4e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1a05016affe8cb21dc717289084d3c4e() : base() {
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
protected override OSList<RC_0cbd4d7610423d8899428a14f9ab38ee> NewList() {
return new RL_1a05016affe8cb21dc717289084d3c4e();
}


} // RL_1a05016affe8cb21dc717289084d3c4e
}

