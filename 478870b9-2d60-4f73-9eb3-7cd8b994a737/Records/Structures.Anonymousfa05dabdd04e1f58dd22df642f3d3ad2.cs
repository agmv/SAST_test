namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (vdoF+k7QWB_dIt9kLz060g)
///  <code>RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae</code> that represent
/// s <code>ActivityDefinitionRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: ActivityDefinitionRoleRecord
public partial struct RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae : ITypedRecord<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> {
internal static readonly GlobalObjectKey IdActivityDefinitionRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7zPv5lZiSucsbp9dv+zGrg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityDefinitionRole")]
public ENActivityDefinitionRoleEntityRecord ssENActivityDefinitionRole;


public static implicit operator ENActivityDefinitionRoleEntityRecord( RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae r) {
return r.ssENActivityDefinitionRole;
}

public static implicit operator RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae (ENActivityDefinitionRoleEntityRecord r) {
RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae res = new RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae ();
res.ssENActivityDefinitionRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityDefinitionRole.ChangedAttributes = value;
}
get {
    return ssENActivityDefinitionRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae() {
OptimizedAttributes = null;
ssENActivityDefinitionRole = new ENActivityDefinitionRoleEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityDefinitionRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityDefinitionRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityDefinitionRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityDefinitionRole.Read( r, ref index);
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
public void ReadIM(RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae r) {
this = r;
}


public static bool operator == (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae a, RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae b) {
if (a.ssENActivityDefinitionRole != b.ssENActivityDefinitionRole) return false;
return true;
}

public static bool operator != (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae a, RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae)) return false;
return (this == (RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityDefinitionRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityDefinitionRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityDefinitionRole.InternalRecursiveSave();
}


public RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae Duplicate() {
RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae t;
t.ssENActivityDefinitionRole = (ENActivityDefinitionRoleEntityRecord)this.ssENActivityDefinitionRole.Duplicate();
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
if (head == "activitydefinitionrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionRole")) variable.Value = ssENActivityDefinitionRole; else variable.Optimized = true;
variable.SetFieldName("activitydefinitionrole");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinitionRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinitionRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityDefinitionRole) {
return ssENActivityDefinitionRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityDefinitionRole.Key.AsGuid) {
return ssENActivityDefinitionRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityDefinitionRole.FillFromOther((IRecord) other.AttributeGet(IdActivityDefinitionRole));
}
} // RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae
/// <summary>
/// RecordList type <code>ActivityDefinitionRoleRecordList</code> that represents a record list of
///  <code>ActivityDefinitionRole</code>
/// </summary>
public partial class RL_998b7e962bf7fec9cf03c9baf25fb2da : GenericRecordList<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae GetElementDefaultValue() {
return new RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae();
}

public T[] ToArray<T>(Func<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_998b7e962bf7fec9cf03c9baf25fb2da recordList, Func<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_998b7e962bf7fec9cf03c9baf25fb2da(RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae[] array) {
  RL_998b7e962bf7fec9cf03c9baf25fb2da result = new RL_998b7e962bf7fec9cf03c9baf25fb2da();
result.InnerFromArray(array);
    return result;
}

public static RL_998b7e962bf7fec9cf03c9baf25fb2da ToList<T>(T[] array, Func <T, RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> converter) {
  RL_998b7e962bf7fec9cf03c9baf25fb2da result = new RL_998b7e962bf7fec9cf03c9baf25fb2da();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_998b7e962bf7fec9cf03c9baf25fb2da FromRestList<T>(RestList<T> restList, Func <T, RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> converter) {
  RL_998b7e962bf7fec9cf03c9baf25fb2da result = new RL_998b7e962bf7fec9cf03c9baf25fb2da();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_998b7e962bf7fec9cf03c9baf25fb2da() : base() {
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
protected override OSList<RC_e6ef33ef6256e74a2c6e9f5dbfecc6ae> NewList() {
return new RL_998b7e962bf7fec9cf03c9baf25fb2da();
}


} // RL_998b7e962bf7fec9cf03c9baf25fb2da
}

