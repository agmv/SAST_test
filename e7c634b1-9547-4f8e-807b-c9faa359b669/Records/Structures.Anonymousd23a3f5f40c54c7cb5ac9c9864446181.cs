namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (Xz860sVAfEy1rJyYZERhgQ)
///  <code>RC_331ddee75740189a809db62f762472bd</code> that represents <code>AIContentTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AIContentTypeRecord
public partial struct RC_331ddee75740189a809db62f762472bd : ITypedRecord<RC_331ddee75740189a809db62f762472bd> {
internal static readonly GlobalObjectKey IdAIContentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*594dM0BXmhiAnbYvdiRyvQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AIContentType")]
public ENAIContentTypeEntityRecord ssENAIContentType;


public static implicit operator ENAIContentTypeEntityRecord( RC_331ddee75740189a809db62f762472bd r) {
return r.ssENAIContentType;
}

public static implicit operator RC_331ddee75740189a809db62f762472bd (ENAIContentTypeEntityRecord r) {
RC_331ddee75740189a809db62f762472bd res = new RC_331ddee75740189a809db62f762472bd ();
res.ssENAIContentType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAIContentType.ChangedAttributes = value;
}
get {
    return ssENAIContentType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_331ddee75740189a809db62f762472bd() {
OptimizedAttributes = null;
ssENAIContentType = new ENAIContentTypeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAIContentType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAIContentType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAIContentType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAIContentType.Read( r, ref index);
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
public void ReadIM(RC_331ddee75740189a809db62f762472bd r) {
this = r;
}


public static bool operator == (RC_331ddee75740189a809db62f762472bd a, RC_331ddee75740189a809db62f762472bd b) {
if (a.ssENAIContentType != b.ssENAIContentType) return false;
return true;
}

public static bool operator != (RC_331ddee75740189a809db62f762472bd a, RC_331ddee75740189a809db62f762472bd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_331ddee75740189a809db62f762472bd)) return false;
return (this == (RC_331ddee75740189a809db62f762472bd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAIContentType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAIContentType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAIContentType.InternalRecursiveSave();
}


public RC_331ddee75740189a809db62f762472bd Duplicate() {
RC_331ddee75740189a809db62f762472bd t;
t.ssENAIContentType = (ENAIContentTypeEntityRecord)this.ssENAIContentType.Duplicate();
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
if (head == "aicontenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AIContentType")) variable.Value = ssENAIContentType; else variable.Optimized = true;
variable.SetFieldName("aicontenttype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAIContentType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAIContentType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAIContentType) {
return ssENAIContentType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAIContentType.Key.AsGuid) {
return ssENAIContentType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAIContentType.FillFromOther((IRecord) other.AttributeGet(IdAIContentType));
}
} // RC_331ddee75740189a809db62f762472bd
/// <summary>
/// RecordList type <code>AIContentTypeRecordList</code> that represents a record list of
///  <code>AIContentType</code>
/// </summary>
public partial class RL_cec9dfd4c1161962e6e08ed8fc3f9af5 : GenericRecordList<RC_331ddee75740189a809db62f762472bd>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_331ddee75740189a809db62f762472bd GetElementDefaultValue() {
return new RC_331ddee75740189a809db62f762472bd();
}

public T[] ToArray<T>(Func<RC_331ddee75740189a809db62f762472bd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cec9dfd4c1161962e6e08ed8fc3f9af5 recordList, Func<RC_331ddee75740189a809db62f762472bd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cec9dfd4c1161962e6e08ed8fc3f9af5(RC_331ddee75740189a809db62f762472bd[] array) {
  RL_cec9dfd4c1161962e6e08ed8fc3f9af5 result = new RL_cec9dfd4c1161962e6e08ed8fc3f9af5();
result.InnerFromArray(array);
    return result;
}

public static RL_cec9dfd4c1161962e6e08ed8fc3f9af5 ToList<T>(T[] array, Func <T, RC_331ddee75740189a809db62f762472bd> converter) {
  RL_cec9dfd4c1161962e6e08ed8fc3f9af5 result = new RL_cec9dfd4c1161962e6e08ed8fc3f9af5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cec9dfd4c1161962e6e08ed8fc3f9af5 FromRestList<T>(RestList<T> restList, Func <T, RC_331ddee75740189a809db62f762472bd> converter) {
  RL_cec9dfd4c1161962e6e08ed8fc3f9af5 result = new RL_cec9dfd4c1161962e6e08ed8fc3f9af5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cec9dfd4c1161962e6e08ed8fc3f9af5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_331ddee75740189a809db62f762472bd> NewList() {
return new RL_cec9dfd4c1161962e6e08ed8fc3f9af5();
}


} // RL_cec9dfd4c1161962e6e08ed8fc3f9af5
}

