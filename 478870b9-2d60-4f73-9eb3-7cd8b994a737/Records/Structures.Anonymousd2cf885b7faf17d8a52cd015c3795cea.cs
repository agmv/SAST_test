namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (W4jP0q9_2BelLNAVw3lc6g)
///  <code>RC_d5e6f13d187b5006f9f88b20f576700b</code> that represents <code>ProcessOutputRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProcessOutputRecord
public partial struct RC_d5e6f13d187b5006f9f88b20f576700b : ITypedRecord<RC_d5e6f13d187b5006f9f88b20f576700b> {
internal static readonly GlobalObjectKey IdProcessOutput = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PfHm1XsYBlD5+Isg9XZwCw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessOutput")]
public ENProcessOutputEntityRecord ssENProcessOutput;


public static implicit operator ENProcessOutputEntityRecord( RC_d5e6f13d187b5006f9f88b20f576700b r) {
return r.ssENProcessOutput;
}

public static implicit operator RC_d5e6f13d187b5006f9f88b20f576700b (ENProcessOutputEntityRecord r) {
RC_d5e6f13d187b5006f9f88b20f576700b res = new RC_d5e6f13d187b5006f9f88b20f576700b ();
res.ssENProcessOutput = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessOutput.ChangedAttributes = value;
}
get {
    return ssENProcessOutput.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d5e6f13d187b5006f9f88b20f576700b() {
OptimizedAttributes = null;
ssENProcessOutput = new ENProcessOutputEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessOutput.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessOutput.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessOutput.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessOutput.Read( r, ref index);
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
public void ReadIM(RC_d5e6f13d187b5006f9f88b20f576700b r) {
this = r;
}


public static bool operator == (RC_d5e6f13d187b5006f9f88b20f576700b a, RC_d5e6f13d187b5006f9f88b20f576700b b) {
if (a.ssENProcessOutput != b.ssENProcessOutput) return false;
return true;
}

public static bool operator != (RC_d5e6f13d187b5006f9f88b20f576700b a, RC_d5e6f13d187b5006f9f88b20f576700b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d5e6f13d187b5006f9f88b20f576700b)) return false;
return (this == (RC_d5e6f13d187b5006f9f88b20f576700b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessOutput.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessOutput.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessOutput.InternalRecursiveSave();
}


public RC_d5e6f13d187b5006f9f88b20f576700b Duplicate() {
RC_d5e6f13d187b5006f9f88b20f576700b t;
t.ssENProcessOutput = (ENProcessOutputEntityRecord)this.ssENProcessOutput.Duplicate();
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
if (head == "processoutput") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessOutput")) variable.Value = ssENProcessOutput; else variable.Optimized = true;
variable.SetFieldName("processoutput");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessOutput.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessOutput.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessOutput) {
return ssENProcessOutput;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessOutput.Key.AsGuid) {
return ssENProcessOutput;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessOutput.FillFromOther((IRecord) other.AttributeGet(IdProcessOutput));
}
} // RC_d5e6f13d187b5006f9f88b20f576700b
/// <summary>
/// RecordList type <code>ProcessOutputRecordList</code> that represents a record list of
///  <code>ProcessOutput</code>
/// </summary>
public partial class RL_bc43d11ed6e576c35db6fd694bd47a1e : GenericRecordList<RC_d5e6f13d187b5006f9f88b20f576700b>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d5e6f13d187b5006f9f88b20f576700b GetElementDefaultValue() {
return new RC_d5e6f13d187b5006f9f88b20f576700b();
}

public T[] ToArray<T>(Func<RC_d5e6f13d187b5006f9f88b20f576700b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bc43d11ed6e576c35db6fd694bd47a1e recordList, Func<RC_d5e6f13d187b5006f9f88b20f576700b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bc43d11ed6e576c35db6fd694bd47a1e(RC_d5e6f13d187b5006f9f88b20f576700b[] array) {
  RL_bc43d11ed6e576c35db6fd694bd47a1e result = new RL_bc43d11ed6e576c35db6fd694bd47a1e();
result.InnerFromArray(array);
    return result;
}

public static RL_bc43d11ed6e576c35db6fd694bd47a1e ToList<T>(T[] array, Func <T, RC_d5e6f13d187b5006f9f88b20f576700b> converter) {
  RL_bc43d11ed6e576c35db6fd694bd47a1e result = new RL_bc43d11ed6e576c35db6fd694bd47a1e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bc43d11ed6e576c35db6fd694bd47a1e FromRestList<T>(RestList<T> restList, Func <T, RC_d5e6f13d187b5006f9f88b20f576700b> converter) {
  RL_bc43d11ed6e576c35db6fd694bd47a1e result = new RL_bc43d11ed6e576c35db6fd694bd47a1e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bc43d11ed6e576c35db6fd694bd47a1e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d5e6f13d187b5006f9f88b20f576700b> NewList() {
return new RL_bc43d11ed6e576c35db6fd694bd47a1e();
}


} // RL_bc43d11ed6e576c35db6fd694bd47a1e
}

