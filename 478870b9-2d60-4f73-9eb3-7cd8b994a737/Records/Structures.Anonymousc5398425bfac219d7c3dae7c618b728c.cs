namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (JYQ5xay_nSF8Pa58YYtyjA)
///  <code>RC_a04f94cfd410c813b8dee156f64b6537</code> that represent
/// s <code>ActivityDefinitionRecord</code> <p>Description: </p>
/// </summary>
// Name: ActivityDefinitionRecord
public partial struct RC_a04f94cfd410c813b8dee156f64b6537 : ITypedRecord<RC_a04f94cfd410c813b8dee156f64b6537> {
internal static readonly GlobalObjectKey IdActivityDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*z5RPoBDUE8i43uFW9ktlNw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityDefinition")]
public ENActivityDefinitionEntityRecord ssENActivityDefinition;


public static implicit operator ENActivityDefinitionEntityRecord( RC_a04f94cfd410c813b8dee156f64b6537 r) {
return r.ssENActivityDefinition;
}

public static implicit operator RC_a04f94cfd410c813b8dee156f64b6537 (ENActivityDefinitionEntityRecord r) {
RC_a04f94cfd410c813b8dee156f64b6537 res = new RC_a04f94cfd410c813b8dee156f64b6537 ();
res.ssENActivityDefinition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityDefinition.ChangedAttributes = value;
}
get {
    return ssENActivityDefinition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a04f94cfd410c813b8dee156f64b6537() {
OptimizedAttributes = null;
ssENActivityDefinition = new ENActivityDefinitionEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityDefinition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityDefinition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityDefinition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityDefinition.Read( r, ref index);
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
public void ReadIM(RC_a04f94cfd410c813b8dee156f64b6537 r) {
this = r;
}


public static bool operator == (RC_a04f94cfd410c813b8dee156f64b6537 a, RC_a04f94cfd410c813b8dee156f64b6537 b) {
if (a.ssENActivityDefinition != b.ssENActivityDefinition) return false;
return true;
}

public static bool operator != (RC_a04f94cfd410c813b8dee156f64b6537 a, RC_a04f94cfd410c813b8dee156f64b6537 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a04f94cfd410c813b8dee156f64b6537)) return false;
return (this == (RC_a04f94cfd410c813b8dee156f64b6537)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityDefinition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityDefinition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityDefinition.InternalRecursiveSave();
}


public RC_a04f94cfd410c813b8dee156f64b6537 Duplicate() {
RC_a04f94cfd410c813b8dee156f64b6537 t;
t.ssENActivityDefinition = (ENActivityDefinitionEntityRecord)this.ssENActivityDefinition.Duplicate();
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
if (head == "activitydefinition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinition")) variable.Value = ssENActivityDefinition; else variable.Optimized = true;
variable.SetFieldName("activitydefinition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityDefinition) {
return ssENActivityDefinition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityDefinition.Key.AsGuid) {
return ssENActivityDefinition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityDefinition.FillFromOther((IRecord) other.AttributeGet(IdActivityDefinition));
}
} // RC_a04f94cfd410c813b8dee156f64b6537
/// <summary>
/// RecordList type <code>ActivityDefinitionRecordList</code> that represents a record list of
///  <code>ActivityDefinition</code>
/// </summary>
public partial class RL_3e3c312f4b244ea01713a0fa4a15518a : GenericRecordList<RC_a04f94cfd410c813b8dee156f64b6537>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a04f94cfd410c813b8dee156f64b6537 GetElementDefaultValue() {
return new RC_a04f94cfd410c813b8dee156f64b6537();
}

public T[] ToArray<T>(Func<RC_a04f94cfd410c813b8dee156f64b6537, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3e3c312f4b244ea01713a0fa4a15518a recordList, Func<RC_a04f94cfd410c813b8dee156f64b6537, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3e3c312f4b244ea01713a0fa4a15518a(RC_a04f94cfd410c813b8dee156f64b6537[] array) {
  RL_3e3c312f4b244ea01713a0fa4a15518a result = new RL_3e3c312f4b244ea01713a0fa4a15518a();
result.InnerFromArray(array);
    return result;
}

public static RL_3e3c312f4b244ea01713a0fa4a15518a ToList<T>(T[] array, Func <T, RC_a04f94cfd410c813b8dee156f64b6537> converter) {
  RL_3e3c312f4b244ea01713a0fa4a15518a result = new RL_3e3c312f4b244ea01713a0fa4a15518a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3e3c312f4b244ea01713a0fa4a15518a FromRestList<T>(RestList<T> restList, Func <T, RC_a04f94cfd410c813b8dee156f64b6537> converter) {
  RL_3e3c312f4b244ea01713a0fa4a15518a result = new RL_3e3c312f4b244ea01713a0fa4a15518a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3e3c312f4b244ea01713a0fa4a15518a() : base() {
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
protected override OSList<RC_a04f94cfd410c813b8dee156f64b6537> NewList() {
return new RL_3e3c312f4b244ea01713a0fa4a15518a();
}


} // RL_3e3c312f4b244ea01713a0fa4a15518a
}

