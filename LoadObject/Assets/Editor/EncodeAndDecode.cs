using System.IO;

namespace EnAndDecode
{
    public class EncodeAndDecode
    {
        static int offset = 0;
        public static byte[] Encode(byte[] text)
        {
            if (text == null)
            {
                return null;
            }
            /*
             * TODO: �����㷨
             */

            // demo
            int encodeVersion = 1;
            byte[] versionData = System.BitConverter.GetBytes(encodeVersion);
            offset = versionData.Length;
            byte[] resultData = new byte[text.Length + offset];
            int j = 0;
            for (int i = 0; i < versionData.Length; i++)
            {
                resultData[j++] = versionData[i];
            }
            for (int i = 0; i < text.Length; i++)
            {
                resultData[j++] = text[i];
            }
            return resultData;
        }

        public static byte[] Decode(byte[] text)
        {
            if (text == null)
                return null;
            /**
             *  TODO: �����㷨 
             */


            // demo 
            byte[] result = new byte[text.Length - offset];
            for (int i = offset, j = 0; i < text.Length; i++, j++)
            {
                result[j] = text[i];
            }
            return result;
        }
    }

}

