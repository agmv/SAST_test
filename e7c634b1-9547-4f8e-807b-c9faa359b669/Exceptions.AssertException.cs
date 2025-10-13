namespace ssRuntimeDestroyer;

/// <summary>
/// User Defined Exception class: AssertException
/// </summary>
public class Ex_AssertExceptionUserException : UserException {

/// <summary>
/// User Defined Exception (AssertException) constructor:
/// </summary>
public Ex_AssertExceptionUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "RuntimeDestroyer.AssertException";
}

}
