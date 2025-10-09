namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (H7mLuE6kltXBeO3bCigoFw)
///  <code>RC_2efffbee03fccc31484e893e007e6c9a</code> that represents <code>EntityAttributeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EntityAttributeRecord
public partial struct RC_2efffbee03fccc31484e893e007e6c9a : ITypedRecord<RC_2efffbee03fccc31484e893e007e6c9a> {
internal static readonly GlobalObjectKey IdEntityAttribute = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7vv_LvwDMcxITok+AH5smg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("EntityAttribute")]
public ENEntityAttributeEntityRecord ssENEntityAttribute;


public static implicit operator ENEntityAttributeEntityRecord( RC_2efffbee03fccc31484e893e007e6c9a r) {
return r.ssENEntityAttribute;
}

public static implicit operator RC_2efffbee03fccc31484e893e007e6c9a (ENEntityAttributeEntityRecord r) {
RC_2efffbee03fccc31484e893e007e6c9a res = new RC_2efffbee03fccc31484e893e007e6c9a ();
res.ssENEntityAttribute = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEntityAttribute.ChangedAttributes = value;
}
get {
    return ssENEntityAttribute.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2efffbee03fccc31484e893e007e6c9a() {
OptimizedAttributes = null;
ssENEntityAttribute = new ENEntityAttributeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntityAttribute.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEntityAttribute.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEntityAttribute.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntityAttribute.Read( r, ref index);
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
public void ReadIM(RC_2efffbee03fccc31484e893e007e6c9a r) {
this = r;
}


public static bool operator == (RC_2efffbee03fccc31484e893e007e6c9a a, RC_2efffbee03fccc31484e893e007e6c9a b) {
if (a.ssENEntityAttribute != b.ssENEntityAttribute) return false;
return true;
}

public static bool operator != (RC_2efffbee03fccc31484e893e007e6c9a a, RC_2efffbee03fccc31484e893e007e6c9a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2efffbee03fccc31484e893e007e6c9a)) return false;
return (this == (RC_2efffbee03fccc31484e893e007e6c9a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntityAttribute.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntityAttribute.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntityAttribute.InternalRecursiveSave();
}


public RC_2efffbee03fccc31484e893e007e6c9a Duplicate() {
RC_2efffbee03fccc31484e893e007e6c9a t;
t.ssENEntityAttribute = (ENEntityAttributeEntityRecord)this.ssENEntityAttribute.Duplicate();
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
if (head == "entityattribute") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityAttribute")) variable.Value = ssENEntityAttribute; else variable.Optimized = true;
variable.SetFieldName("entityattribute");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEntityAttribute.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEntityAttribute.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEntityAttribute) {
return ssENEntityAttribute;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntityAttribute.Key.AsGuid) {
return ssENEntityAttribute;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntityAttribute.FillFromOther((IRecord) other.AttributeGet(IdEntityAttribute));
}
} // RC_2efffbee03fccc31484e893e007e6c9a
/// <summary>
/// RecordList type <code>EntityAttributeRecordList</code> that represents a record list of
///  <code>EntityAttribute</code>
/// </summary>
public partial class RL_582b59adcb0660dd0915958cbaffea77 : GenericRecordList<RC_2efffbee03fccc31484e893e007e6c9a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2efffbee03fccc31484e893e007e6c9a GetElementDefaultValue() {
return new RC_2efffbee03fccc31484e893e007e6c9a();
}

public T[] ToArray<T>(Func<RC_2efffbee03fccc31484e893e007e6c9a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_582b59adcb0660dd0915958cbaffea77 recordList, Func<RC_2efffbee03fccc31484e893e007e6c9a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_582b59adcb0660dd0915958cbaffea77(RC_2efffbee03fccc31484e893e007e6c9a[] array) {
  RL_582b59adcb0660dd0915958cbaffea77 result = new RL_582b59adcb0660dd0915958cbaffea77();
result.InnerFromArray(array);
    return result;
}

public static RL_582b59adcb0660dd0915958cbaffea77 ToList<T>(T[] array, Func <T, RC_2efffbee03fccc31484e893e007e6c9a> converter) {
  RL_582b59adcb0660dd0915958cbaffea77 result = new RL_582b59adcb0660dd0915958cbaffea77();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_582b59adcb0660dd0915958cbaffea77 FromRestList<T>(RestList<T> restList, Func <T, RC_2efffbee03fccc31484e893e007e6c9a> converter) {
  RL_582b59adcb0660dd0915958cbaffea77 result = new RL_582b59adcb0660dd0915958cbaffea77();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_582b59adcb0660dd0915958cbaffea77() : base() {
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
protected override OSList<RC_2efffbee03fccc31484e893e007e6c9a> NewList() {
return new RL_582b59adcb0660dd0915958cbaffea77();
}


} // RL_582b59adcb0660dd0915958cbaffea77
}

