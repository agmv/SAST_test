namespace ssRuntimeDestroyerLib {
/// <summary>
/// [AnonymousStructure] Record (OKydtg4dhU+snLRwSbbPFg)
///  <code>RC_fbd3e4c28e569cea299f20f76971b2b8</code> that represent
/// s <code>HttpResponseStructRecord</code> <p>Description: </p>
/// </summary>
// Name: HttpResponseStructRecord
public partial struct RC_fbd3e4c28e569cea299f20f76971b2b8 : ITypedRecord<RC_fbd3e4c28e569cea299f20f76971b2b8> {
internal static readonly GlobalObjectKey IdHttpResponseStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wuTT+1aO6pwpnyD3aXGyuA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("HttpResponseStruct")]
public ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure ssSTHttpResponseStruct;


public static implicit operator ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure( RC_fbd3e4c28e569cea299f20f76971b2b8 r) {
return r.ssSTHttpResponseStruct;
}

public static implicit operator RC_fbd3e4c28e569cea299f20f76971b2b8 (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure r) {
RC_fbd3e4c28e569cea299f20f76971b2b8 res = new RC_fbd3e4c28e569cea299f20f76971b2b8 ();
res.ssSTHttpResponseStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fbd3e4c28e569cea299f20f76971b2b8() {
OptimizedAttributes = null;
ssSTHttpResponseStruct = new ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure();
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
    ssSTHttpResponseStruct.OptimizedAttributes = value[0];
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
ssSTHttpResponseStruct.Read( r, ref index);
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
public void ReadIM(RC_fbd3e4c28e569cea299f20f76971b2b8 r) {
this = r;
}


public static bool operator == (RC_fbd3e4c28e569cea299f20f76971b2b8 a, RC_fbd3e4c28e569cea299f20f76971b2b8 b) {
if (a.ssSTHttpResponseStruct != b.ssSTHttpResponseStruct) return false;
return true;
}

public static bool operator != (RC_fbd3e4c28e569cea299f20f76971b2b8 a, RC_fbd3e4c28e569cea299f20f76971b2b8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fbd3e4c28e569cea299f20f76971b2b8)) return false;
return (this == (RC_fbd3e4c28e569cea299f20f76971b2b8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHttpResponseStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHttpResponseStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHttpResponseStruct.InternalRecursiveSave();
}


public RC_fbd3e4c28e569cea299f20f76971b2b8 Duplicate() {
RC_fbd3e4c28e569cea299f20f76971b2b8 t;
t.ssSTHttpResponseStruct = (ST_d1e5397f6cff662bcbd1cfc4d8f7eedaStructure)this.ssSTHttpResponseStruct.Duplicate();
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
if (head == "httpresponsestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HttpResponseStruct")) variable.Value = ssSTHttpResponseStruct; else variable.Optimized = true;
variable.SetFieldName("httpresponsestruct");
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
if (key == IdHttpResponseStruct) {
return ssSTHttpResponseStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHttpResponseStruct.Key.AsGuid) {
return ssSTHttpResponseStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHttpResponseStruct.FillFromOther((IRecord) other.AttributeGet(IdHttpResponseStruct));
}
} // RC_fbd3e4c28e569cea299f20f76971b2b8
/// <summary>
/// RecordList type <code>HttpResponseStructRecordList</code> that represents a record list of
///  <code>HttpResponseStruct</code>
/// </summary>
public partial class RL_c4c09defea7b1ff05fb012b085f14fc9 : GenericRecordList<RC_fbd3e4c28e569cea299f20f76971b2b8>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_fbd3e4c28e569cea299f20f76971b2b8 GetElementDefaultValue() {
return new RC_fbd3e4c28e569cea299f20f76971b2b8();
}

public T[] ToArray<T>(Func<RC_fbd3e4c28e569cea299f20f76971b2b8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c4c09defea7b1ff05fb012b085f14fc9 recordList, Func<RC_fbd3e4c28e569cea299f20f76971b2b8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c4c09defea7b1ff05fb012b085f14fc9(RC_fbd3e4c28e569cea299f20f76971b2b8[] array) {
  RL_c4c09defea7b1ff05fb012b085f14fc9 result = new RL_c4c09defea7b1ff05fb012b085f14fc9();
result.InnerFromArray(array);
    return result;
}

public static RL_c4c09defea7b1ff05fb012b085f14fc9 ToList<T>(T[] array, Func <T, RC_fbd3e4c28e569cea299f20f76971b2b8> converter) {
  RL_c4c09defea7b1ff05fb012b085f14fc9 result = new RL_c4c09defea7b1ff05fb012b085f14fc9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c4c09defea7b1ff05fb012b085f14fc9 FromRestList<T>(RestList<T> restList, Func <T, RC_fbd3e4c28e569cea299f20f76971b2b8> converter) {
  RL_c4c09defea7b1ff05fb012b085f14fc9 result = new RL_c4c09defea7b1ff05fb012b085f14fc9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c4c09defea7b1ff05fb012b085f14fc9() : base() {
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
protected override OSList<RC_fbd3e4c28e569cea299f20f76971b2b8> NewList() {
return new RL_c4c09defea7b1ff05fb012b085f14fc9();
}


} // RL_c4c09defea7b1ff05fb012b085f14fc9
}

