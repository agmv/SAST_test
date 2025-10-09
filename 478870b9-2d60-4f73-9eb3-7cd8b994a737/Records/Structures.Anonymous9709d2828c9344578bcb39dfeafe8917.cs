namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (gtIJl5OMV0SLyznf6v6JFw)
///  <code>RC_8a5dc374bf936f41e6af63789db6143f</code> that represent
/// s <code>FinishUserRegistrationResultRecord</code> <p>Description: </p>
/// </summary>
// Name: FinishUserRegistrationResultRecord
public partial struct RC_8a5dc374bf936f41e6af63789db6143f : ITypedRecord<RC_8a5dc374bf936f41e6af63789db6143f> {
internal static readonly GlobalObjectKey IdFinishUserRegistrationResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dMNdipO_QW_mr2N4nbYUPw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FinishUserRegistrationResult")]
public ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure ssSTFinishUserRegistrationResult;


public static implicit operator ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure( RC_8a5dc374bf936f41e6af63789db6143f r) {
return r.ssSTFinishUserRegistrationResult;
}

public static implicit operator RC_8a5dc374bf936f41e6af63789db6143f (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure r) {
RC_8a5dc374bf936f41e6af63789db6143f res = new RC_8a5dc374bf936f41e6af63789db6143f ();
res.ssSTFinishUserRegistrationResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8a5dc374bf936f41e6af63789db6143f() {
OptimizedAttributes = null;
ssSTFinishUserRegistrationResult = new ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure();
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
    ssSTFinishUserRegistrationResult.OptimizedAttributes = value[0];
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
ssSTFinishUserRegistrationResult.Read( r, ref index);
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
public void ReadIM(RC_8a5dc374bf936f41e6af63789db6143f r) {
this = r;
}


public static bool operator == (RC_8a5dc374bf936f41e6af63789db6143f a, RC_8a5dc374bf936f41e6af63789db6143f b) {
if (a.ssSTFinishUserRegistrationResult != b.ssSTFinishUserRegistrationResult) return false;
return true;
}

public static bool operator != (RC_8a5dc374bf936f41e6af63789db6143f a, RC_8a5dc374bf936f41e6af63789db6143f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8a5dc374bf936f41e6af63789db6143f)) return false;
return (this == (RC_8a5dc374bf936f41e6af63789db6143f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFinishUserRegistrationResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFinishUserRegistrationResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFinishUserRegistrationResult.InternalRecursiveSave();
}


public RC_8a5dc374bf936f41e6af63789db6143f Duplicate() {
RC_8a5dc374bf936f41e6af63789db6143f t;
t.ssSTFinishUserRegistrationResult = (ST_6ae840a01e1abcf21a5dce7b68bc4d92Structure)this.ssSTFinishUserRegistrationResult.Duplicate();
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
if (head == "finishuserregistrationresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishUserRegistrationResult")) variable.Value = ssSTFinishUserRegistrationResult; else variable.Optimized = true;
variable.SetFieldName("finishuserregistrationresult");
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
if (key == IdFinishUserRegistrationResult) {
return ssSTFinishUserRegistrationResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFinishUserRegistrationResult.Key.AsGuid) {
return ssSTFinishUserRegistrationResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFinishUserRegistrationResult.FillFromOther((IRecord) other.AttributeGet(IdFinishUserRegistrationResult));
}
} // RC_8a5dc374bf936f41e6af63789db6143f
/// <summary>
/// RecordList type <code>FinishUserRegistrationResultRecordList</code> that represents a record list
///  of <code>FinishUserRegistrationResult</code>
/// </summary>
public partial class RL_a7ed37c4ad7efcace07e2b019a1eb3fb : GenericRecordList<RC_8a5dc374bf936f41e6af63789db6143f>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8a5dc374bf936f41e6af63789db6143f GetElementDefaultValue() {
return new RC_8a5dc374bf936f41e6af63789db6143f();
}

public T[] ToArray<T>(Func<RC_8a5dc374bf936f41e6af63789db6143f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a7ed37c4ad7efcace07e2b019a1eb3fb recordList, Func<RC_8a5dc374bf936f41e6af63789db6143f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a7ed37c4ad7efcace07e2b019a1eb3fb(RC_8a5dc374bf936f41e6af63789db6143f[] array) {
  RL_a7ed37c4ad7efcace07e2b019a1eb3fb result = new RL_a7ed37c4ad7efcace07e2b019a1eb3fb();
result.InnerFromArray(array);
    return result;
}

public static RL_a7ed37c4ad7efcace07e2b019a1eb3fb ToList<T>(T[] array, Func <T, RC_8a5dc374bf936f41e6af63789db6143f> converter) {
  RL_a7ed37c4ad7efcace07e2b019a1eb3fb result = new RL_a7ed37c4ad7efcace07e2b019a1eb3fb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a7ed37c4ad7efcace07e2b019a1eb3fb FromRestList<T>(RestList<T> restList, Func <T, RC_8a5dc374bf936f41e6af63789db6143f> converter) {
  RL_a7ed37c4ad7efcace07e2b019a1eb3fb result = new RL_a7ed37c4ad7efcace07e2b019a1eb3fb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a7ed37c4ad7efcace07e2b019a1eb3fb() : base() {
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
protected override OSList<RC_8a5dc374bf936f41e6af63789db6143f> NewList() {
return new RL_a7ed37c4ad7efcace07e2b019a1eb3fb();
}


} // RL_a7ed37c4ad7efcace07e2b019a1eb3fb
}

