﻿using Hcdz.Communication.Scs.Communication.Protocols.BinarySerialization;

namespace Hcdz.Communication.Scs.Communication.Protocols
{
    /// <summary>
    /// This class is used to get default protocols.
    /// </summary>
    internal static class WireProtocolManager
    {
        /// <summary>
        /// Creates a default wire protocol factory object to be used on communicating of applications.
        /// </summary>
        /// <returns>A new instance of default wire protocol</returns>
        public static IScsWireProtocolFactory GetDefaultWireProtocolFactory()
        {
            return new BinarySerializationProtocolFactory();
        }

        /// <summary>
        /// Creates a default wire protocol object to be used on communicating of applications.
        /// </summary>
        /// <returns>A new instance of default wire protocol</returns>
        public static IScsWireProtocol GetDefaultWireProtocol()
        {
            return new BinarySerializationProtocol();
        }
        public static IScsWireProtocol GetTextWireProtocol()
        {
            return new TextWireProtocol();
        }
        public static IScsWireProtocol GetRawDataWireProtocol()
        {
            return new RawDataWireProtocol();
        }
    }
}
