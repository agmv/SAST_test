namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (MRDJka_EPJDYfqynuOJNog)
///  <code>RC_c2c51a49c601586c1a143904ac6893f9</code> that represents <code>ProcessInstanceRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProcessInstanceRecord
public partial struct RC_c2c51a49c601586c1a143904ac6893f9 : ITypedRecord<RC_c2c51a49c601586c1a143904ac6893f9> {
internal static readonly GlobalObjectKey IdProcessInstance = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SRrFwgHGbFgaFDkErGiT+Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessInstance")]
public ENProcessInstanceEntityRecord ssENProcessInstance;


public static implicit operator ENProcessInstanceEntityRecord( RC_c2c51a49c601586c1a143904ac6893f9 r) {
return r.ssENProcessInstance;
}

public static implicit operator RC_c2c51a49c601586c1a143904ac6893f9 (ENProcessInstanceEntityRecord r) {
RC_c2c51a49c601586c1a143904ac6893f9 res = new RC_c2c51a49c601586c1a143904ac6893f9 ();
res.ssENProcessInstance = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessInstance.ChangedAttributes = value;
}
get {
    return ssENProcessInstance.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c2c51a49c601586c1a143904ac6893f9() {
OptimizedAttributes = null;
ssENProcessInstance = new ENProcessInstanceEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessInstance.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessInstance.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessInstance.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessInstance.Read( r, ref index);
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
public void ReadIM(RC_c2c51a49c601586c1a143904ac6893f9 r) {
this = r;
}


public static bool operator == (RC_c2c51a49c601586c1a143904ac6893f9 a, RC_c2c51a49c601586c1a143904ac6893f9 b) {
if (a.ssENProcessInstance != b.ssENProcessInstance) return false;
return true;
}

public static bool operator != (RC_c2c51a49c601586c1a143904ac6893f9 a, RC_c2c51a49c601586c1a143904ac6893f9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c2c51a49c601586c1a143904ac6893f9)) return false;
return (this == (RC_c2c51a49c601586c1a143904ac6893f9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessInstance.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessInstance.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessInstance.InternalRecursiveSave();
}


public RC_c2c51a49c601586c1a143904ac6893f9 Duplicate() {
RC_c2c51a49c601586c1a143904ac6893f9 t;
t.ssENProcessInstance = (ENProcessInstanceEntityRecord)this.ssENProcessInstance.Duplicate();
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
if (head == "processinstance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessInstance")) variable.Value = ssENProcessInstance; else variable.Optimized = true;
variable.SetFieldName("processinstance");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessInstance.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessInstance.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessInstance) {
return ssENProcessInstance;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessInstance.Key.AsGuid) {
return ssENProcessInstance;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessInstance.FillFromOther((IRecord) other.AttributeGet(IdProcessInstance));
}
} // RC_c2c51a49c601586c1a143904ac6893f9
/// <summary>
/// RecordList type <code>ProcessInstanceRecordList</code> that represents a record list of
///  <code>ProcessInstance</code>
/// </summary>
public partial class RL_247a9c7809b4893cc7a21d0914d69e61 : GenericRecordList<RC_c2c51a49c601586c1a143904ac6893f9>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c2c51a49c601586c1a143904ac6893f9 GetElementDefaultValue() {
return new RC_c2c51a49c601586c1a143904ac6893f9();
}

public T[] ToArray<T>(Func<RC_c2c51a49c601586c1a143904ac6893f9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_247a9c7809b4893cc7a21d0914d69e61 recordList, Func<RC_c2c51a49c601586c1a143904ac6893f9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_247a9c7809b4893cc7a21d0914d69e61(RC_c2c51a49c601586c1a143904ac6893f9[] array) {
  RL_247a9c7809b4893cc7a21d0914d69e61 result = new RL_247a9c7809b4893cc7a21d0914d69e61();
result.InnerFromArray(array);
    return result;
}

public static RL_247a9c7809b4893cc7a21d0914d69e61 ToList<T>(T[] array, Func <T, RC_c2c51a49c601586c1a143904ac6893f9> converter) {
  RL_247a9c7809b4893cc7a21d0914d69e61 result = new RL_247a9c7809b4893cc7a21d0914d69e61();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_247a9c7809b4893cc7a21d0914d69e61 FromRestList<T>(RestList<T> restList, Func <T, RC_c2c51a49c601586c1a143904ac6893f9> converter) {
  RL_247a9c7809b4893cc7a21d0914d69e61 result = new RL_247a9c7809b4893cc7a21d0914d69e61();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_247a9c7809b4893cc7a21d0914d69e61() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c2c51a49c601586c1a143904ac6893f9> NewList() {
return new RL_247a9c7809b4893cc7a21d0914d69e61();
}


} // RL_247a9c7809b4893cc7a21d0914d69e61
}

