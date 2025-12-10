namespace ssRuntimeDestroyer {
/// <summary>
/// [AnonymousStructure] Record (sT5busLtp0Gg78RDmqqHvw)
///  <code>RC_3b55179c5be20c3d1041cf4a1dcf3f76</code> that represents <code>EmployeeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EmployeeRecord
public partial struct RC_3b55179c5be20c3d1041cf4a1dcf3f76 : ITypedRecord<RC_3b55179c5be20c3d1041cf4a1dcf3f76> {
internal static readonly GlobalObjectKey IdEmployee = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nBdVO+JbPQwQQc9KHc8_dg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Employee")]
public EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord ssENEmployee;


public static implicit operator EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord( RC_3b55179c5be20c3d1041cf4a1dcf3f76 r) {
return r.ssENEmployee;
}

public static implicit operator RC_3b55179c5be20c3d1041cf4a1dcf3f76 (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord r) {
RC_3b55179c5be20c3d1041cf4a1dcf3f76 res = new RC_3b55179c5be20c3d1041cf4a1dcf3f76 ();
res.ssENEmployee = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEmployee.ChangedAttributes = value;
}
get {
    return ssENEmployee.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3b55179c5be20c3d1041cf4a1dcf3f76() {
OptimizedAttributes = null;
ssENEmployee = new EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEmployee.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEmployee.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEmployee.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEmployee.Read( r, ref index);
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
public void ReadIM(RC_3b55179c5be20c3d1041cf4a1dcf3f76 r) {
this = r;
}


public static bool operator == (RC_3b55179c5be20c3d1041cf4a1dcf3f76 a, RC_3b55179c5be20c3d1041cf4a1dcf3f76 b) {
if (a.ssENEmployee != b.ssENEmployee) return false;
return true;
}

public static bool operator != (RC_3b55179c5be20c3d1041cf4a1dcf3f76 a, RC_3b55179c5be20c3d1041cf4a1dcf3f76 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3b55179c5be20c3d1041cf4a1dcf3f76)) return false;
return (this == (RC_3b55179c5be20c3d1041cf4a1dcf3f76)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEmployee.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEmployee.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEmployee.InternalRecursiveSave();
}


public RC_3b55179c5be20c3d1041cf4a1dcf3f76 Duplicate() {
RC_3b55179c5be20c3d1041cf4a1dcf3f76 t;
t.ssENEmployee = (EN_2768c35a9833a2af2f1bcfea06a332f4EntityRecord)this.ssENEmployee.Duplicate();
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
if (head == "employee") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Employee")) variable.Value = ssENEmployee; else variable.Optimized = true;
variable.SetFieldName("employee");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEmployee.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEmployee.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEmployee) {
return ssENEmployee;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmployee.Key.AsGuid) {
return ssENEmployee;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEmployee.FillFromOther((IRecord) other.AttributeGet(IdEmployee));
}
} // RC_3b55179c5be20c3d1041cf4a1dcf3f76
/// <summary>
/// RecordList type <code>EmployeeRecordList</code> that represents a record list of
///  <code>Employee</code>
/// </summary>
public partial class RL_3be1495f5fc898e41acd45a19b4ddd3b : GenericRecordList<RC_3b55179c5be20c3d1041cf4a1dcf3f76>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3b55179c5be20c3d1041cf4a1dcf3f76 GetElementDefaultValue() {
return new RC_3b55179c5be20c3d1041cf4a1dcf3f76();
}

public T[] ToArray<T>(Func<RC_3b55179c5be20c3d1041cf4a1dcf3f76, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3be1495f5fc898e41acd45a19b4ddd3b recordList, Func<RC_3b55179c5be20c3d1041cf4a1dcf3f76, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3be1495f5fc898e41acd45a19b4ddd3b(RC_3b55179c5be20c3d1041cf4a1dcf3f76[] array) {
  RL_3be1495f5fc898e41acd45a19b4ddd3b result = new RL_3be1495f5fc898e41acd45a19b4ddd3b();
result.InnerFromArray(array);
    return result;
}

public static RL_3be1495f5fc898e41acd45a19b4ddd3b ToList<T>(T[] array, Func <T, RC_3b55179c5be20c3d1041cf4a1dcf3f76> converter) {
  RL_3be1495f5fc898e41acd45a19b4ddd3b result = new RL_3be1495f5fc898e41acd45a19b4ddd3b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3be1495f5fc898e41acd45a19b4ddd3b FromRestList<T>(RestList<T> restList, Func <T, RC_3b55179c5be20c3d1041cf4a1dcf3f76> converter) {
  RL_3be1495f5fc898e41acd45a19b4ddd3b result = new RL_3be1495f5fc898e41acd45a19b4ddd3b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3be1495f5fc898e41acd45a19b4ddd3b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3b55179c5be20c3d1041cf4a1dcf3f76> NewList() {
return new RL_3be1495f5fc898e41acd45a19b4ddd3b();
}


} // RL_3be1495f5fc898e41acd45a19b4ddd3b
}

