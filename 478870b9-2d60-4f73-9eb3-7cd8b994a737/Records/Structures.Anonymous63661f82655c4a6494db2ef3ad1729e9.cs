namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (gh9mY1xlZEqU2y7zrRcp6Q)
///  <code>RC_87c777c37ddf7c1355edbd72c4b71391</code> that represent
/// s <code>HumanActivityRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: HumanActivityRoleRecord
public partial struct RC_87c777c37ddf7c1355edbd72c4b71391 : ITypedRecord<RC_87c777c37ddf7c1355edbd72c4b71391> {
internal static readonly GlobalObjectKey IdHumanActivityRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w3fHh999E3xV7b1yxLcTkQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HumanActivityRole")]
public ENHumanActivityRoleEntityRecord ssENHumanActivityRole;


public static implicit operator ENHumanActivityRoleEntityRecord( RC_87c777c37ddf7c1355edbd72c4b71391 r) {
return r.ssENHumanActivityRole;
}

public static implicit operator RC_87c777c37ddf7c1355edbd72c4b71391 (ENHumanActivityRoleEntityRecord r) {
RC_87c777c37ddf7c1355edbd72c4b71391 res = new RC_87c777c37ddf7c1355edbd72c4b71391 ();
res.ssENHumanActivityRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENHumanActivityRole.ChangedAttributes = value;
}
get {
    return ssENHumanActivityRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_87c777c37ddf7c1355edbd72c4b71391() {
OptimizedAttributes = null;
ssENHumanActivityRole = new ENHumanActivityRoleEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENHumanActivityRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENHumanActivityRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENHumanActivityRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENHumanActivityRole.Read( r, ref index);
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
public void ReadIM(RC_87c777c37ddf7c1355edbd72c4b71391 r) {
this = r;
}


public static bool operator == (RC_87c777c37ddf7c1355edbd72c4b71391 a, RC_87c777c37ddf7c1355edbd72c4b71391 b) {
if (a.ssENHumanActivityRole != b.ssENHumanActivityRole) return false;
return true;
}

public static bool operator != (RC_87c777c37ddf7c1355edbd72c4b71391 a, RC_87c777c37ddf7c1355edbd72c4b71391 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_87c777c37ddf7c1355edbd72c4b71391)) return false;
return (this == (RC_87c777c37ddf7c1355edbd72c4b71391)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENHumanActivityRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENHumanActivityRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENHumanActivityRole.InternalRecursiveSave();
}


public RC_87c777c37ddf7c1355edbd72c4b71391 Duplicate() {
RC_87c777c37ddf7c1355edbd72c4b71391 t;
t.ssENHumanActivityRole = (ENHumanActivityRoleEntityRecord)this.ssENHumanActivityRole.Duplicate();
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
if (head == "humanactivityrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HumanActivityRole")) variable.Value = ssENHumanActivityRole; else variable.Optimized = true;
variable.SetFieldName("humanactivityrole");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENHumanActivityRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENHumanActivityRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdHumanActivityRole) {
return ssENHumanActivityRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHumanActivityRole.Key.AsGuid) {
return ssENHumanActivityRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENHumanActivityRole.FillFromOther((IRecord) other.AttributeGet(IdHumanActivityRole));
}
} // RC_87c777c37ddf7c1355edbd72c4b71391
/// <summary>
/// RecordList type <code>HumanActivityRoleRecordList</code> that represents a record list of
///  <code>HumanActivityRole</code>
/// </summary>
public partial class RL_205f290c854bc0e1aa93388e5772d11f : GenericRecordList<RC_87c777c37ddf7c1355edbd72c4b71391>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_87c777c37ddf7c1355edbd72c4b71391 GetElementDefaultValue() {
return new RC_87c777c37ddf7c1355edbd72c4b71391();
}

public T[] ToArray<T>(Func<RC_87c777c37ddf7c1355edbd72c4b71391, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_205f290c854bc0e1aa93388e5772d11f recordList, Func<RC_87c777c37ddf7c1355edbd72c4b71391, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_205f290c854bc0e1aa93388e5772d11f(RC_87c777c37ddf7c1355edbd72c4b71391[] array) {
  RL_205f290c854bc0e1aa93388e5772d11f result = new RL_205f290c854bc0e1aa93388e5772d11f();
result.InnerFromArray(array);
    return result;
}

public static RL_205f290c854bc0e1aa93388e5772d11f ToList<T>(T[] array, Func <T, RC_87c777c37ddf7c1355edbd72c4b71391> converter) {
  RL_205f290c854bc0e1aa93388e5772d11f result = new RL_205f290c854bc0e1aa93388e5772d11f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_205f290c854bc0e1aa93388e5772d11f FromRestList<T>(RestList<T> restList, Func <T, RC_87c777c37ddf7c1355edbd72c4b71391> converter) {
  RL_205f290c854bc0e1aa93388e5772d11f result = new RL_205f290c854bc0e1aa93388e5772d11f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_205f290c854bc0e1aa93388e5772d11f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_87c777c37ddf7c1355edbd72c4b71391> NewList() {
return new RL_205f290c854bc0e1aa93388e5772d11f();
}


} // RL_205f290c854bc0e1aa93388e5772d11f
}

