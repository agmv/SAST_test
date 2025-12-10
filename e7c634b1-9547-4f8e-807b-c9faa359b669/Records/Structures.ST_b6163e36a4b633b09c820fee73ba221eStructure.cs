namespace ssRuntimeDestroyer {
/// <summary>
/// [CustomStructure] HTTPHeader (rhKNRTDL9EinYGjZIjnjgA)
///  <code>ST_b6163e36a4b633b09c820fee73ba221eStructure</code> that represents <code>HTTPHeader</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPHeader
public partial struct ST_b6163e36a4b633b09c820fee73ba221eStructure : ITypedRecord<ST_b6163e36a4b633b09c820fee73ba221eStructure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*wCtRPEwZ5kewCVXZ6Nof_g");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*xwEBjNISWUuvwKIZKYxu+A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Name")]
public string ssName;

[System.Xml.Serialization.XmlElement("Value")]
public string ssValue;


public BitArray OptimizedAttributes;

public ST_b6163e36a4b633b09c820fee73ba221eStructure() {
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
ssName = r.ReadText(index++, "HTTPHeader.Name", "");
ssValue = r.ReadText(index++, "HTTPHeader.Value", "");
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
public void ReadIM(ST_b6163e36a4b633b09c820fee73ba221eStructure r) {
this = r;
}


public static bool operator == (ST_b6163e36a4b633b09c820fee73ba221eStructure a, ST_b6163e36a4b633b09c820fee73ba221eStructure b) {
if (a.ssName != b.ssName) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_b6163e36a4b633b09c820fee73ba221eStructure a, ST_b6163e36a4b633b09c820fee73ba221eStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b6163e36a4b633b09c820fee73ba221eStructure)) return false;
return (this == (ST_b6163e36a4b633b09c820fee73ba221eStructure)o);
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


public ST_b6163e36a4b633b09c820fee73ba221eStructure Duplicate() {
ST_b6163e36a4b633b09c820fee73ba221eStructure t;
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
} // ST_b6163e36a4b633b09c820fee73ba221eStructure
/// <summary>
/// RecordList type <code>HTTPHeaderList</code> that represents a record list of
///  <code>HTTPHeader</code>
/// </summary>
public partial class RL_435011a192ffc5b6f97bc0a73c8501c1 : GenericRecordList<ST_b6163e36a4b633b09c820fee73ba221eStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b6163e36a4b633b09c820fee73ba221eStructure GetElementDefaultValue() {
return new ST_b6163e36a4b633b09c820fee73ba221eStructure();
}

public T[] ToArray<T>(Func<ST_b6163e36a4b633b09c820fee73ba221eStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_435011a192ffc5b6f97bc0a73c8501c1 recordList, Func<ST_b6163e36a4b633b09c820fee73ba221eStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_435011a192ffc5b6f97bc0a73c8501c1(ST_b6163e36a4b633b09c820fee73ba221eStructure[] array) {
  RL_435011a192ffc5b6f97bc0a73c8501c1 result = new RL_435011a192ffc5b6f97bc0a73c8501c1();
result.InnerFromArray(array);
    return result;
}

public static RL_435011a192ffc5b6f97bc0a73c8501c1 ToList<T>(T[] array, Func <T, ST_b6163e36a4b633b09c820fee73ba221eStructure> converter) {
  RL_435011a192ffc5b6f97bc0a73c8501c1 result = new RL_435011a192ffc5b6f97bc0a73c8501c1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_435011a192ffc5b6f97bc0a73c8501c1 FromRestList<T>(RestList<T> restList, Func <T, ST_b6163e36a4b633b09c820fee73ba221eStructure> converter) {
  RL_435011a192ffc5b6f97bc0a73c8501c1 result = new RL_435011a192ffc5b6f97bc0a73c8501c1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_435011a192ffc5b6f97bc0a73c8501c1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b6163e36a4b633b09c820fee73ba221eStructure> NewList() {
return new RL_435011a192ffc5b6f97bc0a73c8501c1();
}


} // RL_435011a192ffc5b6f97bc0a73c8501c1
}

