namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (AlIoYVn+dECFsWKN0aYAxQ) <code>RCAttachmentRecord</code> that
///  represents <code>AttachmentRecord</code> <p>Description: </p>
/// </summary>
// Name: AttachmentRecord
public partial struct RCAttachmentRecord : ITypedRecord<RCAttachmentRecord> {
internal static readonly GlobalObjectKey IdAttachment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_8pKcYic0yM9vQPkOisHvA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Attachment")]
public STAttachmentStructure ssSTAttachment;


public static implicit operator STAttachmentStructure( RCAttachmentRecord r) {
return r.ssSTAttachment;
}

public static implicit operator RCAttachmentRecord (STAttachmentStructure r) {
RCAttachmentRecord res = new RCAttachmentRecord ();
res.ssSTAttachment = r;
return res;
}

public BitArray OptimizedAttributes;

public RCAttachmentRecord() {
OptimizedAttributes = null;
ssSTAttachment = new STAttachmentStructure();
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
    ssSTAttachment.OptimizedAttributes = value[0];
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
ssSTAttachment.Read( r, ref index);
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
public void ReadIM(RCAttachmentRecord r) {
this = r;
}


public static bool operator == (RCAttachmentRecord a, RCAttachmentRecord b) {
if (a.ssSTAttachment != b.ssSTAttachment) return false;
return true;
}

public static bool operator != (RCAttachmentRecord a, RCAttachmentRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCAttachmentRecord)) return false;
return (this == (RCAttachmentRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAttachment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAttachment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAttachment.InternalRecursiveSave();
}


public RCAttachmentRecord Duplicate() {
RCAttachmentRecord t;
t.ssSTAttachment = (STAttachmentStructure)this.ssSTAttachment.Duplicate();
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
if (head == "attachment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Attachment")) variable.Value = ssSTAttachment; else variable.Optimized = true;
variable.SetFieldName("attachment");
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
if (key == IdAttachment) {
return ssSTAttachment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAttachment.Key.AsGuid) {
return ssSTAttachment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAttachment.FillFromOther((IRecord) other.AttributeGet(IdAttachment));
}
} // RCAttachmentRecord
/// <summary>
/// RecordList type <code>AttachmentRecordList</code> that represents a record list of
///  <code>Attachment</code>
/// </summary>
public partial class RLAttachmentRecordList : GenericRecordList<RCAttachmentRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RCAttachmentRecord GetElementDefaultValue() {
return new RCAttachmentRecord();
}

public T[] ToArray<T>(Func<RCAttachmentRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAttachmentRecordList recordList, Func<RCAttachmentRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAttachmentRecordList(RCAttachmentRecord[] array) {
  RLAttachmentRecordList result = new RLAttachmentRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLAttachmentRecordList ToList<T>(T[] array, Func <T, RCAttachmentRecord> converter) {
  RLAttachmentRecordList result = new RLAttachmentRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAttachmentRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAttachmentRecord> converter) {
  RLAttachmentRecordList result = new RLAttachmentRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAttachmentRecordList() : base() {
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
protected override OSList<RCAttachmentRecord> NewList() {
return new RLAttachmentRecordList();
}


} // RLAttachmentRecordList
}

