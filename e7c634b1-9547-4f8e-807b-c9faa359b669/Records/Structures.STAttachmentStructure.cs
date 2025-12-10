namespace ssRuntimeDestroyer {
/// <summary>
/// [SystemStructure] Attachment (YNQT3+w2UUOc8+VhYaAo5A) <code>STAttachmentStructure</code> that
///  represents <code>Attachment</code> <p>Description: </p>
/// </summary>
// Name: Attachment
public partial struct STAttachmentStructure : ITypedRecord<STAttachmentStructure> {
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ErXO1bgWaEKNvko4q_Tc9w");
internal static readonly GlobalObjectKey IdFileContent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VhJ+mq7w5kS7dagyIRKoMQ");
internal static readonly GlobalObjectKey IdMimeType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1fFHA2T+fEGDG0MwJ1nIxA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FileName")]
public string ssFileName;

[System.Xml.Serialization.XmlElement("FileContent")]
public byte[] ssFileContent;

[System.Xml.Serialization.XmlElement("MimeType")]
public string ssMimeType;


public BitArray OptimizedAttributes;

public STAttachmentStructure() {
OptimizedAttributes = null;
ssFileName = "";
ssFileContent = new byte[] {};
ssMimeType = "";
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
ssFileName = r.ReadText(index++, "Attachment.FileName", "");
ssFileContent = r.ReadBinaryData(index++, "Attachment.FileContent", new byte[] {});
ssMimeType = r.ReadText(index++, "Attachment.MimeType", "");
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
public void ReadIM(STAttachmentStructure r) {
this = r;
}


public static bool operator == (STAttachmentStructure a, STAttachmentStructure b) {
if (a.ssFileName != b.ssFileName) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssFileContent, b.ssFileContent)) return false;
if (a.ssMimeType != b.ssMimeType) return false;
return true;
}

public static bool operator != (STAttachmentStructure a, STAttachmentStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STAttachmentStructure)) return false;
return (this == (STAttachmentStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssFileContent.GetHashCode()
 ^ ssMimeType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public STAttachmentStructure Duplicate() {
STAttachmentStructure t;
t.ssFileName = this.ssFileName;
t.ssFileContent = this.ssFileContent;
t.ssMimeType = this.ssMimeType;
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
if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
} else if (head == "filecontent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileContent")) variable.Value = ssFileContent; else variable.Optimized = true;
} else if (head == "mimetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MimeType")) variable.Value = ssMimeType; else variable.Optimized = true;
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
if (key == IdFileName) {
return ssFileName;
}
if (key == IdFileContent) {
return ssFileContent;
}
if (key == IdMimeType) {
return ssMimeType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdFileContent.Key.AsGuid) {
return ssFileContent;
}
if (attributeKey == IdMimeType.Key.AsGuid) {
return ssMimeType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFileName = (string) other.AttributeGet(IdFileName);
ssFileContent = (byte[]) other.AttributeGet(IdFileContent);
ssMimeType = (string) other.AttributeGet(IdMimeType);
}
} // STAttachmentStructure
/// <summary>
/// RecordList type <code>AttachmentList</code> that represents a record list of
///  <code>Attachment</code>
/// </summary>
public partial class RLAttachmentList : GenericRecordList<STAttachmentStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override STAttachmentStructure GetElementDefaultValue() {
return new STAttachmentStructure();
}

public T[] ToArray<T>(Func<STAttachmentStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAttachmentList recordList, Func<STAttachmentStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAttachmentList(STAttachmentStructure[] array) {
  RLAttachmentList result = new RLAttachmentList();
result.InnerFromArray(array);
    return result;
}

public static RLAttachmentList ToList<T>(T[] array, Func <T, STAttachmentStructure> converter) {
  RLAttachmentList result = new RLAttachmentList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAttachmentList FromRestList<T>(RestList<T> restList, Func <T, STAttachmentStructure> converter) {
  RLAttachmentList result = new RLAttachmentList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAttachmentList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STAttachmentStructure> NewList() {
return new RLAttachmentList();
}


} // RLAttachmentList
}

