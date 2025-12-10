namespace ssRuntimeDestroyer {
/// <summary>
/// [Structure] EmployeeName (sXtHJ_qj8kK9+D8bFxi_3A)
///  <code>ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure</code> that represents <code>EmployeeName</code
/// > <p>Description: </p>
/// </summary>
// Name: EmployeeName
public partial struct ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure : ITypedRecord<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("sTTG50eVjk+Ae8n6o1m2aQ*WrcubIhyNkW4SCvgX2OcYA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Name")]
public string ssName;


public BitArray OptimizedAttributes;

public ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure() {
OptimizedAttributes = null;
ssName = "";
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
ssName = r.ReadText(index++, "EmployeeName.Name", "");
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
public void ReadIM(ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure r) {
this = r;
}


public static bool operator == (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure a, ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure b) {
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure a, ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure)) return false;
return (this == (ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure Duplicate() {
ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure t;
t.ssName = this.ssName;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
}
} // ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure
/// <summary>
/// RecordList type <code>EmployeeNameList</code> that represents a record list of
///  <code>EmployeeName</code>
/// </summary>
public partial class RL_6600b86256c1bf3f6cdac9ff6a9bf480 : GenericRecordList<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure GetElementDefaultValue() {
return new ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure();
}

public T[] ToArray<T>(Func<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6600b86256c1bf3f6cdac9ff6a9bf480 recordList, Func<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6600b86256c1bf3f6cdac9ff6a9bf480(ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure[] array) {
  RL_6600b86256c1bf3f6cdac9ff6a9bf480 result = new RL_6600b86256c1bf3f6cdac9ff6a9bf480();
result.InnerFromArray(array);
    return result;
}

public static RL_6600b86256c1bf3f6cdac9ff6a9bf480 ToList<T>(T[] array, Func <T, ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> converter) {
  RL_6600b86256c1bf3f6cdac9ff6a9bf480 result = new RL_6600b86256c1bf3f6cdac9ff6a9bf480();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6600b86256c1bf3f6cdac9ff6a9bf480 FromRestList<T>(RestList<T> restList, Func <T, ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> converter) {
  RL_6600b86256c1bf3f6cdac9ff6a9bf480 result = new RL_6600b86256c1bf3f6cdac9ff6a9bf480();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6600b86256c1bf3f6cdac9ff6a9bf480() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e42dfe98d0cfe1bf0f0899faf43c3288Structure> NewList() {
return new RL_6600b86256c1bf3f6cdac9ff6a9bf480();
}


} // RL_6600b86256c1bf3f6cdac9ff6a9bf480
}

