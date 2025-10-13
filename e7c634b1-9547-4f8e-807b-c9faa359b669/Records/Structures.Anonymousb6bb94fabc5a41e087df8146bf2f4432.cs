namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (+pS7tlq84EGH34FGvy9EMg)
///  <code>RC_97347e879886250cc6e293fbc6c919f7</code> that represent
/// s <code>SampleListStructRecord</code> <p>Description: </p>
/// </summary>
// Name: SampleListStructRecord
public partial struct RC_97347e879886250cc6e293fbc6c919f7 : ITypedRecord<RC_97347e879886250cc6e293fbc6c919f7> {
internal static readonly GlobalObjectKey IdSampleListStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*h340l4aYDCXG4pP7xskZ9w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SampleListStruct")]
public ST_00ba72a41660161c6373af90c87d0979Structure ssSTSampleListStruct;


public static implicit operator ST_00ba72a41660161c6373af90c87d0979Structure( RC_97347e879886250cc6e293fbc6c919f7 r) {
return r.ssSTSampleListStruct;
}

public static implicit operator RC_97347e879886250cc6e293fbc6c919f7 (ST_00ba72a41660161c6373af90c87d0979Structure r) {
RC_97347e879886250cc6e293fbc6c919f7 res = new RC_97347e879886250cc6e293fbc6c919f7 ();
res.ssSTSampleListStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_97347e879886250cc6e293fbc6c919f7() {
OptimizedAttributes = null;
ssSTSampleListStruct = new ST_00ba72a41660161c6373af90c87d0979Structure();
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
    ssSTSampleListStruct.OptimizedAttributes = value[0];
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
ssSTSampleListStruct.Read( r, ref index);
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
public void ReadIM(RC_97347e879886250cc6e293fbc6c919f7 r) {
this = r;
}


public static bool operator == (RC_97347e879886250cc6e293fbc6c919f7 a, RC_97347e879886250cc6e293fbc6c919f7 b) {
if (a.ssSTSampleListStruct != b.ssSTSampleListStruct) return false;
return true;
}

public static bool operator != (RC_97347e879886250cc6e293fbc6c919f7 a, RC_97347e879886250cc6e293fbc6c919f7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_97347e879886250cc6e293fbc6c919f7)) return false;
return (this == (RC_97347e879886250cc6e293fbc6c919f7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSampleListStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSampleListStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSampleListStruct.InternalRecursiveSave();
}


public RC_97347e879886250cc6e293fbc6c919f7 Duplicate() {
RC_97347e879886250cc6e293fbc6c919f7 t;
t.ssSTSampleListStruct = (ST_00ba72a41660161c6373af90c87d0979Structure)this.ssSTSampleListStruct.Duplicate();
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
if (head == "sampleliststruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SampleListStruct")) variable.Value = ssSTSampleListStruct; else variable.Optimized = true;
variable.SetFieldName("sampleliststruct");
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
if (key == IdSampleListStruct) {
return ssSTSampleListStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSampleListStruct.Key.AsGuid) {
return ssSTSampleListStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSampleListStruct.FillFromOther((IRecord) other.AttributeGet(IdSampleListStruct));
}
} // RC_97347e879886250cc6e293fbc6c919f7
/// <summary>
/// RecordList type <code>SampleListStructRecordList</code> that represents a record list of
///  <code>SampleListStruct</code>
/// </summary>
public partial class RL_ce9b30ae6a9c469e29603a5719f5573d : GenericRecordList<RC_97347e879886250cc6e293fbc6c919f7>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_97347e879886250cc6e293fbc6c919f7 GetElementDefaultValue() {
return new RC_97347e879886250cc6e293fbc6c919f7();
}

public T[] ToArray<T>(Func<RC_97347e879886250cc6e293fbc6c919f7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ce9b30ae6a9c469e29603a5719f5573d recordList, Func<RC_97347e879886250cc6e293fbc6c919f7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ce9b30ae6a9c469e29603a5719f5573d(RC_97347e879886250cc6e293fbc6c919f7[] array) {
  RL_ce9b30ae6a9c469e29603a5719f5573d result = new RL_ce9b30ae6a9c469e29603a5719f5573d();
result.InnerFromArray(array);
    return result;
}

public static RL_ce9b30ae6a9c469e29603a5719f5573d ToList<T>(T[] array, Func <T, RC_97347e879886250cc6e293fbc6c919f7> converter) {
  RL_ce9b30ae6a9c469e29603a5719f5573d result = new RL_ce9b30ae6a9c469e29603a5719f5573d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ce9b30ae6a9c469e29603a5719f5573d FromRestList<T>(RestList<T> restList, Func <T, RC_97347e879886250cc6e293fbc6c919f7> converter) {
  RL_ce9b30ae6a9c469e29603a5719f5573d result = new RL_ce9b30ae6a9c469e29603a5719f5573d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ce9b30ae6a9c469e29603a5719f5573d() : base() {
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
protected override OSList<RC_97347e879886250cc6e293fbc6c919f7> NewList() {
return new RL_ce9b30ae6a9c469e29603a5719f5573d();
}


} // RL_ce9b30ae6a9c469e29603a5719f5573d
}

