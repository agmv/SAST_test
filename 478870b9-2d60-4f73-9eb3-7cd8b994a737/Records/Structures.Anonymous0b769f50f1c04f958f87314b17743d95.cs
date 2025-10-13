namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (UJ92C8DxlU+PhzFLF3Q9lQ)
///  <code>RC_679ae82d2c7d05b47c7411f8ce9aeb62</code> that represent
/// s <code>FinishUpdateEmailResultRecord</code> <p>Description: </p>
/// </summary>
// Name: FinishUpdateEmailResultRecord
public partial struct RC_679ae82d2c7d05b47c7411f8ce9aeb62 : ITypedRecord<RC_679ae82d2c7d05b47c7411f8ce9aeb62> {
internal static readonly GlobalObjectKey IdFinishUpdateEmailResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LeiaZ30stAV8dBH4zprrYg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FinishUpdateEmailResult")]
public ST_992b6b077ef933bd10f0df6cf0ce4be3Structure ssSTFinishUpdateEmailResult;


public static implicit operator ST_992b6b077ef933bd10f0df6cf0ce4be3Structure( RC_679ae82d2c7d05b47c7411f8ce9aeb62 r) {
return r.ssSTFinishUpdateEmailResult;
}

public static implicit operator RC_679ae82d2c7d05b47c7411f8ce9aeb62 (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure r) {
RC_679ae82d2c7d05b47c7411f8ce9aeb62 res = new RC_679ae82d2c7d05b47c7411f8ce9aeb62 ();
res.ssSTFinishUpdateEmailResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_679ae82d2c7d05b47c7411f8ce9aeb62() {
OptimizedAttributes = null;
ssSTFinishUpdateEmailResult = new ST_992b6b077ef933bd10f0df6cf0ce4be3Structure();
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
    ssSTFinishUpdateEmailResult.OptimizedAttributes = value[0];
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
ssSTFinishUpdateEmailResult.Read( r, ref index);
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
public void ReadIM(RC_679ae82d2c7d05b47c7411f8ce9aeb62 r) {
this = r;
}


public static bool operator == (RC_679ae82d2c7d05b47c7411f8ce9aeb62 a, RC_679ae82d2c7d05b47c7411f8ce9aeb62 b) {
if (a.ssSTFinishUpdateEmailResult != b.ssSTFinishUpdateEmailResult) return false;
return true;
}

public static bool operator != (RC_679ae82d2c7d05b47c7411f8ce9aeb62 a, RC_679ae82d2c7d05b47c7411f8ce9aeb62 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_679ae82d2c7d05b47c7411f8ce9aeb62)) return false;
return (this == (RC_679ae82d2c7d05b47c7411f8ce9aeb62)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFinishUpdateEmailResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFinishUpdateEmailResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFinishUpdateEmailResult.InternalRecursiveSave();
}


public RC_679ae82d2c7d05b47c7411f8ce9aeb62 Duplicate() {
RC_679ae82d2c7d05b47c7411f8ce9aeb62 t;
t.ssSTFinishUpdateEmailResult = (ST_992b6b077ef933bd10f0df6cf0ce4be3Structure)this.ssSTFinishUpdateEmailResult.Duplicate();
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
if (head == "finishupdateemailresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishUpdateEmailResult")) variable.Value = ssSTFinishUpdateEmailResult; else variable.Optimized = true;
variable.SetFieldName("finishupdateemailresult");
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
if (key == IdFinishUpdateEmailResult) {
return ssSTFinishUpdateEmailResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFinishUpdateEmailResult.Key.AsGuid) {
return ssSTFinishUpdateEmailResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFinishUpdateEmailResult.FillFromOther((IRecord) other.AttributeGet(IdFinishUpdateEmailResult));
}
} // RC_679ae82d2c7d05b47c7411f8ce9aeb62
/// <summary>
/// RecordList type <code>FinishUpdateEmailResultRecordList</code> that represents a record list of
///  <code>FinishUpdateEmailResult</code>
/// </summary>
public partial class RL_a16bff4ffe259a251b49331d47845f50 : GenericRecordList<RC_679ae82d2c7d05b47c7411f8ce9aeb62>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_679ae82d2c7d05b47c7411f8ce9aeb62 GetElementDefaultValue() {
return new RC_679ae82d2c7d05b47c7411f8ce9aeb62();
}

public T[] ToArray<T>(Func<RC_679ae82d2c7d05b47c7411f8ce9aeb62, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a16bff4ffe259a251b49331d47845f50 recordList, Func<RC_679ae82d2c7d05b47c7411f8ce9aeb62, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a16bff4ffe259a251b49331d47845f50(RC_679ae82d2c7d05b47c7411f8ce9aeb62[] array) {
  RL_a16bff4ffe259a251b49331d47845f50 result = new RL_a16bff4ffe259a251b49331d47845f50();
result.InnerFromArray(array);
    return result;
}

public static RL_a16bff4ffe259a251b49331d47845f50 ToList<T>(T[] array, Func <T, RC_679ae82d2c7d05b47c7411f8ce9aeb62> converter) {
  RL_a16bff4ffe259a251b49331d47845f50 result = new RL_a16bff4ffe259a251b49331d47845f50();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a16bff4ffe259a251b49331d47845f50 FromRestList<T>(RestList<T> restList, Func <T, RC_679ae82d2c7d05b47c7411f8ce9aeb62> converter) {
  RL_a16bff4ffe259a251b49331d47845f50 result = new RL_a16bff4ffe259a251b49331d47845f50();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a16bff4ffe259a251b49331d47845f50() : base() {
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
protected override OSList<RC_679ae82d2c7d05b47c7411f8ce9aeb62> NewList() {
return new RL_a16bff4ffe259a251b49331d47845f50();
}


} // RL_a16bff4ffe259a251b49331d47845f50
}

