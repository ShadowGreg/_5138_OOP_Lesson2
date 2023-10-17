// Реализуйте операторы неявного приведения из long, int, byt в Bits

using homework;

public class Program {
    public static void Main(string[] args) {
        const long l = 1234567890123456789;
        Bits bitsFromLong = l; 

        const int i = 123456789;
        Bits bitsFromInt = i; 

        const byte b = 255;
        Bits bitsFromByte = b; 
    }
}