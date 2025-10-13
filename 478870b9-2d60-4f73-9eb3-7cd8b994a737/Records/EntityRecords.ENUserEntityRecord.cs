using System.Diagnostics;
namespace ssSystem_ {

/// <summary>
/// [Entity] User (LYIWpF+Ey0aicHD144NUTA) <code>ENUserEntityRecord</code> that represents
///  <code>User</code> <p>Description: The end users of the app.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("User","LYIWpF+Ey0aicHD144NUTA","uXCIR2Atc0+es3zYuZSnNw", 0,"", null, false)]
// Name: User
public partial struct ENUserEntityRecord : ITypedRecord<ENUserEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*B7uELqKKTUyJG5vlRU_lQw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*cuXgKmbx5EaYJXAHSTXToQ");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*kGAqP0RQmkSYTElnszcN7Q");
internal static readonly GlobalObjectKey IdPhotoUrl = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*gl2n6jCTYkqDRUF2UHgKEw");
internal static readonly GlobalObjectKey IdUsername = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*zKtqQf8eIUa4xRU4BsI2dQ");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",36,false,true,false,true)]
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",256,false,false,false,false)]
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EMAIL",256,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Email")]
private string _ssEmail;
public string ssEmail{
  get{
      return _ssEmail;
  }
  set{
      if((_ssEmail!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssEmail = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PHOTOURL",2048,false,false,false,false)]
[System.Xml.Serialization.XmlElement("PhotoUrl")]
private string _ssPhotoUrl;
public string ssPhotoUrl{
  get{
      return _ssPhotoUrl;
  }
  set{
      if((_ssPhotoUrl!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssPhotoUrl = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("USERNAME",256,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Username")]
private string _ssUsername;
public string ssUsername{
  get{
      return _ssUsername;
  }
  set{
      if((_ssUsername!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssUsername = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public ENUserEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = "";
_ssName = "";
_ssEmail = "";
_ssPhotoUrl = "";
_ssUsername = "";
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
ssId = r.ReadText(index++, "User.Id", "");
ssName = r.ReadText(index++, "User.Name", "");
ssEmail = r.ReadEmail(index++, "User.Email", "");
ssPhotoUrl = r.ReadText(index++, "User.PhotoUrl", "");
ssUsername = r.ReadText(index++, "User.Username", "");
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
public void ReadIM(ENUserEntityRecord r) {
this = r;
}


public static bool operator == (ENUserEntityRecord a, ENUserEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssPhotoUrl != b.ssPhotoUrl) return false;
if (a.ssUsername != b.ssUsername) return false;
return true;
}

public static bool operator != (ENUserEntityRecord a, ENUserEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ENUserEntityRecord)) return false;
return (this == (ENUserEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssPhotoUrl.GetHashCode()
 ^ ssUsername.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ENUserEntityRecord Duplicate() {
ENUserEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssEmail = this._ssEmail;
t._ssPhotoUrl = this._ssPhotoUrl;
t._ssUsername = this._ssUsername;
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
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "photourl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PhotoUrl")) variable.Value = ssPhotoUrl; else variable.Optimized = true;
} else if (head == "username") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Username")) variable.Value = ssUsername; else variable.Optimized = true;
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
if (key.Equals(IdEmail)) {
return ChangedAttributes[2];
}
if (key.Equals(IdPhotoUrl)) {
return ChangedAttributes[3];
}
if (key.Equals(IdUsername)) {
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
if (key.Equals(IdEmail)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdPhotoUrl)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdUsername)) {
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
if (key == IdEmail) {
return ssEmail;
}
if (key == IdPhotoUrl) {
return ssPhotoUrl;
}
if (key == IdUsername) {
return ssUsername;
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
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdPhotoUrl.Key.AsGuid) {
return ssPhotoUrl;
}
if (attributeKey == IdUsername.Key.AsGuid) {
return ssUsername;
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
ssEmail = (string) other.AttributeGet(IdEmail);
ChangedAttributes[2] = other.ChangedAttributeGet(IdEmail);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdEmail);
ssPhotoUrl = (string) other.AttributeGet(IdPhotoUrl);
ChangedAttributes[3] = other.ChangedAttributeGet(IdPhotoUrl);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdPhotoUrl);
ssUsername = (string) other.AttributeGet(IdUsername);
ChangedAttributes[4] = other.ChangedAttributeGet(IdUsername);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUsername);
}
} // ENUserEntityRecord

/// <summary>
/// RecordList type <code>UserList</code> that represents a record list of <code>User</code>
/// </summary>
public partial class RLUserList : GenericRecordList<ENUserEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ENUserEntityRecord GetElementDefaultValue() {
return new ENUserEntityRecord();
}

public T[] ToArray<T>(Func<ENUserEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLUserList recordList, Func<ENUserEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLUserList(ENUserEntityRecord[] array) {
  RLUserList result = new RLUserList();
result.InnerFromArray(array);
    return result;
}

public static RLUserList ToList<T>(T[] array, Func <T, ENUserEntityRecord> converter) {
  RLUserList result = new RLUserList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLUserList FromRestList<T>(RestList<T> restList, Func <T, ENUserEntityRecord> converter) {
  RLUserList result = new RLUserList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLUserList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ENUserEntityRecord> NewList() {
return new RLUserList();
}


} // RLUserList
}
