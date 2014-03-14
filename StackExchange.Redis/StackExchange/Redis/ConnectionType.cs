﻿namespace StackExchange.Redis
{
    /// <summary>
    /// The type of a connection
    /// </summary>
    public enum ConnectionType
    {
        /// <summary>
        /// An interactive connection handles request/response commands for accessing data on demand
        /// </summary>
        Interactive = 0,
        /// <summary>
        /// A subscriber connection recieves unsolicted messages from the server as pub/sub events occur
        /// </summary>
        Subscription = 1
    }
}
