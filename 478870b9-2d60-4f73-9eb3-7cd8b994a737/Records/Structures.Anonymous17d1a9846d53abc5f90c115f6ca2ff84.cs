namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (hKnRF1Ntxav5DBFfbKL_hA)
///  <code>RC_eb90da5b34724818e84008409205001c</code> that represent
/// s <code>ActivityDefinitionLanguageRecord</code> <p>Description: </p>
/// </summary>
// Name: ActivityDefinitionLanguageRecord
public partial struct RC_eb90da5b34724818e84008409205001c : ITypedRecord<RC_eb90da5b34724818e84008409205001c> {
internal static readonly GlobalObjectKey IdActivityDefinitionLanguage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W9qQ63I0GEjoQAhAkgUAHA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityDefinitionLanguage")]
public ENActivityDefinitionLanguageEntityRecord ssENActivityDefinitionLanguage;


public static implicit operator ENActivityDefinitionLanguageEntityRecord( RC_eb90da5b34724818e84008409205001c r) {
return r.ssENActivityDefinitionLanguage;
}

public static implicit operator RC_eb90da5b34724818e84008409205001c (ENActivityDefinitionLanguageEntityRecord r) {
RC_eb90da5b34724818e84008409205001c res = new RC_eb90da5b34724818e84008409205001c ();
res.ssENActivityDefinitionLanguage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityDefinitionLanguage.ChangedAttributes = value;
}
get {
    return ssENActivityDefinitionLanguage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_eb90da5b34724818e84008409205001c() {
OptimizedAttributes = null;
ssENActivityDefinitionLanguage = new ENActivityDefinitionLanguageEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityDefinitionLanguage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityDefinitionLanguage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityDefinitionLanguage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityDefinitionLanguage.Read( r, ref index);
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
public void ReadIM(RC_eb90da5b34724818e84008409205001c r) {
this = r;
}


public static bool operator == (RC_eb90da5b34724818e84008409205001c a, RC_eb90da5b34724818e84008409205001c b) {
if (a.ssENActivityDefinitionLanguage != b.ssENActivityDefinitionLanguage) return false;
return true;
}

public static bool operator != (RC_eb90da5b34724818e84008409205001c a, RC_eb90da5b34724818e84008409205001c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eb90da5b34724818e84008409205001c)) return false;
return (this == (RC_eb90da5b34724818e84008409205001c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityDefinitionLanguage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityDefinitionLanguage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityDefinitionLanguage.InternalRecursiveSave();
}


public RC_eb90da5b34724818e84008409205001c Duplicate() {
RC_eb90da5b34724818e84008409205001c t;
t.ssENActivityDefinitionLanguage = (ENActivityDefinitionLanguageEntityRecord)this.ssENActivityDefinitionLanguage.Duplicate();
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
if (head == "activitydefinitionlanguage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionLanguage")) variable.Value = ssENActivityDefinitionLanguage; else variable.Optimized = true;
variable.SetFieldName("activitydefinitionlanguage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinitionLanguage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinitionLanguage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityDefinitionLanguage) {
return ssENActivityDefinitionLanguage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityDefinitionLanguage.Key.AsGuid) {
return ssENActivityDefinitionLanguage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityDefinitionLanguage.FillFromOther((IRecord) other.AttributeGet(IdActivityDefinitionLanguage));
}
} // RC_eb90da5b34724818e84008409205001c
/// <summary>
/// RecordList type <code>ActivityDefinitionLanguageRecordList</code> that represents a record list of
///  <code>ActivityDefinitionLanguage</code>
/// </summary>
public partial class RL_84cf1463cd1d81cde9e2c5c4a48cc763 : GenericRecordList<RC_eb90da5b34724818e84008409205001c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_eb90da5b34724818e84008409205001c GetElementDefaultValue() {
return new RC_eb90da5b34724818e84008409205001c();
}

public T[] ToArray<T>(Func<RC_eb90da5b34724818e84008409205001c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_84cf1463cd1d81cde9e2c5c4a48cc763 recordList, Func<RC_eb90da5b34724818e84008409205001c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_84cf1463cd1d81cde9e2c5c4a48cc763(RC_eb90da5b34724818e84008409205001c[] array) {
  RL_84cf1463cd1d81cde9e2c5c4a48cc763 result = new RL_84cf1463cd1d81cde9e2c5c4a48cc763();
result.InnerFromArray(array);
    return result;
}

public static RL_84cf1463cd1d81cde9e2c5c4a48cc763 ToList<T>(T[] array, Func <T, RC_eb90da5b34724818e84008409205001c> converter) {
  RL_84cf1463cd1d81cde9e2c5c4a48cc763 result = new RL_84cf1463cd1d81cde9e2c5c4a48cc763();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_84cf1463cd1d81cde9e2c5c4a48cc763 FromRestList<T>(RestList<T> restList, Func <T, RC_eb90da5b34724818e84008409205001c> converter) {
  RL_84cf1463cd1d81cde9e2c5c4a48cc763 result = new RL_84cf1463cd1d81cde9e2c5c4a48cc763();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_84cf1463cd1d81cde9e2c5c4a48cc763() : base() {
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
protected override OSList<RC_eb90da5b34724818e84008409205001c> NewList() {
return new RL_84cf1463cd1d81cde9e2c5c4a48cc763();
}


} // RL_84cf1463cd1d81cde9e2c5c4a48cc763
}

