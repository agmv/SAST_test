namespace ssSystem_ {
/// <summary>
/// [Structure] UserInfo (dkiYtuyqmEeA0mx5d1O42w)
///  <code>ST_401f0448f59979847b24ebdd2db9e1ebStructure</code> that represents <code>UserInfo</code
/// > <p>Description: User information structure.</p>
/// </summary>
// Name: UserInfo
public partial struct ST_401f0448f59979847b24ebdd2db9e1ebStructure : ITypedRecord<ST_401f0448f59979847b24ebdd2db9e1ebStructure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*QZ9vSSkh2kuqu+vwiCaUow");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*F9usK0hLR0KCjjJhmJKPww");
internal static readonly GlobalObjectKey IdPhotoURL = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*HZvec0wFAE2Eo7_JQd+onQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Name")]
public string ssName;

[System.Xml.Serialization.XmlElement("Email")]
public string ssEmail;

[System.Xml.Serialization.XmlElement("PhotoURL")]
public string ssPhotoURL;


public BitArray OptimizedAttributes;

public ST_401f0448f59979847b24ebdd2db9e1ebStructure() {
OptimizedAttributes = null;
ssName = "";
ssEmail = "";
ssPhotoURL = "";
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
ssName = r.ReadText(index++, "UserInfo.Name", "");
ssEmail = r.ReadEmail(index++, "UserInfo.Email", "");
ssPhotoURL = r.ReadText(index++, "UserInfo.PhotoURL", "");
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
public void ReadIM(ST_401f0448f59979847b24ebdd2db9e1ebStructure r) {
this = r;
}


public static bool operator == (ST_401f0448f59979847b24ebdd2db9e1ebStructure a, ST_401f0448f59979847b24ebdd2db9e1ebStructure b) {
if (a.ssName != b.ssName) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssPhotoURL != b.ssPhotoURL) return false;
return true;
}

public static bool operator != (ST_401f0448f59979847b24ebdd2db9e1ebStructure a, ST_401f0448f59979847b24ebdd2db9e1ebStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_401f0448f59979847b24ebdd2db9e1ebStructure)) return false;
return (this == (ST_401f0448f59979847b24ebdd2db9e1ebStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssPhotoURL.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_401f0448f59979847b24ebdd2db9e1ebStructure Duplicate() {
ST_401f0448f59979847b24ebdd2db9e1ebStructure t;
t.ssName = this.ssName;
t.ssEmail = this.ssEmail;
t.ssPhotoURL = this.ssPhotoURL;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "photourl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PhotoURL")) variable.Value = ssPhotoURL; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdPhotoURL) {
return ssPhotoURL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdPhotoURL.Key.AsGuid) {
return ssPhotoURL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssEmail = (string) other.AttributeGet(IdEmail);
ssPhotoURL = (string) other.AttributeGet(IdPhotoURL);
}
} // ST_401f0448f59979847b24ebdd2db9e1ebStructure
/// <summary>
/// RecordList type <code>UserInfoList</code> that represents a record list of <code>UserInfo</code>
/// </summary>
public partial class RL_54fab648630d41e343fad35c1143481d : GenericRecordList<ST_401f0448f59979847b24ebdd2db9e1ebStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_401f0448f59979847b24ebdd2db9e1ebStructure GetElementDefaultValue() {
return new ST_401f0448f59979847b24ebdd2db9e1ebStructure();
}

public T[] ToArray<T>(Func<ST_401f0448f59979847b24ebdd2db9e1ebStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_54fab648630d41e343fad35c1143481d recordList, Func<ST_401f0448f59979847b24ebdd2db9e1ebStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_54fab648630d41e343fad35c1143481d(ST_401f0448f59979847b24ebdd2db9e1ebStructure[] array) {
  RL_54fab648630d41e343fad35c1143481d result = new RL_54fab648630d41e343fad35c1143481d();
result.InnerFromArray(array);
    return result;
}

public static RL_54fab648630d41e343fad35c1143481d ToList<T>(T[] array, Func <T, ST_401f0448f59979847b24ebdd2db9e1ebStructure> converter) {
  RL_54fab648630d41e343fad35c1143481d result = new RL_54fab648630d41e343fad35c1143481d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_54fab648630d41e343fad35c1143481d FromRestList<T>(RestList<T> restList, Func <T, ST_401f0448f59979847b24ebdd2db9e1ebStructure> converter) {
  RL_54fab648630d41e343fad35c1143481d result = new RL_54fab648630d41e343fad35c1143481d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_54fab648630d41e343fad35c1143481d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_401f0448f59979847b24ebdd2db9e1ebStructure> NewList() {
return new RL_54fab648630d41e343fad35c1143481d();
}


} // RL_54fab648630d41e343fad35c1143481d
}

