namespace ssSystem_ {
/// <summary>
/// [Structure] ExternalIdentityProvider (BWnFzaa1vkS2KZyfhL+pdw)
///  <code>ST_7b0e31d9e5a94347cc99b90226c3a090Structure</code> that represent
/// s <code>ExternalIdentityProvider</code> <p>Description: Holds the information that identifies a
///  configured external Identity Provider</p>
/// </summary>
// Name: ExternalIdentityProvider
public partial struct ST_7b0e31d9e5a94347cc99b90226c3a090Structure : ITypedRecord<ST_7b0e31d9e5a94347cc99b90226c3a090Structure> {
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*yv2YF2DGDkCQ3qN62Si7xQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*WaNeArJ6mEe7JkrQjSCHpg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Key")]
public string ssKey;

[System.Xml.Serialization.XmlElement("Name")]
public string ssName;


public BitArray OptimizedAttributes;

public ST_7b0e31d9e5a94347cc99b90226c3a090Structure() {
OptimizedAttributes = null;
ssKey = "";
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
ssKey = r.ReadText(index++, "ExternalIdentityProvider.Key", "");
ssName = r.ReadText(index++, "ExternalIdentityProvider.Name", "");
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
public void ReadIM(ST_7b0e31d9e5a94347cc99b90226c3a090Structure r) {
this = r;
}


public static bool operator == (ST_7b0e31d9e5a94347cc99b90226c3a090Structure a, ST_7b0e31d9e5a94347cc99b90226c3a090Structure b) {
if (a.ssKey != b.ssKey) return false;
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (ST_7b0e31d9e5a94347cc99b90226c3a090Structure a, ST_7b0e31d9e5a94347cc99b90226c3a090Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7b0e31d9e5a94347cc99b90226c3a090Structure)) return false;
return (this == (ST_7b0e31d9e5a94347cc99b90226c3a090Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKey.GetHashCode()
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


public ST_7b0e31d9e5a94347cc99b90226c3a090Structure Duplicate() {
ST_7b0e31d9e5a94347cc99b90226c3a090Structure t;
t.ssKey = this.ssKey;
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
if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "name") {
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
if (key == IdKey) {
return ssKey;
}
if (key == IdName) {
return ssName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKey = (string) other.AttributeGet(IdKey);
ssName = (string) other.AttributeGet(IdName);
}
} // ST_7b0e31d9e5a94347cc99b90226c3a090Structure
/// <summary>
/// RecordList type <code>ExternalIdentityProviderList</code> that represents a record list of
///  <code>ExternalIdentityProvider</code>
/// </summary>
public partial class RL_d8b9fa35673308f4ed8408d9b35c518e : GenericRecordList<ST_7b0e31d9e5a94347cc99b90226c3a090Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7b0e31d9e5a94347cc99b90226c3a090Structure GetElementDefaultValue() {
return new ST_7b0e31d9e5a94347cc99b90226c3a090Structure();
}

public T[] ToArray<T>(Func<ST_7b0e31d9e5a94347cc99b90226c3a090Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8b9fa35673308f4ed8408d9b35c518e recordList, Func<ST_7b0e31d9e5a94347cc99b90226c3a090Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8b9fa35673308f4ed8408d9b35c518e(ST_7b0e31d9e5a94347cc99b90226c3a090Structure[] array) {
  RL_d8b9fa35673308f4ed8408d9b35c518e result = new RL_d8b9fa35673308f4ed8408d9b35c518e();
result.InnerFromArray(array);
    return result;
}

public static RL_d8b9fa35673308f4ed8408d9b35c518e ToList<T>(T[] array, Func <T, ST_7b0e31d9e5a94347cc99b90226c3a090Structure> converter) {
  RL_d8b9fa35673308f4ed8408d9b35c518e result = new RL_d8b9fa35673308f4ed8408d9b35c518e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8b9fa35673308f4ed8408d9b35c518e FromRestList<T>(RestList<T> restList, Func <T, ST_7b0e31d9e5a94347cc99b90226c3a090Structure> converter) {
  RL_d8b9fa35673308f4ed8408d9b35c518e result = new RL_d8b9fa35673308f4ed8408d9b35c518e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8b9fa35673308f4ed8408d9b35c518e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7b0e31d9e5a94347cc99b90226c3a090Structure> NewList() {
return new RL_d8b9fa35673308f4ed8408d9b35c518e();
}


} // RL_d8b9fa35673308f4ed8408d9b35c518e
}

