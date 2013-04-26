using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace DotNetBench.IncludedBenchmarks
{
    class AES : IBenchmark 
    {
        public string TestName
        {
            get { return "AES"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            for (int i = 0; i < 4; i++)
            {
                byte[] toCrypt = new byte[(int)numOps];
                byte[] key = new byte[16];
                Encrypt(ref toCrypt, key);
            }
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 600000000;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }

        private void Encrypt(ref byte[] Data, byte[] Key)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael AESAlg = Rijndael.Create();
            //AESAlg.IV = IV;
            AESAlg.Key = Key;

            CryptoStream AesCS = new CryptoStream(ms, AESAlg.CreateEncryptor(), CryptoStreamMode.Write);

            AesCS.Write(Data, 0, Data.Length);
            AesCS.Close();
            Data = ms.ToArray();
        }
    }
}
