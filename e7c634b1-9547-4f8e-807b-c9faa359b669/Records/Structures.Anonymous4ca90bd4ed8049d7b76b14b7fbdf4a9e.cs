namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (1AupTIDt10m3axS3+99Kng)
///  <code>RC_ee5350e5200eabac6362c9f03f6b7e3b</code> that represents <code>HttpMethodRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HttpMethodRecord
public partial struct RC_ee5350e5200eabac6362c9f03f6b7e3b : ITypedRecord<RC_ee5350e5200eabac6362c9f03f6b7e3b> {
internal static readonly GlobalObjectKey IdHttpMethod = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5VBT7g4grKtjYsnwP2t+Ow");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HttpMethod")]
public EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord ssENHttpMethod;


public static implicit operator EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord( RC_ee5350e5200eabac6362c9f03f6b7e3b r) {
return r.ssENHttpMethod;
}

public static implicit operator RC_ee5350e5200eabac6362c9f03f6b7e3b (EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord r) {
RC_ee5350e5200eabac6362c9f03f6b7e3b res = new RC_ee5350e5200eabac6362c9f03f6b7e3b ();
res.ssENHttpMethod = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENHttpMethod.ChangedAttributes = value;
}
get {
    return ssENHttpMethod.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ee5350e5200eabac6362c9f03f6b7e3b() {
OptimizedAttributes = null;
ssENHttpMethod = new EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENHttpMethod.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENHttpMethod.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENHttpMethod.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENHttpMethod.Read( r, ref index);
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
public void ReadIM(RC_ee5350e5200eabac6362c9f03f6b7e3b r) {
this = r;
}


public static bool operator == (RC_ee5350e5200eabac6362c9f03f6b7e3b a, RC_ee5350e5200eabac6362c9f03f6b7e3b b) {
if (a.ssENHttpMethod != b.ssENHttpMethod) return false;
return true;
}

public static bool operator != (RC_ee5350e5200eabac6362c9f03f6b7e3b a, RC_ee5350e5200eabac6362c9f03f6b7e3b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ee5350e5200eabac6362c9f03f6b7e3b)) return false;
return (this == (RC_ee5350e5200eabac6362c9f03f6b7e3b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENHttpMethod.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENHttpMethod.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENHttpMethod.InternalRecursiveSave();
}


public RC_ee5350e5200eabac6362c9f03f6b7e3b Duplicate() {
RC_ee5350e5200eabac6362c9f03f6b7e3b t;
t.ssENHttpMethod = (EN_02ad87d3c2a24e88a42ee1e665695e3cEntityRecord)this.ssENHttpMethod.Duplicate();
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
if (head == "httpmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpMethod")) variable.Value = ssENHttpMethod; else variable.Optimized = true;
variable.SetFieldName("httpmethod");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENHttpMethod.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENHttpMethod.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdHttpMethod) {
return ssENHttpMethod;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHttpMethod.Key.AsGuid) {
return ssENHttpMethod;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENHttpMethod.FillFromOther((IRecord) other.AttributeGet(IdHttpMethod));
}
} // RC_ee5350e5200eabac6362c9f03f6b7e3b
/// <summary>
/// RecordList type <code>HttpMethodRecordList</code> that represents a record list of
///  <code>HttpMethod</code>
/// </summary>
public partial class RL_247079eb7ba180a0ae01d5f8ac440c45 : GenericRecordList<RC_ee5350e5200eabac6362c9f03f6b7e3b>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_ee5350e5200eabac6362c9f03f6b7e3b GetElementDefaultValue() {
return new RC_ee5350e5200eabac6362c9f03f6b7e3b();
}

public T[] ToArray<T>(Func<RC_ee5350e5200eabac6362c9f03f6b7e3b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_247079eb7ba180a0ae01d5f8ac440c45 recordList, Func<RC_ee5350e5200eabac6362c9f03f6b7e3b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_247079eb7ba180a0ae01d5f8ac440c45(RC_ee5350e5200eabac6362c9f03f6b7e3b[] array) {
  RL_247079eb7ba180a0ae01d5f8ac440c45 result = new RL_247079eb7ba180a0ae01d5f8ac440c45();
result.InnerFromArray(array);
    return result;
}

public static RL_247079eb7ba180a0ae01d5f8ac440c45 ToList<T>(T[] array, Func <T, RC_ee5350e5200eabac6362c9f03f6b7e3b> converter) {
  RL_247079eb7ba180a0ae01d5f8ac440c45 result = new RL_247079eb7ba180a0ae01d5f8ac440c45();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_247079eb7ba180a0ae01d5f8ac440c45 FromRestList<T>(RestList<T> restList, Func <T, RC_ee5350e5200eabac6362c9f03f6b7e3b> converter) {
  RL_247079eb7ba180a0ae01d5f8ac440c45 result = new RL_247079eb7ba180a0ae01d5f8ac440c45();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_247079eb7ba180a0ae01d5f8ac440c45() : base() {
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
protected override OSList<RC_ee5350e5200eabac6362c9f03f6b7e3b> NewList() {
return new RL_247079eb7ba180a0ae01d5f8ac440c45();
}


} // RL_247079eb7ba180a0ae01d5f8ac440c45
}

