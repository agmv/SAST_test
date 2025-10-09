namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (elhnbWC0B0ySm8H9T7hSdA)
///  <code>RC_79f003baa030e546826ed42c3962f582</code> that represents <code>UserInfoRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserInfoRecord
public partial struct RC_79f003baa030e546826ed42c3962f582 : ITypedRecord<RC_79f003baa030e546826ed42c3962f582> {
internal static readonly GlobalObjectKey IdUserInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ugPweTCgRuWCbtQsOWL1gg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UserInfo")]
public ST_401f0448f59979847b24ebdd2db9e1ebStructure ssSTUserInfo;


public static implicit operator ST_401f0448f59979847b24ebdd2db9e1ebStructure( RC_79f003baa030e546826ed42c3962f582 r) {
return r.ssSTUserInfo;
}

public static implicit operator RC_79f003baa030e546826ed42c3962f582 (ST_401f0448f59979847b24ebdd2db9e1ebStructure r) {
RC_79f003baa030e546826ed42c3962f582 res = new RC_79f003baa030e546826ed42c3962f582 ();
res.ssSTUserInfo = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_79f003baa030e546826ed42c3962f582() {
OptimizedAttributes = null;
ssSTUserInfo = new ST_401f0448f59979847b24ebdd2db9e1ebStructure();
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
    ssSTUserInfo.OptimizedAttributes = value[0];
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
ssSTUserInfo.Read( r, ref index);
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
public void ReadIM(RC_79f003baa030e546826ed42c3962f582 r) {
this = r;
}


public static bool operator == (RC_79f003baa030e546826ed42c3962f582 a, RC_79f003baa030e546826ed42c3962f582 b) {
if (a.ssSTUserInfo != b.ssSTUserInfo) return false;
return true;
}

public static bool operator != (RC_79f003baa030e546826ed42c3962f582 a, RC_79f003baa030e546826ed42c3962f582 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_79f003baa030e546826ed42c3962f582)) return false;
return (this == (RC_79f003baa030e546826ed42c3962f582)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserInfo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserInfo.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserInfo.InternalRecursiveSave();
}


public RC_79f003baa030e546826ed42c3962f582 Duplicate() {
RC_79f003baa030e546826ed42c3962f582 t;
t.ssSTUserInfo = (ST_401f0448f59979847b24ebdd2db9e1ebStructure)this.ssSTUserInfo.Duplicate();
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
if (head == "userinfo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserInfo")) variable.Value = ssSTUserInfo; else variable.Optimized = true;
variable.SetFieldName("userinfo");
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
if (key == IdUserInfo) {
return ssSTUserInfo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserInfo.Key.AsGuid) {
return ssSTUserInfo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserInfo.FillFromOther((IRecord) other.AttributeGet(IdUserInfo));
}
} // RC_79f003baa030e546826ed42c3962f582
/// <summary>
/// RecordList type <code>UserInfoRecordList</code> that represents a record list of
///  <code>UserInfo</code>
/// </summary>
public partial class RL_1503951706c05a1675ae923dc239c757 : GenericRecordList<RC_79f003baa030e546826ed42c3962f582>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_79f003baa030e546826ed42c3962f582 GetElementDefaultValue() {
return new RC_79f003baa030e546826ed42c3962f582();
}

public T[] ToArray<T>(Func<RC_79f003baa030e546826ed42c3962f582, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1503951706c05a1675ae923dc239c757 recordList, Func<RC_79f003baa030e546826ed42c3962f582, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1503951706c05a1675ae923dc239c757(RC_79f003baa030e546826ed42c3962f582[] array) {
  RL_1503951706c05a1675ae923dc239c757 result = new RL_1503951706c05a1675ae923dc239c757();
result.InnerFromArray(array);
    return result;
}

public static RL_1503951706c05a1675ae923dc239c757 ToList<T>(T[] array, Func <T, RC_79f003baa030e546826ed42c3962f582> converter) {
  RL_1503951706c05a1675ae923dc239c757 result = new RL_1503951706c05a1675ae923dc239c757();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1503951706c05a1675ae923dc239c757 FromRestList<T>(RestList<T> restList, Func <T, RC_79f003baa030e546826ed42c3962f582> converter) {
  RL_1503951706c05a1675ae923dc239c757 result = new RL_1503951706c05a1675ae923dc239c757();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1503951706c05a1675ae923dc239c757() : base() {
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
protected override OSList<RC_79f003baa030e546826ed42c3962f582> NewList() {
return new RL_1503951706c05a1675ae923dc239c757();
}


} // RL_1503951706c05a1675ae923dc239c757
}

