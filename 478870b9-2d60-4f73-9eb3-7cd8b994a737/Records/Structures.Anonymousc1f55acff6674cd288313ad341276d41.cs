namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (z1r1wWf20kyIMTrTQSdtQQ)
///  <code>RC_bd573fb2cb521691dc6a8c4b02eeb054</code> that represent
/// s <code>UpdateUserResultRecord</code> <p>Description: </p>
/// </summary>
// Name: UpdateUserResultRecord
public partial struct RC_bd573fb2cb521691dc6a8c4b02eeb054 : ITypedRecord<RC_bd573fb2cb521691dc6a8c4b02eeb054> {
internal static readonly GlobalObjectKey IdUpdateUserResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sj9XvVLLkRbcaoxLAu6wVA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UpdateUserResult")]
public ST_c57cc6bedbdc9e62046393fa735672cfStructure ssSTUpdateUserResult;


public static implicit operator ST_c57cc6bedbdc9e62046393fa735672cfStructure( RC_bd573fb2cb521691dc6a8c4b02eeb054 r) {
return r.ssSTUpdateUserResult;
}

public static implicit operator RC_bd573fb2cb521691dc6a8c4b02eeb054 (ST_c57cc6bedbdc9e62046393fa735672cfStructure r) {
RC_bd573fb2cb521691dc6a8c4b02eeb054 res = new RC_bd573fb2cb521691dc6a8c4b02eeb054 ();
res.ssSTUpdateUserResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bd573fb2cb521691dc6a8c4b02eeb054() {
OptimizedAttributes = null;
ssSTUpdateUserResult = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();
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
    ssSTUpdateUserResult.OptimizedAttributes = value[0];
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
ssSTUpdateUserResult.Read( r, ref index);
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
public void ReadIM(RC_bd573fb2cb521691dc6a8c4b02eeb054 r) {
this = r;
}


public static bool operator == (RC_bd573fb2cb521691dc6a8c4b02eeb054 a, RC_bd573fb2cb521691dc6a8c4b02eeb054 b) {
if (a.ssSTUpdateUserResult != b.ssSTUpdateUserResult) return false;
return true;
}

public static bool operator != (RC_bd573fb2cb521691dc6a8c4b02eeb054 a, RC_bd573fb2cb521691dc6a8c4b02eeb054 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bd573fb2cb521691dc6a8c4b02eeb054)) return false;
return (this == (RC_bd573fb2cb521691dc6a8c4b02eeb054)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUpdateUserResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUpdateUserResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUpdateUserResult.InternalRecursiveSave();
}


public RC_bd573fb2cb521691dc6a8c4b02eeb054 Duplicate() {
RC_bd573fb2cb521691dc6a8c4b02eeb054 t;
t.ssSTUpdateUserResult = (ST_c57cc6bedbdc9e62046393fa735672cfStructure)this.ssSTUpdateUserResult.Duplicate();
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
if (head == "updateuserresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateUserResult")) variable.Value = ssSTUpdateUserResult; else variable.Optimized = true;
variable.SetFieldName("updateuserresult");
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
if (key == IdUpdateUserResult) {
return ssSTUpdateUserResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUpdateUserResult.Key.AsGuid) {
return ssSTUpdateUserResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUpdateUserResult.FillFromOther((IRecord) other.AttributeGet(IdUpdateUserResult));
}
} // RC_bd573fb2cb521691dc6a8c4b02eeb054
/// <summary>
/// RecordList type <code>UpdateUserResultRecordList</code> that represents a record list of
///  <code>UpdateUserResult</code>
/// </summary>
public partial class RL_201410915258bdd92387bbd4bec2a7bb : GenericRecordList<RC_bd573fb2cb521691dc6a8c4b02eeb054>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_bd573fb2cb521691dc6a8c4b02eeb054 GetElementDefaultValue() {
return new RC_bd573fb2cb521691dc6a8c4b02eeb054();
}

public T[] ToArray<T>(Func<RC_bd573fb2cb521691dc6a8c4b02eeb054, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_201410915258bdd92387bbd4bec2a7bb recordList, Func<RC_bd573fb2cb521691dc6a8c4b02eeb054, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_201410915258bdd92387bbd4bec2a7bb(RC_bd573fb2cb521691dc6a8c4b02eeb054[] array) {
  RL_201410915258bdd92387bbd4bec2a7bb result = new RL_201410915258bdd92387bbd4bec2a7bb();
result.InnerFromArray(array);
    return result;
}

public static RL_201410915258bdd92387bbd4bec2a7bb ToList<T>(T[] array, Func <T, RC_bd573fb2cb521691dc6a8c4b02eeb054> converter) {
  RL_201410915258bdd92387bbd4bec2a7bb result = new RL_201410915258bdd92387bbd4bec2a7bb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_201410915258bdd92387bbd4bec2a7bb FromRestList<T>(RestList<T> restList, Func <T, RC_bd573fb2cb521691dc6a8c4b02eeb054> converter) {
  RL_201410915258bdd92387bbd4bec2a7bb result = new RL_201410915258bdd92387bbd4bec2a7bb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_201410915258bdd92387bbd4bec2a7bb() : base() {
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
protected override OSList<RC_bd573fb2cb521691dc6a8c4b02eeb054> NewList() {
return new RL_201410915258bdd92387bbd4bec2a7bb();
}


} // RL_201410915258bdd92387bbd4bec2a7bb
}

