namespace FileLockerLibrary;

public interface IKeyDeriver
{
    byte[] GenerateSalt();
    byte[] DeriveKey(string password, byte[] salt, int length = 32);
}
