namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (nOCFvwTCckOvk+UanhPa1Q)
///  <code>RC_04ad037e78ae694bb0e09c43b99c8b99</code> that represent
/// s <code>HttpRequestStructRecord</code> <p>Description: </p>
/// </summary>
// Name: HttpRequestStructRecord
public partial struct RC_04ad037e78ae694bb0e09c43b99c8b99 : ITypedRecord<RC_04ad037e78ae694bb0e09c43b99c8b99> {
internal static readonly GlobalObjectKey IdHttpRequestStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fgOtBK54S2mw4JxDuZyLmQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HttpRequestStruct")]
public ST_34ce93e9f60ca0d98b2e231b96135f86Structure ssSTHttpRequestStruct;


public static implicit operator ST_34ce93e9f60ca0d98b2e231b96135f86Structure( RC_04ad037e78ae694bb0e09c43b99c8b99 r) {
return r.ssSTHttpRequestStruct;
}

public static implicit operator RC_04ad037e78ae694bb0e09c43b99c8b99 (ST_34ce93e9f60ca0d98b2e231b96135f86Structure r) {
RC_04ad037e78ae694bb0e09c43b99c8b99 res = new RC_04ad037e78ae694bb0e09c43b99c8b99 ();
res.ssSTHttpRequestStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_04ad037e78ae694bb0e09c43b99c8b99() {
OptimizedAttributes = null;
ssSTHttpRequestStruct = new ST_34ce93e9f60ca0d98b2e231b96135f86Structure();
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
    ssSTHttpRequestStruct.OptimizedAttributes = value[0];
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
ssSTHttpRequestStruct.Read( r, ref index);
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
public void ReadIM(RC_04ad037e78ae694bb0e09c43b99c8b99 r) {
this = r;
}


public static bool operator == (RC_04ad037e78ae694bb0e09c43b99c8b99 a, RC_04ad037e78ae694bb0e09c43b99c8b99 b) {
if (a.ssSTHttpRequestStruct != b.ssSTHttpRequestStruct) return false;
return true;
}

public static bool operator != (RC_04ad037e78ae694bb0e09c43b99c8b99 a, RC_04ad037e78ae694bb0e09c43b99c8b99 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_04ad037e78ae694bb0e09c43b99c8b99)) return false;
return (this == (RC_04ad037e78ae694bb0e09c43b99c8b99)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHttpRequestStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHttpRequestStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHttpRequestStruct.InternalRecursiveSave();
}


public RC_04ad037e78ae694bb0e09c43b99c8b99 Duplicate() {
RC_04ad037e78ae694bb0e09c43b99c8b99 t;
t.ssSTHttpRequestStruct = (ST_34ce93e9f60ca0d98b2e231b96135f86Structure)this.ssSTHttpRequestStruct.Duplicate();
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
if (head == "httprequeststruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpRequestStruct")) variable.Value = ssSTHttpRequestStruct; else variable.Optimized = true;
variable.SetFieldName("httprequeststruct");
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
if (key == IdHttpRequestStruct) {
return ssSTHttpRequestStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHttpRequestStruct.Key.AsGuid) {
return ssSTHttpRequestStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHttpRequestStruct.FillFromOther((IRecord) other.AttributeGet(IdHttpRequestStruct));
}
} // RC_04ad037e78ae694bb0e09c43b99c8b99
/// <summary>
/// RecordList type <code>HttpRequestStructRecordList</code> that represents a record list of
///  <code>HttpRequestStruct</code>
/// </summary>
public partial class RL_baf7fbd918ed0b111a92b3bc21b6a983 : GenericRecordList<RC_04ad037e78ae694bb0e09c43b99c8b99>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_04ad037e78ae694bb0e09c43b99c8b99 GetElementDefaultValue() {
return new RC_04ad037e78ae694bb0e09c43b99c8b99();
}

public T[] ToArray<T>(Func<RC_04ad037e78ae694bb0e09c43b99c8b99, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_baf7fbd918ed0b111a92b3bc21b6a983 recordList, Func<RC_04ad037e78ae694bb0e09c43b99c8b99, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_baf7fbd918ed0b111a92b3bc21b6a983(RC_04ad037e78ae694bb0e09c43b99c8b99[] array) {
  RL_baf7fbd918ed0b111a92b3bc21b6a983 result = new RL_baf7fbd918ed0b111a92b3bc21b6a983();
result.InnerFromArray(array);
    return result;
}

public static RL_baf7fbd918ed0b111a92b3bc21b6a983 ToList<T>(T[] array, Func <T, RC_04ad037e78ae694bb0e09c43b99c8b99> converter) {
  RL_baf7fbd918ed0b111a92b3bc21b6a983 result = new RL_baf7fbd918ed0b111a92b3bc21b6a983();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_baf7fbd918ed0b111a92b3bc21b6a983 FromRestList<T>(RestList<T> restList, Func <T, RC_04ad037e78ae694bb0e09c43b99c8b99> converter) {
  RL_baf7fbd918ed0b111a92b3bc21b6a983 result = new RL_baf7fbd918ed0b111a92b3bc21b6a983();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_baf7fbd918ed0b111a92b3bc21b6a983() : base() {
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
protected override OSList<RC_04ad037e78ae694bb0e09c43b99c8b99> NewList() {
return new RL_baf7fbd918ed0b111a92b3bc21b6a983();
}


} // RL_baf7fbd918ed0b111a92b3bc21b6a983
}

