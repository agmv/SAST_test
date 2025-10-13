namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (642WykiIA0e_PzpNpxTvsw)
///  <code>RC_78fc3f34c3c68c7b3604ba4da3920682</code> that represent
/// s <code>FinishUserRegistrationFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: FinishUserRegistrationFailureReasonRecord
public partial struct RC_78fc3f34c3c68c7b3604ba4da3920682 : ITypedRecord<RC_78fc3f34c3c68c7b3604ba4da3920682> {
internal static readonly GlobalObjectKey IdFinishUserRegistrationFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ND_8eMbDe4w2BLpNo5IGgg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FinishUserRegistrationFailureReason")]
public ST_6512d51a2c447fea2b8340c839f73d57Structure ssSTFinishUserRegistrationFailureReason;


public static implicit operator ST_6512d51a2c447fea2b8340c839f73d57Structure( RC_78fc3f34c3c68c7b3604ba4da3920682 r) {
return r.ssSTFinishUserRegistrationFailureReason;
}

public static implicit operator RC_78fc3f34c3c68c7b3604ba4da3920682 (ST_6512d51a2c447fea2b8340c839f73d57Structure r) {
RC_78fc3f34c3c68c7b3604ba4da3920682 res = new RC_78fc3f34c3c68c7b3604ba4da3920682 ();
res.ssSTFinishUserRegistrationFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_78fc3f34c3c68c7b3604ba4da3920682() {
OptimizedAttributes = null;
ssSTFinishUserRegistrationFailureReason = new ST_6512d51a2c447fea2b8340c839f73d57Structure();
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
    ssSTFinishUserRegistrationFailureReason.OptimizedAttributes = value[0];
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
ssSTFinishUserRegistrationFailureReason.Read( r, ref index);
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
public void ReadIM(RC_78fc3f34c3c68c7b3604ba4da3920682 r) {
this = r;
}


public static bool operator == (RC_78fc3f34c3c68c7b3604ba4da3920682 a, RC_78fc3f34c3c68c7b3604ba4da3920682 b) {
if (a.ssSTFinishUserRegistrationFailureReason != b.ssSTFinishUserRegistrationFailureReason) return false;
return true;
}

public static bool operator != (RC_78fc3f34c3c68c7b3604ba4da3920682 a, RC_78fc3f34c3c68c7b3604ba4da3920682 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_78fc3f34c3c68c7b3604ba4da3920682)) return false;
return (this == (RC_78fc3f34c3c68c7b3604ba4da3920682)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFinishUserRegistrationFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFinishUserRegistrationFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFinishUserRegistrationFailureReason.InternalRecursiveSave();
}


public RC_78fc3f34c3c68c7b3604ba4da3920682 Duplicate() {
RC_78fc3f34c3c68c7b3604ba4da3920682 t;
t.ssSTFinishUserRegistrationFailureReason = (ST_6512d51a2c447fea2b8340c839f73d57Structure)this.ssSTFinishUserRegistrationFailureReason.Duplicate();
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
if (head == "finishuserregistrationfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishUserRegistrationFailureReason")) variable.Value = ssSTFinishUserRegistrationFailureReason; else variable.Optimized = true;
variable.SetFieldName("finishuserregistrationfailurereason");
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
if (key == IdFinishUserRegistrationFailureReason) {
return ssSTFinishUserRegistrationFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFinishUserRegistrationFailureReason.Key.AsGuid) {
return ssSTFinishUserRegistrationFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFinishUserRegistrationFailureReason.FillFromOther((IRecord) other.AttributeGet(IdFinishUserRegistrationFailureReason));
}
} // RC_78fc3f34c3c68c7b3604ba4da3920682
/// <summary>
/// RecordList type <code>FinishUserRegistrationFailureReasonRecordList</code> that represents a record
///  list of <code>FinishUserRegistrationFailureReason</code>
/// </summary>
public partial class RL_9cf7ac5f0e0e6764a1fd30a6b5272901 : GenericRecordList<RC_78fc3f34c3c68c7b3604ba4da3920682>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_78fc3f34c3c68c7b3604ba4da3920682 GetElementDefaultValue() {
return new RC_78fc3f34c3c68c7b3604ba4da3920682();
}

public T[] ToArray<T>(Func<RC_78fc3f34c3c68c7b3604ba4da3920682, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9cf7ac5f0e0e6764a1fd30a6b5272901 recordList, Func<RC_78fc3f34c3c68c7b3604ba4da3920682, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9cf7ac5f0e0e6764a1fd30a6b5272901(RC_78fc3f34c3c68c7b3604ba4da3920682[] array) {
  RL_9cf7ac5f0e0e6764a1fd30a6b5272901 result = new RL_9cf7ac5f0e0e6764a1fd30a6b5272901();
result.InnerFromArray(array);
    return result;
}

public static RL_9cf7ac5f0e0e6764a1fd30a6b5272901 ToList<T>(T[] array, Func <T, RC_78fc3f34c3c68c7b3604ba4da3920682> converter) {
  RL_9cf7ac5f0e0e6764a1fd30a6b5272901 result = new RL_9cf7ac5f0e0e6764a1fd30a6b5272901();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9cf7ac5f0e0e6764a1fd30a6b5272901 FromRestList<T>(RestList<T> restList, Func <T, RC_78fc3f34c3c68c7b3604ba4da3920682> converter) {
  RL_9cf7ac5f0e0e6764a1fd30a6b5272901 result = new RL_9cf7ac5f0e0e6764a1fd30a6b5272901();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9cf7ac5f0e0e6764a1fd30a6b5272901() : base() {
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
protected override OSList<RC_78fc3f34c3c68c7b3604ba4da3920682> NewList() {
return new RL_9cf7ac5f0e0e6764a1fd30a6b5272901();
}


} // RL_9cf7ac5f0e0e6764a1fd30a6b5272901
}

