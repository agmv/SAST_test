namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (5TxGmqQF4EmPLuf1WYdy+Q)
///  <code>RC_1ba5183fe935decff47a51e639a147ac</code> that represents <code>HttpRequestRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HttpRequestRecord
public partial struct RC_1ba5183fe935decff47a51e639a147ac : ITypedRecord<RC_1ba5183fe935decff47a51e639a147ac> {
internal static readonly GlobalObjectKey IdHttpRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PxilGzXpz970elHmOaFHrA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HttpRequest")]
public EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord ssENHttpRequest;


public static implicit operator EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord( RC_1ba5183fe935decff47a51e639a147ac r) {
return r.ssENHttpRequest;
}

public static implicit operator RC_1ba5183fe935decff47a51e639a147ac (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord r) {
RC_1ba5183fe935decff47a51e639a147ac res = new RC_1ba5183fe935decff47a51e639a147ac ();
res.ssENHttpRequest = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENHttpRequest.ChangedAttributes = value;
}
get {
    return ssENHttpRequest.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1ba5183fe935decff47a51e639a147ac() {
OptimizedAttributes = null;
ssENHttpRequest = new EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENHttpRequest.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENHttpRequest.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENHttpRequest.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENHttpRequest.Read( r, ref index);
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
public void ReadIM(RC_1ba5183fe935decff47a51e639a147ac r) {
this = r;
}


public static bool operator == (RC_1ba5183fe935decff47a51e639a147ac a, RC_1ba5183fe935decff47a51e639a147ac b) {
if (a.ssENHttpRequest != b.ssENHttpRequest) return false;
return true;
}

public static bool operator != (RC_1ba5183fe935decff47a51e639a147ac a, RC_1ba5183fe935decff47a51e639a147ac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1ba5183fe935decff47a51e639a147ac)) return false;
return (this == (RC_1ba5183fe935decff47a51e639a147ac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENHttpRequest.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENHttpRequest.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENHttpRequest.InternalRecursiveSave();
}


public RC_1ba5183fe935decff47a51e639a147ac Duplicate() {
RC_1ba5183fe935decff47a51e639a147ac t;
t.ssENHttpRequest = (EN_f359738871d9ae45fb13f4707e4a8c7aEntityRecord)this.ssENHttpRequest.Duplicate();
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
if (head == "httprequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpRequest")) variable.Value = ssENHttpRequest; else variable.Optimized = true;
variable.SetFieldName("httprequest");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENHttpRequest.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENHttpRequest.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdHttpRequest) {
return ssENHttpRequest;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHttpRequest.Key.AsGuid) {
return ssENHttpRequest;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENHttpRequest.FillFromOther((IRecord) other.AttributeGet(IdHttpRequest));
}
} // RC_1ba5183fe935decff47a51e639a147ac
/// <summary>
/// RecordList type <code>HttpRequestRecordList</code> that represents a record list of
///  <code>HttpRequest</code>
/// </summary>
public partial class RL_cb90b4d276d47c120cb334b7b28342e2 : GenericRecordList<RC_1ba5183fe935decff47a51e639a147ac>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_1ba5183fe935decff47a51e639a147ac GetElementDefaultValue() {
return new RC_1ba5183fe935decff47a51e639a147ac();
}

public T[] ToArray<T>(Func<RC_1ba5183fe935decff47a51e639a147ac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cb90b4d276d47c120cb334b7b28342e2 recordList, Func<RC_1ba5183fe935decff47a51e639a147ac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cb90b4d276d47c120cb334b7b28342e2(RC_1ba5183fe935decff47a51e639a147ac[] array) {
  RL_cb90b4d276d47c120cb334b7b28342e2 result = new RL_cb90b4d276d47c120cb334b7b28342e2();
result.InnerFromArray(array);
    return result;
}

public static RL_cb90b4d276d47c120cb334b7b28342e2 ToList<T>(T[] array, Func <T, RC_1ba5183fe935decff47a51e639a147ac> converter) {
  RL_cb90b4d276d47c120cb334b7b28342e2 result = new RL_cb90b4d276d47c120cb334b7b28342e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cb90b4d276d47c120cb334b7b28342e2 FromRestList<T>(RestList<T> restList, Func <T, RC_1ba5183fe935decff47a51e639a147ac> converter) {
  RL_cb90b4d276d47c120cb334b7b28342e2 result = new RL_cb90b4d276d47c120cb334b7b28342e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cb90b4d276d47c120cb334b7b28342e2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1ba5183fe935decff47a51e639a147ac> NewList() {
return new RL_cb90b4d276d47c120cb334b7b28342e2();
}


} // RL_cb90b4d276d47c120cb334b7b28342e2
}

