namespace ssSystem_ {
/// <summary>
/// [AnonymousStructure] Record (3slEPCVBEgOxuYlOSu4FLQ)
///  <code>RC_c97a9c0cb896c874168b02efa3e48866</code> that represent
/// s <code>ActivityDefinitionLinkRecord</code> <p>Description: </p>
/// </summary>
// Name: ActivityDefinitionLinkRecord
public partial struct RC_c97a9c0cb896c874168b02efa3e48866 : ITypedRecord<RC_c97a9c0cb896c874168b02efa3e48866> {
internal static readonly GlobalObjectKey IdActivityDefinitionLink = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DJx6yZa4dMgWiwLvo+SIZg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ActivityDefinitionLink")]
public ENActivityDefinitionLinkEntityRecord ssENActivityDefinitionLink;


public static implicit operator ENActivityDefinitionLinkEntityRecord( RC_c97a9c0cb896c874168b02efa3e48866 r) {
return r.ssENActivityDefinitionLink;
}

public static implicit operator RC_c97a9c0cb896c874168b02efa3e48866 (ENActivityDefinitionLinkEntityRecord r) {
RC_c97a9c0cb896c874168b02efa3e48866 res = new RC_c97a9c0cb896c874168b02efa3e48866 ();
res.ssENActivityDefinitionLink = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActivityDefinitionLink.ChangedAttributes = value;
}
get {
    return ssENActivityDefinitionLink.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c97a9c0cb896c874168b02efa3e48866() {
OptimizedAttributes = null;
ssENActivityDefinitionLink = new ENActivityDefinitionLinkEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActivityDefinitionLink.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActivityDefinitionLink.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActivityDefinitionLink.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActivityDefinitionLink.Read( r, ref index);
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
public void ReadIM(RC_c97a9c0cb896c874168b02efa3e48866 r) {
this = r;
}


public static bool operator == (RC_c97a9c0cb896c874168b02efa3e48866 a, RC_c97a9c0cb896c874168b02efa3e48866 b) {
if (a.ssENActivityDefinitionLink != b.ssENActivityDefinitionLink) return false;
return true;
}

public static bool operator != (RC_c97a9c0cb896c874168b02efa3e48866 a, RC_c97a9c0cb896c874168b02efa3e48866 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c97a9c0cb896c874168b02efa3e48866)) return false;
return (this == (RC_c97a9c0cb896c874168b02efa3e48866)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActivityDefinitionLink.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActivityDefinitionLink.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActivityDefinitionLink.InternalRecursiveSave();
}


public RC_c97a9c0cb896c874168b02efa3e48866 Duplicate() {
RC_c97a9c0cb896c874168b02efa3e48866 t;
t.ssENActivityDefinitionLink = (ENActivityDefinitionLinkEntityRecord)this.ssENActivityDefinitionLink.Duplicate();
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
if (head == "activitydefinitionlink") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivityDefinitionLink")) variable.Value = ssENActivityDefinitionLink; else variable.Optimized = true;
variable.SetFieldName("activitydefinitionlink");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinitionLink.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActivityDefinitionLink.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActivityDefinitionLink) {
return ssENActivityDefinitionLink;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActivityDefinitionLink.Key.AsGuid) {
return ssENActivityDefinitionLink;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActivityDefinitionLink.FillFromOther((IRecord) other.AttributeGet(IdActivityDefinitionLink));
}
} // RC_c97a9c0cb896c874168b02efa3e48866
/// <summary>
/// RecordList type <code>ActivityDefinitionLinkRecordList</code> that represents a record list of
///  <code>ActivityDefinitionLink</code>
/// </summary>
public partial class RL_9587436fe4e8f406175a43d163260035 : GenericRecordList<RC_c97a9c0cb896c874168b02efa3e48866>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c97a9c0cb896c874168b02efa3e48866 GetElementDefaultValue() {
return new RC_c97a9c0cb896c874168b02efa3e48866();
}

public T[] ToArray<T>(Func<RC_c97a9c0cb896c874168b02efa3e48866, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9587436fe4e8f406175a43d163260035 recordList, Func<RC_c97a9c0cb896c874168b02efa3e48866, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9587436fe4e8f406175a43d163260035(RC_c97a9c0cb896c874168b02efa3e48866[] array) {
  RL_9587436fe4e8f406175a43d163260035 result = new RL_9587436fe4e8f406175a43d163260035();
result.InnerFromArray(array);
    return result;
}

public static RL_9587436fe4e8f406175a43d163260035 ToList<T>(T[] array, Func <T, RC_c97a9c0cb896c874168b02efa3e48866> converter) {
  RL_9587436fe4e8f406175a43d163260035 result = new RL_9587436fe4e8f406175a43d163260035();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9587436fe4e8f406175a43d163260035 FromRestList<T>(RestList<T> restList, Func <T, RC_c97a9c0cb896c874168b02efa3e48866> converter) {
  RL_9587436fe4e8f406175a43d163260035 result = new RL_9587436fe4e8f406175a43d163260035();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9587436fe4e8f406175a43d163260035() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c97a9c0cb896c874168b02efa3e48866> NewList() {
return new RL_9587436fe4e8f406175a43d163260035();
}


} // RL_9587436fe4e8f406175a43d163260035
}

