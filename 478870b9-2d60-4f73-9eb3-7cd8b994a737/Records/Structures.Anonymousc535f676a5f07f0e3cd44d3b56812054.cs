namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (dvY1xfClDn881E07VoEgVA)
///  <code>RC_99e7afb0bae555fcf70d1cd06f23ae14</code> that represents <code>ActivityKindRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ActivityKindRecord
public partial struct RC_99e7afb0bae555fcf70d1cd06f23ae14 : ITypedRecord<RC_99e7afb0bae555fcf70d1cd06f23ae14> {
internal static readonly GlobalObjectKey IdActivityKind = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sK_nmeW6_FX3DRzQbyOuFA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityKind")]
public ENActivityKindEntityRecord ssENActivityKind;


public static implicit operator ENActivityKindEntityRecord( RC_99e7afb0bae555fcf70d1cd06f23ae14 r) {
return r.ssENActivityKind;
}

public static implicit operator RC_99e7afb0bae555fcf70d1cd06f23ae14 (ENActivityKindEntityRecord r) {
RC_99e7afb0bae555fcf70d1cd06f23ae14 res = new RC_99e7afb0bae555fcf70d1cd06f23ae14 ();
res.ssENActivityKind = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityKind.ChangedAttributes = value;
}
get {
    return ssENActivityKind.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_99e7afb0bae555fcf70d1cd06f23ae14() {
OptimizedAttributes = null;
ssENActivityKind = new ENActivityKindEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityKind.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityKind.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityKind.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityKind.Read( r, ref index);
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
public void ReadIM(RC_99e7afb0bae555fcf70d1cd06f23ae14 r) {
this = r;
}


public static bool operator == (RC_99e7afb0bae555fcf70d1cd06f23ae14 a, RC_99e7afb0bae555fcf70d1cd06f23ae14 b) {
if (a.ssENActivityKind != b.ssENActivityKind) return false;
return true;
}

public static bool operator != (RC_99e7afb0bae555fcf70d1cd06f23ae14 a, RC_99e7afb0bae555fcf70d1cd06f23ae14 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_99e7afb0bae555fcf70d1cd06f23ae14)) return false;
return (this == (RC_99e7afb0bae555fcf70d1cd06f23ae14)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityKind.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityKind.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityKind.InternalRecursiveSave();
}


public RC_99e7afb0bae555fcf70d1cd06f23ae14 Duplicate() {
RC_99e7afb0bae555fcf70d1cd06f23ae14 t;
t.ssENActivityKind = (ENActivityKindEntityRecord)this.ssENActivityKind.Duplicate();
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
if (head == "activitykind") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityKind")) variable.Value = ssENActivityKind; else variable.Optimized = true;
variable.SetFieldName("activitykind");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityKind.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityKind.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityKind) {
return ssENActivityKind;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityKind.Key.AsGuid) {
return ssENActivityKind;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityKind.FillFromOther((IRecord) other.AttributeGet(IdActivityKind));
}
} // RC_99e7afb0bae555fcf70d1cd06f23ae14
/// <summary>
/// RecordList type <code>ActivityKindRecordList</code> that represents a record list of
///  <code>ActivityKind</code>
/// </summary>
public partial class RL_12438f333dd1f8c1a50e2396d5890dd1 : GenericRecordList<RC_99e7afb0bae555fcf70d1cd06f23ae14>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_99e7afb0bae555fcf70d1cd06f23ae14 GetElementDefaultValue() {
return new RC_99e7afb0bae555fcf70d1cd06f23ae14();
}

public T[] ToArray<T>(Func<RC_99e7afb0bae555fcf70d1cd06f23ae14, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_12438f333dd1f8c1a50e2396d5890dd1 recordList, Func<RC_99e7afb0bae555fcf70d1cd06f23ae14, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_12438f333dd1f8c1a50e2396d5890dd1(RC_99e7afb0bae555fcf70d1cd06f23ae14[] array) {
  RL_12438f333dd1f8c1a50e2396d5890dd1 result = new RL_12438f333dd1f8c1a50e2396d5890dd1();
result.InnerFromArray(array);
    return result;
}

public static RL_12438f333dd1f8c1a50e2396d5890dd1 ToList<T>(T[] array, Func <T, RC_99e7afb0bae555fcf70d1cd06f23ae14> converter) {
  RL_12438f333dd1f8c1a50e2396d5890dd1 result = new RL_12438f333dd1f8c1a50e2396d5890dd1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_12438f333dd1f8c1a50e2396d5890dd1 FromRestList<T>(RestList<T> restList, Func <T, RC_99e7afb0bae555fcf70d1cd06f23ae14> converter) {
  RL_12438f333dd1f8c1a50e2396d5890dd1 result = new RL_12438f333dd1f8c1a50e2396d5890dd1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_12438f333dd1f8c1a50e2396d5890dd1() : base() {
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
protected override OSList<RC_99e7afb0bae555fcf70d1cd06f23ae14> NewList() {
return new RL_12438f333dd1f8c1a50e2396d5890dd1();
}


} // RL_12438f333dd1f8c1a50e2396d5890dd1
}

