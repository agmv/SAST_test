namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (PR23j2Jyo0qhJiQDH9j54Q)
///  <code>RC_f61c868ef053db94121ce89ee15a14fe</code> that represent
/// s <code>UserLoginFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: UserLoginFailureReasonRecord
public partial struct RC_f61c868ef053db94121ce89ee15a14fe : ITypedRecord<RC_f61c868ef053db94121ce89ee15a14fe> {
internal static readonly GlobalObjectKey IdUserLoginFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*joYc9lPwlNsSHOie4VoU_g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UserLoginFailureReason")]
public ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure ssSTUserLoginFailureReason;


public static implicit operator ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure( RC_f61c868ef053db94121ce89ee15a14fe r) {
return r.ssSTUserLoginFailureReason;
}

public static implicit operator RC_f61c868ef053db94121ce89ee15a14fe (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure r) {
RC_f61c868ef053db94121ce89ee15a14fe res = new RC_f61c868ef053db94121ce89ee15a14fe ();
res.ssSTUserLoginFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f61c868ef053db94121ce89ee15a14fe() {
OptimizedAttributes = null;
ssSTUserLoginFailureReason = new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure();
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
    ssSTUserLoginFailureReason.OptimizedAttributes = value[0];
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
ssSTUserLoginFailureReason.Read( r, ref index);
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
public void ReadIM(RC_f61c868ef053db94121ce89ee15a14fe r) {
this = r;
}


public static bool operator == (RC_f61c868ef053db94121ce89ee15a14fe a, RC_f61c868ef053db94121ce89ee15a14fe b) {
if (a.ssSTUserLoginFailureReason != b.ssSTUserLoginFailureReason) return false;
return true;
}

public static bool operator != (RC_f61c868ef053db94121ce89ee15a14fe a, RC_f61c868ef053db94121ce89ee15a14fe b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f61c868ef053db94121ce89ee15a14fe)) return false;
return (this == (RC_f61c868ef053db94121ce89ee15a14fe)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserLoginFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserLoginFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserLoginFailureReason.InternalRecursiveSave();
}


public RC_f61c868ef053db94121ce89ee15a14fe Duplicate() {
RC_f61c868ef053db94121ce89ee15a14fe t;
t.ssSTUserLoginFailureReason = (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure)this.ssSTUserLoginFailureReason.Duplicate();
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
if (head == "userloginfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserLoginFailureReason")) variable.Value = ssSTUserLoginFailureReason; else variable.Optimized = true;
variable.SetFieldName("userloginfailurereason");
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
if (key == IdUserLoginFailureReason) {
return ssSTUserLoginFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserLoginFailureReason.Key.AsGuid) {
return ssSTUserLoginFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserLoginFailureReason.FillFromOther((IRecord) other.AttributeGet(IdUserLoginFailureReason));
}
} // RC_f61c868ef053db94121ce89ee15a14fe
/// <summary>
/// RecordList type <code>UserLoginFailureReasonRecordList</code> that represents a record list of
///  <code>UserLoginFailureReason</code>
/// </summary>
public partial class RL_fbc9fc52e3cef45822e06efc69df5a4a : GenericRecordList<RC_f61c868ef053db94121ce89ee15a14fe>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f61c868ef053db94121ce89ee15a14fe GetElementDefaultValue() {
return new RC_f61c868ef053db94121ce89ee15a14fe();
}

public T[] ToArray<T>(Func<RC_f61c868ef053db94121ce89ee15a14fe, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fbc9fc52e3cef45822e06efc69df5a4a recordList, Func<RC_f61c868ef053db94121ce89ee15a14fe, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fbc9fc52e3cef45822e06efc69df5a4a(RC_f61c868ef053db94121ce89ee15a14fe[] array) {
  RL_fbc9fc52e3cef45822e06efc69df5a4a result = new RL_fbc9fc52e3cef45822e06efc69df5a4a();
result.InnerFromArray(array);
    return result;
}

public static RL_fbc9fc52e3cef45822e06efc69df5a4a ToList<T>(T[] array, Func <T, RC_f61c868ef053db94121ce89ee15a14fe> converter) {
  RL_fbc9fc52e3cef45822e06efc69df5a4a result = new RL_fbc9fc52e3cef45822e06efc69df5a4a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fbc9fc52e3cef45822e06efc69df5a4a FromRestList<T>(RestList<T> restList, Func <T, RC_f61c868ef053db94121ce89ee15a14fe> converter) {
  RL_fbc9fc52e3cef45822e06efc69df5a4a result = new RL_fbc9fc52e3cef45822e06efc69df5a4a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fbc9fc52e3cef45822e06efc69df5a4a() : base() {
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
protected override OSList<RC_f61c868ef053db94121ce89ee15a14fe> NewList() {
return new RL_fbc9fc52e3cef45822e06efc69df5a4a();
}


} // RL_fbc9fc52e3cef45822e06efc69df5a4a
}

