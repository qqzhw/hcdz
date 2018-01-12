using System.Text;
using System.Collections.Generic;
using Hcdz.Communication.Scs.Communication.Messages;

namespace Hcdz.Communication.Scs.Communication.Protocols
{
    /// <summary>
    /// This class is a sample custom wire protocol to use as wire protocol in SCS framework.
    /// It extends BinarySerializationProtocol.
    /// It is used just to send/receive ScsTextMessage messages.
    /// 
    /// Since BinarySerializationProtocol automatically writes message length to the beggining
    /// of the message, a message format of this class is:
    /// 
    /// [Message length (4 bytes)][UTF-8 encoded text (N bytes)]
    /// 
    /// So, total length of the message = (N + 4) bytes;
    /// </summary>
    public class TextWireProtocol : IScsWireProtocol
    {
       
        public byte[] GetBytes(IScsMessage message)
        {
            return Encoding.Default.GetBytes(((ScsTextMessage)message).Text);
        }

        public   IEnumerable<IScsMessage> CreateMessages(string receicedMsg)
        {
            var messages = new List<IScsMessage>();

            messages.Add(new ScsTextMessage(receicedMsg));    
            //Return message list
            return messages;          
        }

        public IEnumerable<IScsMessage> CreateMessages(byte[] receivedBytes)
        {
            var messages = new List<IScsMessage>();

            messages.Add(new ScsTextMessage(Encoding.Default.GetString(receivedBytes)));
            //Return message list
            return messages;      
        }

        public void Reset()
        {
           
        }
    }
}
