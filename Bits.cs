namespace homework; 

public class Bits
{
    private readonly byte[] data;

    public Bits(byte[] data)
    {
        this.data = data;
    }

    public static implicit operator Bits(long value) => new(BitConverter.GetBytes(value));

    public static implicit operator Bits(int value) => new(BitConverter.GetBytes(value));

    public static implicit operator Bits(byte value) => new(new[] { value });
}