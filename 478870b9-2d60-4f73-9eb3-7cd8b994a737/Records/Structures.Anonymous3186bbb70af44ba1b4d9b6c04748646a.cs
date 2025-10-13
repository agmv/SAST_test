namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (t7uGMfQKoUu02bbAR0hkag)
///  <code>RC_5d4c0a98b9773e489e7e27bfe5360793</code> that represent
/// s <code>UpdateUserFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: UpdateUserFailureReasonRecord
public partial struct RC_5d4c0a98b9773e489e7e27bfe5360793 : ITypedRecord<RC_5d4c0a98b9773e489e7e27bfe5360793> {
internal static readonly GlobalObjectKey IdUpdateUserFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mApMXXe5SD6efie_5TYHkw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UpdateUserFailureReason")]
public ST_6f88d6be05f2234ba151435ee8bf2cd4Structure ssSTUpdateUserFailureReason;


public static implicit operator ST_6f88d6be05f2234ba151435ee8bf2cd4Structure( RC_5d4c0a98b9773e489e7e27bfe5360793 r) {
return r.ssSTUpdateUserFailureReason;
}

public static implicit operator RC_5d4c0a98b9773e489e7e27bfe5360793 (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure r) {
RC_5d4c0a98b9773e489e7e27bfe5360793 res = new RC_5d4c0a98b9773e489e7e27bfe5360793 ();
res.ssSTUpdateUserFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5d4c0a98b9773e489e7e27bfe5360793() {
OptimizedAttributes = null;
ssSTUpdateUserFailureReason = new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure();
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
    ssSTUpdateUserFailureReason.OptimizedAttributes = value[0];
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
ssSTUpdateUserFailureReason.Read( r, ref index);
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
public void ReadIM(RC_5d4c0a98b9773e489e7e27bfe5360793 r) {
this = r;
}


public static bool operator == (RC_5d4c0a98b9773e489e7e27bfe5360793 a, RC_5d4c0a98b9773e489e7e27bfe5360793 b) {
if (a.ssSTUpdateUserFailureReason != b.ssSTUpdateUserFailureReason) return false;
return true;
}

public static bool operator != (RC_5d4c0a98b9773e489e7e27bfe5360793 a, RC_5d4c0a98b9773e489e7e27bfe5360793 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5d4c0a98b9773e489e7e27bfe5360793)) return false;
return (this == (RC_5d4c0a98b9773e489e7e27bfe5360793)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUpdateUserFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUpdateUserFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUpdateUserFailureReason.InternalRecursiveSave();
}


public RC_5d4c0a98b9773e489e7e27bfe5360793 Duplicate() {
RC_5d4c0a98b9773e489e7e27bfe5360793 t;
t.ssSTUpdateUserFailureReason = (ST_6f88d6be05f2234ba151435ee8bf2cd4Structure)this.ssSTUpdateUserFailureReason.Duplicate();
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
if (head == "updateuserfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateUserFailureReason")) variable.Value = ssSTUpdateUserFailureReason; else variable.Optimized = true;
variable.SetFieldName("updateuserfailurereason");
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
if (key == IdUpdateUserFailureReason) {
return ssSTUpdateUserFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUpdateUserFailureReason.Key.AsGuid) {
return ssSTUpdateUserFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUpdateUserFailureReason.FillFromOther((IRecord) other.AttributeGet(IdUpdateUserFailureReason));
}
} // RC_5d4c0a98b9773e489e7e27bfe5360793
/// <summary>
/// RecordList type <code>UpdateUserFailureReasonRecordList</code> that represents a record list of
///  <code>UpdateUserFailureReason</code>
/// </summary>
public partial class RL_9bba1220f91628d35d17687902f382ad : GenericRecordList<RC_5d4c0a98b9773e489e7e27bfe5360793>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_5d4c0a98b9773e489e7e27bfe5360793 GetElementDefaultValue() {
return new RC_5d4c0a98b9773e489e7e27bfe5360793();
}

public T[] ToArray<T>(Func<RC_5d4c0a98b9773e489e7e27bfe5360793, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9bba1220f91628d35d17687902f382ad recordList, Func<RC_5d4c0a98b9773e489e7e27bfe5360793, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9bba1220f91628d35d17687902f382ad(RC_5d4c0a98b9773e489e7e27bfe5360793[] array) {
  RL_9bba1220f91628d35d17687902f382ad result = new RL_9bba1220f91628d35d17687902f382ad();
result.InnerFromArray(array);
    return result;
}

public static RL_9bba1220f91628d35d17687902f382ad ToList<T>(T[] array, Func <T, RC_5d4c0a98b9773e489e7e27bfe5360793> converter) {
  RL_9bba1220f91628d35d17687902f382ad result = new RL_9bba1220f91628d35d17687902f382ad();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9bba1220f91628d35d17687902f382ad FromRestList<T>(RestList<T> restList, Func <T, RC_5d4c0a98b9773e489e7e27bfe5360793> converter) {
  RL_9bba1220f91628d35d17687902f382ad result = new RL_9bba1220f91628d35d17687902f382ad();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9bba1220f91628d35d17687902f382ad() : base() {
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
protected override OSList<RC_5d4c0a98b9773e489e7e27bfe5360793> NewList() {
return new RL_9bba1220f91628d35d17687902f382ad();
}


} // RL_9bba1220f91628d35d17687902f382ad
}

