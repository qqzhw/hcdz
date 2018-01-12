using Hcdz.Communication.Scs.Communication.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcdz.Communication.Scs.Communication.Protocols
{
    public class RawDataWireProtocol : IScsWireProtocol
    {
        public IEnumerable<IScsMessage> CreateMessages(byte[] receivedBytes)
        {
            return new List<IScsMessage>
            {
                new ScsRawDataMessage(receivedBytes)
            };
        }

        public IEnumerable<IScsMessage> CreateMessages(string receicedMsg)
        {
            var bytes = HexStringToByteArray(receicedMsg);
            return new List<IScsMessage>
            {
                new ScsRawDataMessage(bytes)
            };
        }

        public byte[] GetBytes(IScsMessage message)
        {
            if (message is ScsPingMessage)
            {
                return new byte[0];
            }
            return ((ScsRawDataMessage)message).MessageData;
        }
        private  byte[] HexStringToByteArray(string str)
        {
            str = str.Replace(" ", "");
            byte[] buffer = new byte[str.Length / 2];
            for (int i = 0; i < str.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(str.Substring(i, 2), 16);
            }
            return buffer;
        }
        public void Reset()
        {

        }
    }
}
