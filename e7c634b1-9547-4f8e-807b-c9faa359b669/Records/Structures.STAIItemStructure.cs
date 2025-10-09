namespace ssRuntimeDestroyer {
/// <summary>
/// [SystemStructure] AIItem (SIMrhJ_Y3UqsS_kTZEgM6w) <code>STAIItemStructure</code> that represents
///  <code>AIItem</code> <p>Description: </p>
/// </summary>
// Name: AIItem
public partial struct STAIItemStructure : ITypedRecord<STAIItemStructure> {
internal static readonly GlobalObjectKey IdContentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lSXEcAIdc0W6lIc4QRU3TA");
internal static readonly GlobalObjectKey IdContentText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rRMgMRXUzU2DH9pumKzamQ");
internal static readonly GlobalObjectKey IdContentUrl = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UgycqGa1HUyGq9mXL7HRyQ");
internal static readonly GlobalObjectKey IdContentBinaryData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qU+rcVwPCEC5Q1vZGWO4sA");
internal static readonly GlobalObjectKey IdFileFormat = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2vv4qzpRZUKbjGlt2LOw6A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ContentType")]
public long ssContentType;

[System.Xml.Serialization.XmlElement("ContentText")]
public string ssContentText;

[System.Xml.Serialization.XmlElement("ContentUrl")]
public string ssContentUrl;

[System.Xml.Serialization.XmlElement("ContentBinaryData")]
public byte[] ssContentBinaryData;

[System.Xml.Serialization.XmlElement("FileFormat")]
public string ssFileFormat;


public BitArray OptimizedAttributes;

public STAIItemStructure() {
OptimizedAttributes = null;
ssContentType = 0L;
ssContentText = "";
ssContentUrl = "";
ssContentBinaryData = new byte[] {};
ssFileFormat = "";
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
ssContentType = r.ReadEntityReferenceLongInteger(index++, "AIItem.ContentType", 0L);
ssContentText = r.ReadText(index++, "AIItem.ContentText", "");
ssContentUrl = r.ReadText(index++, "AIItem.ContentUrl", "");
ssContentBinaryData = r.ReadBinaryData(index++, "AIItem.ContentBinaryData", new byte[] {});
ssFileFormat = r.ReadText(index++, "AIItem.FileFormat", "");
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
public void ReadIM(STAIItemStructure r) {
this = r;
}


public static bool operator == (STAIItemStructure a, STAIItemStructure b) {
if (a.ssContentType != b.ssContentType) return false;
if (a.ssContentText != b.ssContentText) return false;
if (a.ssContentUrl != b.ssContentUrl) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssContentBinaryData, b.ssContentBinaryData)) return false;
if (a.ssFileFormat != b.ssFileFormat) return false;
return true;
}

public static bool operator != (STAIItemStructure a, STAIItemStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STAIItemStructure)) return false;
return (this == (STAIItemStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssContentType.GetHashCode()
 ^ ssContentText.GetHashCode()
 ^ ssContentUrl.GetHashCode()
 ^ ssContentBinaryData.GetHashCode()
 ^ ssFileFormat.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public STAIItemStructure Duplicate() {
STAIItemStructure t;
t.ssContentType = this.ssContentType;
t.ssContentText = this.ssContentText;
t.ssContentUrl = this.ssContentUrl;
t.ssContentBinaryData = this.ssContentBinaryData;
t.ssFileFormat = this.ssFileFormat;
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
if (head == "contenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentType")) variable.Value = ssContentType; else variable.Optimized = true;
} else if (head == "contenttext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentText")) variable.Value = ssContentText; else variable.Optimized = true;
} else if (head == "contenturl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentUrl")) variable.Value = ssContentUrl; else variable.Optimized = true;
} else if (head == "contentbinarydata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentBinaryData")) variable.Value = ssContentBinaryData; else variable.Optimized = true;
} else if (head == "fileformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileFormat")) variable.Value = ssFileFormat; else variable.Optimized = true;
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
if (key == IdContentType) {
return ssContentType;
}
if (key == IdContentText) {
return ssContentText;
}
if (key == IdContentUrl) {
return ssContentUrl;
}
if (key == IdContentBinaryData) {
return ssContentBinaryData;
}
if (key == IdFileFormat) {
return ssFileFormat;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContentType.Key.AsGuid) {
return ssContentType;
}
if (attributeKey == IdContentText.Key.AsGuid) {
return ssContentText;
}
if (attributeKey == IdContentUrl.Key.AsGuid) {
return ssContentUrl;
}
if (attributeKey == IdContentBinaryData.Key.AsGuid) {
return ssContentBinaryData;
}
if (attributeKey == IdFileFormat.Key.AsGuid) {
return ssFileFormat;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssContentType = (long) other.AttributeGet(IdContentType);
ssContentText = (string) other.AttributeGet(IdContentText);
ssContentUrl = (string) other.AttributeGet(IdContentUrl);
ssContentBinaryData = (byte[]) other.AttributeGet(IdContentBinaryData);
ssFileFormat = (string) other.AttributeGet(IdFileFormat);
}
} // STAIItemStructure
/// <summary>
/// RecordList type <code>AIItemList</code> that represents a record list of <code>AIItem</code>
/// </summary>
public partial class RLAIItemList : GenericRecordList<STAIItemStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override STAIItemStructure GetElementDefaultValue() {
return new STAIItemStructure();
}

public T[] ToArray<T>(Func<STAIItemStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLAIItemList recordList, Func<STAIItemStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLAIItemList(STAIItemStructure[] array) {
  RLAIItemList result = new RLAIItemList();
result.InnerFromArray(array);
    return result;
}

public static RLAIItemList ToList<T>(T[] array, Func <T, STAIItemStructure> converter) {
  RLAIItemList result = new RLAIItemList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLAIItemList FromRestList<T>(RestList<T> restList, Func <T, STAIItemStructure> converter) {
  RLAIItemList result = new RLAIItemList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLAIItemList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STAIItemStructure> NewList() {
return new RLAIItemList();
}


} // RLAIItemList
}

