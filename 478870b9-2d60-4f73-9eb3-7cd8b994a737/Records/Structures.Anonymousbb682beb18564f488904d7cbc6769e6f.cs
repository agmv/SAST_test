namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (6ytou1YYSE+JBNfLxnaebw)
///  <code>RC_c25115a84bc21f80350d8ea6536353ed</code> that represents <code>EmailRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EmailRecord
public partial struct RC_c25115a84bc21f80350d8ea6536353ed : ITypedRecord<RC_c25115a84bc21f80350d8ea6536353ed> {
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qBVRwsJLgB81DY6mU2NT7Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Email")]
public ENEmailEntityRecord ssENEmail;


public static implicit operator ENEmailEntityRecord( RC_c25115a84bc21f80350d8ea6536353ed r) {
return r.ssENEmail;
}

public static implicit operator RC_c25115a84bc21f80350d8ea6536353ed (ENEmailEntityRecord r) {
RC_c25115a84bc21f80350d8ea6536353ed res = new RC_c25115a84bc21f80350d8ea6536353ed ();
res.ssENEmail = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEmail.ChangedAttributes = value;
}
get {
    return ssENEmail.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c25115a84bc21f80350d8ea6536353ed() {
OptimizedAttributes = null;
ssENEmail = new ENEmailEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEmail.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEmail.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEmail.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEmail.Read( r, ref index);
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
public void ReadIM(RC_c25115a84bc21f80350d8ea6536353ed r) {
this = r;
}


public static bool operator == (RC_c25115a84bc21f80350d8ea6536353ed a, RC_c25115a84bc21f80350d8ea6536353ed b) {
if (a.ssENEmail != b.ssENEmail) return false;
return true;
}

public static bool operator != (RC_c25115a84bc21f80350d8ea6536353ed a, RC_c25115a84bc21f80350d8ea6536353ed b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c25115a84bc21f80350d8ea6536353ed)) return false;
return (this == (RC_c25115a84bc21f80350d8ea6536353ed)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEmail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEmail.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEmail.InternalRecursiveSave();
}


public RC_c25115a84bc21f80350d8ea6536353ed Duplicate() {
RC_c25115a84bc21f80350d8ea6536353ed t;
t.ssENEmail = (ENEmailEntityRecord)this.ssENEmail.Duplicate();
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
if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssENEmail; else variable.Optimized = true;
variable.SetFieldName("email");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEmail.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEmail.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEmail) {
return ssENEmail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmail.Key.AsGuid) {
return ssENEmail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEmail.FillFromOther((IRecord) other.AttributeGet(IdEmail));
}
} // RC_c25115a84bc21f80350d8ea6536353ed
/// <summary>
/// RecordList type <code>EmailRecordList</code> that represents a record list of <code>Email</code>
/// </summary>
public partial class RL_fd604259751c80eed887a8f5a0f5dc23 : GenericRecordList<RC_c25115a84bc21f80350d8ea6536353ed>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c25115a84bc21f80350d8ea6536353ed GetElementDefaultValue() {
return new RC_c25115a84bc21f80350d8ea6536353ed();
}

public T[] ToArray<T>(Func<RC_c25115a84bc21f80350d8ea6536353ed, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fd604259751c80eed887a8f5a0f5dc23 recordList, Func<RC_c25115a84bc21f80350d8ea6536353ed, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fd604259751c80eed887a8f5a0f5dc23(RC_c25115a84bc21f80350d8ea6536353ed[] array) {
  RL_fd604259751c80eed887a8f5a0f5dc23 result = new RL_fd604259751c80eed887a8f5a0f5dc23();
result.InnerFromArray(array);
    return result;
}

public static RL_fd604259751c80eed887a8f5a0f5dc23 ToList<T>(T[] array, Func <T, RC_c25115a84bc21f80350d8ea6536353ed> converter) {
  RL_fd604259751c80eed887a8f5a0f5dc23 result = new RL_fd604259751c80eed887a8f5a0f5dc23();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fd604259751c80eed887a8f5a0f5dc23 FromRestList<T>(RestList<T> restList, Func <T, RC_c25115a84bc21f80350d8ea6536353ed> converter) {
  RL_fd604259751c80eed887a8f5a0f5dc23 result = new RL_fd604259751c80eed887a8f5a0f5dc23();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fd604259751c80eed887a8f5a0f5dc23() : base() {
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
protected override OSList<RC_c25115a84bc21f80350d8ea6536353ed> NewList() {
return new RL_fd604259751c80eed887a8f5a0f5dc23();
}


} // RL_fd604259751c80eed887a8f5a0f5dc23
}

