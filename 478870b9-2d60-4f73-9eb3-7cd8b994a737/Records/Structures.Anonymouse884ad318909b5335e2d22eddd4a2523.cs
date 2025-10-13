namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (Ma2E6AmJM7VeLSLt3UolIw)
///  <code>RC_13630884b629a3a59e929e1cdea42eb1</code> that represents <code>RoleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RoleRecord
public partial struct RC_13630884b629a3a59e929e1cdea42eb1 : ITypedRecord<RC_13630884b629a3a59e929e1cdea42eb1> {
internal static readonly GlobalObjectKey IdRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hAhjEym2paOekp4c3qQusQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Role")]
public ENRoleEntityRecord ssENRole;


public static implicit operator ENRoleEntityRecord( RC_13630884b629a3a59e929e1cdea42eb1 r) {
return r.ssENRole;
}

public static implicit operator RC_13630884b629a3a59e929e1cdea42eb1 (ENRoleEntityRecord r) {
RC_13630884b629a3a59e929e1cdea42eb1 res = new RC_13630884b629a3a59e929e1cdea42eb1 ();
res.ssENRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRole.ChangedAttributes = value;
}
get {
    return ssENRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_13630884b629a3a59e929e1cdea42eb1() {
OptimizedAttributes = null;
ssENRole = new ENRoleEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRole.Read( r, ref index);
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
public void ReadIM(RC_13630884b629a3a59e929e1cdea42eb1 r) {
this = r;
}


public static bool operator == (RC_13630884b629a3a59e929e1cdea42eb1 a, RC_13630884b629a3a59e929e1cdea42eb1 b) {
if (a.ssENRole != b.ssENRole) return false;
return true;
}

public static bool operator != (RC_13630884b629a3a59e929e1cdea42eb1 a, RC_13630884b629a3a59e929e1cdea42eb1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_13630884b629a3a59e929e1cdea42eb1)) return false;
return (this == (RC_13630884b629a3a59e929e1cdea42eb1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRole.InternalRecursiveSave();
}


public RC_13630884b629a3a59e929e1cdea42eb1 Duplicate() {
RC_13630884b629a3a59e929e1cdea42eb1 t;
t.ssENRole = (ENRoleEntityRecord)this.ssENRole.Duplicate();
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
if (head == "role") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Role")) variable.Value = ssENRole; else variable.Optimized = true;
variable.SetFieldName("role");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRole) {
return ssENRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRole.Key.AsGuid) {
return ssENRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRole.FillFromOther((IRecord) other.AttributeGet(IdRole));
}
} // RC_13630884b629a3a59e929e1cdea42eb1
/// <summary>
/// RecordList type <code>RoleRecordList</code> that represents a record list of <code>Role</code>
/// </summary>
public partial class RL_db06c2b916049d1c72db56f953d2667f : GenericRecordList<RC_13630884b629a3a59e929e1cdea42eb1>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_13630884b629a3a59e929e1cdea42eb1 GetElementDefaultValue() {
return new RC_13630884b629a3a59e929e1cdea42eb1();
}

public T[] ToArray<T>(Func<RC_13630884b629a3a59e929e1cdea42eb1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_db06c2b916049d1c72db56f953d2667f recordList, Func<RC_13630884b629a3a59e929e1cdea42eb1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_db06c2b916049d1c72db56f953d2667f(RC_13630884b629a3a59e929e1cdea42eb1[] array) {
  RL_db06c2b916049d1c72db56f953d2667f result = new RL_db06c2b916049d1c72db56f953d2667f();
result.InnerFromArray(array);
    return result;
}

public static RL_db06c2b916049d1c72db56f953d2667f ToList<T>(T[] array, Func <T, RC_13630884b629a3a59e929e1cdea42eb1> converter) {
  RL_db06c2b916049d1c72db56f953d2667f result = new RL_db06c2b916049d1c72db56f953d2667f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_db06c2b916049d1c72db56f953d2667f FromRestList<T>(RestList<T> restList, Func <T, RC_13630884b629a3a59e929e1cdea42eb1> converter) {
  RL_db06c2b916049d1c72db56f953d2667f result = new RL_db06c2b916049d1c72db56f953d2667f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_db06c2b916049d1c72db56f953d2667f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_13630884b629a3a59e929e1cdea42eb1> NewList() {
return new RL_db06c2b916049d1c72db56f953d2667f();
}


} // RL_db06c2b916049d1c72db56f953d2667f
}

