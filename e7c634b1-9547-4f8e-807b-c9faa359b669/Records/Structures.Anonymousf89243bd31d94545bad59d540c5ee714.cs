namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (vUOS+NkxRUW61Z1UDF7nFA) <code>RCAIItemRecord</code> that represents
///  <code>AIItemRecord</code> <p>Description: </p>
/// </summary>
// Name: AIItemRecord
public partial struct RCAIItemRecord : ITypedRecord<RCAIItemRecord> {
internal static readonly GlobalObjectKey IdAIItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QuZTyaxdT_SCovMRVovEpA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AIItem")]
public STAIItemStructure ssSTAIItem;


public static implicit operator STAIItemStructure( RCAIItemRecord r) {
return r.ssSTAIItem;
}

public static implicit operator RCAIItemRecord (STAIItemStructure r) {
RCAIItemRecord res = new RCAIItemRecord ();
res.ssSTAIItem = r;
return res;
}

public BitArray OptimizedAttributes;

public RCAIItemRecord() {
OptimizedAttributes = null;
ssSTAIItem = new STAIItemStructure();
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
    ssSTAIItem.OptimizedAttributes = value[0];
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
ssSTAIItem.Read( r, ref index);
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
public void ReadIM(RCAIItemRecord r) {
this = r;
}


public static bool operator == (RCAIItemRecord a, RCAIItemRecord b) {
if (a.ssSTAIItem != b.ssSTAIItem) return false;
return true;
}

public static bool operator != (RCAIItemRecord a, RCAIItemRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCAIItemRecord)) return false;
return (this == (RCAIItemRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAIItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAIItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAIItem.InternalRecursiveSave();
}


public RCAIItemRecord Duplicate() {
RCAIItemRecord t;
t.ssSTAIItem = (STAIItemStructure)this.ssSTAIItem.Duplicate();
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
if (head == "aiitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AIItem")) variable.Value = ssSTAIItem; else variable.Optimized = true;
variable.SetFieldName("aiitem");
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
if (key == IdAIItem) {
return ssSTAIItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAIItem.Key.AsGuid) {
return ssSTAIItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAIItem.FillFromOther((IRecord) other.AttributeGet(IdAIItem));
}
} // RCAIItemRecord
/// <summary>
/// RecordList type <code>AIItemRecordList</code> that represents a record list of <code>AIItem</code>
/// </summary>
public partial class RLAIItemRecordList : GenericRecordList<RCAIItemRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RCAIItemRecord GetElementDefaultValue() {
return new RCAIItemRecord();
}

public T[] ToArray<T>(Func<RCAIItemRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIItemRecordList recordList, Func<RCAIItemRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIItemRecordList(RCAIItemRecord[] array) {
  RLAIItemRecordList result = new RLAIItemRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLAIItemRecordList ToList<T>(T[] array, Func <T, RCAIItemRecord> converter) {
  RLAIItemRecordList result = new RLAIItemRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIItemRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAIItemRecord> converter) {
  RLAIItemRecordList result = new RLAIItemRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIItemRecordList() : base() {
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
protected override OSList<RCAIItemRecord> NewList() {
return new RLAIItemRecordList();
}


} // RLAIItemRecordList
}

