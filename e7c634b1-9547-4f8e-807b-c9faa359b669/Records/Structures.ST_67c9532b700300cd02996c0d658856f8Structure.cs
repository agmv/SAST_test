namespace ssRuntimeDestroyer {
/// <summary>
/// [CustomStructure] URLQueryParameter (0BXISOYdukKjtIN7AWlptA)
///  <code>ST_67c9532b700300cd02996c0d658856f8Structure</code> that represent
/// s <code>URLQueryParameter</code> <p>Description: </p>
/// </summary>
// Name: URLQueryParameter
public partial struct ST_67c9532b700300cd02996c0d658856f8Structure : ITypedRecord<ST_67c9532b700300cd02996c0d658856f8Structure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*kRoiRuZvl0m3l0apDmb6Jg");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*Sb2gKCzMh0arN2bdqUTqBg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Name")]
public string ssName;

[System.Xml.Serialization.XmlElement("Value")]
public string ssValue;


public BitArray OptimizedAttributes;

public ST_67c9532b700300cd02996c0d658856f8Structure() {
OptimizedAttributes = null;
ssName = "";
ssValue = "";
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
ssName = r.ReadText(index++, "URLQueryParameter.Name", "");
ssValue = r.ReadText(index++, "URLQueryParameter.Value", "");
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
public void ReadIM(ST_67c9532b700300cd02996c0d658856f8Structure r) {
this = r;
}


public static bool operator == (ST_67c9532b700300cd02996c0d658856f8Structure a, ST_67c9532b700300cd02996c0d658856f8Structure b) {
if (a.ssName != b.ssName) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_67c9532b700300cd02996c0d658856f8Structure a, ST_67c9532b700300cd02996c0d658856f8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_67c9532b700300cd02996c0d658856f8Structure)) return false;
return (this == (ST_67c9532b700300cd02996c0d658856f8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_67c9532b700300cd02996c0d658856f8Structure Duplicate() {
ST_67c9532b700300cd02996c0d658856f8Structure t;
t.ssName = this.ssName;
t.ssValue = this.ssValue;
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
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssValue = (string) other.AttributeGet(IdValue);
}
} // ST_67c9532b700300cd02996c0d658856f8Structure
/// <summary>
/// RecordList type <code>URLQueryParameterList</code> that represents a record list of
///  <code>URLQueryParameter</code>
/// </summary>
public partial class RL_f12ccf0a92533f516726b4232e2b352e : GenericRecordList<ST_67c9532b700300cd02996c0d658856f8Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_67c9532b700300cd02996c0d658856f8Structure GetElementDefaultValue() {
return new ST_67c9532b700300cd02996c0d658856f8Structure();
}

public T[] ToArray<T>(Func<ST_67c9532b700300cd02996c0d658856f8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f12ccf0a92533f516726b4232e2b352e recordList, Func<ST_67c9532b700300cd02996c0d658856f8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f12ccf0a92533f516726b4232e2b352e(ST_67c9532b700300cd02996c0d658856f8Structure[] array) {
  RL_f12ccf0a92533f516726b4232e2b352e result = new RL_f12ccf0a92533f516726b4232e2b352e();
result.InnerFromArray(array);
    return result;
}

public static RL_f12ccf0a92533f516726b4232e2b352e ToList<T>(T[] array, Func <T, ST_67c9532b700300cd02996c0d658856f8Structure> converter) {
  RL_f12ccf0a92533f516726b4232e2b352e result = new RL_f12ccf0a92533f516726b4232e2b352e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f12ccf0a92533f516726b4232e2b352e FromRestList<T>(RestList<T> restList, Func <T, ST_67c9532b700300cd02996c0d658856f8Structure> converter) {
  RL_f12ccf0a92533f516726b4232e2b352e result = new RL_f12ccf0a92533f516726b4232e2b352e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f12ccf0a92533f516726b4232e2b352e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_67c9532b700300cd02996c0d658856f8Structure> NewList() {
return new RL_f12ccf0a92533f516726b4232e2b352e();
}


} // RL_f12ccf0a92533f516726b4232e2b352e
}

