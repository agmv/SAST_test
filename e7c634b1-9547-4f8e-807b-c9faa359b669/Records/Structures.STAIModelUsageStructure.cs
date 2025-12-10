namespace ssRuntimeDestroyer {
/// <summary>
/// [SystemStructure] AIModelUsage (2J2FAUkW4U2YFljXwfQcwA) <code>STAIModelUsageStructure</code> that
///  represents <code>AIModelUsage</code> <p>Description: </p>
/// </summary>
// Name: AIModelUsage
public partial struct STAIModelUsageStructure : ITypedRecord<STAIModelUsageStructure> {
internal static readonly GlobalObjectKey IdResponseTokens = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*REwviPkAAEOerq+iai8FHA");
internal static readonly GlobalObjectKey IdInputTokens = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*l9Cmon2dT0yFNQ+nzbrTIA");
internal static readonly GlobalObjectKey IdTotalTokens = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NfZoQWG02km5dpgeeVHv_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ResponseTokens")]
public long ssResponseTokens;

[System.Xml.Serialization.XmlElement("InputTokens")]
public long ssInputTokens;

[System.Xml.Serialization.XmlElement("TotalTokens")]
public long ssTotalTokens;


public BitArray OptimizedAttributes;

public STAIModelUsageStructure() {
OptimizedAttributes = null;
ssResponseTokens = 0L;
ssInputTokens = 0L;
ssTotalTokens = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssResponseTokens = r.ReadLongInteger(index++, "AIModelUsage.ResponseTokens", 0L);
ssInputTokens = r.ReadLongInteger(index++, "AIModelUsage.InputTokens", 0L);
ssTotalTokens = r.ReadLongInteger(index++, "AIModelUsage.TotalTokens", 0L);
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
public void ReadIM(STAIModelUsageStructure r) {
this = r;
}


public static bool operator == (STAIModelUsageStructure a, STAIModelUsageStructure b) {
if (a.ssResponseTokens != b.ssResponseTokens) return false;
if (a.ssInputTokens != b.ssInputTokens) return false;
if (a.ssTotalTokens != b.ssTotalTokens) return false;
return true;
}

public static bool operator != (STAIModelUsageStructure a, STAIModelUsageStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STAIModelUsageStructure)) return false;
return (this == (STAIModelUsageStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssResponseTokens.GetHashCode()
 ^ ssInputTokens.GetHashCode()
 ^ ssTotalTokens.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public STAIModelUsageStructure Duplicate() {
STAIModelUsageStructure t;
t.ssResponseTokens = this.ssResponseTokens;
t.ssInputTokens = this.ssInputTokens;
t.ssTotalTokens = this.ssTotalTokens;
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
if (head == "responsetokens") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ResponseTokens")) variable.Value = ssResponseTokens; else variable.Optimized = true;
} else if (head == "inputtokens") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InputTokens")) variable.Value = ssInputTokens; else variable.Optimized = true;
} else if (head == "totaltokens") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalTokens")) variable.Value = ssTotalTokens; else variable.Optimized = true;
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
if (key == IdResponseTokens) {
return ssResponseTokens;
}
if (key == IdInputTokens) {
return ssInputTokens;
}
if (key == IdTotalTokens) {
return ssTotalTokens;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdResponseTokens.Key.AsGuid) {
return ssResponseTokens;
}
if (attributeKey == IdInputTokens.Key.AsGuid) {
return ssInputTokens;
}
if (attributeKey == IdTotalTokens.Key.AsGuid) {
return ssTotalTokens;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssResponseTokens = (long) other.AttributeGet(IdResponseTokens);
ssInputTokens = (long) other.AttributeGet(IdInputTokens);
ssTotalTokens = (long) other.AttributeGet(IdTotalTokens);
}
} // STAIModelUsageStructure
/// <summary>
/// RecordList type <code>AIModelUsageList</code> that represents a record list of
///  <code>AIModelUsage</code>
/// </summary>
public partial class RLAIModelUsageList : GenericRecordList<STAIModelUsageStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override STAIModelUsageStructure GetElementDefaultValue() {
return new STAIModelUsageStructure();
}

public T[] ToArray<T>(Func<STAIModelUsageStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIModelUsageList recordList, Func<STAIModelUsageStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIModelUsageList(STAIModelUsageStructure[] array) {
  RLAIModelUsageList result = new RLAIModelUsageList();
result.InnerFromArray(array);
    return result;
}

public static RLAIModelUsageList ToList<T>(T[] array, Func <T, STAIModelUsageStructure> converter) {
  RLAIModelUsageList result = new RLAIModelUsageList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIModelUsageList FromRestList<T>(RestList<T> restList, Func <T, STAIModelUsageStructure> converter) {
  RLAIModelUsageList result = new RLAIModelUsageList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIModelUsageList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STAIModelUsageStructure> NewList() {
return new RLAIModelUsageList();
}


} // RLAIModelUsageList
}

