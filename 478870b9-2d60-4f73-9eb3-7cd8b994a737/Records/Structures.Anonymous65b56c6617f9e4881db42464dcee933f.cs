namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (Zmy1ZfkXiOQdtCRk3O6TPw)
///  <code>RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4</code> that represent
/// s <code>ProcessOutputDefinitionRecord</code> <p>Description: </p>
/// </summary>
// Name: ProcessOutputDefinitionRecord
public partial struct RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 : ITypedRecord<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> {
internal static readonly GlobalObjectKey IdProcessOutputDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xQ58_dTpav1KmjMtPhdd1A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessOutputDefinition")]
public ENProcessOutputDefinitionEntityRecord ssENProcessOutputDefinition;


public static implicit operator ENProcessOutputDefinitionEntityRecord( RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 r) {
return r.ssENProcessOutputDefinition;
}

public static implicit operator RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 (ENProcessOutputDefinitionEntityRecord r) {
RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 res = new RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 ();
res.ssENProcessOutputDefinition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessOutputDefinition.ChangedAttributes = value;
}
get {
    return ssENProcessOutputDefinition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4() {
OptimizedAttributes = null;
ssENProcessOutputDefinition = new ENProcessOutputDefinitionEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessOutputDefinition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessOutputDefinition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessOutputDefinition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessOutputDefinition.Read( r, ref index);
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
public void ReadIM(RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 r) {
this = r;
}


public static bool operator == (RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 a, RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 b) {
if (a.ssENProcessOutputDefinition != b.ssENProcessOutputDefinition) return false;
return true;
}

public static bool operator != (RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 a, RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4)) return false;
return (this == (RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessOutputDefinition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessOutputDefinition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessOutputDefinition.InternalRecursiveSave();
}


public RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 Duplicate() {
RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 t;
t.ssENProcessOutputDefinition = (ENProcessOutputDefinitionEntityRecord)this.ssENProcessOutputDefinition.Duplicate();
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
if (head == "processoutputdefinition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessOutputDefinition")) variable.Value = ssENProcessOutputDefinition; else variable.Optimized = true;
variable.SetFieldName("processoutputdefinition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessOutputDefinition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessOutputDefinition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessOutputDefinition) {
return ssENProcessOutputDefinition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessOutputDefinition.Key.AsGuid) {
return ssENProcessOutputDefinition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessOutputDefinition.FillFromOther((IRecord) other.AttributeGet(IdProcessOutputDefinition));
}
} // RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4
/// <summary>
/// RecordList type <code>ProcessOutputDefinitionRecordList</code> that represents a record list of
///  <code>ProcessOutputDefinition</code>
/// </summary>
public partial class RL_52acedf8b6208b104cbd689064facc6a : GenericRecordList<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4 GetElementDefaultValue() {
return new RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4();
}

public T[] ToArray<T>(Func<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_52acedf8b6208b104cbd689064facc6a recordList, Func<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_52acedf8b6208b104cbd689064facc6a(RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4[] array) {
  RL_52acedf8b6208b104cbd689064facc6a result = new RL_52acedf8b6208b104cbd689064facc6a();
result.InnerFromArray(array);
    return result;
}

public static RL_52acedf8b6208b104cbd689064facc6a ToList<T>(T[] array, Func <T, RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> converter) {
  RL_52acedf8b6208b104cbd689064facc6a result = new RL_52acedf8b6208b104cbd689064facc6a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_52acedf8b6208b104cbd689064facc6a FromRestList<T>(RestList<T> restList, Func <T, RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> converter) {
  RL_52acedf8b6208b104cbd689064facc6a result = new RL_52acedf8b6208b104cbd689064facc6a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_52acedf8b6208b104cbd689064facc6a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fd7c0ec5e9d4fd6a4a9a332d3e175dd4> NewList() {
return new RL_52acedf8b6208b104cbd689064facc6a();
}


} // RL_52acedf8b6208b104cbd689064facc6a
}

