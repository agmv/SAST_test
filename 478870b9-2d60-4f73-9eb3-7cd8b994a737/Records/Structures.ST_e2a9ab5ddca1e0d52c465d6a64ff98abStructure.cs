namespace ssSystem_ {
/// <summary>
/// [Structure] UserLoginFailureReason (CkcjuR0y50mx0pQ1SWfd_g)
///  <code>ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure</code> that represent
/// s <code>UserLoginFailureReason</code> <p>Description: </p>
/// </summary>
// Name: UserLoginFailureReason
public partial struct ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure : ITypedRecord<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure> {
internal static readonly GlobalObjectKey IdInvalidCredentials = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*9KyENzEeG0a8xU6_fbwnjA");
internal static readonly GlobalObjectKey IdTooManyFailedLoginAttempts = GlobalObjectKey.Parse("uXCIR2Atc0+es3zYuZSnNw*fRK4RTUg_UKOqg6iUMRxAA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InvalidCredentials")]
public bool ssInvalidCredentials;

[System.Xml.Serialization.XmlElement("TooManyFailedLoginAttempts")]
public bool ssTooManyFailedLoginAttempts;


public BitArray OptimizedAttributes;

public ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure() {
OptimizedAttributes = null;
ssInvalidCredentials = false;
ssTooManyFailedLoginAttempts = false;
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
ssInvalidCredentials = r.ReadBoolean(index++, "UserLoginFailureReason.InvalidCredentials", false);
ssTooManyFailedLoginAttempts = r.ReadBoolean(index++, "UserLoginFailureReason.TooManyFailedLoginAttempts", false);
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
public void ReadIM(ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure r) {
this = r;
}


public static bool operator == (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure a, ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure b) {
if (a.ssInvalidCredentials != b.ssInvalidCredentials) return false;
if (a.ssTooManyFailedLoginAttempts != b.ssTooManyFailedLoginAttempts) return false;
return true;
}

public static bool operator != (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure a, ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure)) return false;
return (this == (ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvalidCredentials.GetHashCode()
 ^ ssTooManyFailedLoginAttempts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure Duplicate() {
ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure t;
t.ssInvalidCredentials = this.ssInvalidCredentials;
t.ssTooManyFailedLoginAttempts = this.ssTooManyFailedLoginAttempts;
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
if (head == "invalidcredentials") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvalidCredentials")) variable.Value = ssInvalidCredentials; else variable.Optimized = true;
} else if (head == "toomanyfailedloginattempts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TooManyFailedLoginAttempts")) variable.Value = ssTooManyFailedLoginAttempts; else variable.Optimized = true;
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
if (key == IdInvalidCredentials) {
return ssInvalidCredentials;
}
if (key == IdTooManyFailedLoginAttempts) {
return ssTooManyFailedLoginAttempts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvalidCredentials.Key.AsGuid) {
return ssInvalidCredentials;
}
if (attributeKey == IdTooManyFailedLoginAttempts.Key.AsGuid) {
return ssTooManyFailedLoginAttempts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvalidCredentials = (bool) other.AttributeGet(IdInvalidCredentials);
ssTooManyFailedLoginAttempts = (bool) other.AttributeGet(IdTooManyFailedLoginAttempts);
}
} // ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure
/// <summary>
/// RecordList type <code>UserLoginFailureReasonList</code> that represents a record list of
///  <code>UserLoginFailureReason</code>
/// </summary>
public partial class RL_3b8feaa11cc930133dbb7eecb085b527 : GenericRecordList<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure GetElementDefaultValue() {
return new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure();
}

public T[] ToArray<T>(Func<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3b8feaa11cc930133dbb7eecb085b527 recordList, Func<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3b8feaa11cc930133dbb7eecb085b527(ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure[] array) {
  RL_3b8feaa11cc930133dbb7eecb085b527 result = new RL_3b8feaa11cc930133dbb7eecb085b527();
result.InnerFromArray(array);
    return result;
}

public static RL_3b8feaa11cc930133dbb7eecb085b527 ToList<T>(T[] array, Func <T, ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure> converter) {
  RL_3b8feaa11cc930133dbb7eecb085b527 result = new RL_3b8feaa11cc930133dbb7eecb085b527();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3b8feaa11cc930133dbb7eecb085b527 FromRestList<T>(RestList<T> restList, Func <T, ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure> converter) {
  RL_3b8feaa11cc930133dbb7eecb085b527 result = new RL_3b8feaa11cc930133dbb7eecb085b527();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3b8feaa11cc930133dbb7eecb085b527() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure> NewList() {
return new RL_3b8feaa11cc930133dbb7eecb085b527();
}


} // RL_3b8feaa11cc930133dbb7eecb085b527
}

