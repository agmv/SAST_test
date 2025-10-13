namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (g5Rc+pJXCU+HEkFQjw90eg)
///  <code>RC_b27f0b968b0f7cea61506ac9d6ee7c27</code> that represent
/// s <code>PasswordValidationResultRecord</code> <p>Description: </p>
/// </summary>
// Name: PasswordValidationResultRecord
public partial struct RC_b27f0b968b0f7cea61506ac9d6ee7c27 : ITypedRecord<RC_b27f0b968b0f7cea61506ac9d6ee7c27> {
internal static readonly GlobalObjectKey IdPasswordValidationResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lgt_sg+L6nxhUGrJ1u58Jw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("PasswordValidationResult")]
public ST_b9e6959231369ae517164f0fb8e8606dStructure ssSTPasswordValidationResult;


public static implicit operator ST_b9e6959231369ae517164f0fb8e8606dStructure( RC_b27f0b968b0f7cea61506ac9d6ee7c27 r) {
return r.ssSTPasswordValidationResult;
}

public static implicit operator RC_b27f0b968b0f7cea61506ac9d6ee7c27 (ST_b9e6959231369ae517164f0fb8e8606dStructure r) {
RC_b27f0b968b0f7cea61506ac9d6ee7c27 res = new RC_b27f0b968b0f7cea61506ac9d6ee7c27 ();
res.ssSTPasswordValidationResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b27f0b968b0f7cea61506ac9d6ee7c27() {
OptimizedAttributes = null;
ssSTPasswordValidationResult = new ST_b9e6959231369ae517164f0fb8e8606dStructure();
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
    ssSTPasswordValidationResult.OptimizedAttributes = value[0];
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
ssSTPasswordValidationResult.Read( r, ref index);
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
public void ReadIM(RC_b27f0b968b0f7cea61506ac9d6ee7c27 r) {
this = r;
}


public static bool operator == (RC_b27f0b968b0f7cea61506ac9d6ee7c27 a, RC_b27f0b968b0f7cea61506ac9d6ee7c27 b) {
if (a.ssSTPasswordValidationResult != b.ssSTPasswordValidationResult) return false;
return true;
}

public static bool operator != (RC_b27f0b968b0f7cea61506ac9d6ee7c27 a, RC_b27f0b968b0f7cea61506ac9d6ee7c27 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b27f0b968b0f7cea61506ac9d6ee7c27)) return false;
return (this == (RC_b27f0b968b0f7cea61506ac9d6ee7c27)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPasswordValidationResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPasswordValidationResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPasswordValidationResult.InternalRecursiveSave();
}


public RC_b27f0b968b0f7cea61506ac9d6ee7c27 Duplicate() {
RC_b27f0b968b0f7cea61506ac9d6ee7c27 t;
t.ssSTPasswordValidationResult = (ST_b9e6959231369ae517164f0fb8e8606dStructure)this.ssSTPasswordValidationResult.Duplicate();
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
if (head == "passwordvalidationresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PasswordValidationResult")) variable.Value = ssSTPasswordValidationResult; else variable.Optimized = true;
variable.SetFieldName("passwordvalidationresult");
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
if (key == IdPasswordValidationResult) {
return ssSTPasswordValidationResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPasswordValidationResult.Key.AsGuid) {
return ssSTPasswordValidationResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPasswordValidationResult.FillFromOther((IRecord) other.AttributeGet(IdPasswordValidationResult));
}
} // RC_b27f0b968b0f7cea61506ac9d6ee7c27
/// <summary>
/// RecordList type <code>PasswordValidationResultRecordList</code> that represents a record list of
///  <code>PasswordValidationResult</code>
/// </summary>
public partial class RL_ca4befaa7d5de5d9bbcd4bf59c44b15c : GenericRecordList<RC_b27f0b968b0f7cea61506ac9d6ee7c27>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b27f0b968b0f7cea61506ac9d6ee7c27 GetElementDefaultValue() {
return new RC_b27f0b968b0f7cea61506ac9d6ee7c27();
}

public T[] ToArray<T>(Func<RC_b27f0b968b0f7cea61506ac9d6ee7c27, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ca4befaa7d5de5d9bbcd4bf59c44b15c recordList, Func<RC_b27f0b968b0f7cea61506ac9d6ee7c27, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ca4befaa7d5de5d9bbcd4bf59c44b15c(RC_b27f0b968b0f7cea61506ac9d6ee7c27[] array) {
  RL_ca4befaa7d5de5d9bbcd4bf59c44b15c result = new RL_ca4befaa7d5de5d9bbcd4bf59c44b15c();
result.InnerFromArray(array);
    return result;
}

public static RL_ca4befaa7d5de5d9bbcd4bf59c44b15c ToList<T>(T[] array, Func <T, RC_b27f0b968b0f7cea61506ac9d6ee7c27> converter) {
  RL_ca4befaa7d5de5d9bbcd4bf59c44b15c result = new RL_ca4befaa7d5de5d9bbcd4bf59c44b15c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ca4befaa7d5de5d9bbcd4bf59c44b15c FromRestList<T>(RestList<T> restList, Func <T, RC_b27f0b968b0f7cea61506ac9d6ee7c27> converter) {
  RL_ca4befaa7d5de5d9bbcd4bf59c44b15c result = new RL_ca4befaa7d5de5d9bbcd4bf59c44b15c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ca4befaa7d5de5d9bbcd4bf59c44b15c() : base() {
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
protected override OSList<RC_b27f0b968b0f7cea61506ac9d6ee7c27> NewList() {
return new RL_ca4befaa7d5de5d9bbcd4bf59c44b15c();
}


} // RL_ca4befaa7d5de5d9bbcd4bf59c44b15c
}

