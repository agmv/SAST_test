namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (odGSELWTmkeGts_3ICk_cw)
///  <code>RC_3c619bc2cefd7ed268d81977413e1480</code> that represent
/// s <code>StartUserRegistrationFailureReasonRecord</code> <p>Description: </p>
/// </summary>
// Name: StartUserRegistrationFailureReasonRecord
public partial struct RC_3c619bc2cefd7ed268d81977413e1480 : ITypedRecord<RC_3c619bc2cefd7ed268d81977413e1480> {
internal static readonly GlobalObjectKey IdStartUserRegistrationFailureReason = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wpthPP3O0n5o2Bl3QT4UgA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StartUserRegistrationFailureReason")]
public ST_8f28b651568fa9d5ba7b5b342de64a1cStructure ssSTStartUserRegistrationFailureReason;


public static implicit operator ST_8f28b651568fa9d5ba7b5b342de64a1cStructure( RC_3c619bc2cefd7ed268d81977413e1480 r) {
return r.ssSTStartUserRegistrationFailureReason;
}

public static implicit operator RC_3c619bc2cefd7ed268d81977413e1480 (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure r) {
RC_3c619bc2cefd7ed268d81977413e1480 res = new RC_3c619bc2cefd7ed268d81977413e1480 ();
res.ssSTStartUserRegistrationFailureReason = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3c619bc2cefd7ed268d81977413e1480() {
OptimizedAttributes = null;
ssSTStartUserRegistrationFailureReason = new ST_8f28b651568fa9d5ba7b5b342de64a1cStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTStartUserRegistrationFailureReason.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTStartUserRegistrationFailureReason.Read( r, ref index);
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
public void ReadIM(RC_3c619bc2cefd7ed268d81977413e1480 r) {
this = r;
}


public static bool operator == (RC_3c619bc2cefd7ed268d81977413e1480 a, RC_3c619bc2cefd7ed268d81977413e1480 b) {
if (a.ssSTStartUserRegistrationFailureReason != b.ssSTStartUserRegistrationFailureReason) return false;
return true;
}

public static bool operator != (RC_3c619bc2cefd7ed268d81977413e1480 a, RC_3c619bc2cefd7ed268d81977413e1480 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3c619bc2cefd7ed268d81977413e1480)) return false;
return (this == (RC_3c619bc2cefd7ed268d81977413e1480)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStartUserRegistrationFailureReason.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStartUserRegistrationFailureReason.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStartUserRegistrationFailureReason.InternalRecursiveSave();
}


public RC_3c619bc2cefd7ed268d81977413e1480 Duplicate() {
RC_3c619bc2cefd7ed268d81977413e1480 t;
t.ssSTStartUserRegistrationFailureReason = (ST_8f28b651568fa9d5ba7b5b342de64a1cStructure)this.ssSTStartUserRegistrationFailureReason.Duplicate();
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
if (head == "startuserregistrationfailurereason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartUserRegistrationFailureReason")) variable.Value = ssSTStartUserRegistrationFailureReason; else variable.Optimized = true;
variable.SetFieldName("startuserregistrationfailurereason");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdStartUserRegistrationFailureReason) {
return ssSTStartUserRegistrationFailureReason;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStartUserRegistrationFailureReason.Key.AsGuid) {
return ssSTStartUserRegistrationFailureReason;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStartUserRegistrationFailureReason.FillFromOther((IRecord) other.AttributeGet(IdStartUserRegistrationFailureReason));
}
} // RC_3c619bc2cefd7ed268d81977413e1480
/// <summary>
/// RecordList type <code>StartUserRegistrationFailureReasonRecordList</code> that represents a record
///  list of <code>StartUserRegistrationFailureReason</code>
/// </summary>
public partial class RL_089f77c93d3ce6afa3f16b6014987fb9 : GenericRecordList<RC_3c619bc2cefd7ed268d81977413e1480>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3c619bc2cefd7ed268d81977413e1480 GetElementDefaultValue() {
return new RC_3c619bc2cefd7ed268d81977413e1480();
}

public T[] ToArray<T>(Func<RC_3c619bc2cefd7ed268d81977413e1480, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_089f77c93d3ce6afa3f16b6014987fb9 recordList, Func<RC_3c619bc2cefd7ed268d81977413e1480, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_089f77c93d3ce6afa3f16b6014987fb9(RC_3c619bc2cefd7ed268d81977413e1480[] array) {
  RL_089f77c93d3ce6afa3f16b6014987fb9 result = new RL_089f77c93d3ce6afa3f16b6014987fb9();
result.InnerFromArray(array);
    return result;
}

public static RL_089f77c93d3ce6afa3f16b6014987fb9 ToList<T>(T[] array, Func <T, RC_3c619bc2cefd7ed268d81977413e1480> converter) {
  RL_089f77c93d3ce6afa3f16b6014987fb9 result = new RL_089f77c93d3ce6afa3f16b6014987fb9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_089f77c93d3ce6afa3f16b6014987fb9 FromRestList<T>(RestList<T> restList, Func <T, RC_3c619bc2cefd7ed268d81977413e1480> converter) {
  RL_089f77c93d3ce6afa3f16b6014987fb9 result = new RL_089f77c93d3ce6afa3f16b6014987fb9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_089f77c93d3ce6afa3f16b6014987fb9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3c619bc2cefd7ed268d81977413e1480> NewList() {
return new RL_089f77c93d3ce6afa3f16b6014987fb9();
}


} // RL_089f77c93d3ce6afa3f16b6014987fb9
}

