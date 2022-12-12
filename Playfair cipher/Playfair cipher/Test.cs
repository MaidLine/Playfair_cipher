using NUnit.Framework;

namespace Playfair_cipher
{
    public class Test
    {

        [Test]
        public void EncryptionTest()
        {
            Encrypter encrypter = new();

            encrypter.Encryption("Im on the highway to hell", "hell");

            Assert.AreEqual("DPLUOZSELZADDLVBZ!UNYLLAE ", encrypter.outtext);
        }

        [Test]
        public void DescryptionTest()
        {
            Encrypter decrypter = new();

            decrypter.Descryption("DPLUOZSELZADDLVBZ!UNYLLAE ", "hell");

            Assert.AreEqual("IM ON THE HIGHWAY TO HELL", decrypter.outtext);
        }
    }
}
