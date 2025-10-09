using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ProcessDefinitionLanguage (tEWz2Q7ZgEWZCme8qOtupA)
///  <code>ENProcessDefinitionLanguageEntityRecord</code> that represent
/// s <code>ProcessDefinitionLanguage</code> <p>Description: Translations for the process label as
///  defined in Service Studio.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProcessDefinitionLanguage","tEWz2Q7ZgEWZCme8qOtupA","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ProcessDefinitionLanguage
public partial struct ENProcessDefinitionLanguageEntityRecord : ITypedRecord<ENProcessDefinitionLanguageEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*akxriLxV3kygeByNRMrl0g");
internal static readonly GlobalObjectKey IdProcessDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*QSaQcpNA+kigz_4K2nAQjw");
internal static readonly GlobalObjectKey IdLocale = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*l_d1baPwHUmmXXrVUwEU7A");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*u9NPHaPGWk2DZYiTIYXbaA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROCESSDEFINITIONID",0,false,false,true,true)]
[System.Xml.Serialization.XmlElement("ProcessDefinitionId")]
private int _ssProcessDefinitionId;
public int ssProcessDefinitionId{
  get{
      return _ssProcessDefinitionId;
  }
  set{
      if((_ssProcessDefinitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProcessDefinitionId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LOCALE",10,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Locale")]
private string _ssLocale;
public string ssLocale{
  get{
      return _ssLocale;
  }
  set{
      if((_ssLocale!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssLocale = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL",100,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Label")]
private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssLabel = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENProcessDefinitionLanguageEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssProcessDefinitionId = 0;
_ssLocale = "";
_ssLabel = "";
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
ssId = r.ReadLongInteger(index++, "ProcessDefinitionLanguage.Id", 0L);
ssProcessDefinitionId = r.ReadEntityReference(index++, "ProcessDefinitionLanguage.ProcessDefinitionId", 0);
ssLocale = r.ReadText(index++, "ProcessDefinitionLanguage.Locale", "");
ssLabel = r.ReadText(index++, "ProcessDefinitionLanguage.Label", "");
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(ENProcessDefinitionLanguageEntityRecord r) {
this = r;
}


public static bool operator == (ENProcessDefinitionLanguageEntityRecord a, ENProcessDefinitionLanguageEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessDefinitionId != b.ssProcessDefinitionId) return false;
if (a.ssLocale != b.ssLocale) return false;
if (a.ssLabel != b.ssLabel) return false;
return true;
}

public static bool operator != (ENProcessDefinitionLanguageEntityRecord a, ENProcessDefinitionLanguageEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENProcessDefinitionLanguageEntityRecord)) return false;
return (this == (ENProcessDefinitionLanguageEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessDefinitionId.GetHashCode()
 ^ ssLocale.GetHashCode()
 ^ ssLabel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENProcessDefinitionLanguageEntityRecord Duplicate() {
ENProcessDefinitionLanguageEntityRecord t;
t._ssId = this._ssId;
t._ssProcessDefinitionId = this._ssProcessDefinitionId;
t._ssLocale = this._ssLocale;
t._ssLabel = this._ssLabel;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "processdefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessDefinitionId")) variable.Value = ssProcessDefinitionId; else variable.Optimized = true;
} else if (head == "locale") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Locale")) variable.Value = ssLocale; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProcessDefinitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLocale)) {
return ChangedAttributes[2];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProcessDefinitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLocale)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProcessDefinitionId) {
return ssProcessDefinitionId;
}
if (key == IdLocale) {
return ssLocale;
}
if (key == IdLabel) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProcessDefinitionId.Key.AsGuid) {
return ssProcessDefinitionId;
}
if (attributeKey == IdLocale.Key.AsGuid) {
return ssLocale;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProcessDefinitionId = (int) other.AttributeGet(IdProcessDefinitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProcessDefinitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProcessDefinitionId);
ssLocale = (string) other.AttributeGet(IdLocale);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLocale);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLocale);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[3] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdLabel);
}
} // ENProcessDefinitionLanguageEntityRecord

/// <summary>
/// RecordList type <code>ProcessDefinitionLanguageList</code> that represents a record list of
///  <code>ProcessDefinitionLanguage</code>
/// </summary>
public partial class RLProcessDefinitionLanguageList : GenericRecordList<ENProcessDefinitionLanguageEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENProcessDefinitionLanguageEntityRecord GetElementDefaultValue() {
return new ENProcessDefinitionLanguageEntityRecord();
}

public T[] ToArray<T>(Func<ENProcessDefinitionLanguageEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLProcessDefinitionLanguageList recordList, Func<ENProcessDefinitionLanguageEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLProcessDefinitionLanguageList(ENProcessDefinitionLanguageEntityRecord[] array) {
  RLProcessDefinitionLanguageList result = new RLProcessDefinitionLanguageList();
result.InnerFromArray(array);
    return result;
}

public static RLProcessDefinitionLanguageList ToList<T>(T[] array, Func <T, ENProcessDefinitionLanguageEntityRecord> converter) {
  RLProcessDefinitionLanguageList result = new RLProcessDefinitionLanguageList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLProcessDefinitionLanguageList FromRestList<T>(RestList<T> restList, Func <T, ENProcessDefinitionLanguageEntityRecord> converter) {
  RLProcessDefinitionLanguageList result = new RLProcessDefinitionLanguageList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLProcessDefinitionLanguageList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENProcessDefinitionLanguageEntityRecord> NewList() {
return new RLProcessDefinitionLanguageList();
}


} // RLProcessDefinitionLanguageList
}
