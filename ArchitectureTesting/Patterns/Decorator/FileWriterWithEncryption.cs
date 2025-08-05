using System.Security.Cryptography;
using System.Text;

namespace ArchitectureTesting.Patterns.Decorator
{
    /* **
     * This is a very simple example of the Decorator patter (AKA Wrapper)
     * Its purpose is to wrap an entity or service or copy it but change the data passed in or out
     * **/
    public class FileWriterWithEncryption(string Path, string Name) : FileWriter
    {
        public void Write()
        {
            var encryptor = new RSACryptoServiceProvider();
            encryptor.KeySize = 128;
            var encryptedText = encryptor.Encrypt(Encoding.UTF8.GetBytes(Name), true);
            Write(Path, encryptedText.ToString());
        }
    }
}
