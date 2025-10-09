using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] ActivityDefinitionLanguage (GrSy1rRl60eDWvnI6WFT8w)
///  <code>ENActivityDefinitionLanguageEntityRecord</code> that represent
/// s <code>ActivityDefinitionLanguage</code> <p>Description: Process activity translations for the
///  label and instructions.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ActivityDefinitionLanguage","GrSy1rRl60eDWvnI6WFT8w","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: ActivityDefinitionLanguage
public partial struct ENActivityDefinitionLanguageEntityRecord : ITypedRecord<ENActivityDefinitionLanguageEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*3PiZgDKxIUaC9xqOIz1uCQ");
internal static readonly GlobalObjectKey IdActivityDefinitionId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*ZNTgJ8LBfUaI5CR1ioCrOQ");
internal static readonly GlobalObjectKey IdLocale = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*s2sIg8HzDkq5OOQxBUKCZw");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*IjZ274wtIUC7qn8CHZMpmA");
internal static readonly GlobalObjectKey IdInboxInstructions = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*sid3tuz3nkaBRZJaifvfYw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",0,true,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ACTIVITYDEFINITIONID",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("ActivityDefinitionId")]
private int _ssActivityDefinitionId;
public int ssActivityDefinitionId{
  get{
      return _ssActivityDefinitionId;
  }
  set{
      if((_ssActivityDefinitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssActivityDefinitionId = value;
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("INBOXINSTRUCTIONS",1500,false,false,false,false)]
[System.Xml.Serialization.XmlElement("InboxInstructions")]
private string _ssInboxInstructions;
public string ssInboxInstructions{
  get{
      return _ssInboxInstructions;
  }
  set{
      if((_ssInboxInstructions!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssInboxInstructions = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENActivityDefinitionLanguageEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssActivityDefinitionId = 0;
_ssLocale = "";
_ssLabel = "";
_ssInboxInstructions = "";
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
ssId = r.ReadLongInteger(index++, "ActivityDefinitionLanguage.Id", 0L);
ssActivityDefinitionId = r.ReadEntityReference(index++, "ActivityDefinitionLanguage.ActivityDefinitionId", 0);
ssLocale = r.ReadText(index++, "ActivityDefinitionLanguage.Locale", "");
ssLabel = r.ReadText(index++, "ActivityDefinitionLanguage.Label", "");
ssInboxInstructions = r.ReadText(index++, "ActivityDefinitionLanguage.InboxInstructions", "");
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(ENActivityDefinitionLanguageEntityRecord r) {
this = r;
}


public static bool operator == (ENActivityDefinitionLanguageEntityRecord a, ENActivityDefinitionLanguageEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssActivityDefinitionId != b.ssActivityDefinitionId) return false;
if (a.ssLocale != b.ssLocale) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssInboxInstructions != b.ssInboxInstructions) return false;
return true;
}

public static bool operator != (ENActivityDefinitionLanguageEntityRecord a, ENActivityDefinitionLanguageEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENActivityDefinitionLanguageEntityRecord)) return false;
return (this == (ENActivityDefinitionLanguageEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssActivityDefinitionId.GetHashCode()
 ^ ssLocale.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssInboxInstructions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENActivityDefinitionLanguageEntityRecord Duplicate() {
ENActivityDefinitionLanguageEntityRecord t;
t._ssId = this._ssId;
t._ssActivityDefinitionId = this._ssActivityDefinitionId;
t._ssLocale = this._ssLocale;
t._ssLabel = this._ssLabel;
t._ssInboxInstructions = this._ssInboxInstructions;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "activitydefinitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionId")) variable.Value = ssActivityDefinitionId; else variable.Optimized = true;
} else if (head == "locale") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Locale")) variable.Value = ssLocale; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "inboxinstructions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InboxInstructions")) variable.Value = ssInboxInstructions; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdActivityDefinitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLocale)) {
return ChangedAttributes[2];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[3];
}
if (key.Equals(IdInboxInstructions)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdActivityDefinitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLocale)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdInboxInstructions)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdActivityDefinitionId) {
return ssActivityDefinitionId;
}
if (key == IdLocale) {
return ssLocale;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdInboxInstructions) {
return ssInboxInstructions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdActivityDefinitionId.Key.AsGuid) {
return ssActivityDefinitionId;
}
if (attributeKey == IdLocale.Key.AsGuid) {
return ssLocale;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdInboxInstructions.Key.AsGuid) {
return ssInboxInstructions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssActivityDefinitionId = (int) other.AttributeGet(IdActivityDefinitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdActivityDefinitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdActivityDefinitionId);
ssLocale = (string) other.AttributeGet(IdLocale);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLocale);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLocale);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[3] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdLabel);
ssInboxInstructions = (string) other.AttributeGet(IdInboxInstructions);
ChangedAttributes[4] = other.ChangedAttributeGet(IdInboxInstructions);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdInboxInstructions);
}
} // ENActivityDefinitionLanguageEntityRecord

/// <summary>
/// RecordList type <code>ActivityDefinitionLanguageList</code> that represents a record list of
///  <code>ActivityDefinitionLanguage</code>
/// </summary>
public partial class RLActivityDefinitionLanguageList : GenericRecordList<ENActivityDefinitionLanguageEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENActivityDefinitionLanguageEntityRecord GetElementDefaultValue() {
return new ENActivityDefinitionLanguageEntityRecord();
}

public T[] ToArray<T>(Func<ENActivityDefinitionLanguageEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLActivityDefinitionLanguageList recordList, Func<ENActivityDefinitionLanguageEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLActivityDefinitionLanguageList(ENActivityDefinitionLanguageEntityRecord[] array) {
  RLActivityDefinitionLanguageList result = new RLActivityDefinitionLanguageList();
result.InnerFromArray(array);
    return result;
}

public static RLActivityDefinitionLanguageList ToList<T>(T[] array, Func <T, ENActivityDefinitionLanguageEntityRecord> converter) {
  RLActivityDefinitionLanguageList result = new RLActivityDefinitionLanguageList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLActivityDefinitionLanguageList FromRestList<T>(RestList<T> restList, Func <T, ENActivityDefinitionLanguageEntityRecord> converter) {
  RLActivityDefinitionLanguageList result = new RLActivityDefinitionLanguageList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLActivityDefinitionLanguageList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENActivityDefinitionLanguageEntityRecord> NewList() {
return new RLActivityDefinitionLanguageList();
}


} // RLActivityDefinitionLanguageList
}
