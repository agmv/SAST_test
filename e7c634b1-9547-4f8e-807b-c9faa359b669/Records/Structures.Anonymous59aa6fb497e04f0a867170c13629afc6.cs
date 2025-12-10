namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (tG+qWeCXCk+GcXDBNimvxg)
///  <code>RC_f58af668359cdeaaa540e4e6dadabd34</code> that represent
/// s <code>SampleListEntityRecord</code> <p>Description: </p>
/// </summary>
// Name: SampleListEntityRecord
public partial struct RC_f58af668359cdeaaa540e4e6dadabd34 : ITypedRecord<RC_f58af668359cdeaaa540e4e6dadabd34> {
internal static readonly GlobalObjectKey IdSampleListEntity = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aPaK9Zw1qt6lQOTm2tq9NA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SampleListEntity")]
public EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord ssENSampleListEntity;


public static implicit operator EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord( RC_f58af668359cdeaaa540e4e6dadabd34 r) {
return r.ssENSampleListEntity;
}

public static implicit operator RC_f58af668359cdeaaa540e4e6dadabd34 (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord r) {
RC_f58af668359cdeaaa540e4e6dadabd34 res = new RC_f58af668359cdeaaa540e4e6dadabd34 ();
res.ssENSampleListEntity = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSampleListEntity.ChangedAttributes = value;
}
get {
    return ssENSampleListEntity.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f58af668359cdeaaa540e4e6dadabd34() {
OptimizedAttributes = null;
ssENSampleListEntity = new EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSampleListEntity.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSampleListEntity.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSampleListEntity.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSampleListEntity.Read( r, ref index);
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
public void ReadIM(RC_f58af668359cdeaaa540e4e6dadabd34 r) {
this = r;
}


public static bool operator == (RC_f58af668359cdeaaa540e4e6dadabd34 a, RC_f58af668359cdeaaa540e4e6dadabd34 b) {
if (a.ssENSampleListEntity != b.ssENSampleListEntity) return false;
return true;
}

public static bool operator != (RC_f58af668359cdeaaa540e4e6dadabd34 a, RC_f58af668359cdeaaa540e4e6dadabd34 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f58af668359cdeaaa540e4e6dadabd34)) return false;
return (this == (RC_f58af668359cdeaaa540e4e6dadabd34)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSampleListEntity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSampleListEntity.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSampleListEntity.InternalRecursiveSave();
}


public RC_f58af668359cdeaaa540e4e6dadabd34 Duplicate() {
RC_f58af668359cdeaaa540e4e6dadabd34 t;
t.ssENSampleListEntity = (EN_ec446d8b8b73647ceab37071e9e48fbdEntityRecord)this.ssENSampleListEntity.Duplicate();
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
if (head == "samplelistentity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SampleListEntity")) variable.Value = ssENSampleListEntity; else variable.Optimized = true;
variable.SetFieldName("samplelistentity");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSampleListEntity.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSampleListEntity.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSampleListEntity) {
return ssENSampleListEntity;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSampleListEntity.Key.AsGuid) {
return ssENSampleListEntity;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSampleListEntity.FillFromOther((IRecord) other.AttributeGet(IdSampleListEntity));
}
} // RC_f58af668359cdeaaa540e4e6dadabd34
/// <summary>
/// RecordList type <code>SampleListEntityRecordList</code> that represents a record list of
///  <code>SampleListEntity</code>
/// </summary>
public partial class RL_677b1053a44870339ea33453b927fdea : GenericRecordList<RC_f58af668359cdeaaa540e4e6dadabd34>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f58af668359cdeaaa540e4e6dadabd34 GetElementDefaultValue() {
return new RC_f58af668359cdeaaa540e4e6dadabd34();
}

public T[] ToArray<T>(Func<RC_f58af668359cdeaaa540e4e6dadabd34, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_677b1053a44870339ea33453b927fdea recordList, Func<RC_f58af668359cdeaaa540e4e6dadabd34, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_677b1053a44870339ea33453b927fdea(RC_f58af668359cdeaaa540e4e6dadabd34[] array) {
  RL_677b1053a44870339ea33453b927fdea result = new RL_677b1053a44870339ea33453b927fdea();
result.InnerFromArray(array);
    return result;
}

public static RL_677b1053a44870339ea33453b927fdea ToList<T>(T[] array, Func <T, RC_f58af668359cdeaaa540e4e6dadabd34> converter) {
  RL_677b1053a44870339ea33453b927fdea result = new RL_677b1053a44870339ea33453b927fdea();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_677b1053a44870339ea33453b927fdea FromRestList<T>(RestList<T> restList, Func <T, RC_f58af668359cdeaaa540e4e6dadabd34> converter) {
  RL_677b1053a44870339ea33453b927fdea result = new RL_677b1053a44870339ea33453b927fdea();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_677b1053a44870339ea33453b927fdea() : base() {
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
protected override OSList<RC_f58af668359cdeaaa540e4e6dadabd34> NewList() {
return new RL_677b1053a44870339ea33453b927fdea();
}


} // RL_677b1053a44870339ea33453b927fdea
}

