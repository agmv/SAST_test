namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (h9XHpeb4G0St7fUYbA_UZA)
///  <code>RC_ced013358a82a813f1d9a5108f17ce79</code> that represents <code>UserRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserRecord
public partial struct RC_ced013358a82a813f1d9a5108f17ce79 : ITypedRecord<RC_ced013358a82a813f1d9a5108f17ce79> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("User")]
public ENUserEntityRecord ssENUser;


public static implicit operator ENUserEntityRecord( RC_ced013358a82a813f1d9a5108f17ce79 r) {
return r.ssENUser;
}

public static implicit operator RC_ced013358a82a813f1d9a5108f17ce79 (ENUserEntityRecord r) {
RC_ced013358a82a813f1d9a5108f17ce79 res = new RC_ced013358a82a813f1d9a5108f17ce79 ();
res.ssENUser = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUser.ChangedAttributes = value;
}
get {
    return ssENUser.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ced013358a82a813f1d9a5108f17ce79() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUser.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
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
public void ReadIM(RC_ced013358a82a813f1d9a5108f17ce79 r) {
this = r;
}


public static bool operator == (RC_ced013358a82a813f1d9a5108f17ce79 a, RC_ced013358a82a813f1d9a5108f17ce79 b) {
if (a.ssENUser != b.ssENUser) return false;
return true;
}

public static bool operator != (RC_ced013358a82a813f1d9a5108f17ce79 a, RC_ced013358a82a813f1d9a5108f17ce79 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ced013358a82a813f1d9a5108f17ce79)) return false;
return (this == (RC_ced013358a82a813f1d9a5108f17ce79)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
}


public RC_ced013358a82a813f1d9a5108f17ce79 Duplicate() {
RC_ced013358a82a813f1d9a5108f17ce79 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUser.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUser.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUser) {
return ssENUser;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
}
} // RC_ced013358a82a813f1d9a5108f17ce79
/// <summary>
/// RecordList type <code>UserRecordList</code> that represents a record list of <code>User</code>
/// </summary>
public partial class RL_8430333e95ceffc00def96d8abb01f75 : GenericRecordList<RC_ced013358a82a813f1d9a5108f17ce79>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_ced013358a82a813f1d9a5108f17ce79 GetElementDefaultValue() {
return new RC_ced013358a82a813f1d9a5108f17ce79();
}

public T[] ToArray<T>(Func<RC_ced013358a82a813f1d9a5108f17ce79, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8430333e95ceffc00def96d8abb01f75 recordList, Func<RC_ced013358a82a813f1d9a5108f17ce79, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8430333e95ceffc00def96d8abb01f75(RC_ced013358a82a813f1d9a5108f17ce79[] array) {
  RL_8430333e95ceffc00def96d8abb01f75 result = new RL_8430333e95ceffc00def96d8abb01f75();
result.InnerFromArray(array);
    return result;
}

public static RL_8430333e95ceffc00def96d8abb01f75 ToList<T>(T[] array, Func <T, RC_ced013358a82a813f1d9a5108f17ce79> converter) {
  RL_8430333e95ceffc00def96d8abb01f75 result = new RL_8430333e95ceffc00def96d8abb01f75();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8430333e95ceffc00def96d8abb01f75 FromRestList<T>(RestList<T> restList, Func <T, RC_ced013358a82a813f1d9a5108f17ce79> converter) {
  RL_8430333e95ceffc00def96d8abb01f75 result = new RL_8430333e95ceffc00def96d8abb01f75();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8430333e95ceffc00def96d8abb01f75() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ced013358a82a813f1d9a5108f17ce79> NewList() {
return new RL_8430333e95ceffc00def96d8abb01f75();
}


} // RL_8430333e95ceffc00def96d8abb01f75
}

