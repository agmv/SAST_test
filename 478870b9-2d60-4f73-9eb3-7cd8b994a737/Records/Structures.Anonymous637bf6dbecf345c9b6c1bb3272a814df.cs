namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (2_Z7Y_PsyUW2wbsycqgU3w)
///  <code>RC_53d491417faf149f9fb8a0dda9c12d06</code> that represent
/// s <code>ChangePasswordResultRecord</code> <p>Description: </p>
/// </summary>
// Name: ChangePasswordResultRecord
public partial struct RC_53d491417faf149f9fb8a0dda9c12d06 : ITypedRecord<RC_53d491417faf149f9fb8a0dda9c12d06> {
internal static readonly GlobalObjectKey IdChangePasswordResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QZHUU69_nxSfuKDdqcEtBg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ChangePasswordResult")]
public ST_368bb4a94e9c212b75f0247c9d3e6e37Structure ssSTChangePasswordResult;


public static implicit operator ST_368bb4a94e9c212b75f0247c9d3e6e37Structure( RC_53d491417faf149f9fb8a0dda9c12d06 r) {
return r.ssSTChangePasswordResult;
}

public static implicit operator RC_53d491417faf149f9fb8a0dda9c12d06 (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure r) {
RC_53d491417faf149f9fb8a0dda9c12d06 res = new RC_53d491417faf149f9fb8a0dda9c12d06 ();
res.ssSTChangePasswordResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_53d491417faf149f9fb8a0dda9c12d06() {
OptimizedAttributes = null;
ssSTChangePasswordResult = new ST_368bb4a94e9c212b75f0247c9d3e6e37Structure();
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
    ssSTChangePasswordResult.OptimizedAttributes = value[0];
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
ssSTChangePasswordResult.Read( r, ref index);
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
public void ReadIM(RC_53d491417faf149f9fb8a0dda9c12d06 r) {
this = r;
}


public static bool operator == (RC_53d491417faf149f9fb8a0dda9c12d06 a, RC_53d491417faf149f9fb8a0dda9c12d06 b) {
if (a.ssSTChangePasswordResult != b.ssSTChangePasswordResult) return false;
return true;
}

public static bool operator != (RC_53d491417faf149f9fb8a0dda9c12d06 a, RC_53d491417faf149f9fb8a0dda9c12d06 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_53d491417faf149f9fb8a0dda9c12d06)) return false;
return (this == (RC_53d491417faf149f9fb8a0dda9c12d06)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTChangePasswordResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTChangePasswordResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTChangePasswordResult.InternalRecursiveSave();
}


public RC_53d491417faf149f9fb8a0dda9c12d06 Duplicate() {
RC_53d491417faf149f9fb8a0dda9c12d06 t;
t.ssSTChangePasswordResult = (ST_368bb4a94e9c212b75f0247c9d3e6e37Structure)this.ssSTChangePasswordResult.Duplicate();
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
if (head == "changepasswordresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangePasswordResult")) variable.Value = ssSTChangePasswordResult; else variable.Optimized = true;
variable.SetFieldName("changepasswordresult");
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
if (key == IdChangePasswordResult) {
return ssSTChangePasswordResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdChangePasswordResult.Key.AsGuid) {
return ssSTChangePasswordResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTChangePasswordResult.FillFromOther((IRecord) other.AttributeGet(IdChangePasswordResult));
}
} // RC_53d491417faf149f9fb8a0dda9c12d06
/// <summary>
/// RecordList type <code>ChangePasswordResultRecordList</code> that represents a record list of
///  <code>ChangePasswordResult</code>
/// </summary>
public partial class RL_f07d4ee6d8af2ad822d0947b26fdf6f3 : GenericRecordList<RC_53d491417faf149f9fb8a0dda9c12d06>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_53d491417faf149f9fb8a0dda9c12d06 GetElementDefaultValue() {
return new RC_53d491417faf149f9fb8a0dda9c12d06();
}

public T[] ToArray<T>(Func<RC_53d491417faf149f9fb8a0dda9c12d06, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f07d4ee6d8af2ad822d0947b26fdf6f3 recordList, Func<RC_53d491417faf149f9fb8a0dda9c12d06, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f07d4ee6d8af2ad822d0947b26fdf6f3(RC_53d491417faf149f9fb8a0dda9c12d06[] array) {
  RL_f07d4ee6d8af2ad822d0947b26fdf6f3 result = new RL_f07d4ee6d8af2ad822d0947b26fdf6f3();
result.InnerFromArray(array);
    return result;
}

public static RL_f07d4ee6d8af2ad822d0947b26fdf6f3 ToList<T>(T[] array, Func <T, RC_53d491417faf149f9fb8a0dda9c12d06> converter) {
  RL_f07d4ee6d8af2ad822d0947b26fdf6f3 result = new RL_f07d4ee6d8af2ad822d0947b26fdf6f3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f07d4ee6d8af2ad822d0947b26fdf6f3 FromRestList<T>(RestList<T> restList, Func <T, RC_53d491417faf149f9fb8a0dda9c12d06> converter) {
  RL_f07d4ee6d8af2ad822d0947b26fdf6f3 result = new RL_f07d4ee6d8af2ad822d0947b26fdf6f3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f07d4ee6d8af2ad822d0947b26fdf6f3() : base() {
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
protected override OSList<RC_53d491417faf149f9fb8a0dda9c12d06> NewList() {
return new RL_f07d4ee6d8af2ad822d0947b26fdf6f3();
}


} // RL_f07d4ee6d8af2ad822d0947b26fdf6f3
}

