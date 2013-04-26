using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class RC4 : IBenchmark 
    {
        public string TestName
        {
            get { return "RC4"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            byte[] toCrypt = new byte[(int)numOps];
            byte[] key = new byte[64];
            RC4Crypt(ref toCrypt, key);
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 1200000000;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }

        /// <summary>
        /// RC4 Block cipher
        /// </summary>
        /// <param name="bytes">bytes to encrypt/decrypt</param>
        /// <param name="key">key</param>
        private void RC4Crypt(ref Byte[] bytes, Byte[] key)
        {
            Byte[] s = new Byte[256];
            Byte[] k = new Byte[256];
            Byte temp;
            int i, j;

            for (i = 0; i < 256; i++)
            {
                s[i] = (Byte)i;
                k[i] = key[i % key.GetLength(0)];
            }

            j = 0;
            for (i = 0; i < 256; i++)
            {
                j = (j + s[i] + k[i]) % 256;
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            i = j = 0;
            for (int x = 0; x < bytes.GetLength(0); x++)
            {
                i = (i + 1) % 256;
                j = (j + s[i]) % 256;
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                int t = (s[i] + s[j]) % 256;
                bytes[x] ^= s[t];
            }
        }
    }
}
