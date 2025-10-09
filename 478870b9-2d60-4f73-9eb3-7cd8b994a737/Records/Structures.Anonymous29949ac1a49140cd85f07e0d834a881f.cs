namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (wZqUKZGkzUCF8H4Ng0qIHw)
///  <code>RC_8f8c9b77bcc0996564febb7d38ea930a</code> that represent
/// s <code>StartResetPasswordResultRecord</code> <p>Description: </p>
/// </summary>
// Name: StartResetPasswordResultRecord
public partial struct RC_8f8c9b77bcc0996564febb7d38ea930a : ITypedRecord<RC_8f8c9b77bcc0996564febb7d38ea930a> {
internal static readonly GlobalObjectKey IdStartResetPasswordResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d5uMj8C8ZZlk_rt9OOqTCg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StartResetPasswordResult")]
public ST_7df0b593cd1052614bf3d2f66d1ab2efStructure ssSTStartResetPasswordResult;


public static implicit operator ST_7df0b593cd1052614bf3d2f66d1ab2efStructure( RC_8f8c9b77bcc0996564febb7d38ea930a r) {
return r.ssSTStartResetPasswordResult;
}

public static implicit operator RC_8f8c9b77bcc0996564febb7d38ea930a (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure r) {
RC_8f8c9b77bcc0996564febb7d38ea930a res = new RC_8f8c9b77bcc0996564febb7d38ea930a ();
res.ssSTStartResetPasswordResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8f8c9b77bcc0996564febb7d38ea930a() {
OptimizedAttributes = null;
ssSTStartResetPasswordResult = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();
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
    ssSTStartResetPasswordResult.OptimizedAttributes = value[0];
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
ssSTStartResetPasswordResult.Read( r, ref index);
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
public void ReadIM(RC_8f8c9b77bcc0996564febb7d38ea930a r) {
this = r;
}


public static bool operator == (RC_8f8c9b77bcc0996564febb7d38ea930a a, RC_8f8c9b77bcc0996564febb7d38ea930a b) {
if (a.ssSTStartResetPasswordResult != b.ssSTStartResetPasswordResult) return false;
return true;
}

public static bool operator != (RC_8f8c9b77bcc0996564febb7d38ea930a a, RC_8f8c9b77bcc0996564febb7d38ea930a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8f8c9b77bcc0996564febb7d38ea930a)) return false;
return (this == (RC_8f8c9b77bcc0996564febb7d38ea930a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStartResetPasswordResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStartResetPasswordResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStartResetPasswordResult.InternalRecursiveSave();
}


public RC_8f8c9b77bcc0996564febb7d38ea930a Duplicate() {
RC_8f8c9b77bcc0996564febb7d38ea930a t;
t.ssSTStartResetPasswordResult = (ST_7df0b593cd1052614bf3d2f66d1ab2efStructure)this.ssSTStartResetPasswordResult.Duplicate();
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
if (head == "startresetpasswordresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartResetPasswordResult")) variable.Value = ssSTStartResetPasswordResult; else variable.Optimized = true;
variable.SetFieldName("startresetpasswordresult");
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
if (key == IdStartResetPasswordResult) {
return ssSTStartResetPasswordResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStartResetPasswordResult.Key.AsGuid) {
return ssSTStartResetPasswordResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStartResetPasswordResult.FillFromOther((IRecord) other.AttributeGet(IdStartResetPasswordResult));
}
} // RC_8f8c9b77bcc0996564febb7d38ea930a
/// <summary>
/// RecordList type <code>StartResetPasswordResultRecordList</code> that represents a record list of
///  <code>StartResetPasswordResult</code>
/// </summary>
public partial class RL_8c6f3d2b086b4a75242a7e7c084f1692 : GenericRecordList<RC_8f8c9b77bcc0996564febb7d38ea930a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8f8c9b77bcc0996564febb7d38ea930a GetElementDefaultValue() {
return new RC_8f8c9b77bcc0996564febb7d38ea930a();
}

public T[] ToArray<T>(Func<RC_8f8c9b77bcc0996564febb7d38ea930a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8c6f3d2b086b4a75242a7e7c084f1692 recordList, Func<RC_8f8c9b77bcc0996564febb7d38ea930a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8c6f3d2b086b4a75242a7e7c084f1692(RC_8f8c9b77bcc0996564febb7d38ea930a[] array) {
  RL_8c6f3d2b086b4a75242a7e7c084f1692 result = new RL_8c6f3d2b086b4a75242a7e7c084f1692();
result.InnerFromArray(array);
    return result;
}

public static RL_8c6f3d2b086b4a75242a7e7c084f1692 ToList<T>(T[] array, Func <T, RC_8f8c9b77bcc0996564febb7d38ea930a> converter) {
  RL_8c6f3d2b086b4a75242a7e7c084f1692 result = new RL_8c6f3d2b086b4a75242a7e7c084f1692();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8c6f3d2b086b4a75242a7e7c084f1692 FromRestList<T>(RestList<T> restList, Func <T, RC_8f8c9b77bcc0996564febb7d38ea930a> converter) {
  RL_8c6f3d2b086b4a75242a7e7c084f1692 result = new RL_8c6f3d2b086b4a75242a7e7c084f1692();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8c6f3d2b086b4a75242a7e7c084f1692() : base() {
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
protected override OSList<RC_8f8c9b77bcc0996564febb7d38ea930a> NewList() {
return new RL_8c6f3d2b086b4a75242a7e7c084f1692();
}


} // RL_8c6f3d2b086b4a75242a7e7c084f1692
}

