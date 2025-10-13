using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] Entity (Iij1+NVHMrIHd3nUfG9f+w) <code>ENEntityEntityRecord</code> that represents
///  <code>Entity</code> <p>Description: Entities defined in Service Studio. Only active entities ar
/// e retained.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Entity","Iij1+NVHMrIHd3nUfG9f+w","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: Entity
public partial struct ENEntityEntityRecord : ITypedRecord<ENEntityEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*QkldIElpBaqfb6pRN3EuRg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*Ye86EJPxArZbYhekaWc2Yg");
internal static readonly GlobalObjectKey IdApplicationId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*zJlsIEbrwvyxoQYBqvtAaA");
internal static readonly GlobalObjectKey IdIsStatic = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*u+k7r5BxRJFUTQ25qeI1SQ");
internal static readonly GlobalObjectKey IdPrimaryKeyAttribute = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*dYdhSPq1aKtq3VQKeVj1Zg");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",100,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private string _ssId;
public string ssId{
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",50,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Name")]
private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("APPLICATIONID",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("ApplicationId")]
private string _ssApplicationId;
public string ssApplicationId{
  get{
      return _ssApplicationId;
  }
  set{
      if((_ssApplicationId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssApplicationId = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ISSTATIC",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("IsStatic")]
private bool _ssIsStatic;
public bool ssIsStatic{
  get{
      return _ssIsStatic;
  }
  set{
      if((_ssIsStatic!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsStatic = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PRIMARYKEYATTRIBUTE",0,false,false,true,false)]
[System.Xml.Serialization.XmlElement("PrimaryKeyAttribute")]
private string _ssPrimaryKeyAttribute;
public string ssPrimaryKeyAttribute{
  get{
      return _ssPrimaryKeyAttribute;
  }
  set{
      if((_ssPrimaryKeyAttribute!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssPrimaryKeyAttribute = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENEntityEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = "";
_ssName = "";
_ssApplicationId = "";
_ssIsStatic = false;
_ssPrimaryKeyAttribute = "";
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
ssId = r.ReadText(index++, "Entity.Id", "");
ssName = r.ReadText(index++, "Entity.Name", "");
ssApplicationId = r.ReadEntityReferenceText(index++, "Entity.ApplicationId", "");
ssIsStatic = r.ReadBoolean(index++, "Entity.IsStatic", false);
ssPrimaryKeyAttribute = r.ReadEntityReferenceText(index++, "Entity.PrimaryKeyAttribute", "");
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
public void ReadIM(ENEntityEntityRecord r) {
this = r;
}


public static bool operator == (ENEntityEntityRecord a, ENEntityEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssApplicationId != b.ssApplicationId) return false;
if (a.ssIsStatic != b.ssIsStatic) return false;
if (a.ssPrimaryKeyAttribute != b.ssPrimaryKeyAttribute) return false;
return true;
}

public static bool operator != (ENEntityEntityRecord a, ENEntityEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENEntityEntityRecord)) return false;
return (this == (ENEntityEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssApplicationId.GetHashCode()
 ^ ssIsStatic.GetHashCode()
 ^ ssPrimaryKeyAttribute.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENEntityEntityRecord Duplicate() {
ENEntityEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssApplicationId = this._ssApplicationId;
t._ssIsStatic = this._ssIsStatic;
t._ssPrimaryKeyAttribute = this._ssPrimaryKeyAttribute;
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "applicationid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationId")) variable.Value = ssApplicationId; else variable.Optimized = true;
} else if (head == "isstatic") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsStatic")) variable.Value = ssIsStatic; else variable.Optimized = true;
} else if (head == "primarykeyattribute") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PrimaryKeyAttribute")) variable.Value = ssPrimaryKeyAttribute; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdApplicationId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsStatic)) {
return ChangedAttributes[3];
}
if (key.Equals(IdPrimaryKeyAttribute)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdApplicationId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsStatic)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdPrimaryKeyAttribute)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdApplicationId) {
return ssApplicationId;
}
if (key == IdIsStatic) {
return ssIsStatic;
}
if (key == IdPrimaryKeyAttribute) {
return ssPrimaryKeyAttribute;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdApplicationId.Key.AsGuid) {
return ssApplicationId;
}
if (attributeKey == IdIsStatic.Key.AsGuid) {
return ssIsStatic;
}
if (attributeKey == IdPrimaryKeyAttribute.Key.AsGuid) {
return ssPrimaryKeyAttribute;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssApplicationId = (string) other.AttributeGet(IdApplicationId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdApplicationId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdApplicationId);
ssIsStatic = (bool) other.AttributeGet(IdIsStatic);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsStatic);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsStatic);
ssPrimaryKeyAttribute = (string) other.AttributeGet(IdPrimaryKeyAttribute);
ChangedAttributes[4] = other.ChangedAttributeGet(IdPrimaryKeyAttribute);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdPrimaryKeyAttribute);
}
} // ENEntityEntityRecord

/// <summary>
/// RecordList type <code>EntityList</code> that represents a record list of <code>Entity</code>
/// </summary>
public partial class RLEntityList : GenericRecordList<ENEntityEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENEntityEntityRecord GetElementDefaultValue() {
return new ENEntityEntityRecord();
}

public T[] ToArray<T>(Func<ENEntityEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLEntityList recordList, Func<ENEntityEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLEntityList(ENEntityEntityRecord[] array) {
  RLEntityList result = new RLEntityList();
result.InnerFromArray(array);
    return result;
}

public static RLEntityList ToList<T>(T[] array, Func <T, ENEntityEntityRecord> converter) {
  RLEntityList result = new RLEntityList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLEntityList FromRestList<T>(RestList<T> restList, Func <T, ENEntityEntityRecord> converter) {
  RLEntityList result = new RLEntityList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLEntityList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENEntityEntityRecord> NewList() {
return new RLEntityList();
}


} // RLEntityList
}
