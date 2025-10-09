namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (murn112r_k2y8jq8vzYcUw)
///  <code>RC_e5c662d406f83f7f791bd7e5c8b0c543</code> that represent
/// s <code>ChangePasswordFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: ChangePasswordFailureReasonRecord
public partial struct RC_e5c662d406f83f7f791bd7e5c8b0c543 : ITypedRecord<RC_e5c662d406f83f7f791bd7e5c8b0c543> {
internal static readonly GlobalObjectKey IdChangePasswordFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1GLG5fgGfz95G9flyLDFQw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ChangePasswordFailureReason")]
public ST_896e066bc5a2d27c8f6a276746e82800Structure ssSTChangePasswordFailureReason;


public static implicit operator ST_896e066bc5a2d27c8f6a276746e82800Structure( RC_e5c662d406f83f7f791bd7e5c8b0c543 r) {
return r.ssSTChangePasswordFailureReason;
}

public static implicit operator RC_e5c662d406f83f7f791bd7e5c8b0c543 (ST_896e066bc5a2d27c8f6a276746e82800Structure r) {
RC_e5c662d406f83f7f791bd7e5c8b0c543 res = new RC_e5c662d406f83f7f791bd7e5c8b0c543 ();
res.ssSTChangePasswordFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e5c662d406f83f7f791bd7e5c8b0c543() {
OptimizedAttributes = null;
ssSTChangePasswordFailureReason = new ST_896e066bc5a2d27c8f6a276746e82800Structure();
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
    ssSTChangePasswordFailureReason.OptimizedAttributes = value[0];
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
ssSTChangePasswordFailureReason.Read( r, ref index);
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
public void ReadIM(RC_e5c662d406f83f7f791bd7e5c8b0c543 r) {
this = r;
}


public static bool operator == (RC_e5c662d406f83f7f791bd7e5c8b0c543 a, RC_e5c662d406f83f7f791bd7e5c8b0c543 b) {
if (a.ssSTChangePasswordFailureReason != b.ssSTChangePasswordFailureReason) return false;
return true;
}

public static bool operator != (RC_e5c662d406f83f7f791bd7e5c8b0c543 a, RC_e5c662d406f83f7f791bd7e5c8b0c543 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e5c662d406f83f7f791bd7e5c8b0c543)) return false;
return (this == (RC_e5c662d406f83f7f791bd7e5c8b0c543)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTChangePasswordFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTChangePasswordFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTChangePasswordFailureReason.InternalRecursiveSave();
}


public RC_e5c662d406f83f7f791bd7e5c8b0c543 Duplicate() {
RC_e5c662d406f83f7f791bd7e5c8b0c543 t;
t.ssSTChangePasswordFailureReason = (ST_896e066bc5a2d27c8f6a276746e82800Structure)this.ssSTChangePasswordFailureReason.Duplicate();
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
if (head == "changepasswordfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangePasswordFailureReason")) variable.Value = ssSTChangePasswordFailureReason; else variable.Optimized = true;
variable.SetFieldName("changepasswordfailurereason");
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
if (key == IdChangePasswordFailureReason) {
return ssSTChangePasswordFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdChangePasswordFailureReason.Key.AsGuid) {
return ssSTChangePasswordFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTChangePasswordFailureReason.FillFromOther((IRecord) other.AttributeGet(IdChangePasswordFailureReason));
}
} // RC_e5c662d406f83f7f791bd7e5c8b0c543
/// <summary>
/// RecordList type <code>ChangePasswordFailureReasonRecordList</code> that represents a record list of
///  <code>ChangePasswordFailureReason</code>
/// </summary>
public partial class RL_b6f4bbf36a4770c53788c60d2b555d3c : GenericRecordList<RC_e5c662d406f83f7f791bd7e5c8b0c543>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e5c662d406f83f7f791bd7e5c8b0c543 GetElementDefaultValue() {
return new RC_e5c662d406f83f7f791bd7e5c8b0c543();
}

public T[] ToArray<T>(Func<RC_e5c662d406f83f7f791bd7e5c8b0c543, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b6f4bbf36a4770c53788c60d2b555d3c recordList, Func<RC_e5c662d406f83f7f791bd7e5c8b0c543, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b6f4bbf36a4770c53788c60d2b555d3c(RC_e5c662d406f83f7f791bd7e5c8b0c543[] array) {
  RL_b6f4bbf36a4770c53788c60d2b555d3c result = new RL_b6f4bbf36a4770c53788c60d2b555d3c();
result.InnerFromArray(array);
    return result;
}

public static RL_b6f4bbf36a4770c53788c60d2b555d3c ToList<T>(T[] array, Func <T, RC_e5c662d406f83f7f791bd7e5c8b0c543> converter) {
  RL_b6f4bbf36a4770c53788c60d2b555d3c result = new RL_b6f4bbf36a4770c53788c60d2b555d3c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b6f4bbf36a4770c53788c60d2b555d3c FromRestList<T>(RestList<T> restList, Func <T, RC_e5c662d406f83f7f791bd7e5c8b0c543> converter) {
  RL_b6f4bbf36a4770c53788c60d2b555d3c result = new RL_b6f4bbf36a4770c53788c60d2b555d3c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b6f4bbf36a4770c53788c60d2b555d3c() : base() {
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
protected override OSList<RC_e5c662d406f83f7f791bd7e5c8b0c543> NewList() {
return new RL_b6f4bbf36a4770c53788c60d2b555d3c();
}


} // RL_b6f4bbf36a4770c53788c60d2b555d3c
}

