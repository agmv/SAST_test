namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (5O1vJ+BAZ0GYFTVCL+nE_w)
///  <code>RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301</code> that represent
/// s <code>ExternalIdentityProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: ExternalIdentityProviderRecord
public partial struct RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 : ITypedRecord<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> {
internal static readonly GlobalObjectKey IdExternalIdentityProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+vIbKv2GP4wb07vz+_sjAQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ExternalIdentityProvider")]
public ST_7b0e31d9e5a94347cc99b90226c3a090Structure ssSTExternalIdentityProvider;


public static implicit operator ST_7b0e31d9e5a94347cc99b90226c3a090Structure( RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 r) {
return r.ssSTExternalIdentityProvider;
}

public static implicit operator RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 (ST_7b0e31d9e5a94347cc99b90226c3a090Structure r) {
RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 res = new RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 ();
res.ssSTExternalIdentityProvider = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301() {
OptimizedAttributes = null;
ssSTExternalIdentityProvider = new ST_7b0e31d9e5a94347cc99b90226c3a090Structure();
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
    ssSTExternalIdentityProvider.OptimizedAttributes = value[0];
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
ssSTExternalIdentityProvider.Read( r, ref index);
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
public void ReadIM(RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 r) {
this = r;
}


public static bool operator == (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 a, RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 b) {
if (a.ssSTExternalIdentityProvider != b.ssSTExternalIdentityProvider) return false;
return true;
}

public static bool operator != (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 a, RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301)) return false;
return (this == (RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExternalIdentityProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExternalIdentityProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExternalIdentityProvider.InternalRecursiveSave();
}


public RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 Duplicate() {
RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 t;
t.ssSTExternalIdentityProvider = (ST_7b0e31d9e5a94347cc99b90226c3a090Structure)this.ssSTExternalIdentityProvider.Duplicate();
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
if (head == "externalidentityprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExternalIdentityProvider")) variable.Value = ssSTExternalIdentityProvider; else variable.Optimized = true;
variable.SetFieldName("externalidentityprovider");
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
if (key == IdExternalIdentityProvider) {
return ssSTExternalIdentityProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExternalIdentityProvider.Key.AsGuid) {
return ssSTExternalIdentityProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExternalIdentityProvider.FillFromOther((IRecord) other.AttributeGet(IdExternalIdentityProvider));
}
} // RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301
/// <summary>
/// RecordList type <code>ExternalIdentityProviderRecordList</code> that represents a record list of
///  <code>ExternalIdentityProvider</code>
/// </summary>
public partial class RL_a205e0551414b7b66bdfc7ae856335b6 : GenericRecordList<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301 GetElementDefaultValue() {
return new RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301();
}

public T[] ToArray<T>(Func<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a205e0551414b7b66bdfc7ae856335b6 recordList, Func<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a205e0551414b7b66bdfc7ae856335b6(RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301[] array) {
  RL_a205e0551414b7b66bdfc7ae856335b6 result = new RL_a205e0551414b7b66bdfc7ae856335b6();
result.InnerFromArray(array);
    return result;
}

public static RL_a205e0551414b7b66bdfc7ae856335b6 ToList<T>(T[] array, Func <T, RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> converter) {
  RL_a205e0551414b7b66bdfc7ae856335b6 result = new RL_a205e0551414b7b66bdfc7ae856335b6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a205e0551414b7b66bdfc7ae856335b6 FromRestList<T>(RestList<T> restList, Func <T, RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> converter) {
  RL_a205e0551414b7b66bdfc7ae856335b6 result = new RL_a205e0551414b7b66bdfc7ae856335b6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a205e0551414b7b66bdfc7ae856335b6() : base() {
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
protected override OSList<RC_2a1bf2fa86fd8c3f1bd3bbf3fbfb2301> NewList() {
return new RL_a205e0551414b7b66bdfc7ae856335b6();
}


} // RL_a205e0551414b7b66bdfc7ae856335b6
}

