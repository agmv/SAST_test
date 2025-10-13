namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (tz9rk50AqUisdPrej0N+gg)
///  <code>RC_a702e171772a9b89c17e2544ab6d1d29</code> that represents <code>ApplicationRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ApplicationRecord
public partial struct RC_a702e171772a9b89c17e2544ab6d1d29 : ITypedRecord<RC_a702e171772a9b89c17e2544ab6d1d29> {
internal static readonly GlobalObjectKey IdApplication = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ceECpyp3iZvBfiVEq20dKQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Application")]
public ENApplicationEntityRecord ssENApplication;


public static implicit operator ENApplicationEntityRecord( RC_a702e171772a9b89c17e2544ab6d1d29 r) {
return r.ssENApplication;
}

public static implicit operator RC_a702e171772a9b89c17e2544ab6d1d29 (ENApplicationEntityRecord r) {
RC_a702e171772a9b89c17e2544ab6d1d29 res = new RC_a702e171772a9b89c17e2544ab6d1d29 ();
res.ssENApplication = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApplication.ChangedAttributes = value;
}
get {
    return ssENApplication.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a702e171772a9b89c17e2544ab6d1d29() {
OptimizedAttributes = null;
ssENApplication = new ENApplicationEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApplication.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApplication.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApplication.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApplication.Read( r, ref index);
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
public void ReadIM(RC_a702e171772a9b89c17e2544ab6d1d29 r) {
this = r;
}


public static bool operator == (RC_a702e171772a9b89c17e2544ab6d1d29 a, RC_a702e171772a9b89c17e2544ab6d1d29 b) {
if (a.ssENApplication != b.ssENApplication) return false;
return true;
}

public static bool operator != (RC_a702e171772a9b89c17e2544ab6d1d29 a, RC_a702e171772a9b89c17e2544ab6d1d29 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a702e171772a9b89c17e2544ab6d1d29)) return false;
return (this == (RC_a702e171772a9b89c17e2544ab6d1d29)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApplication.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApplication.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApplication.InternalRecursiveSave();
}


public RC_a702e171772a9b89c17e2544ab6d1d29 Duplicate() {
RC_a702e171772a9b89c17e2544ab6d1d29 t;
t.ssENApplication = (ENApplicationEntityRecord)this.ssENApplication.Duplicate();
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
if (head == "application") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Application")) variable.Value = ssENApplication; else variable.Optimized = true;
variable.SetFieldName("application");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApplication.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApplication.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApplication) {
return ssENApplication;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplication.Key.AsGuid) {
return ssENApplication;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApplication.FillFromOther((IRecord) other.AttributeGet(IdApplication));
}
} // RC_a702e171772a9b89c17e2544ab6d1d29
/// <summary>
/// RecordList type <code>ApplicationRecordList</code> that represents a record list of
///  <code>Application</code>
/// </summary>
public partial class RL_77de0cb9f6a169c5c7917faf23aa1522 : GenericRecordList<RC_a702e171772a9b89c17e2544ab6d1d29>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a702e171772a9b89c17e2544ab6d1d29 GetElementDefaultValue() {
return new RC_a702e171772a9b89c17e2544ab6d1d29();
}

public T[] ToArray<T>(Func<RC_a702e171772a9b89c17e2544ab6d1d29, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_77de0cb9f6a169c5c7917faf23aa1522 recordList, Func<RC_a702e171772a9b89c17e2544ab6d1d29, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_77de0cb9f6a169c5c7917faf23aa1522(RC_a702e171772a9b89c17e2544ab6d1d29[] array) {
  RL_77de0cb9f6a169c5c7917faf23aa1522 result = new RL_77de0cb9f6a169c5c7917faf23aa1522();
result.InnerFromArray(array);
    return result;
}

public static RL_77de0cb9f6a169c5c7917faf23aa1522 ToList<T>(T[] array, Func <T, RC_a702e171772a9b89c17e2544ab6d1d29> converter) {
  RL_77de0cb9f6a169c5c7917faf23aa1522 result = new RL_77de0cb9f6a169c5c7917faf23aa1522();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_77de0cb9f6a169c5c7917faf23aa1522 FromRestList<T>(RestList<T> restList, Func <T, RC_a702e171772a9b89c17e2544ab6d1d29> converter) {
  RL_77de0cb9f6a169c5c7917faf23aa1522 result = new RL_77de0cb9f6a169c5c7917faf23aa1522();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_77de0cb9f6a169c5c7917faf23aa1522() : base() {
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
protected override OSList<RC_a702e171772a9b89c17e2544ab6d1d29> NewList() {
return new RL_77de0cb9f6a169c5c7917faf23aa1522();
}


} // RL_77de0cb9f6a169c5c7917faf23aa1522
}

