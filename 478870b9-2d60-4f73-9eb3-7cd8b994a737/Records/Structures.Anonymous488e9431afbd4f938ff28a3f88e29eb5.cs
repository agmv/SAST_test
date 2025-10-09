namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (MZSOSL2vk0+P8oo_iOKetQ)
///  <code>RC_f9a589fe5b81c3bda7db0e574d5d11fb</code> that represents <code>UserLoginResultRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserLoginResultRecord
public partial struct RC_f9a589fe5b81c3bda7db0e574d5d11fb : ITypedRecord<RC_f9a589fe5b81c3bda7db0e574d5d11fb> {
internal static readonly GlobalObjectKey IdUserLoginResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_oml+YFbvcOn2w5XTV0R+w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UserLoginResult")]
public ST_784fb57b420e5c0c2e1f611378088fbaStructure ssSTUserLoginResult;


public static implicit operator ST_784fb57b420e5c0c2e1f611378088fbaStructure( RC_f9a589fe5b81c3bda7db0e574d5d11fb r) {
return r.ssSTUserLoginResult;
}

public static implicit operator RC_f9a589fe5b81c3bda7db0e574d5d11fb (ST_784fb57b420e5c0c2e1f611378088fbaStructure r) {
RC_f9a589fe5b81c3bda7db0e574d5d11fb res = new RC_f9a589fe5b81c3bda7db0e574d5d11fb ();
res.ssSTUserLoginResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f9a589fe5b81c3bda7db0e574d5d11fb() {
OptimizedAttributes = null;
ssSTUserLoginResult = new ST_784fb57b420e5c0c2e1f611378088fbaStructure();
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
    ssSTUserLoginResult.OptimizedAttributes = value[0];
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
ssSTUserLoginResult.Read( r, ref index);
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
public void ReadIM(RC_f9a589fe5b81c3bda7db0e574d5d11fb r) {
this = r;
}


public static bool operator == (RC_f9a589fe5b81c3bda7db0e574d5d11fb a, RC_f9a589fe5b81c3bda7db0e574d5d11fb b) {
if (a.ssSTUserLoginResult != b.ssSTUserLoginResult) return false;
return true;
}

public static bool operator != (RC_f9a589fe5b81c3bda7db0e574d5d11fb a, RC_f9a589fe5b81c3bda7db0e574d5d11fb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f9a589fe5b81c3bda7db0e574d5d11fb)) return false;
return (this == (RC_f9a589fe5b81c3bda7db0e574d5d11fb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserLoginResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserLoginResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserLoginResult.InternalRecursiveSave();
}


public RC_f9a589fe5b81c3bda7db0e574d5d11fb Duplicate() {
RC_f9a589fe5b81c3bda7db0e574d5d11fb t;
t.ssSTUserLoginResult = (ST_784fb57b420e5c0c2e1f611378088fbaStructure)this.ssSTUserLoginResult.Duplicate();
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
if (head == "userloginresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserLoginResult")) variable.Value = ssSTUserLoginResult; else variable.Optimized = true;
variable.SetFieldName("userloginresult");
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
if (key == IdUserLoginResult) {
return ssSTUserLoginResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserLoginResult.Key.AsGuid) {
return ssSTUserLoginResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserLoginResult.FillFromOther((IRecord) other.AttributeGet(IdUserLoginResult));
}
} // RC_f9a589fe5b81c3bda7db0e574d5d11fb
/// <summary>
/// RecordList type <code>UserLoginResultRecordList</code> that represents a record list of
///  <code>UserLoginResult</code>
/// </summary>
public partial class RL_137c1fde2390fc7845ae92a0265be990 : GenericRecordList<RC_f9a589fe5b81c3bda7db0e574d5d11fb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f9a589fe5b81c3bda7db0e574d5d11fb GetElementDefaultValue() {
return new RC_f9a589fe5b81c3bda7db0e574d5d11fb();
}

public T[] ToArray<T>(Func<RC_f9a589fe5b81c3bda7db0e574d5d11fb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_137c1fde2390fc7845ae92a0265be990 recordList, Func<RC_f9a589fe5b81c3bda7db0e574d5d11fb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_137c1fde2390fc7845ae92a0265be990(RC_f9a589fe5b81c3bda7db0e574d5d11fb[] array) {
  RL_137c1fde2390fc7845ae92a0265be990 result = new RL_137c1fde2390fc7845ae92a0265be990();
result.InnerFromArray(array);
    return result;
}

public static RL_137c1fde2390fc7845ae92a0265be990 ToList<T>(T[] array, Func <T, RC_f9a589fe5b81c3bda7db0e574d5d11fb> converter) {
  RL_137c1fde2390fc7845ae92a0265be990 result = new RL_137c1fde2390fc7845ae92a0265be990();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_137c1fde2390fc7845ae92a0265be990 FromRestList<T>(RestList<T> restList, Func <T, RC_f9a589fe5b81c3bda7db0e574d5d11fb> converter) {
  RL_137c1fde2390fc7845ae92a0265be990 result = new RL_137c1fde2390fc7845ae92a0265be990();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_137c1fde2390fc7845ae92a0265be990() : base() {
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
protected override OSList<RC_f9a589fe5b81c3bda7db0e574d5d11fb> NewList() {
return new RL_137c1fde2390fc7845ae92a0265be990();
}


} // RL_137c1fde2390fc7845ae92a0265be990
}

