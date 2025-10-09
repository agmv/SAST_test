namespace ssSystem_ {
/// <summary>
/// [Structure] StartUpdateEmailFailureReason (6ZXROIpIw0mod7NBaRH23A)
///  <code>ST_265373b7ea713cad761986e9aec6548dStructure</code> that represent
/// s <code>StartUpdateEmailFailureReason</code> <p>Description: Failure reason structure. Contains the
///  reason for failure if the action isn't successful.</p>
/// </summary>
// Name: StartUpdateEmailFailureReason
public partial struct ST_265373b7ea713cad761986e9aec6548dStructure : ITypedRecord<ST_265373b7ea713cad761986e9aec6548dStructure> {
internal static readonly GlobalObjectKey IdInvalidEmail = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*xhDjq6brX0WikYX5QPagtQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InvalidEmail")]
public bool ssInvalidEmail;


public BitArray OptimizedAttributes;

public ST_265373b7ea713cad761986e9aec6548dStructure() {
OptimizedAttributes = null;
ssInvalidEmail = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssInvalidEmail = r.ReadBoolean(index++, "StartUpdateEmailFailureReason.InvalidEmail", false);
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
public void ReadIM(ST_265373b7ea713cad761986e9aec6548dStructure r) {
this = r;
}


public static bool operator == (ST_265373b7ea713cad761986e9aec6548dStructure a, ST_265373b7ea713cad761986e9aec6548dStructure b) {
if (a.ssInvalidEmail != b.ssInvalidEmail) return false;
return true;
}

public static bool operator != (ST_265373b7ea713cad761986e9aec6548dStructure a, ST_265373b7ea713cad761986e9aec6548dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_265373b7ea713cad761986e9aec6548dStructure)) return false;
return (this == (ST_265373b7ea713cad761986e9aec6548dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvalidEmail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_265373b7ea713cad761986e9aec6548dStructure Duplicate() {
ST_265373b7ea713cad761986e9aec6548dStructure t;
t.ssInvalidEmail = this.ssInvalidEmail;
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
if (head == "invalidemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidEmail")) variable.Value = ssInvalidEmail; else variable.Optimized = true;
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
if (key == IdInvalidEmail) {
return ssInvalidEmail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvalidEmail.Key.AsGuid) {
return ssInvalidEmail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvalidEmail = (bool) other.AttributeGet(IdInvalidEmail);
}
} // ST_265373b7ea713cad761986e9aec6548dStructure
/// <summary>
/// RecordList type <code>StartUpdateEmailFailureReasonList</code> that represents a record list of
///  <code>StartUpdateEmailFailureReason</code>
/// </summary>
public partial class RL_2e1aa6e9e18d6f294e32465b29a6dd26 : GenericRecordList<ST_265373b7ea713cad761986e9aec6548dStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_265373b7ea713cad761986e9aec6548dStructure GetElementDefaultValue() {
return new ST_265373b7ea713cad761986e9aec6548dStructure();
}

public T[] ToArray<T>(Func<ST_265373b7ea713cad761986e9aec6548dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2e1aa6e9e18d6f294e32465b29a6dd26 recordList, Func<ST_265373b7ea713cad761986e9aec6548dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2e1aa6e9e18d6f294e32465b29a6dd26(ST_265373b7ea713cad761986e9aec6548dStructure[] array) {
  RL_2e1aa6e9e18d6f294e32465b29a6dd26 result = new RL_2e1aa6e9e18d6f294e32465b29a6dd26();
result.InnerFromArray(array);
    return result;
}

public static RL_2e1aa6e9e18d6f294e32465b29a6dd26 ToList<T>(T[] array, Func <T, ST_265373b7ea713cad761986e9aec6548dStructure> converter) {
  RL_2e1aa6e9e18d6f294e32465b29a6dd26 result = new RL_2e1aa6e9e18d6f294e32465b29a6dd26();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2e1aa6e9e18d6f294e32465b29a6dd26 FromRestList<T>(RestList<T> restList, Func <T, ST_265373b7ea713cad761986e9aec6548dStructure> converter) {
  RL_2e1aa6e9e18d6f294e32465b29a6dd26 result = new RL_2e1aa6e9e18d6f294e32465b29a6dd26();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2e1aa6e9e18d6f294e32465b29a6dd26() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_265373b7ea713cad761986e9aec6548dStructure> NewList() {
return new RL_2e1aa6e9e18d6f294e32465b29a6dd26();
}


} // RL_2e1aa6e9e18d6f294e32465b29a6dd26
}

