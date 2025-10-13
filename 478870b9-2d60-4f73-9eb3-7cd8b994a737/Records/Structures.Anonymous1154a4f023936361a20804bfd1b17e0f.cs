namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (8KRUEZMjYWOiCAS_0bF+Dw)
///  <code>RC_d43fed74d1678e954ae3786a22cd1029</code> that represents <code>ProcessInputRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProcessInputRecord
public partial struct RC_d43fed74d1678e954ae3786a22cd1029 : ITypedRecord<RC_d43fed74d1678e954ae3786a22cd1029> {
internal static readonly GlobalObjectKey IdProcessInput = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dO0_1GfRlY5K43hqIs0QKQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessInput")]
public ENProcessInputEntityRecord ssENProcessInput;


public static implicit operator ENProcessInputEntityRecord( RC_d43fed74d1678e954ae3786a22cd1029 r) {
return r.ssENProcessInput;
}

public static implicit operator RC_d43fed74d1678e954ae3786a22cd1029 (ENProcessInputEntityRecord r) {
RC_d43fed74d1678e954ae3786a22cd1029 res = new RC_d43fed74d1678e954ae3786a22cd1029 ();
res.ssENProcessInput = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessInput.ChangedAttributes = value;
}
get {
    return ssENProcessInput.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d43fed74d1678e954ae3786a22cd1029() {
OptimizedAttributes = null;
ssENProcessInput = new ENProcessInputEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessInput.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessInput.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessInput.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessInput.Read( r, ref index);
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
public void ReadIM(RC_d43fed74d1678e954ae3786a22cd1029 r) {
this = r;
}


public static bool operator == (RC_d43fed74d1678e954ae3786a22cd1029 a, RC_d43fed74d1678e954ae3786a22cd1029 b) {
if (a.ssENProcessInput != b.ssENProcessInput) return false;
return true;
}

public static bool operator != (RC_d43fed74d1678e954ae3786a22cd1029 a, RC_d43fed74d1678e954ae3786a22cd1029 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d43fed74d1678e954ae3786a22cd1029)) return false;
return (this == (RC_d43fed74d1678e954ae3786a22cd1029)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessInput.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessInput.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessInput.InternalRecursiveSave();
}


public RC_d43fed74d1678e954ae3786a22cd1029 Duplicate() {
RC_d43fed74d1678e954ae3786a22cd1029 t;
t.ssENProcessInput = (ENProcessInputEntityRecord)this.ssENProcessInput.Duplicate();
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
if (head == "processinput") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessInput")) variable.Value = ssENProcessInput; else variable.Optimized = true;
variable.SetFieldName("processinput");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessInput.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessInput.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessInput) {
return ssENProcessInput;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessInput.Key.AsGuid) {
return ssENProcessInput;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessInput.FillFromOther((IRecord) other.AttributeGet(IdProcessInput));
}
} // RC_d43fed74d1678e954ae3786a22cd1029
/// <summary>
/// RecordList type <code>ProcessInputRecordList</code> that represents a record list of
///  <code>ProcessInput</code>
/// </summary>
public partial class RL_d3784dc8f20ed95f2aa0989c41c24312 : GenericRecordList<RC_d43fed74d1678e954ae3786a22cd1029>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d43fed74d1678e954ae3786a22cd1029 GetElementDefaultValue() {
return new RC_d43fed74d1678e954ae3786a22cd1029();
}

public T[] ToArray<T>(Func<RC_d43fed74d1678e954ae3786a22cd1029, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d3784dc8f20ed95f2aa0989c41c24312 recordList, Func<RC_d43fed74d1678e954ae3786a22cd1029, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d3784dc8f20ed95f2aa0989c41c24312(RC_d43fed74d1678e954ae3786a22cd1029[] array) {
  RL_d3784dc8f20ed95f2aa0989c41c24312 result = new RL_d3784dc8f20ed95f2aa0989c41c24312();
result.InnerFromArray(array);
    return result;
}

public static RL_d3784dc8f20ed95f2aa0989c41c24312 ToList<T>(T[] array, Func <T, RC_d43fed74d1678e954ae3786a22cd1029> converter) {
  RL_d3784dc8f20ed95f2aa0989c41c24312 result = new RL_d3784dc8f20ed95f2aa0989c41c24312();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d3784dc8f20ed95f2aa0989c41c24312 FromRestList<T>(RestList<T> restList, Func <T, RC_d43fed74d1678e954ae3786a22cd1029> converter) {
  RL_d3784dc8f20ed95f2aa0989c41c24312 result = new RL_d3784dc8f20ed95f2aa0989c41c24312();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d3784dc8f20ed95f2aa0989c41c24312() : base() {
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
protected override OSList<RC_d43fed74d1678e954ae3786a22cd1029> NewList() {
return new RL_d3784dc8f20ed95f2aa0989c41c24312();
}


} // RL_d3784dc8f20ed95f2aa0989c41c24312
}

