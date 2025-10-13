namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (hhobC6mac0CRyJrdFgyyIA)
///  <code>RC_49344a0c853da358d36b40a428b7e5a5</code> that represents <code>SampleListGetRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SampleListGetRecord
public partial struct RC_49344a0c853da358d36b40a428b7e5a5 : ITypedRecord<RC_49344a0c853da358d36b40a428b7e5a5> {
internal static readonly GlobalObjectKey IdSampleListGet = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DEo0ST2FWKPTa0CkKLflpQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SampleListGet")]
public EN_80054628bf73dfa0a64914948a216302EntityRecord ssENSampleListGet;


public static implicit operator EN_80054628bf73dfa0a64914948a216302EntityRecord( RC_49344a0c853da358d36b40a428b7e5a5 r) {
return r.ssENSampleListGet;
}

public static implicit operator RC_49344a0c853da358d36b40a428b7e5a5 (EN_80054628bf73dfa0a64914948a216302EntityRecord r) {
RC_49344a0c853da358d36b40a428b7e5a5 res = new RC_49344a0c853da358d36b40a428b7e5a5 ();
res.ssENSampleListGet = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSampleListGet.ChangedAttributes = value;
}
get {
    return ssENSampleListGet.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_49344a0c853da358d36b40a428b7e5a5() {
OptimizedAttributes = null;
ssENSampleListGet = new EN_80054628bf73dfa0a64914948a216302EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSampleListGet.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSampleListGet.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSampleListGet.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSampleListGet.Read( r, ref index);
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
public void ReadIM(RC_49344a0c853da358d36b40a428b7e5a5 r) {
this = r;
}


public static bool operator == (RC_49344a0c853da358d36b40a428b7e5a5 a, RC_49344a0c853da358d36b40a428b7e5a5 b) {
if (a.ssENSampleListGet != b.ssENSampleListGet) return false;
return true;
}

public static bool operator != (RC_49344a0c853da358d36b40a428b7e5a5 a, RC_49344a0c853da358d36b40a428b7e5a5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_49344a0c853da358d36b40a428b7e5a5)) return false;
return (this == (RC_49344a0c853da358d36b40a428b7e5a5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSampleListGet.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSampleListGet.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSampleListGet.InternalRecursiveSave();
}


public RC_49344a0c853da358d36b40a428b7e5a5 Duplicate() {
RC_49344a0c853da358d36b40a428b7e5a5 t;
t.ssENSampleListGet = (EN_80054628bf73dfa0a64914948a216302EntityRecord)this.ssENSampleListGet.Duplicate();
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
if (head == "samplelistget") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SampleListGet")) variable.Value = ssENSampleListGet; else variable.Optimized = true;
variable.SetFieldName("samplelistget");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSampleListGet.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSampleListGet.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSampleListGet) {
return ssENSampleListGet;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSampleListGet.Key.AsGuid) {
return ssENSampleListGet;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSampleListGet.FillFromOther((IRecord) other.AttributeGet(IdSampleListGet));
}
} // RC_49344a0c853da358d36b40a428b7e5a5
/// <summary>
/// RecordList type <code>SampleListGetRecordList</code> that represents a record list of
///  <code>SampleListGet</code>
/// </summary>
public partial class RL_3f06d244b0b5226052eebe4a6c0636e0 : GenericRecordList<RC_49344a0c853da358d36b40a428b7e5a5>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_49344a0c853da358d36b40a428b7e5a5 GetElementDefaultValue() {
return new RC_49344a0c853da358d36b40a428b7e5a5();
}

public T[] ToArray<T>(Func<RC_49344a0c853da358d36b40a428b7e5a5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3f06d244b0b5226052eebe4a6c0636e0 recordList, Func<RC_49344a0c853da358d36b40a428b7e5a5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3f06d244b0b5226052eebe4a6c0636e0(RC_49344a0c853da358d36b40a428b7e5a5[] array) {
  RL_3f06d244b0b5226052eebe4a6c0636e0 result = new RL_3f06d244b0b5226052eebe4a6c0636e0();
result.InnerFromArray(array);
    return result;
}

public static RL_3f06d244b0b5226052eebe4a6c0636e0 ToList<T>(T[] array, Func <T, RC_49344a0c853da358d36b40a428b7e5a5> converter) {
  RL_3f06d244b0b5226052eebe4a6c0636e0 result = new RL_3f06d244b0b5226052eebe4a6c0636e0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3f06d244b0b5226052eebe4a6c0636e0 FromRestList<T>(RestList<T> restList, Func <T, RC_49344a0c853da358d36b40a428b7e5a5> converter) {
  RL_3f06d244b0b5226052eebe4a6c0636e0 result = new RL_3f06d244b0b5226052eebe4a6c0636e0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3f06d244b0b5226052eebe4a6c0636e0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_49344a0c853da358d36b40a428b7e5a5> NewList() {
return new RL_3f06d244b0b5226052eebe4a6c0636e0();
}


} // RL_3f06d244b0b5226052eebe4a6c0636e0
}

