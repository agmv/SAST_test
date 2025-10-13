namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (AK6Kfv+ga35kekT85aA9pQ)
///  <code>RC_faf38c2d2aeee71f293ad23cd32fa7e2</code> that represent
/// s <code>ActivityInstanceRecord</code> <p>Description: </p>
/// </summary>
// Name: ActivityInstanceRecord
public partial struct RC_faf38c2d2aeee71f293ad23cd32fa7e2 : ITypedRecord<RC_faf38c2d2aeee71f293ad23cd32fa7e2> {
internal static readonly GlobalObjectKey IdActivityInstance = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LYzz+u4qH+cpOtI80y+n4g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityInstance")]
public ENActivityInstanceEntityRecord ssENActivityInstance;


public static implicit operator ENActivityInstanceEntityRecord( RC_faf38c2d2aeee71f293ad23cd32fa7e2 r) {
return r.ssENActivityInstance;
}

public static implicit operator RC_faf38c2d2aeee71f293ad23cd32fa7e2 (ENActivityInstanceEntityRecord r) {
RC_faf38c2d2aeee71f293ad23cd32fa7e2 res = new RC_faf38c2d2aeee71f293ad23cd32fa7e2 ();
res.ssENActivityInstance = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityInstance.ChangedAttributes = value;
}
get {
    return ssENActivityInstance.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_faf38c2d2aeee71f293ad23cd32fa7e2() {
OptimizedAttributes = null;
ssENActivityInstance = new ENActivityInstanceEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityInstance.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityInstance.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityInstance.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityInstance.Read( r, ref index);
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
public void ReadIM(RC_faf38c2d2aeee71f293ad23cd32fa7e2 r) {
this = r;
}


public static bool operator == (RC_faf38c2d2aeee71f293ad23cd32fa7e2 a, RC_faf38c2d2aeee71f293ad23cd32fa7e2 b) {
if (a.ssENActivityInstance != b.ssENActivityInstance) return false;
return true;
}

public static bool operator != (RC_faf38c2d2aeee71f293ad23cd32fa7e2 a, RC_faf38c2d2aeee71f293ad23cd32fa7e2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_faf38c2d2aeee71f293ad23cd32fa7e2)) return false;
return (this == (RC_faf38c2d2aeee71f293ad23cd32fa7e2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityInstance.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityInstance.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityInstance.InternalRecursiveSave();
}


public RC_faf38c2d2aeee71f293ad23cd32fa7e2 Duplicate() {
RC_faf38c2d2aeee71f293ad23cd32fa7e2 t;
t.ssENActivityInstance = (ENActivityInstanceEntityRecord)this.ssENActivityInstance.Duplicate();
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
if (head == "activityinstance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityInstance")) variable.Value = ssENActivityInstance; else variable.Optimized = true;
variable.SetFieldName("activityinstance");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityInstance.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityInstance.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityInstance) {
return ssENActivityInstance;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityInstance.Key.AsGuid) {
return ssENActivityInstance;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityInstance.FillFromOther((IRecord) other.AttributeGet(IdActivityInstance));
}
} // RC_faf38c2d2aeee71f293ad23cd32fa7e2
/// <summary>
/// RecordList type <code>ActivityInstanceRecordList</code> that represents a record list of
///  <code>ActivityInstance</code>
/// </summary>
public partial class RL_e4683611f40e200d3ecdb101fca93d6d : GenericRecordList<RC_faf38c2d2aeee71f293ad23cd32fa7e2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_faf38c2d2aeee71f293ad23cd32fa7e2 GetElementDefaultValue() {
return new RC_faf38c2d2aeee71f293ad23cd32fa7e2();
}

public T[] ToArray<T>(Func<RC_faf38c2d2aeee71f293ad23cd32fa7e2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e4683611f40e200d3ecdb101fca93d6d recordList, Func<RC_faf38c2d2aeee71f293ad23cd32fa7e2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e4683611f40e200d3ecdb101fca93d6d(RC_faf38c2d2aeee71f293ad23cd32fa7e2[] array) {
  RL_e4683611f40e200d3ecdb101fca93d6d result = new RL_e4683611f40e200d3ecdb101fca93d6d();
result.InnerFromArray(array);
    return result;
}

public static RL_e4683611f40e200d3ecdb101fca93d6d ToList<T>(T[] array, Func <T, RC_faf38c2d2aeee71f293ad23cd32fa7e2> converter) {
  RL_e4683611f40e200d3ecdb101fca93d6d result = new RL_e4683611f40e200d3ecdb101fca93d6d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e4683611f40e200d3ecdb101fca93d6d FromRestList<T>(RestList<T> restList, Func <T, RC_faf38c2d2aeee71f293ad23cd32fa7e2> converter) {
  RL_e4683611f40e200d3ecdb101fca93d6d result = new RL_e4683611f40e200d3ecdb101fca93d6d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e4683611f40e200d3ecdb101fca93d6d() : base() {
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
protected override OSList<RC_faf38c2d2aeee71f293ad23cd32fa7e2> NewList() {
return new RL_e4683611f40e200d3ecdb101fca93d6d();
}


} // RL_e4683611f40e200d3ecdb101fca93d6d
}

