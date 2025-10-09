namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (PDizIYfihUaDPHIpRRyvWA)
///  <code>RC_880f0b08a77c1575f19f408e1fddc8c6</code> that represent
/// s <code>HumanActivityInstanceRecord</code> <p>Description: </p>
/// </summary>
// Name: HumanActivityInstanceRecord
public partial struct RC_880f0b08a77c1575f19f408e1fddc8c6 : ITypedRecord<RC_880f0b08a77c1575f19f408e1fddc8c6> {
internal static readonly GlobalObjectKey IdHumanActivityInstance = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CAsPiHyndRXxn0COH93Ixg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HumanActivityInstance")]
public ENHumanActivityInstanceEntityRecord ssENHumanActivityInstance;


public static implicit operator ENHumanActivityInstanceEntityRecord( RC_880f0b08a77c1575f19f408e1fddc8c6 r) {
return r.ssENHumanActivityInstance;
}

public static implicit operator RC_880f0b08a77c1575f19f408e1fddc8c6 (ENHumanActivityInstanceEntityRecord r) {
RC_880f0b08a77c1575f19f408e1fddc8c6 res = new RC_880f0b08a77c1575f19f408e1fddc8c6 ();
res.ssENHumanActivityInstance = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENHumanActivityInstance.ChangedAttributes = value;
}
get {
    return ssENHumanActivityInstance.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_880f0b08a77c1575f19f408e1fddc8c6() {
OptimizedAttributes = null;
ssENHumanActivityInstance = new ENHumanActivityInstanceEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENHumanActivityInstance.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENHumanActivityInstance.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENHumanActivityInstance.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENHumanActivityInstance.Read( r, ref index);
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
public void ReadIM(RC_880f0b08a77c1575f19f408e1fddc8c6 r) {
this = r;
}


public static bool operator == (RC_880f0b08a77c1575f19f408e1fddc8c6 a, RC_880f0b08a77c1575f19f408e1fddc8c6 b) {
if (a.ssENHumanActivityInstance != b.ssENHumanActivityInstance) return false;
return true;
}

public static bool operator != (RC_880f0b08a77c1575f19f408e1fddc8c6 a, RC_880f0b08a77c1575f19f408e1fddc8c6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_880f0b08a77c1575f19f408e1fddc8c6)) return false;
return (this == (RC_880f0b08a77c1575f19f408e1fddc8c6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENHumanActivityInstance.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENHumanActivityInstance.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENHumanActivityInstance.InternalRecursiveSave();
}


public RC_880f0b08a77c1575f19f408e1fddc8c6 Duplicate() {
RC_880f0b08a77c1575f19f408e1fddc8c6 t;
t.ssENHumanActivityInstance = (ENHumanActivityInstanceEntityRecord)this.ssENHumanActivityInstance.Duplicate();
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
if (head == "humanactivityinstance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HumanActivityInstance")) variable.Value = ssENHumanActivityInstance; else variable.Optimized = true;
variable.SetFieldName("humanactivityinstance");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENHumanActivityInstance.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENHumanActivityInstance.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdHumanActivityInstance) {
return ssENHumanActivityInstance;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHumanActivityInstance.Key.AsGuid) {
return ssENHumanActivityInstance;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENHumanActivityInstance.FillFromOther((IRecord) other.AttributeGet(IdHumanActivityInstance));
}
} // RC_880f0b08a77c1575f19f408e1fddc8c6
/// <summary>
/// RecordList type <code>HumanActivityInstanceRecordList</code> that represents a record list of
///  <code>HumanActivityInstance</code>
/// </summary>
public partial class RL_b1951e6718fee0cfdfe159a4bfc6a006 : GenericRecordList<RC_880f0b08a77c1575f19f408e1fddc8c6>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_880f0b08a77c1575f19f408e1fddc8c6 GetElementDefaultValue() {
return new RC_880f0b08a77c1575f19f408e1fddc8c6();
}

public T[] ToArray<T>(Func<RC_880f0b08a77c1575f19f408e1fddc8c6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b1951e6718fee0cfdfe159a4bfc6a006 recordList, Func<RC_880f0b08a77c1575f19f408e1fddc8c6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b1951e6718fee0cfdfe159a4bfc6a006(RC_880f0b08a77c1575f19f408e1fddc8c6[] array) {
  RL_b1951e6718fee0cfdfe159a4bfc6a006 result = new RL_b1951e6718fee0cfdfe159a4bfc6a006();
result.InnerFromArray(array);
    return result;
}

public static RL_b1951e6718fee0cfdfe159a4bfc6a006 ToList<T>(T[] array, Func <T, RC_880f0b08a77c1575f19f408e1fddc8c6> converter) {
  RL_b1951e6718fee0cfdfe159a4bfc6a006 result = new RL_b1951e6718fee0cfdfe159a4bfc6a006();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b1951e6718fee0cfdfe159a4bfc6a006 FromRestList<T>(RestList<T> restList, Func <T, RC_880f0b08a77c1575f19f408e1fddc8c6> converter) {
  RL_b1951e6718fee0cfdfe159a4bfc6a006 result = new RL_b1951e6718fee0cfdfe159a4bfc6a006();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b1951e6718fee0cfdfe159a4bfc6a006() : base() {
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
protected override OSList<RC_880f0b08a77c1575f19f408e1fddc8c6> NewList() {
return new RL_b1951e6718fee0cfdfe159a4bfc6a006();
}


} // RL_b1951e6718fee0cfdfe159a4bfc6a006
}

