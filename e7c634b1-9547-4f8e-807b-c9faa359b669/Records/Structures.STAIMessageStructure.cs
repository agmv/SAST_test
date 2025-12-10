namespace ssRuntimeDestroyer {
/// <summary>
/// [SystemStructure] AIMessage (pPQ37OnpukWHX+pFjr12FQ) <code>STAIMessageStructure</code> that
///  represents <code>AIMessage</code> <p>Description: </p>
/// </summary>
// Name: AIMessage
public partial struct STAIMessageStructure : ITypedRecord<STAIMessageStructure> {
internal static readonly GlobalObjectKey IdContent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cbrgrst42U+7xJWk9mfi4Q");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kqBFxRUZRkiiXkI6AsSsNg");
internal static readonly GlobalObjectKey IdRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vzCqHuk7sE+k5H3rkBYtIw");
internal static readonly GlobalObjectKey IdActionName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*c4aUDaKdrE+KMFROJtZh5A");
internal static readonly GlobalObjectKey IdActionParameters = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rG9pCBwGaEW64LVaTxEXXg");
internal static readonly GlobalObjectKey IdActionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bRIaTY+N_U+sHlQaGMGSiw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Content")]
public RLAIItemList ssContent;

[System.Xml.Serialization.XmlElement("CreatedOn")]
public DateTime ssCreatedOn;

[System.Xml.Serialization.XmlElement("Role")]
public long ssRole;

[System.Xml.Serialization.XmlElement("ActionName")]
public string ssActionName;

[System.Xml.Serialization.XmlElement("ActionParameters")]
public string ssActionParameters;

[System.Xml.Serialization.XmlElement("ActionId")]
public string ssActionId;


public BitArray OptimizedAttributes;

public STAIMessageStructure() {
OptimizedAttributes = null;
ssContent = new RLAIItemList();
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssRole = 0L;
ssActionName = "";
ssActionParameters = "";
ssActionId = "";
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
ssCreatedOn = r.ReadDateTime(index++, "AIMessage.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRole = r.ReadEntityReferenceLongInteger(index++, "AIMessage.Role", 0L);
ssActionName = r.ReadText(index++, "AIMessage.ActionName", "");
ssActionParameters = r.ReadText(index++, "AIMessage.ActionParameters", "");
ssActionId = r.ReadText(index++, "AIMessage.ActionId", "");
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
public void ReadIM(STAIMessageStructure r) {
this = r;
}


public static bool operator == (STAIMessageStructure a, STAIMessageStructure b) {
if (a.ssContent != b.ssContent) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssRole != b.ssRole) return false;
if (a.ssActionName != b.ssActionName) return false;
if (a.ssActionParameters != b.ssActionParameters) return false;
if (a.ssActionId != b.ssActionId) return false;
return true;
}

public static bool operator != (STAIMessageStructure a, STAIMessageStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STAIMessageStructure)) return false;
return (this == (STAIMessageStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssContent.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssRole.GetHashCode()
 ^ ssActionName.GetHashCode()
 ^ ssActionParameters.GetHashCode()
 ^ ssActionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssContent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssContent.InternalRecursiveSave();
}


public STAIMessageStructure Duplicate() {
STAIMessageStructure t;
t.ssContent = (RLAIItemList)this.ssContent.Duplicate();
t.ssCreatedOn = this.ssCreatedOn;
t.ssRole = this.ssRole;
t.ssActionName = this.ssActionName;
t.ssActionParameters = this.ssActionParameters;
t.ssActionId = this.ssActionId;
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
if (head == "content") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Content")) variable.Value = ssContent; else variable.Optimized = true;
variable.SetFieldName("content");
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "role") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Role")) variable.Value = ssRole; else variable.Optimized = true;
} else if (head == "actionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActionName")) variable.Value = ssActionName; else variable.Optimized = true;
} else if (head == "actionparameters") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActionParameters")) variable.Value = ssActionParameters; else variable.Optimized = true;
} else if (head == "actionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActionId")) variable.Value = ssActionId; else variable.Optimized = true;
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
if (key == IdContent) {
return ssContent;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdRole) {
return ssRole;
}
if (key == IdActionName) {
return ssActionName;
}
if (key == IdActionParameters) {
return ssActionParameters;
}
if (key == IdActionId) {
return ssActionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContent.Key.AsGuid) {
return ssContent;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdRole.Key.AsGuid) {
return ssRole;
}
if (attributeKey == IdActionName.Key.AsGuid) {
return ssActionName;
}
if (attributeKey == IdActionParameters.Key.AsGuid) {
return ssActionParameters;
}
if (attributeKey == IdActionId.Key.AsGuid) {
return ssActionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssContent = new RLAIItemList();
ssContent.FillFromOther((IOSList) other.AttributeGet(IdContent));
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssRole = (long) other.AttributeGet(IdRole);
ssActionName = (string) other.AttributeGet(IdActionName);
ssActionParameters = (string) other.AttributeGet(IdActionParameters);
ssActionId = (string) other.AttributeGet(IdActionId);
}
} // STAIMessageStructure
/// <summary>
/// RecordList type <code>AIMessageList</code> that represents a record list of <code>AIMessage</code>
/// </summary>
public partial class RLAIMessageList : GenericRecordList<STAIMessageStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override STAIMessageStructure GetElementDefaultValue() {
return new STAIMessageStructure();
}

public T[] ToArray<T>(Func<STAIMessageStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIMessageList recordList, Func<STAIMessageStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIMessageList(STAIMessageStructure[] array) {
  RLAIMessageList result = new RLAIMessageList();
result.InnerFromArray(array);
    return result;
}

public static RLAIMessageList ToList<T>(T[] array, Func <T, STAIMessageStructure> converter) {
  RLAIMessageList result = new RLAIMessageList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIMessageList FromRestList<T>(RestList<T> restList, Func <T, STAIMessageStructure> converter) {
  RLAIMessageList result = new RLAIMessageList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIMessageList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STAIMessageStructure> NewList() {
return new RLAIMessageList();
}


} // RLAIMessageList
}

