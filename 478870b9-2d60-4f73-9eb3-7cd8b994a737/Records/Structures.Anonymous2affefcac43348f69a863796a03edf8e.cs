namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (yu__KjPE9kiahjeWoD7fjg)
///  <code>RC_37cfc11aad68902b9d78f57915b7ae79</code> that represent
/// s <code>StartUserRegistrationResultRecord</code> <p>Description: </p>
/// </summary>
// Name: StartUserRegistrationResultRecord
public partial struct RC_37cfc11aad68902b9d78f57915b7ae79 : ITypedRecord<RC_37cfc11aad68902b9d78f57915b7ae79> {
internal static readonly GlobalObjectKey IdStartUserRegistrationResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GsHPN2itK5CdePV5FbeueQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StartUserRegistrationResult")]
public ST_b465768a49759f20ddd40d498521c3aeStructure ssSTStartUserRegistrationResult;


public static implicit operator ST_b465768a49759f20ddd40d498521c3aeStructure( RC_37cfc11aad68902b9d78f57915b7ae79 r) {
return r.ssSTStartUserRegistrationResult;
}

public static implicit operator RC_37cfc11aad68902b9d78f57915b7ae79 (ST_b465768a49759f20ddd40d498521c3aeStructure r) {
RC_37cfc11aad68902b9d78f57915b7ae79 res = new RC_37cfc11aad68902b9d78f57915b7ae79 ();
res.ssSTStartUserRegistrationResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_37cfc11aad68902b9d78f57915b7ae79() {
OptimizedAttributes = null;
ssSTStartUserRegistrationResult = new ST_b465768a49759f20ddd40d498521c3aeStructure();
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
    ssSTStartUserRegistrationResult.OptimizedAttributes = value[0];
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
ssSTStartUserRegistrationResult.Read( r, ref index);
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
public void ReadIM(RC_37cfc11aad68902b9d78f57915b7ae79 r) {
this = r;
}


public static bool operator == (RC_37cfc11aad68902b9d78f57915b7ae79 a, RC_37cfc11aad68902b9d78f57915b7ae79 b) {
if (a.ssSTStartUserRegistrationResult != b.ssSTStartUserRegistrationResult) return false;
return true;
}

public static bool operator != (RC_37cfc11aad68902b9d78f57915b7ae79 a, RC_37cfc11aad68902b9d78f57915b7ae79 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_37cfc11aad68902b9d78f57915b7ae79)) return false;
return (this == (RC_37cfc11aad68902b9d78f57915b7ae79)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStartUserRegistrationResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStartUserRegistrationResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStartUserRegistrationResult.InternalRecursiveSave();
}


public RC_37cfc11aad68902b9d78f57915b7ae79 Duplicate() {
RC_37cfc11aad68902b9d78f57915b7ae79 t;
t.ssSTStartUserRegistrationResult = (ST_b465768a49759f20ddd40d498521c3aeStructure)this.ssSTStartUserRegistrationResult.Duplicate();
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
if (head == "startuserregistrationresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartUserRegistrationResult")) variable.Value = ssSTStartUserRegistrationResult; else variable.Optimized = true;
variable.SetFieldName("startuserregistrationresult");
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
if (key == IdStartUserRegistrationResult) {
return ssSTStartUserRegistrationResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStartUserRegistrationResult.Key.AsGuid) {
return ssSTStartUserRegistrationResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStartUserRegistrationResult.FillFromOther((IRecord) other.AttributeGet(IdStartUserRegistrationResult));
}
} // RC_37cfc11aad68902b9d78f57915b7ae79
/// <summary>
/// RecordList type <code>StartUserRegistrationResultRecordList</code> that represents a record list of
///  <code>StartUserRegistrationResult</code>
/// </summary>
public partial class RL_cc1e5a7165115293b327c74187de23a0 : GenericRecordList<RC_37cfc11aad68902b9d78f57915b7ae79>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_37cfc11aad68902b9d78f57915b7ae79 GetElementDefaultValue() {
return new RC_37cfc11aad68902b9d78f57915b7ae79();
}

public T[] ToArray<T>(Func<RC_37cfc11aad68902b9d78f57915b7ae79, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cc1e5a7165115293b327c74187de23a0 recordList, Func<RC_37cfc11aad68902b9d78f57915b7ae79, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cc1e5a7165115293b327c74187de23a0(RC_37cfc11aad68902b9d78f57915b7ae79[] array) {
  RL_cc1e5a7165115293b327c74187de23a0 result = new RL_cc1e5a7165115293b327c74187de23a0();
result.InnerFromArray(array);
    return result;
}

public static RL_cc1e5a7165115293b327c74187de23a0 ToList<T>(T[] array, Func <T, RC_37cfc11aad68902b9d78f57915b7ae79> converter) {
  RL_cc1e5a7165115293b327c74187de23a0 result = new RL_cc1e5a7165115293b327c74187de23a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cc1e5a7165115293b327c74187de23a0 FromRestList<T>(RestList<T> restList, Func <T, RC_37cfc11aad68902b9d78f57915b7ae79> converter) {
  RL_cc1e5a7165115293b327c74187de23a0 result = new RL_cc1e5a7165115293b327c74187de23a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cc1e5a7165115293b327c74187de23a0() : base() {
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
protected override OSList<RC_37cfc11aad68902b9d78f57915b7ae79> NewList() {
return new RL_cc1e5a7165115293b327c74187de23a0();
}


} // RL_cc1e5a7165115293b327c74187de23a0
}

