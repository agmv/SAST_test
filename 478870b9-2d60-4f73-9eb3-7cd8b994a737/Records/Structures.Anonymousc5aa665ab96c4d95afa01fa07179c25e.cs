namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (WmaqxWy5lU2voB+gcXnCXg)
///  <code>RC_a582d84634a30a3a3b1e61cbfd3db9de</code> that represents <code>UserUpdateInfoRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserUpdateInfoRecord
public partial struct RC_a582d84634a30a3a3b1e61cbfd3db9de : ITypedRecord<RC_a582d84634a30a3a3b1e61cbfd3db9de> {
internal static readonly GlobalObjectKey IdUserUpdateInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RtiCpaM0Ogo7HmHL_T253g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UserUpdateInfo")]
public ST_da83da85e5348cd2800e701fda6288aaStructure ssSTUserUpdateInfo;


public static implicit operator ST_da83da85e5348cd2800e701fda6288aaStructure( RC_a582d84634a30a3a3b1e61cbfd3db9de r) {
return r.ssSTUserUpdateInfo;
}

public static implicit operator RC_a582d84634a30a3a3b1e61cbfd3db9de (ST_da83da85e5348cd2800e701fda6288aaStructure r) {
RC_a582d84634a30a3a3b1e61cbfd3db9de res = new RC_a582d84634a30a3a3b1e61cbfd3db9de ();
res.ssSTUserUpdateInfo = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a582d84634a30a3a3b1e61cbfd3db9de() {
OptimizedAttributes = null;
ssSTUserUpdateInfo = new ST_da83da85e5348cd2800e701fda6288aaStructure();
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
    ssSTUserUpdateInfo.OptimizedAttributes = value[0];
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
ssSTUserUpdateInfo.Read( r, ref index);
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
public void ReadIM(RC_a582d84634a30a3a3b1e61cbfd3db9de r) {
this = r;
}


public static bool operator == (RC_a582d84634a30a3a3b1e61cbfd3db9de a, RC_a582d84634a30a3a3b1e61cbfd3db9de b) {
if (a.ssSTUserUpdateInfo != b.ssSTUserUpdateInfo) return false;
return true;
}

public static bool operator != (RC_a582d84634a30a3a3b1e61cbfd3db9de a, RC_a582d84634a30a3a3b1e61cbfd3db9de b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a582d84634a30a3a3b1e61cbfd3db9de)) return false;
return (this == (RC_a582d84634a30a3a3b1e61cbfd3db9de)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserUpdateInfo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserUpdateInfo.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserUpdateInfo.InternalRecursiveSave();
}


public RC_a582d84634a30a3a3b1e61cbfd3db9de Duplicate() {
RC_a582d84634a30a3a3b1e61cbfd3db9de t;
t.ssSTUserUpdateInfo = (ST_da83da85e5348cd2800e701fda6288aaStructure)this.ssSTUserUpdateInfo.Duplicate();
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
if (head == "userupdateinfo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserUpdateInfo")) variable.Value = ssSTUserUpdateInfo; else variable.Optimized = true;
variable.SetFieldName("userupdateinfo");
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
if (key == IdUserUpdateInfo) {
return ssSTUserUpdateInfo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserUpdateInfo.Key.AsGuid) {
return ssSTUserUpdateInfo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserUpdateInfo.FillFromOther((IRecord) other.AttributeGet(IdUserUpdateInfo));
}
} // RC_a582d84634a30a3a3b1e61cbfd3db9de
/// <summary>
/// RecordList type <code>UserUpdateInfoRecordList</code> that represents a record list of
///  <code>UserUpdateInfo</code>
/// </summary>
public partial class RL_a5b6b975942e234f0350205b728240be : GenericRecordList<RC_a582d84634a30a3a3b1e61cbfd3db9de>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a582d84634a30a3a3b1e61cbfd3db9de GetElementDefaultValue() {
return new RC_a582d84634a30a3a3b1e61cbfd3db9de();
}

public T[] ToArray<T>(Func<RC_a582d84634a30a3a3b1e61cbfd3db9de, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a5b6b975942e234f0350205b728240be recordList, Func<RC_a582d84634a30a3a3b1e61cbfd3db9de, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a5b6b975942e234f0350205b728240be(RC_a582d84634a30a3a3b1e61cbfd3db9de[] array) {
  RL_a5b6b975942e234f0350205b728240be result = new RL_a5b6b975942e234f0350205b728240be();
result.InnerFromArray(array);
    return result;
}

public static RL_a5b6b975942e234f0350205b728240be ToList<T>(T[] array, Func <T, RC_a582d84634a30a3a3b1e61cbfd3db9de> converter) {
  RL_a5b6b975942e234f0350205b728240be result = new RL_a5b6b975942e234f0350205b728240be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a5b6b975942e234f0350205b728240be FromRestList<T>(RestList<T> restList, Func <T, RC_a582d84634a30a3a3b1e61cbfd3db9de> converter) {
  RL_a5b6b975942e234f0350205b728240be result = new RL_a5b6b975942e234f0350205b728240be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a5b6b975942e234f0350205b728240be() : base() {
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
protected override OSList<RC_a582d84634a30a3a3b1e61cbfd3db9de> NewList() {
return new RL_a5b6b975942e234f0350205b728240be();
}


} // RL_a5b6b975942e234f0350205b728240be
}

