namespace CleanArchitecture.Shared.SeedWork;

public class ValueObject<T> : IEquatable<ValueObject<T>> where T : notnull
{
    public T Value { get; init; }

    public ValueObject(T value)
    {
        Value = value;
    }

    public static implicit operator T(ValueObject<T> valueObject)
    {
        return valueObject.Value;
    }

    public static implicit operator ValueObject<T>(T value)
    {
        return new(value);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ValueObject<T>)obj);
    }

    public override int GetHashCode()
    {
        return EqualityComparer<T>.Default.GetHashCode(Value);
    }

    public override string ToString()
    {
        return Value.ToString()!;
    }

    public bool Equals(ValueObject<T>? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return EqualityComparer<T>.Default.Equals(Value, other.Value);
    }
}