namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (AseiZviZWqaZ95IR5ggHzg)
///  <code>RC_8535fa70cf0bfd6fa50f69a53d3b4ae1</code> that represent
/// s <code>ActivityOutputDefinitionRecord</code> <p>Description: </p>
/// </summary>
// Name: ActivityOutputDefinitionRecord
public partial struct RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 : ITypedRecord<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> {
internal static readonly GlobalObjectKey IdActivityOutputDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cPo1hQvPb_2lD2mlPTtK4Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityOutputDefinition")]
public ENActivityOutputDefinitionEntityRecord ssENActivityOutputDefinition;


public static implicit operator ENActivityOutputDefinitionEntityRecord( RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 r) {
return r.ssENActivityOutputDefinition;
}

public static implicit operator RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 (ENActivityOutputDefinitionEntityRecord r) {
RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 res = new RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 ();
res.ssENActivityOutputDefinition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityOutputDefinition.ChangedAttributes = value;
}
get {
    return ssENActivityOutputDefinition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8535fa70cf0bfd6fa50f69a53d3b4ae1() {
OptimizedAttributes = null;
ssENActivityOutputDefinition = new ENActivityOutputDefinitionEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityOutputDefinition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityOutputDefinition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityOutputDefinition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityOutputDefinition.Read( r, ref index);
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
public void ReadIM(RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 r) {
this = r;
}


public static bool operator == (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 a, RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 b) {
if (a.ssENActivityOutputDefinition != b.ssENActivityOutputDefinition) return false;
return true;
}

public static bool operator != (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 a, RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1)) return false;
return (this == (RC_8535fa70cf0bfd6fa50f69a53d3b4ae1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityOutputDefinition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityOutputDefinition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityOutputDefinition.InternalRecursiveSave();
}


public RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 Duplicate() {
RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 t;
t.ssENActivityOutputDefinition = (ENActivityOutputDefinitionEntityRecord)this.ssENActivityOutputDefinition.Duplicate();
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
if (head == "activityoutputdefinition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityOutputDefinition")) variable.Value = ssENActivityOutputDefinition; else variable.Optimized = true;
variable.SetFieldName("activityoutputdefinition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityOutputDefinition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityOutputDefinition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityOutputDefinition) {
return ssENActivityOutputDefinition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityOutputDefinition.Key.AsGuid) {
return ssENActivityOutputDefinition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityOutputDefinition.FillFromOther((IRecord) other.AttributeGet(IdActivityOutputDefinition));
}
} // RC_8535fa70cf0bfd6fa50f69a53d3b4ae1
/// <summary>
/// RecordList type <code>ActivityOutputDefinitionRecordList</code> that represents a record list of
///  <code>ActivityOutputDefinition</code>
/// </summary>
public partial class RL_382066feb08849f8e2adc5062ac75efa : GenericRecordList<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8535fa70cf0bfd6fa50f69a53d3b4ae1 GetElementDefaultValue() {
return new RC_8535fa70cf0bfd6fa50f69a53d3b4ae1();
}

public T[] ToArray<T>(Func<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_382066feb08849f8e2adc5062ac75efa recordList, Func<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_382066feb08849f8e2adc5062ac75efa(RC_8535fa70cf0bfd6fa50f69a53d3b4ae1[] array) {
  RL_382066feb08849f8e2adc5062ac75efa result = new RL_382066feb08849f8e2adc5062ac75efa();
result.InnerFromArray(array);
    return result;
}

public static RL_382066feb08849f8e2adc5062ac75efa ToList<T>(T[] array, Func <T, RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> converter) {
  RL_382066feb08849f8e2adc5062ac75efa result = new RL_382066feb08849f8e2adc5062ac75efa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_382066feb08849f8e2adc5062ac75efa FromRestList<T>(RestList<T> restList, Func <T, RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> converter) {
  RL_382066feb08849f8e2adc5062ac75efa result = new RL_382066feb08849f8e2adc5062ac75efa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_382066feb08849f8e2adc5062ac75efa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8535fa70cf0bfd6fa50f69a53d3b4ae1> NewList() {
return new RL_382066feb08849f8e2adc5062ac75efa();
}


} // RL_382066feb08849f8e2adc5062ac75efa
}

