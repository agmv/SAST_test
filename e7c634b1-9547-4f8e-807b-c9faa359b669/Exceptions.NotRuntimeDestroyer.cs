namespace ssRuntimeDestroyer;

/// <summary>
/// User Defined Exception class: NotRuntimeDestroyer
/// </summary>
public class Ex_NotRuntimeDestroyerRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotRuntimeDestroyer) constructor:
/// </summary>
public Ex_NotRuntimeDestroyerRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "RuntimeDestroyer.NotRuntimeDestroyer";
}

}
