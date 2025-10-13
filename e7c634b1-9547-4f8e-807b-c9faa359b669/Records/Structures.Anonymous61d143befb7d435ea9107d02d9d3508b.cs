namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (vkPRYX37XkOpEH0C2dNQiw)
///  <code>RC_8bd458d44b2829526bf34cf688a965a6</code> that represents <code>Enum_colorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: Enum_colorRecord
public partial struct RC_8bd458d44b2829526bf34cf688a965a6 : ITypedRecord<RC_8bd458d44b2829526bf34cf688a965a6> {
internal static readonly GlobalObjectKey IdEnum_color = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1FjUiyhLUilr80z2iKllpg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Enum_color")]
public EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord ssENEnum_color;


public static implicit operator EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord( RC_8bd458d44b2829526bf34cf688a965a6 r) {
return r.ssENEnum_color;
}

public static implicit operator RC_8bd458d44b2829526bf34cf688a965a6 (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord r) {
RC_8bd458d44b2829526bf34cf688a965a6 res = new RC_8bd458d44b2829526bf34cf688a965a6 ();
res.ssENEnum_color = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEnum_color.ChangedAttributes = value;
}
get {
    return ssENEnum_color.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8bd458d44b2829526bf34cf688a965a6() {
OptimizedAttributes = null;
ssENEnum_color = new EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEnum_color.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEnum_color.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEnum_color.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEnum_color.Read( r, ref index);
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
public void ReadIM(RC_8bd458d44b2829526bf34cf688a965a6 r) {
this = r;
}


public static bool operator == (RC_8bd458d44b2829526bf34cf688a965a6 a, RC_8bd458d44b2829526bf34cf688a965a6 b) {
if (a.ssENEnum_color != b.ssENEnum_color) return false;
return true;
}

public static bool operator != (RC_8bd458d44b2829526bf34cf688a965a6 a, RC_8bd458d44b2829526bf34cf688a965a6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8bd458d44b2829526bf34cf688a965a6)) return false;
return (this == (RC_8bd458d44b2829526bf34cf688a965a6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEnum_color.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEnum_color.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEnum_color.InternalRecursiveSave();
}


public RC_8bd458d44b2829526bf34cf688a965a6 Duplicate() {
RC_8bd458d44b2829526bf34cf688a965a6 t;
t.ssENEnum_color = (EN_b60644b9c1f848a453fbb79152cd6b26EntityRecord)this.ssENEnum_color.Duplicate();
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
if (head == "enum_color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Enum_color")) variable.Value = ssENEnum_color; else variable.Optimized = true;
variable.SetFieldName("enum_color");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEnum_color.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEnum_color.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEnum_color) {
return ssENEnum_color;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEnum_color.Key.AsGuid) {
return ssENEnum_color;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEnum_color.FillFromOther((IRecord) other.AttributeGet(IdEnum_color));
}
} // RC_8bd458d44b2829526bf34cf688a965a6
/// <summary>
/// RecordList type <code>Enum_colorRecordList</code> that represents a record list of
///  <code>Enum_color</code>
/// </summary>
public partial class RL_f0b10ff78369136ce472316abac4440e : GenericRecordList<RC_8bd458d44b2829526bf34cf688a965a6>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8bd458d44b2829526bf34cf688a965a6 GetElementDefaultValue() {
return new RC_8bd458d44b2829526bf34cf688a965a6();
}

public T[] ToArray<T>(Func<RC_8bd458d44b2829526bf34cf688a965a6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f0b10ff78369136ce472316abac4440e recordList, Func<RC_8bd458d44b2829526bf34cf688a965a6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f0b10ff78369136ce472316abac4440e(RC_8bd458d44b2829526bf34cf688a965a6[] array) {
  RL_f0b10ff78369136ce472316abac4440e result = new RL_f0b10ff78369136ce472316abac4440e();
result.InnerFromArray(array);
    return result;
}

public static RL_f0b10ff78369136ce472316abac4440e ToList<T>(T[] array, Func <T, RC_8bd458d44b2829526bf34cf688a965a6> converter) {
  RL_f0b10ff78369136ce472316abac4440e result = new RL_f0b10ff78369136ce472316abac4440e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f0b10ff78369136ce472316abac4440e FromRestList<T>(RestList<T> restList, Func <T, RC_8bd458d44b2829526bf34cf688a965a6> converter) {
  RL_f0b10ff78369136ce472316abac4440e result = new RL_f0b10ff78369136ce472316abac4440e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f0b10ff78369136ce472316abac4440e() : base() {
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
protected override OSList<RC_8bd458d44b2829526bf34cf688a965a6> NewList() {
return new RL_f0b10ff78369136ce472316abac4440e();
}


} // RL_f0b10ff78369136ce472316abac4440e
}

