namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (Rho68vTcR0up7UDMqSEBIg)
///  <code>RC_ed6dfadde1ed7fb74003b4bf09b19473</code> that represents <code>AIRoleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AIRoleRecord
public partial struct RC_ed6dfadde1ed7fb74003b4bf09b19473 : ITypedRecord<RC_ed6dfadde1ed7fb74003b4bf09b19473> {
internal static readonly GlobalObjectKey IdAIRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3fpt7e3ht39AA7S_CbGUcw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AIRole")]
public ENAIRoleEntityRecord ssENAIRole;


public static implicit operator ENAIRoleEntityRecord( RC_ed6dfadde1ed7fb74003b4bf09b19473 r) {
return r.ssENAIRole;
}

public static implicit operator RC_ed6dfadde1ed7fb74003b4bf09b19473 (ENAIRoleEntityRecord r) {
RC_ed6dfadde1ed7fb74003b4bf09b19473 res = new RC_ed6dfadde1ed7fb74003b4bf09b19473 ();
res.ssENAIRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAIRole.ChangedAttributes = value;
}
get {
    return ssENAIRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ed6dfadde1ed7fb74003b4bf09b19473() {
OptimizedAttributes = null;
ssENAIRole = new ENAIRoleEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAIRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAIRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAIRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAIRole.Read( r, ref index);
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
public void ReadIM(RC_ed6dfadde1ed7fb74003b4bf09b19473 r) {
this = r;
}


public static bool operator == (RC_ed6dfadde1ed7fb74003b4bf09b19473 a, RC_ed6dfadde1ed7fb74003b4bf09b19473 b) {
if (a.ssENAIRole != b.ssENAIRole) return false;
return true;
}

public static bool operator != (RC_ed6dfadde1ed7fb74003b4bf09b19473 a, RC_ed6dfadde1ed7fb74003b4bf09b19473 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ed6dfadde1ed7fb74003b4bf09b19473)) return false;
return (this == (RC_ed6dfadde1ed7fb74003b4bf09b19473)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAIRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAIRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAIRole.InternalRecursiveSave();
}


public RC_ed6dfadde1ed7fb74003b4bf09b19473 Duplicate() {
RC_ed6dfadde1ed7fb74003b4bf09b19473 t;
t.ssENAIRole = (ENAIRoleEntityRecord)this.ssENAIRole.Duplicate();
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
if (head == "airole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AIRole")) variable.Value = ssENAIRole; else variable.Optimized = true;
variable.SetFieldName("airole");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAIRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAIRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAIRole) {
return ssENAIRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAIRole.Key.AsGuid) {
return ssENAIRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAIRole.FillFromOther((IRecord) other.AttributeGet(IdAIRole));
}
} // RC_ed6dfadde1ed7fb74003b4bf09b19473
/// <summary>
/// RecordList type <code>AIRoleRecordList</code> that represents a record list of <code>AIRole</code>
/// </summary>
public partial class RL_9b4a25538611eb757cffb95a08f16da7 : GenericRecordList<RC_ed6dfadde1ed7fb74003b4bf09b19473>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_ed6dfadde1ed7fb74003b4bf09b19473 GetElementDefaultValue() {
return new RC_ed6dfadde1ed7fb74003b4bf09b19473();
}

public T[] ToArray<T>(Func<RC_ed6dfadde1ed7fb74003b4bf09b19473, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9b4a25538611eb757cffb95a08f16da7 recordList, Func<RC_ed6dfadde1ed7fb74003b4bf09b19473, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9b4a25538611eb757cffb95a08f16da7(RC_ed6dfadde1ed7fb74003b4bf09b19473[] array) {
  RL_9b4a25538611eb757cffb95a08f16da7 result = new RL_9b4a25538611eb757cffb95a08f16da7();
result.InnerFromArray(array);
    return result;
}

public static RL_9b4a25538611eb757cffb95a08f16da7 ToList<T>(T[] array, Func <T, RC_ed6dfadde1ed7fb74003b4bf09b19473> converter) {
  RL_9b4a25538611eb757cffb95a08f16da7 result = new RL_9b4a25538611eb757cffb95a08f16da7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9b4a25538611eb757cffb95a08f16da7 FromRestList<T>(RestList<T> restList, Func <T, RC_ed6dfadde1ed7fb74003b4bf09b19473> converter) {
  RL_9b4a25538611eb757cffb95a08f16da7 result = new RL_9b4a25538611eb757cffb95a08f16da7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9b4a25538611eb757cffb95a08f16da7() : base() {
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
protected override OSList<RC_ed6dfadde1ed7fb74003b4bf09b19473> NewList() {
return new RL_9b4a25538611eb757cffb95a08f16da7();
}


} // RL_9b4a25538611eb757cffb95a08f16da7
}

