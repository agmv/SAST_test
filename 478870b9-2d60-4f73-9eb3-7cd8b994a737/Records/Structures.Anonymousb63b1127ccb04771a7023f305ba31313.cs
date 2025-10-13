namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (JxE7trDMcUenAj8wW6MTEw)
///  <code>RC_cd804aaddb98d881ac0e154d00c7a1ec</code> that represent
/// s <code>StartUpdateEmailFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: StartUpdateEmailFailureReasonRecord
public partial struct RC_cd804aaddb98d881ac0e154d00c7a1ec : ITypedRecord<RC_cd804aaddb98d881ac0e154d00c7a1ec> {
internal static readonly GlobalObjectKey IdStartUpdateEmailFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rUqAzZjbgdisDhVNAMeh7A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StartUpdateEmailFailureReason")]
public ST_265373b7ea713cad761986e9aec6548dStructure ssSTStartUpdateEmailFailureReason;


public static implicit operator ST_265373b7ea713cad761986e9aec6548dStructure( RC_cd804aaddb98d881ac0e154d00c7a1ec r) {
return r.ssSTStartUpdateEmailFailureReason;
}

public static implicit operator RC_cd804aaddb98d881ac0e154d00c7a1ec (ST_265373b7ea713cad761986e9aec6548dStructure r) {
RC_cd804aaddb98d881ac0e154d00c7a1ec res = new RC_cd804aaddb98d881ac0e154d00c7a1ec ();
res.ssSTStartUpdateEmailFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_cd804aaddb98d881ac0e154d00c7a1ec() {
OptimizedAttributes = null;
ssSTStartUpdateEmailFailureReason = new ST_265373b7ea713cad761986e9aec6548dStructure();
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
    ssSTStartUpdateEmailFailureReason.OptimizedAttributes = value[0];
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
ssSTStartUpdateEmailFailureReason.Read( r, ref index);
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
public void ReadIM(RC_cd804aaddb98d881ac0e154d00c7a1ec r) {
this = r;
}


public static bool operator == (RC_cd804aaddb98d881ac0e154d00c7a1ec a, RC_cd804aaddb98d881ac0e154d00c7a1ec b) {
if (a.ssSTStartUpdateEmailFailureReason != b.ssSTStartUpdateEmailFailureReason) return false;
return true;
}

public static bool operator != (RC_cd804aaddb98d881ac0e154d00c7a1ec a, RC_cd804aaddb98d881ac0e154d00c7a1ec b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cd804aaddb98d881ac0e154d00c7a1ec)) return false;
return (this == (RC_cd804aaddb98d881ac0e154d00c7a1ec)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStartUpdateEmailFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStartUpdateEmailFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStartUpdateEmailFailureReason.InternalRecursiveSave();
}


public RC_cd804aaddb98d881ac0e154d00c7a1ec Duplicate() {
RC_cd804aaddb98d881ac0e154d00c7a1ec t;
t.ssSTStartUpdateEmailFailureReason = (ST_265373b7ea713cad761986e9aec6548dStructure)this.ssSTStartUpdateEmailFailureReason.Duplicate();
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
if (head == "startupdateemailfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartUpdateEmailFailureReason")) variable.Value = ssSTStartUpdateEmailFailureReason; else variable.Optimized = true;
variable.SetFieldName("startupdateemailfailurereason");
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
if (key == IdStartUpdateEmailFailureReason) {
return ssSTStartUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStartUpdateEmailFailureReason.Key.AsGuid) {
return ssSTStartUpdateEmailFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStartUpdateEmailFailureReason.FillFromOther((IRecord) other.AttributeGet(IdStartUpdateEmailFailureReason));
}
} // RC_cd804aaddb98d881ac0e154d00c7a1ec
/// <summary>
/// RecordList type <code>StartUpdateEmailFailureReasonRecordList</code> that represents a record list
///  of <code>StartUpdateEmailFailureReason</code>
/// </summary>
public partial class RL_43e25eece776661d5a511fa315c97acb : GenericRecordList<RC_cd804aaddb98d881ac0e154d00c7a1ec>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_cd804aaddb98d881ac0e154d00c7a1ec GetElementDefaultValue() {
return new RC_cd804aaddb98d881ac0e154d00c7a1ec();
}

public T[] ToArray<T>(Func<RC_cd804aaddb98d881ac0e154d00c7a1ec, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_43e25eece776661d5a511fa315c97acb recordList, Func<RC_cd804aaddb98d881ac0e154d00c7a1ec, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_43e25eece776661d5a511fa315c97acb(RC_cd804aaddb98d881ac0e154d00c7a1ec[] array) {
  RL_43e25eece776661d5a511fa315c97acb result = new RL_43e25eece776661d5a511fa315c97acb();
result.InnerFromArray(array);
    return result;
}

public static RL_43e25eece776661d5a511fa315c97acb ToList<T>(T[] array, Func <T, RC_cd804aaddb98d881ac0e154d00c7a1ec> converter) {
  RL_43e25eece776661d5a511fa315c97acb result = new RL_43e25eece776661d5a511fa315c97acb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_43e25eece776661d5a511fa315c97acb FromRestList<T>(RestList<T> restList, Func <T, RC_cd804aaddb98d881ac0e154d00c7a1ec> converter) {
  RL_43e25eece776661d5a511fa315c97acb result = new RL_43e25eece776661d5a511fa315c97acb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_43e25eece776661d5a511fa315c97acb() : base() {
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
protected override OSList<RC_cd804aaddb98d881ac0e154d00c7a1ec> NewList() {
return new RL_43e25eece776661d5a511fa315c97acb();
}


} // RL_43e25eece776661d5a511fa315c97acb
}

