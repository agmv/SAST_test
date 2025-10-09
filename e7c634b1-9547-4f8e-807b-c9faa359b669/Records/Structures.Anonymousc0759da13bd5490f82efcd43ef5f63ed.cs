namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (oZ11wNU7D0mC781D719j7Q) <code>RCAIModelUsageRecord</code> that
///  represents <code>AIModelUsageRecord</code> <p>Description: </p>
/// </summary>
// Name: AIModelUsageRecord
public partial struct RCAIModelUsageRecord : ITypedRecord<RCAIModelUsageRecord> {
internal static readonly GlobalObjectKey IdAIModelUsage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MsHP3P8aTSlbyW4Fr7p1xg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AIModelUsage")]
public STAIModelUsageStructure ssSTAIModelUsage;


public static implicit operator STAIModelUsageStructure( RCAIModelUsageRecord r) {
return r.ssSTAIModelUsage;
}

public static implicit operator RCAIModelUsageRecord (STAIModelUsageStructure r) {
RCAIModelUsageRecord res = new RCAIModelUsageRecord ();
res.ssSTAIModelUsage = r;
return res;
}

public BitArray OptimizedAttributes;

public RCAIModelUsageRecord() {
OptimizedAttributes = null;
ssSTAIModelUsage = new STAIModelUsageStructure();
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
    ssSTAIModelUsage.OptimizedAttributes = value[0];
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
ssSTAIModelUsage.Read( r, ref index);
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
public void ReadIM(RCAIModelUsageRecord r) {
this = r;
}


public static bool operator == (RCAIModelUsageRecord a, RCAIModelUsageRecord b) {
if (a.ssSTAIModelUsage != b.ssSTAIModelUsage) return false;
return true;
}

public static bool operator != (RCAIModelUsageRecord a, RCAIModelUsageRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RCAIModelUsageRecord)) return false;
return (this == (RCAIModelUsageRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAIModelUsage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAIModelUsage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAIModelUsage.InternalRecursiveSave();
}


public RCAIModelUsageRecord Duplicate() {
RCAIModelUsageRecord t;
t.ssSTAIModelUsage = (STAIModelUsageStructure)this.ssSTAIModelUsage.Duplicate();
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
if (head == "aimodelusage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AIModelUsage")) variable.Value = ssSTAIModelUsage; else variable.Optimized = true;
variable.SetFieldName("aimodelusage");
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
if (key == IdAIModelUsage) {
return ssSTAIModelUsage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAIModelUsage.Key.AsGuid) {
return ssSTAIModelUsage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAIModelUsage.FillFromOther((IRecord) other.AttributeGet(IdAIModelUsage));
}
} // RCAIModelUsageRecord
/// <summary>
/// RecordList type <code>AIModelUsageRecordList</code> that represents a record list of
///  <code>AIModelUsage</code>
/// </summary>
public partial class RLAIModelUsageRecordList : GenericRecordList<RCAIModelUsageRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RCAIModelUsageRecord GetElementDefaultValue() {
return new RCAIModelUsageRecord();
}

public T[] ToArray<T>(Func<RCAIModelUsageRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIModelUsageRecordList recordList, Func<RCAIModelUsageRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIModelUsageRecordList(RCAIModelUsageRecord[] array) {
  RLAIModelUsageRecordList result = new RLAIModelUsageRecordList();
result.InnerFromArray(array);
    return result;
}

public static RLAIModelUsageRecordList ToList<T>(T[] array, Func <T, RCAIModelUsageRecord> converter) {
  RLAIModelUsageRecordList result = new RLAIModelUsageRecordList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIModelUsageRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAIModelUsageRecord> converter) {
  RLAIModelUsageRecordList result = new RLAIModelUsageRecordList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIModelUsageRecordList() : base() {
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
protected override OSList<RCAIModelUsageRecord> NewList() {
return new RLAIModelUsageRecordList();
}


} // RLAIModelUsageRecordList
}

