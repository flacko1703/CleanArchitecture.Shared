namespace CleanArchitecture.Shared.SeedWork;

public struct TypedId<T> : IEquatable<TypedId<T>> where T : notnull
{
    public T Value { get; init; }

    public TypedId(T value)
    {
        Value = value;
    }

    public static implicit operator T(TypedId<T> valueObject)
    {
        return valueObject.Value;
    }

    public static implicit operator TypedId<T>(T value)
    {
        return new(value);
    }

    public override bool Equals(object? obj)
    {
        return obj is TypedId<T> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return EqualityComparer<T>.Default.GetHashCode(Value);
    }

    public override string ToString()
    {
        return Value.ToString()!;
    }

    public bool Equals(TypedId<T>? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return EqualityComparer<T>.Default.Equals(Value, other.Value);
    }

    public bool Equals(TypedId<T> other)
    {
        return EqualityComparer<T>.Default.Equals(Value, other.Value);
    }
}