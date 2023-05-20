using System;
using System.Collections.Generic;

namespace Gateway.NonGameRelatedManagers
{
    internal class GUIDRandomizer
    {
        public static Random _random = new Random();
        public static readonly List<ulong> ConsumedGUIDs = new List<ulong>();
        public static ulong RandomGUID()
        {
            ulong GUID;
            while (true)
            {
                byte[] randomBytes = new byte[8];
                for (int i = 0; i < randomBytes.Length; i++)
                    randomBytes[i] = (byte)_random.Next(0, 255);
                GUID = BitConverter.ToUInt64(randomBytes, 0);
                if (!ConsumedGUIDs.Contains(GUID))
                    break;
            }
            return GUID;
        }
    }

    internal class StringByteArray
    {
        public static byte[] StringToByteArray(string hex)
        {
            byte[] array = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return array;
        }
    }

    internal class PositionChecker
    {
        public static double Magnitude(float[] pos0, float[] pos1)
        {
            return Math.Sqrt(
                Math.Pow(pos1[0] - pos0[0], 2) +
                Math.Pow(pos1[1] - pos0[1], 2) +
                Math.Pow(pos1[2] - pos0[2], 2)
            );
        }
    }
}
