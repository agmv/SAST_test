namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (+23cTl7HqUOWSIOat18nRQ)
///  <code>RC_bfa970c705c6402f0a2a74e513cf30f2</code> that represents <code>EmployeeNameRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EmployeeNameRecord
public partial struct RC_bfa970c705c6402f0a2a74e513cf30f2 : ITypedRecord<RC_bfa970c705c6402f0a2a74e513cf30f2> {
internal static readonly GlobalObjectKey IdEmployeeName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*x3Cpv8YFL0AKKnTlE88w8g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("EmployeeName")]
public ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure ssSTEmployeeName;


public static implicit operator ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure( RC_bfa970c705c6402f0a2a74e513cf30f2 r) {
return r.ssSTEmployeeName;
}

public static implicit operator RC_bfa970c705c6402f0a2a74e513cf30f2 (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure r) {
RC_bfa970c705c6402f0a2a74e513cf30f2 res = new RC_bfa970c705c6402f0a2a74e513cf30f2 ();
res.ssSTEmployeeName = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bfa970c705c6402f0a2a74e513cf30f2() {
OptimizedAttributes = null;
ssSTEmployeeName = new ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure();
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
    ssSTEmployeeName.OptimizedAttributes = value[0];
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
ssSTEmployeeName.Read( r, ref index);
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
public void ReadIM(RC_bfa970c705c6402f0a2a74e513cf30f2 r) {
this = r;
}


public static bool operator == (RC_bfa970c705c6402f0a2a74e513cf30f2 a, RC_bfa970c705c6402f0a2a74e513cf30f2 b) {
if (a.ssSTEmployeeName != b.ssSTEmployeeName) return false;
return true;
}

public static bool operator != (RC_bfa970c705c6402f0a2a74e513cf30f2 a, RC_bfa970c705c6402f0a2a74e513cf30f2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bfa970c705c6402f0a2a74e513cf30f2)) return false;
return (this == (RC_bfa970c705c6402f0a2a74e513cf30f2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEmployeeName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEmployeeName.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEmployeeName.InternalRecursiveSave();
}


public RC_bfa970c705c6402f0a2a74e513cf30f2 Duplicate() {
RC_bfa970c705c6402f0a2a74e513cf30f2 t;
t.ssSTEmployeeName = (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure)this.ssSTEmployeeName.Duplicate();
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
if (head == "employeename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmployeeName")) variable.Value = ssSTEmployeeName; else variable.Optimized = true;
variable.SetFieldName("employeename");
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
if (key == IdEmployeeName) {
return ssSTEmployeeName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmployeeName.Key.AsGuid) {
return ssSTEmployeeName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEmployeeName.FillFromOther((IRecord) other.AttributeGet(IdEmployeeName));
}
} // RC_bfa970c705c6402f0a2a74e513cf30f2
/// <summary>
/// RecordList type <code>EmployeeNameRecordList</code> that represents a record list of
///  <code>EmployeeName</code>
/// </summary>
public partial class RL_fef6094efec9c05411063d34335d4327 : GenericRecordList<RC_bfa970c705c6402f0a2a74e513cf30f2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_bfa970c705c6402f0a2a74e513cf30f2 GetElementDefaultValue() {
return new RC_bfa970c705c6402f0a2a74e513cf30f2();
}

public T[] ToArray<T>(Func<RC_bfa970c705c6402f0a2a74e513cf30f2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fef6094efec9c05411063d34335d4327 recordList, Func<RC_bfa970c705c6402f0a2a74e513cf30f2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fef6094efec9c05411063d34335d4327(RC_bfa970c705c6402f0a2a74e513cf30f2[] array) {
  RL_fef6094efec9c05411063d34335d4327 result = new RL_fef6094efec9c05411063d34335d4327();
result.InnerFromArray(array);
    return result;
}

public static RL_fef6094efec9c05411063d34335d4327 ToList<T>(T[] array, Func <T, RC_bfa970c705c6402f0a2a74e513cf30f2> converter) {
  RL_fef6094efec9c05411063d34335d4327 result = new RL_fef6094efec9c05411063d34335d4327();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fef6094efec9c05411063d34335d4327 FromRestList<T>(RestList<T> restList, Func <T, RC_bfa970c705c6402f0a2a74e513cf30f2> converter) {
  RL_fef6094efec9c05411063d34335d4327 result = new RL_fef6094efec9c05411063d34335d4327();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fef6094efec9c05411063d34335d4327() : base() {
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
protected override OSList<RC_bfa970c705c6402f0a2a74e513cf30f2> NewList() {
return new RL_fef6094efec9c05411063d34335d4327();
}


} // RL_fef6094efec9c05411063d34335d4327
}

