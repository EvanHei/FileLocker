namespace FileLockerLibrary;

public interface IMacGenerator
{
    byte[] GenerateMac(byte[] data);

    bool ValidateMac(byte[] data, byte[] expectedHmac);

    byte[] Key { get; set; }
}
