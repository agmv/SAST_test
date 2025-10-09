namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (rnZ2z13BuwYV8qrjk351+A)
///  <code>RC_cbc07de8251245064bd8f80b6b35c7f6</code> that represent
/// s <code>ProcessInputDefinitionRecord</code> <p>Description: </p>
/// </summary>
// Name: ProcessInputDefinitionRecord
public partial struct RC_cbc07de8251245064bd8f80b6b35c7f6 : ITypedRecord<RC_cbc07de8251245064bd8f80b6b35c7f6> {
internal static readonly GlobalObjectKey IdProcessInputDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6H3AyxIlBkVL2PgLazXH9g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProcessInputDefinition")]
public ENProcessInputDefinitionEntityRecord ssENProcessInputDefinition;


public static implicit operator ENProcessInputDefinitionEntityRecord( RC_cbc07de8251245064bd8f80b6b35c7f6 r) {
return r.ssENProcessInputDefinition;
}

public static implicit operator RC_cbc07de8251245064bd8f80b6b35c7f6 (ENProcessInputDefinitionEntityRecord r) {
RC_cbc07de8251245064bd8f80b6b35c7f6 res = new RC_cbc07de8251245064bd8f80b6b35c7f6 ();
res.ssENProcessInputDefinition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessInputDefinition.ChangedAttributes = value;
}
get {
    return ssENProcessInputDefinition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_cbc07de8251245064bd8f80b6b35c7f6() {
OptimizedAttributes = null;
ssENProcessInputDefinition = new ENProcessInputDefinitionEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessInputDefinition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessInputDefinition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessInputDefinition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessInputDefinition.Read( r, ref index);
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
public void ReadIM(RC_cbc07de8251245064bd8f80b6b35c7f6 r) {
this = r;
}


public static bool operator == (RC_cbc07de8251245064bd8f80b6b35c7f6 a, RC_cbc07de8251245064bd8f80b6b35c7f6 b) {
if (a.ssENProcessInputDefinition != b.ssENProcessInputDefinition) return false;
return true;
}

public static bool operator != (RC_cbc07de8251245064bd8f80b6b35c7f6 a, RC_cbc07de8251245064bd8f80b6b35c7f6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cbc07de8251245064bd8f80b6b35c7f6)) return false;
return (this == (RC_cbc07de8251245064bd8f80b6b35c7f6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessInputDefinition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessInputDefinition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessInputDefinition.InternalRecursiveSave();
}


public RC_cbc07de8251245064bd8f80b6b35c7f6 Duplicate() {
RC_cbc07de8251245064bd8f80b6b35c7f6 t;
t.ssENProcessInputDefinition = (ENProcessInputDefinitionEntityRecord)this.ssENProcessInputDefinition.Duplicate();
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
if (head == "processinputdefinition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessInputDefinition")) variable.Value = ssENProcessInputDefinition; else variable.Optimized = true;
variable.SetFieldName("processinputdefinition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessInputDefinition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessInputDefinition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessInputDefinition) {
return ssENProcessInputDefinition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessInputDefinition.Key.AsGuid) {
return ssENProcessInputDefinition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessInputDefinition.FillFromOther((IRecord) other.AttributeGet(IdProcessInputDefinition));
}
} // RC_cbc07de8251245064bd8f80b6b35c7f6
/// <summary>
/// RecordList type <code>ProcessInputDefinitionRecordList</code> that represents a record list of
///  <code>ProcessInputDefinition</code>
/// </summary>
public partial class RL_7a20bba9a4dcbce87cc868fa1eaca840 : GenericRecordList<RC_cbc07de8251245064bd8f80b6b35c7f6>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_cbc07de8251245064bd8f80b6b35c7f6 GetElementDefaultValue() {
return new RC_cbc07de8251245064bd8f80b6b35c7f6();
}

public T[] ToArray<T>(Func<RC_cbc07de8251245064bd8f80b6b35c7f6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7a20bba9a4dcbce87cc868fa1eaca840 recordList, Func<RC_cbc07de8251245064bd8f80b6b35c7f6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7a20bba9a4dcbce87cc868fa1eaca840(RC_cbc07de8251245064bd8f80b6b35c7f6[] array) {
  RL_7a20bba9a4dcbce87cc868fa1eaca840 result = new RL_7a20bba9a4dcbce87cc868fa1eaca840();
result.InnerFromArray(array);
    return result;
}

public static RL_7a20bba9a4dcbce87cc868fa1eaca840 ToList<T>(T[] array, Func <T, RC_cbc07de8251245064bd8f80b6b35c7f6> converter) {
  RL_7a20bba9a4dcbce87cc868fa1eaca840 result = new RL_7a20bba9a4dcbce87cc868fa1eaca840();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7a20bba9a4dcbce87cc868fa1eaca840 FromRestList<T>(RestList<T> restList, Func <T, RC_cbc07de8251245064bd8f80b6b35c7f6> converter) {
  RL_7a20bba9a4dcbce87cc868fa1eaca840 result = new RL_7a20bba9a4dcbce87cc868fa1eaca840();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7a20bba9a4dcbce87cc868fa1eaca840() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cbc07de8251245064bd8f80b6b35c7f6> NewList() {
return new RL_7a20bba9a4dcbce87cc868fa1eaca840();
}


} // RL_7a20bba9a4dcbce87cc868fa1eaca840
}

