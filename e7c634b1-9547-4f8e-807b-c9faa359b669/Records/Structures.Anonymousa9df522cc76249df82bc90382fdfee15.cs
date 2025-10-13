namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (LFLfqWLH30mCvJA4L9_uFQ)
///  <code>RC_cb713964cdef6257549c9c600e5dce68</code> that represents <code>Employee2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: Employee2Record
public partial struct RC_cb713964cdef6257549c9c600e5dce68 : ITypedRecord<RC_cb713964cdef6257549c9c600e5dce68> {
internal static readonly GlobalObjectKey IdEmployee2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZDlxy+_NV2JUnJxgDl3OaA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Employee2")]
public ST_c6c92e08cc1756053230783f07370fc0Structure ssSTEmployee2;


public static implicit operator ST_c6c92e08cc1756053230783f07370fc0Structure( RC_cb713964cdef6257549c9c600e5dce68 r) {
return r.ssSTEmployee2;
}

public static implicit operator RC_cb713964cdef6257549c9c600e5dce68 (ST_c6c92e08cc1756053230783f07370fc0Structure r) {
RC_cb713964cdef6257549c9c600e5dce68 res = new RC_cb713964cdef6257549c9c600e5dce68 ();
res.ssSTEmployee2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_cb713964cdef6257549c9c600e5dce68() {
OptimizedAttributes = null;
ssSTEmployee2 = new ST_c6c92e08cc1756053230783f07370fc0Structure();
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
    ssSTEmployee2.OptimizedAttributes = value[0];
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
ssSTEmployee2.Read( r, ref index);
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
public void ReadIM(RC_cb713964cdef6257549c9c600e5dce68 r) {
this = r;
}


public static bool operator == (RC_cb713964cdef6257549c9c600e5dce68 a, RC_cb713964cdef6257549c9c600e5dce68 b) {
if (a.ssSTEmployee2 != b.ssSTEmployee2) return false;
return true;
}

public static bool operator != (RC_cb713964cdef6257549c9c600e5dce68 a, RC_cb713964cdef6257549c9c600e5dce68 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cb713964cdef6257549c9c600e5dce68)) return false;
return (this == (RC_cb713964cdef6257549c9c600e5dce68)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEmployee2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEmployee2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEmployee2.InternalRecursiveSave();
}


public RC_cb713964cdef6257549c9c600e5dce68 Duplicate() {
RC_cb713964cdef6257549c9c600e5dce68 t;
t.ssSTEmployee2 = (ST_c6c92e08cc1756053230783f07370fc0Structure)this.ssSTEmployee2.Duplicate();
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
if (head == "employee2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Employee2")) variable.Value = ssSTEmployee2; else variable.Optimized = true;
variable.SetFieldName("employee2");
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
if (key == IdEmployee2) {
return ssSTEmployee2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmployee2.Key.AsGuid) {
return ssSTEmployee2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEmployee2.FillFromOther((IRecord) other.AttributeGet(IdEmployee2));
}
} // RC_cb713964cdef6257549c9c600e5dce68
/// <summary>
/// RecordList type <code>Employee2RecordList</code> that represents a record list of
///  <code>Employee2</code>
/// </summary>
public partial class RL_d02488300b5839f7f1f8898c3a6b0d57 : GenericRecordList<RC_cb713964cdef6257549c9c600e5dce68>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_cb713964cdef6257549c9c600e5dce68 GetElementDefaultValue() {
return new RC_cb713964cdef6257549c9c600e5dce68();
}

public T[] ToArray<T>(Func<RC_cb713964cdef6257549c9c600e5dce68, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d02488300b5839f7f1f8898c3a6b0d57 recordList, Func<RC_cb713964cdef6257549c9c600e5dce68, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d02488300b5839f7f1f8898c3a6b0d57(RC_cb713964cdef6257549c9c600e5dce68[] array) {
  RL_d02488300b5839f7f1f8898c3a6b0d57 result = new RL_d02488300b5839f7f1f8898c3a6b0d57();
result.InnerFromArray(array);
    return result;
}

public static RL_d02488300b5839f7f1f8898c3a6b0d57 ToList<T>(T[] array, Func <T, RC_cb713964cdef6257549c9c600e5dce68> converter) {
  RL_d02488300b5839f7f1f8898c3a6b0d57 result = new RL_d02488300b5839f7f1f8898c3a6b0d57();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d02488300b5839f7f1f8898c3a6b0d57 FromRestList<T>(RestList<T> restList, Func <T, RC_cb713964cdef6257549c9c600e5dce68> converter) {
  RL_d02488300b5839f7f1f8898c3a6b0d57 result = new RL_d02488300b5839f7f1f8898c3a6b0d57();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d02488300b5839f7f1f8898c3a6b0d57() : base() {
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
protected override OSList<RC_cb713964cdef6257549c9c600e5dce68> NewList() {
return new RL_d02488300b5839f7f1f8898c3a6b0d57();
}


} // RL_d02488300b5839f7f1f8898c3a6b0d57
}

