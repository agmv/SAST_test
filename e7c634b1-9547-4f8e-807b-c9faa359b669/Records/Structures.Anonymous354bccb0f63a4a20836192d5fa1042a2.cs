namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (sMxLNTr2IEqDYZLV+hBCog) <code>RCAIMessageRecord</code> that represents
///  <code>AIMessageRecord</code> <p>Description: </p>
/// </summary>
// Name: AIMessageRecord
public partial struct RCAIMessageRecord : ITypedRecord<RCAIMessageRecord> {
internal static readonly GlobalObjectKey IdAIMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uzAjBhiIKN9TgdKXrsOsmA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AIMessage")]
public STAIMessageStructure ssSTAIMessage;


public static implicit operator STAIMessageStructure( RCAIMessageRecord r) {
return r.ssSTAIMessage;
}

public static implicit operator RCAIMessageRecord (STAIMessageStructure r) {
RCAIMessageRecord res = new RCAIMessageRecord ();
res.ssSTAIMessage = r;
return res;
}

public BitArray OptimizedAttributes;

public RCAIMessageRecord() {
OptimizedAttributes = null;
ssSTAIMessage = new STAIMessageStructure();
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
    ssSTAIMessage.OptimizedAttributes = value[0];
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
ssSTAIMessage.Read( r, ref index);
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
public void ReadIM(RCAIMessageRecord r) {
this = r;
}


public static bool operator == (RCAIMessageRecord a, RCAIMessageRecord b) {
if (a.ssSTAIMessage != b.ssSTAIMessage) return false;
return true;
}

public static bool operator != (RCAIMessageRecord a, RCAIMessageRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCAIMessageRecord)) return false;
return (this == (RCAIMessageRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAIMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAIMessage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAIMessage.InternalRecursiveSave();
}


public RCAIMessageRecord Duplicate() {
RCAIMessageRecord t;
t.ssSTAIMessage = (STAIMessageStructure)this.ssSTAIMessage.Duplicate();
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
if (head == "aimessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AIMessage")) variable.Value = ssSTAIMessage; else variable.Optimized = true;
variable.SetFieldName("aimessage");
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
if (key == IdAIMessage) {
return ssSTAIMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAIMessage.Key.AsGuid) {
return ssSTAIMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAIMessage.FillFromOther((IRecord) other.AttributeGet(IdAIMessage));
}
} // RCAIMessageRecord
/// <summary>
/// RecordList type <code>AIMessageRecordList</code> that represents a record list of
///  <code>AIMessage</code>
/// </summary>
public partial class RLAIMessageRecordList : GenericRecordList<RCAIMessageRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RCAIMessageRecord GetElementDefaultValue() {
return new RCAIMessageRecord();
}

public T[] ToArray<T>(Func<RCAIMessageRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIMessageRecordList recordList, Func<RCAIMessageRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIMessageRecordList(RCAIMessageRecord[] array) {
  RLAIMessageRecordList result = new RLAIMessageRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLAIMessageRecordList ToList<T>(T[] array, Func <T, RCAIMessageRecord> converter) {
  RLAIMessageRecordList result = new RLAIMessageRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIMessageRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAIMessageRecord> converter) {
  RLAIMessageRecordList result = new RLAIMessageRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIMessageRecordList() : base() {
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
protected override OSList<RCAIMessageRecord> NewList() {
return new RLAIMessageRecordList();
}


} // RLAIMessageRecordList
}

