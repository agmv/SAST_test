namespace ssSystem_ {
/// <summary>
/// [Structure] UserUpdateInfo (GSBnZt_TYEqQakau7kfA6w)
///  <code>ST_da83da85e5348cd2800e701fda6288aaStructure</code> that represent
/// s <code>UserUpdateInfo</code> <p>Description: New user information used to update the user.</p>
/// </summary>
// Name: UserUpdateInfo
public partial struct ST_da83da85e5348cd2800e701fda6288aaStructure : ITypedRecord<ST_da83da85e5348cd2800e701fda6288aaStructure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*o_5ZIBwIW06m9nMwrbF+gw");
internal static readonly GlobalObjectKey IdPhotoURL = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*8C32t8NWokaGFl_oHNIwKQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Name")]
public string ssName;

[System.Xml.Serialization.XmlElement("PhotoURL")]
public string ssPhotoURL;


public BitArray OptimizedAttributes;

public ST_da83da85e5348cd2800e701fda6288aaStructure() {
OptimizedAttributes = null;
ssName = "";
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
ssName = r.ReadText(index++, "UserUpdateInfo.Name", "");
ssPhotoURL = r.ReadText(index++, "UserUpdateInfo.PhotoURL", "");
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
public void ReadIM(ST_da83da85e5348cd2800e701fda6288aaStructure r) {
this = r;
}


public static bool operator == (ST_da83da85e5348cd2800e701fda6288aaStructure a, ST_da83da85e5348cd2800e701fda6288aaStructure b) {
if (a.ssName != b.ssName) return false;
if (a.ssPhotoURL != b.ssPhotoURL) return false;
return true;
}

public static bool operator != (ST_da83da85e5348cd2800e701fda6288aaStructure a, ST_da83da85e5348cd2800e701fda6288aaStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_da83da85e5348cd2800e701fda6288aaStructure)) return false;
return (this == (ST_da83da85e5348cd2800e701fda6288aaStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
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


public ST_da83da85e5348cd2800e701fda6288aaStructure Duplicate() {
ST_da83da85e5348cd2800e701fda6288aaStructure t;
t.ssName = this.ssName;
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
if (key == IdPhotoURL) {
return ssPhotoURL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdPhotoURL.Key.AsGuid) {
return ssPhotoURL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssPhotoURL = (string) other.AttributeGet(IdPhotoURL);
}
} // ST_da83da85e5348cd2800e701fda6288aaStructure
/// <summary>
/// RecordList type <code>UserUpdateInfoList</code> that represents a record list of
///  <code>UserUpdateInfo</code>
/// </summary>
public partial class RL_9ab59cf1963fbe94eddb7ebb18232c35 : GenericRecordList<ST_da83da85e5348cd2800e701fda6288aaStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_da83da85e5348cd2800e701fda6288aaStructure GetElementDefaultValue() {
return new ST_da83da85e5348cd2800e701fda6288aaStructure();
}

public T[] ToArray<T>(Func<ST_da83da85e5348cd2800e701fda6288aaStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9ab59cf1963fbe94eddb7ebb18232c35 recordList, Func<ST_da83da85e5348cd2800e701fda6288aaStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9ab59cf1963fbe94eddb7ebb18232c35(ST_da83da85e5348cd2800e701fda6288aaStructure[] array) {
  RL_9ab59cf1963fbe94eddb7ebb18232c35 result = new RL_9ab59cf1963fbe94eddb7ebb18232c35();
result.InnerFromArray(array);
    return result;
}

public static RL_9ab59cf1963fbe94eddb7ebb18232c35 ToList<T>(T[] array, Func <T, ST_da83da85e5348cd2800e701fda6288aaStructure> converter) {
  RL_9ab59cf1963fbe94eddb7ebb18232c35 result = new RL_9ab59cf1963fbe94eddb7ebb18232c35();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9ab59cf1963fbe94eddb7ebb18232c35 FromRestList<T>(RestList<T> restList, Func <T, ST_da83da85e5348cd2800e701fda6288aaStructure> converter) {
  RL_9ab59cf1963fbe94eddb7ebb18232c35 result = new RL_9ab59cf1963fbe94eddb7ebb18232c35();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9ab59cf1963fbe94eddb7ebb18232c35() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_da83da85e5348cd2800e701fda6288aaStructure> NewList() {
return new RL_9ab59cf1963fbe94eddb7ebb18232c35();
}


} // RL_9ab59cf1963fbe94eddb7ebb18232c35
}

