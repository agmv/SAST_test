namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (fiwqqBW+ZYmzdvi_qw1tcA)
///  <code>RC_b1f889a35d23518bfa5ab890a96efb52</code> that represent
/// s <code>ProcessDefinitionLanguageRecord</code> <p>Description: </p>
/// </summary>
// Name: ProcessDefinitionLanguageRecord
public partial struct RC_b1f889a35d23518bfa5ab890a96efb52 : ITypedRecord<RC_b1f889a35d23518bfa5ab890a96efb52> {
internal static readonly GlobalObjectKey IdProcessDefinitionLanguage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o4n4sSNdi1H6WriQqW77Ug");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessDefinitionLanguage")]
public ENProcessDefinitionLanguageEntityRecord ssENProcessDefinitionLanguage;


public static implicit operator ENProcessDefinitionLanguageEntityRecord( RC_b1f889a35d23518bfa5ab890a96efb52 r) {
return r.ssENProcessDefinitionLanguage;
}

public static implicit operator RC_b1f889a35d23518bfa5ab890a96efb52 (ENProcessDefinitionLanguageEntityRecord r) {
RC_b1f889a35d23518bfa5ab890a96efb52 res = new RC_b1f889a35d23518bfa5ab890a96efb52 ();
res.ssENProcessDefinitionLanguage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessDefinitionLanguage.ChangedAttributes = value;
}
get {
    return ssENProcessDefinitionLanguage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b1f889a35d23518bfa5ab890a96efb52() {
OptimizedAttributes = null;
ssENProcessDefinitionLanguage = new ENProcessDefinitionLanguageEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessDefinitionLanguage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessDefinitionLanguage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessDefinitionLanguage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessDefinitionLanguage.Read( r, ref index);
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
public void ReadIM(RC_b1f889a35d23518bfa5ab890a96efb52 r) {
this = r;
}


public static bool operator == (RC_b1f889a35d23518bfa5ab890a96efb52 a, RC_b1f889a35d23518bfa5ab890a96efb52 b) {
if (a.ssENProcessDefinitionLanguage != b.ssENProcessDefinitionLanguage) return false;
return true;
}

public static bool operator != (RC_b1f889a35d23518bfa5ab890a96efb52 a, RC_b1f889a35d23518bfa5ab890a96efb52 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b1f889a35d23518bfa5ab890a96efb52)) return false;
return (this == (RC_b1f889a35d23518bfa5ab890a96efb52)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessDefinitionLanguage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessDefinitionLanguage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessDefinitionLanguage.InternalRecursiveSave();
}


public RC_b1f889a35d23518bfa5ab890a96efb52 Duplicate() {
RC_b1f889a35d23518bfa5ab890a96efb52 t;
t.ssENProcessDefinitionLanguage = (ENProcessDefinitionLanguageEntityRecord)this.ssENProcessDefinitionLanguage.Duplicate();
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
if (head == "processdefinitionlanguage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinitionLanguage")) variable.Value = ssENProcessDefinitionLanguage; else variable.Optimized = true;
variable.SetFieldName("processdefinitionlanguage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessDefinitionLanguage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessDefinitionLanguage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessDefinitionLanguage) {
return ssENProcessDefinitionLanguage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessDefinitionLanguage.Key.AsGuid) {
return ssENProcessDefinitionLanguage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessDefinitionLanguage.FillFromOther((IRecord) other.AttributeGet(IdProcessDefinitionLanguage));
}
} // RC_b1f889a35d23518bfa5ab890a96efb52
/// <summary>
/// RecordList type <code>ProcessDefinitionLanguageRecordList</code> that represents a record list of
///  <code>ProcessDefinitionLanguage</code>
/// </summary>
public partial class RL_4bc987bb2bbc5a9c083569aa81631f7e : GenericRecordList<RC_b1f889a35d23518bfa5ab890a96efb52>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b1f889a35d23518bfa5ab890a96efb52 GetElementDefaultValue() {
return new RC_b1f889a35d23518bfa5ab890a96efb52();
}

public T[] ToArray<T>(Func<RC_b1f889a35d23518bfa5ab890a96efb52, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4bc987bb2bbc5a9c083569aa81631f7e recordList, Func<RC_b1f889a35d23518bfa5ab890a96efb52, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4bc987bb2bbc5a9c083569aa81631f7e(RC_b1f889a35d23518bfa5ab890a96efb52[] array) {
  RL_4bc987bb2bbc5a9c083569aa81631f7e result = new RL_4bc987bb2bbc5a9c083569aa81631f7e();
result.InnerFromArray(array);
    return result;
}

public static RL_4bc987bb2bbc5a9c083569aa81631f7e ToList<T>(T[] array, Func <T, RC_b1f889a35d23518bfa5ab890a96efb52> converter) {
  RL_4bc987bb2bbc5a9c083569aa81631f7e result = new RL_4bc987bb2bbc5a9c083569aa81631f7e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4bc987bb2bbc5a9c083569aa81631f7e FromRestList<T>(RestList<T> restList, Func <T, RC_b1f889a35d23518bfa5ab890a96efb52> converter) {
  RL_4bc987bb2bbc5a9c083569aa81631f7e result = new RL_4bc987bb2bbc5a9c083569aa81631f7e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4bc987bb2bbc5a9c083569aa81631f7e() : base() {
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
protected override OSList<RC_b1f889a35d23518bfa5ab890a96efb52> NewList() {
return new RL_4bc987bb2bbc5a9c083569aa81631f7e();
}


} // RL_4bc987bb2bbc5a9c083569aa81631f7e
}

