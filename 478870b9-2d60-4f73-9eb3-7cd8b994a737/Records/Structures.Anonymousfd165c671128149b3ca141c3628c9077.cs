namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (Z1wW_SgRmxQ8oUHDYoyQdw)
///  <code>RC_05f199cf8f734662fa6eaa91568947ff</code> that represents <code>EntityRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EntityRecord
public partial struct RC_05f199cf8f734662fa6eaa91568947ff : ITypedRecord<RC_05f199cf8f734662fa6eaa91568947ff> {
internal static readonly GlobalObjectKey IdEntity = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*z5nxBXOPYkb6bqqRVolH_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Entity")]
public ENEntityEntityRecord ssENEntity;


public static implicit operator ENEntityEntityRecord( RC_05f199cf8f734662fa6eaa91568947ff r) {
return r.ssENEntity;
}

public static implicit operator RC_05f199cf8f734662fa6eaa91568947ff (ENEntityEntityRecord r) {
RC_05f199cf8f734662fa6eaa91568947ff res = new RC_05f199cf8f734662fa6eaa91568947ff ();
res.ssENEntity = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEntity.ChangedAttributes = value;
}
get {
    return ssENEntity.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_05f199cf8f734662fa6eaa91568947ff() {
OptimizedAttributes = null;
ssENEntity = new ENEntityEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntity.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEntity.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEntity.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntity.Read( r, ref index);
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
public void ReadIM(RC_05f199cf8f734662fa6eaa91568947ff r) {
this = r;
}


public static bool operator == (RC_05f199cf8f734662fa6eaa91568947ff a, RC_05f199cf8f734662fa6eaa91568947ff b) {
if (a.ssENEntity != b.ssENEntity) return false;
return true;
}

public static bool operator != (RC_05f199cf8f734662fa6eaa91568947ff a, RC_05f199cf8f734662fa6eaa91568947ff b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_05f199cf8f734662fa6eaa91568947ff)) return false;
return (this == (RC_05f199cf8f734662fa6eaa91568947ff)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntity.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntity.InternalRecursiveSave();
}


public RC_05f199cf8f734662fa6eaa91568947ff Duplicate() {
RC_05f199cf8f734662fa6eaa91568947ff t;
t.ssENEntity = (ENEntityEntityRecord)this.ssENEntity.Duplicate();
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
if (head == "entity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Entity")) variable.Value = ssENEntity; else variable.Optimized = true;
variable.SetFieldName("entity");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEntity.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEntity.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEntity) {
return ssENEntity;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntity.Key.AsGuid) {
return ssENEntity;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntity.FillFromOther((IRecord) other.AttributeGet(IdEntity));
}
} // RC_05f199cf8f734662fa6eaa91568947ff
/// <summary>
/// RecordList type <code>EntityRecordList</code> that represents a record list of <code>Entity</code>
/// </summary>
public partial class RL_eba0e3b376adecb3137463bf4c64acb3 : GenericRecordList<RC_05f199cf8f734662fa6eaa91568947ff>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_05f199cf8f734662fa6eaa91568947ff GetElementDefaultValue() {
return new RC_05f199cf8f734662fa6eaa91568947ff();
}

public T[] ToArray<T>(Func<RC_05f199cf8f734662fa6eaa91568947ff, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eba0e3b376adecb3137463bf4c64acb3 recordList, Func<RC_05f199cf8f734662fa6eaa91568947ff, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eba0e3b376adecb3137463bf4c64acb3(RC_05f199cf8f734662fa6eaa91568947ff[] array) {
  RL_eba0e3b376adecb3137463bf4c64acb3 result = new RL_eba0e3b376adecb3137463bf4c64acb3();
result.InnerFromArray(array);
    return result;
}

public static RL_eba0e3b376adecb3137463bf4c64acb3 ToList<T>(T[] array, Func <T, RC_05f199cf8f734662fa6eaa91568947ff> converter) {
  RL_eba0e3b376adecb3137463bf4c64acb3 result = new RL_eba0e3b376adecb3137463bf4c64acb3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eba0e3b376adecb3137463bf4c64acb3 FromRestList<T>(RestList<T> restList, Func <T, RC_05f199cf8f734662fa6eaa91568947ff> converter) {
  RL_eba0e3b376adecb3137463bf4c64acb3 result = new RL_eba0e3b376adecb3137463bf4c64acb3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eba0e3b376adecb3137463bf4c64acb3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_05f199cf8f734662fa6eaa91568947ff> NewList() {
return new RL_eba0e3b376adecb3137463bf4c64acb3();
}


} // RL_eba0e3b376adecb3137463bf4c64acb3
}

