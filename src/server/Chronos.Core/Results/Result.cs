namespace Chronos.Core.Results;

public readonly struct Result<TValue>
{
    private readonly TValue? _value;
    private readonly Error? _error;

    private Result(TValue value)
    {
        _value = value;
        _error = default;
    }
    
    private Result(Error error)
    {
        _error = error;
        _value = default;
    }
    
    private bool IsError => _error is not null;
    public bool IsSuccess => !IsError;
    
    public static implicit operator Result<TValue>(TValue value) => new(value);
    public static implicit operator Result<TValue>(Error error) => new(error);

    public TResult Match<TResult>(
        Func<TValue, TResult> success,
        Func<Error, TResult> failure) =>
        !IsError ? success(_value!) : failure(_error!);
}