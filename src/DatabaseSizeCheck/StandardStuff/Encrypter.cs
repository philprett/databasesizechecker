using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSizeCheck
{
    public class Encrypter
    {
        /// <summary>
        /// The types of hash algorithms available
        /// </summary>
        public enum HashAlgorithms { MD5, SHA1 }


        /// <summary>
        /// Passphrase from which a pseudo-random password will be derived. The
        /// derived password will be used to generate the encryption key.
        /// Passphrase can be any string. In this example we assume that this
        /// passphrase is an ASCII string.
        /// </summary>
        public string PassPhrase { get; set; }

        /// <summary>
        /// Salt value used along with passphrase to generate password. Salt can
        /// be any string. In this example we assume that salt is an ASCII string.
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// Hash algorithm used to generate password. Allowed values are: MD5 and
        /// SHA1. SHA1 hashes are a bit slower, but more secure than MD5 hashes.
        /// </summary>
        public HashAlgorithms HashAlgorithm { get; set; }

        /// <summary>
        /// Number of iterations used to generate password. One or two iterations
        /// should be enough.
        /// </summary>
        public int PasswordIterations { get; set; }

        /// <summary>
        /// Initialization vector (or IV). This value is required to encrypt the
        /// first block of plaintext data. For RijndaelManaged class IV must be 
        /// exactly 16 ASCII characters long.
        /// </summary>
        public string InitVector { get; set; }

        /// <summary>
        /// Size of encryption key in bits. Allowed values are: 128, 192, and 256. 
        /// Longer keys are more secure than shorter keys.
        /// </summary>
        public int KeySize { get; set; }

        /// <summary>
        /// Get the Hash Algorithm as a string
        /// </summary>
        public string HashAlgorithmString
        {
            get
            {
                return HashAlgorithm == HashAlgorithms.MD5 ? "MD5" : HashAlgorithm == HashAlgorithms.SHA1 ? "SHA1" : string.Empty;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Encrypter()
        {
            PassPhrase = "hdDln2aEk/sd5hiFueh&9fdnRs4fpji5%GweaTo7$urfZ8iauf"; // can be any string
            Salt = "lsDjhrF$owEe4who&hgsWidpf%g3qdEgakFfgs6ajFhgajkgasd";      // can be any string
            HashAlgorithm = HashAlgorithms.SHA1;

            PasswordIterations = 2;          // can be any number
            InitVector = "@1B2c2D5e5F6g0H9"; // must be 16 bytes
            KeySize = 256;                   // can be 192 or 128
        }

        /// <summary>
        /// Encrypts specified plaintext using Rijndael symmetric key algorithm
        /// and returns a base64-encoded result.
        /// </summary>
        /// <param name="stringToEncrypt">The string to encrypt</param>
        /// <returns>Encrypted value formatted as a base64-encoded string.</returns>
        public string EncryptString(string stringToEncrypt)
        {
            return RijnDael.Encrypt(stringToEncrypt,
                                    PassPhrase,
                                    Salt,
                                    HashAlgorithmString,
                                    PasswordIterations,
                                    InitVector,
                                    KeySize);
        }

        /// <summary>
        /// Decrypts specified ciphertext using Rijndael symmetric key algorithm.
        /// </summary>
        /// <param name="encryptedString">Base64-formatted ciphertext value.</param>
        /// <returns>Decrypted string value.</returns>
        public string DecryptString(string encryptedString)
        {
            return RijnDael.Decrypt(encryptedString,
                                    PassPhrase,
                                    Salt,
                                    HashAlgorithmString,
                                    PasswordIterations,
                                    InitVector,
                                    KeySize);
        }
    }
}
