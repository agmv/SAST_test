namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (lTOAynK_E1kxodRvLa8EvA)
///  <code>RC_24e87e1f1de297ca8a691099e40c22ed</code> that represents <code>ActivityOutputRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ActivityOutputRecord
public partial struct RC_24e87e1f1de297ca8a691099e40c22ed : ITypedRecord<RC_24e87e1f1de297ca8a691099e40c22ed> {
internal static readonly GlobalObjectKey IdActivityOutput = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*H37oJOIdypeKaRCZ5Awi7Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityOutput")]
public ENActivityOutputEntityRecord ssENActivityOutput;


public static implicit operator ENActivityOutputEntityRecord( RC_24e87e1f1de297ca8a691099e40c22ed r) {
return r.ssENActivityOutput;
}

public static implicit operator RC_24e87e1f1de297ca8a691099e40c22ed (ENActivityOutputEntityRecord r) {
RC_24e87e1f1de297ca8a691099e40c22ed res = new RC_24e87e1f1de297ca8a691099e40c22ed ();
res.ssENActivityOutput = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityOutput.ChangedAttributes = value;
}
get {
    return ssENActivityOutput.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_24e87e1f1de297ca8a691099e40c22ed() {
OptimizedAttributes = null;
ssENActivityOutput = new ENActivityOutputEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityOutput.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityOutput.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityOutput.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityOutput.Read( r, ref index);
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
public void ReadIM(RC_24e87e1f1de297ca8a691099e40c22ed r) {
this = r;
}


public static bool operator == (RC_24e87e1f1de297ca8a691099e40c22ed a, RC_24e87e1f1de297ca8a691099e40c22ed b) {
if (a.ssENActivityOutput != b.ssENActivityOutput) return false;
return true;
}

public static bool operator != (RC_24e87e1f1de297ca8a691099e40c22ed a, RC_24e87e1f1de297ca8a691099e40c22ed b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_24e87e1f1de297ca8a691099e40c22ed)) return false;
return (this == (RC_24e87e1f1de297ca8a691099e40c22ed)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityOutput.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityOutput.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityOutput.InternalRecursiveSave();
}


public RC_24e87e1f1de297ca8a691099e40c22ed Duplicate() {
RC_24e87e1f1de297ca8a691099e40c22ed t;
t.ssENActivityOutput = (ENActivityOutputEntityRecord)this.ssENActivityOutput.Duplicate();
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
if (head == "activityoutput") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityOutput")) variable.Value = ssENActivityOutput; else variable.Optimized = true;
variable.SetFieldName("activityoutput");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityOutput.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityOutput.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityOutput) {
return ssENActivityOutput;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityOutput.Key.AsGuid) {
return ssENActivityOutput;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityOutput.FillFromOther((IRecord) other.AttributeGet(IdActivityOutput));
}
} // RC_24e87e1f1de297ca8a691099e40c22ed
/// <summary>
/// RecordList type <code>ActivityOutputRecordList</code> that represents a record list of
///  <code>ActivityOutput</code>
/// </summary>
public partial class RL_28fc2381cbc1135b5eb41ae627dcd287 : GenericRecordList<RC_24e87e1f1de297ca8a691099e40c22ed>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_24e87e1f1de297ca8a691099e40c22ed GetElementDefaultValue() {
return new RC_24e87e1f1de297ca8a691099e40c22ed();
}

public T[] ToArray<T>(Func<RC_24e87e1f1de297ca8a691099e40c22ed, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_28fc2381cbc1135b5eb41ae627dcd287 recordList, Func<RC_24e87e1f1de297ca8a691099e40c22ed, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_28fc2381cbc1135b5eb41ae627dcd287(RC_24e87e1f1de297ca8a691099e40c22ed[] array) {
  RL_28fc2381cbc1135b5eb41ae627dcd287 result = new RL_28fc2381cbc1135b5eb41ae627dcd287();
result.InnerFromArray(array);
    return result;
}

public static RL_28fc2381cbc1135b5eb41ae627dcd287 ToList<T>(T[] array, Func <T, RC_24e87e1f1de297ca8a691099e40c22ed> converter) {
  RL_28fc2381cbc1135b5eb41ae627dcd287 result = new RL_28fc2381cbc1135b5eb41ae627dcd287();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_28fc2381cbc1135b5eb41ae627dcd287 FromRestList<T>(RestList<T> restList, Func <T, RC_24e87e1f1de297ca8a691099e40c22ed> converter) {
  RL_28fc2381cbc1135b5eb41ae627dcd287 result = new RL_28fc2381cbc1135b5eb41ae627dcd287();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_28fc2381cbc1135b5eb41ae627dcd287() : base() {
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
protected override OSList<RC_24e87e1f1de297ca8a691099e40c22ed> NewList() {
return new RL_28fc2381cbc1135b5eb41ae627dcd287();
}


} // RL_28fc2381cbc1135b5eb41ae627dcd287
}

