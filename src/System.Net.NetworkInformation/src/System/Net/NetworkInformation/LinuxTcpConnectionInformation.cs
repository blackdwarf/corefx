﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Net.NetworkInformation
{
    // This class is not Linux-specific. It is just a data container.
    // TODO: Combine this with SystemTcpConnection. Make Windows construct that object differently.
    internal class LinuxTcpConnectionInformation : TcpConnectionInformation
    {
        private IPEndPoint _localEndPoint;
        private IPEndPoint _remoteEndPoint;
        private TcpState _state;

        public LinuxTcpConnectionInformation(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, TcpState state)
        {
            _localEndPoint = localEndPoint;
            _remoteEndPoint = remoteEndPoint;
            _state = state;
        }

        public override IPEndPoint LocalEndPoint { get { return _localEndPoint; } }

        public override IPEndPoint RemoteEndPoint { get { return _remoteEndPoint; } }

        public override TcpState State { get { return _state; } }
    }
}