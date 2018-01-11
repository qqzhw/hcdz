using Hcdz.Communication.Scs.Communication;
using Hcdz.Communication.Scs.Communication.Messengers;

namespace Hcdz.Communication.Scs.Client
{
    /// <summary>
    /// Represents a client to connect to server.
    /// </summary>
    public interface IScsClient : IMessenger, IConnectableClient
    {
        //Does not define any additional member
    }
}
