namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (PY4MyIGVua7rVVztfJJ5vw)
///  <code>RC_80c865ccf1b0df95391817b0ddc45e18</code> that represent
/// s <code>ProcessDefinitionRecord</code> <p>Description: </p>
/// </summary>
// Name: ProcessDefinitionRecord
public partial struct RC_80c865ccf1b0df95391817b0ddc45e18 : ITypedRecord<RC_80c865ccf1b0df95391817b0ddc45e18> {
internal static readonly GlobalObjectKey IdProcessDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zGXIgLDxld85GBew3cReGA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessDefinition")]
public ENProcessDefinitionEntityRecord ssENProcessDefinition;


public static implicit operator ENProcessDefinitionEntityRecord( RC_80c865ccf1b0df95391817b0ddc45e18 r) {
return r.ssENProcessDefinition;
}

public static implicit operator RC_80c865ccf1b0df95391817b0ddc45e18 (ENProcessDefinitionEntityRecord r) {
RC_80c865ccf1b0df95391817b0ddc45e18 res = new RC_80c865ccf1b0df95391817b0ddc45e18 ();
res.ssENProcessDefinition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessDefinition.ChangedAttributes = value;
}
get {
    return ssENProcessDefinition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_80c865ccf1b0df95391817b0ddc45e18() {
OptimizedAttributes = null;
ssENProcessDefinition = new ENProcessDefinitionEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessDefinition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessDefinition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessDefinition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessDefinition.Read( r, ref index);
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
public void ReadIM(RC_80c865ccf1b0df95391817b0ddc45e18 r) {
this = r;
}


public static bool operator == (RC_80c865ccf1b0df95391817b0ddc45e18 a, RC_80c865ccf1b0df95391817b0ddc45e18 b) {
if (a.ssENProcessDefinition != b.ssENProcessDefinition) return false;
return true;
}

public static bool operator != (RC_80c865ccf1b0df95391817b0ddc45e18 a, RC_80c865ccf1b0df95391817b0ddc45e18 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_80c865ccf1b0df95391817b0ddc45e18)) return false;
return (this == (RC_80c865ccf1b0df95391817b0ddc45e18)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessDefinition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessDefinition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessDefinition.InternalRecursiveSave();
}


public RC_80c865ccf1b0df95391817b0ddc45e18 Duplicate() {
RC_80c865ccf1b0df95391817b0ddc45e18 t;
t.ssENProcessDefinition = (ENProcessDefinitionEntityRecord)this.ssENProcessDefinition.Duplicate();
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
if (head == "processdefinition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinition")) variable.Value = ssENProcessDefinition; else variable.Optimized = true;
variable.SetFieldName("processdefinition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessDefinition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessDefinition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessDefinition) {
return ssENProcessDefinition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessDefinition.Key.AsGuid) {
return ssENProcessDefinition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessDefinition.FillFromOther((IRecord) other.AttributeGet(IdProcessDefinition));
}
} // RC_80c865ccf1b0df95391817b0ddc45e18
/// <summary>
/// RecordList type <code>ProcessDefinitionRecordList</code> that represents a record list of
///  <code>ProcessDefinition</code>
/// </summary>
public partial class RL_d68e5346549cf39dd97c26423ec75146 : GenericRecordList<RC_80c865ccf1b0df95391817b0ddc45e18>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_80c865ccf1b0df95391817b0ddc45e18 GetElementDefaultValue() {
return new RC_80c865ccf1b0df95391817b0ddc45e18();
}

public T[] ToArray<T>(Func<RC_80c865ccf1b0df95391817b0ddc45e18, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d68e5346549cf39dd97c26423ec75146 recordList, Func<RC_80c865ccf1b0df95391817b0ddc45e18, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d68e5346549cf39dd97c26423ec75146(RC_80c865ccf1b0df95391817b0ddc45e18[] array) {
  RL_d68e5346549cf39dd97c26423ec75146 result = new RL_d68e5346549cf39dd97c26423ec75146();
result.InnerFromArray(array);
    return result;
}

public static RL_d68e5346549cf39dd97c26423ec75146 ToList<T>(T[] array, Func <T, RC_80c865ccf1b0df95391817b0ddc45e18> converter) {
  RL_d68e5346549cf39dd97c26423ec75146 result = new RL_d68e5346549cf39dd97c26423ec75146();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d68e5346549cf39dd97c26423ec75146 FromRestList<T>(RestList<T> restList, Func <T, RC_80c865ccf1b0df95391817b0ddc45e18> converter) {
  RL_d68e5346549cf39dd97c26423ec75146 result = new RL_d68e5346549cf39dd97c26423ec75146();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d68e5346549cf39dd97c26423ec75146() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_80c865ccf1b0df95391817b0ddc45e18> NewList() {
return new RL_d68e5346549cf39dd97c26423ec75146();
}


} // RL_d68e5346549cf39dd97c26423ec75146
}

