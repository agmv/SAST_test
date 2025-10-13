namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (RqRba0mR90W62MUyuhlZyg)
///  <code>RC_0be95ff147264c7a8eb5d98a9a36670a</code> that represents <code>HTTPHeaderRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPHeaderRecord
public partial struct RC_0be95ff147264c7a8eb5d98a9a36670a : ITypedRecord<RC_0be95ff147264c7a8eb5d98a9a36670a> {
internal static readonly GlobalObjectKey IdHTTPHeader = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8V_pCyZHekyOtdmKmjZnCg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HTTPHeader")]
public ST_b6163e36a4b633b09c820fee73ba221eStructure ssSTHTTPHeader;


public static implicit operator ST_b6163e36a4b633b09c820fee73ba221eStructure( RC_0be95ff147264c7a8eb5d98a9a36670a r) {
return r.ssSTHTTPHeader;
}

public static implicit operator RC_0be95ff147264c7a8eb5d98a9a36670a (ST_b6163e36a4b633b09c820fee73ba221eStructure r) {
RC_0be95ff147264c7a8eb5d98a9a36670a res = new RC_0be95ff147264c7a8eb5d98a9a36670a ();
res.ssSTHTTPHeader = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0be95ff147264c7a8eb5d98a9a36670a() {
OptimizedAttributes = null;
ssSTHTTPHeader = new ST_b6163e36a4b633b09c820fee73ba221eStructure();
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
    ssSTHTTPHeader.OptimizedAttributes = value[0];
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
ssSTHTTPHeader.Read( r, ref index);
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
public void ReadIM(RC_0be95ff147264c7a8eb5d98a9a36670a r) {
this = r;
}


public static bool operator == (RC_0be95ff147264c7a8eb5d98a9a36670a a, RC_0be95ff147264c7a8eb5d98a9a36670a b) {
if (a.ssSTHTTPHeader != b.ssSTHTTPHeader) return false;
return true;
}

public static bool operator != (RC_0be95ff147264c7a8eb5d98a9a36670a a, RC_0be95ff147264c7a8eb5d98a9a36670a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0be95ff147264c7a8eb5d98a9a36670a)) return false;
return (this == (RC_0be95ff147264c7a8eb5d98a9a36670a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHTTPHeader.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHTTPHeader.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHTTPHeader.InternalRecursiveSave();
}


public RC_0be95ff147264c7a8eb5d98a9a36670a Duplicate() {
RC_0be95ff147264c7a8eb5d98a9a36670a t;
t.ssSTHTTPHeader = (ST_b6163e36a4b633b09c820fee73ba221eStructure)this.ssSTHTTPHeader.Duplicate();
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
if (head == "httpheader") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HTTPHeader")) variable.Value = ssSTHTTPHeader; else variable.Optimized = true;
variable.SetFieldName("httpheader");
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
if (key == IdHTTPHeader) {
return ssSTHTTPHeader;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHTTPHeader.Key.AsGuid) {
return ssSTHTTPHeader;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHTTPHeader.FillFromOther((IRecord) other.AttributeGet(IdHTTPHeader));
}
} // RC_0be95ff147264c7a8eb5d98a9a36670a
/// <summary>
/// RecordList type <code>HTTPHeaderRecordList</code> that represents a record list of
///  <code>HTTPHeader</code>
/// </summary>
public partial class RL_dc22fec337c0665a8974958b300b0764 : GenericRecordList<RC_0be95ff147264c7a8eb5d98a9a36670a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0be95ff147264c7a8eb5d98a9a36670a GetElementDefaultValue() {
return new RC_0be95ff147264c7a8eb5d98a9a36670a();
}

public T[] ToArray<T>(Func<RC_0be95ff147264c7a8eb5d98a9a36670a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dc22fec337c0665a8974958b300b0764 recordList, Func<RC_0be95ff147264c7a8eb5d98a9a36670a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dc22fec337c0665a8974958b300b0764(RC_0be95ff147264c7a8eb5d98a9a36670a[] array) {
  RL_dc22fec337c0665a8974958b300b0764 result = new RL_dc22fec337c0665a8974958b300b0764();
result.InnerFromArray(array);
    return result;
}

public static RL_dc22fec337c0665a8974958b300b0764 ToList<T>(T[] array, Func <T, RC_0be95ff147264c7a8eb5d98a9a36670a> converter) {
  RL_dc22fec337c0665a8974958b300b0764 result = new RL_dc22fec337c0665a8974958b300b0764();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dc22fec337c0665a8974958b300b0764 FromRestList<T>(RestList<T> restList, Func <T, RC_0be95ff147264c7a8eb5d98a9a36670a> converter) {
  RL_dc22fec337c0665a8974958b300b0764 result = new RL_dc22fec337c0665a8974958b300b0764();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dc22fec337c0665a8974958b300b0764() : base() {
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
protected override OSList<RC_0be95ff147264c7a8eb5d98a9a36670a> NewList() {
return new RL_dc22fec337c0665a8974958b300b0764();
}


} // RL_dc22fec337c0665a8974958b300b0764
}

