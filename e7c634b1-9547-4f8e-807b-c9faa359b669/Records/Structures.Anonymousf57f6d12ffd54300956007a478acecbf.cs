namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (Em1_9dX_AEOVYAekeKzsvw)
///  <code>RC_e49ec0d2ad1794ad18666b7d4da994e4</code> that represents <code>HTTPRequest2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPRequest2Record
public partial struct RC_e49ec0d2ad1794ad18666b7d4da994e4 : ITypedRecord<RC_e49ec0d2ad1794ad18666b7d4da994e4> {
internal static readonly GlobalObjectKey IdHTTPRequest2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0sCe5BetrZQYZmt9TamU5A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HTTPRequest2")]
public ST_2e4d23f993f70b2a453aff430875354bStructure ssSTHTTPRequest2;


public static implicit operator ST_2e4d23f993f70b2a453aff430875354bStructure( RC_e49ec0d2ad1794ad18666b7d4da994e4 r) {
return r.ssSTHTTPRequest2;
}

public static implicit operator RC_e49ec0d2ad1794ad18666b7d4da994e4 (ST_2e4d23f993f70b2a453aff430875354bStructure r) {
RC_e49ec0d2ad1794ad18666b7d4da994e4 res = new RC_e49ec0d2ad1794ad18666b7d4da994e4 ();
res.ssSTHTTPRequest2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e49ec0d2ad1794ad18666b7d4da994e4() {
OptimizedAttributes = null;
ssSTHTTPRequest2 = new ST_2e4d23f993f70b2a453aff430875354bStructure();
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
    ssSTHTTPRequest2.OptimizedAttributes = value[0];
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
ssSTHTTPRequest2.Read( r, ref index);
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
public void ReadIM(RC_e49ec0d2ad1794ad18666b7d4da994e4 r) {
this = r;
}


public static bool operator == (RC_e49ec0d2ad1794ad18666b7d4da994e4 a, RC_e49ec0d2ad1794ad18666b7d4da994e4 b) {
if (a.ssSTHTTPRequest2 != b.ssSTHTTPRequest2) return false;
return true;
}

public static bool operator != (RC_e49ec0d2ad1794ad18666b7d4da994e4 a, RC_e49ec0d2ad1794ad18666b7d4da994e4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e49ec0d2ad1794ad18666b7d4da994e4)) return false;
return (this == (RC_e49ec0d2ad1794ad18666b7d4da994e4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHTTPRequest2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHTTPRequest2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHTTPRequest2.InternalRecursiveSave();
}


public RC_e49ec0d2ad1794ad18666b7d4da994e4 Duplicate() {
RC_e49ec0d2ad1794ad18666b7d4da994e4 t;
t.ssSTHTTPRequest2 = (ST_2e4d23f993f70b2a453aff430875354bStructure)this.ssSTHTTPRequest2.Duplicate();
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
if (head == "httprequest2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HTTPRequest2")) variable.Value = ssSTHTTPRequest2; else variable.Optimized = true;
variable.SetFieldName("httprequest2");
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
if (key == IdHTTPRequest2) {
return ssSTHTTPRequest2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHTTPRequest2.Key.AsGuid) {
return ssSTHTTPRequest2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHTTPRequest2.FillFromOther((IRecord) other.AttributeGet(IdHTTPRequest2));
}
} // RC_e49ec0d2ad1794ad18666b7d4da994e4
/// <summary>
/// RecordList type <code>HTTPRequest2RecordList</code> that represents a record list of
///  <code>HTTPRequest2</code>
/// </summary>
public partial class RL_f8707584ee81418f8b9301042a50ffa5 : GenericRecordList<RC_e49ec0d2ad1794ad18666b7d4da994e4>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e49ec0d2ad1794ad18666b7d4da994e4 GetElementDefaultValue() {
return new RC_e49ec0d2ad1794ad18666b7d4da994e4();
}

public T[] ToArray<T>(Func<RC_e49ec0d2ad1794ad18666b7d4da994e4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f8707584ee81418f8b9301042a50ffa5 recordList, Func<RC_e49ec0d2ad1794ad18666b7d4da994e4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f8707584ee81418f8b9301042a50ffa5(RC_e49ec0d2ad1794ad18666b7d4da994e4[] array) {
  RL_f8707584ee81418f8b9301042a50ffa5 result = new RL_f8707584ee81418f8b9301042a50ffa5();
result.InnerFromArray(array);
    return result;
}

public static RL_f8707584ee81418f8b9301042a50ffa5 ToList<T>(T[] array, Func <T, RC_e49ec0d2ad1794ad18666b7d4da994e4> converter) {
  RL_f8707584ee81418f8b9301042a50ffa5 result = new RL_f8707584ee81418f8b9301042a50ffa5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f8707584ee81418f8b9301042a50ffa5 FromRestList<T>(RestList<T> restList, Func <T, RC_e49ec0d2ad1794ad18666b7d4da994e4> converter) {
  RL_f8707584ee81418f8b9301042a50ffa5 result = new RL_f8707584ee81418f8b9301042a50ffa5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f8707584ee81418f8b9301042a50ffa5() : base() {
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
protected override OSList<RC_e49ec0d2ad1794ad18666b7d4da994e4> NewList() {
return new RL_f8707584ee81418f8b9301042a50ffa5();
}


} // RL_f8707584ee81418f8b9301042a50ffa5
}

