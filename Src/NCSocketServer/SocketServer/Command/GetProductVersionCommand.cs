﻿// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Alachisoft.NCache.SocketServer.Command
{
    class GetProductVersionCommand : CommandBase
    {
        private struct CommandInfo
        {
            public string RequestId;
            public string UserName;
            public string Password;
        }

        public override void ExecuteCommand(ClientManager clientManager, Common.Protobuf.Command command)
        {
            CommandInfo cmdInfo;
            try
            {
                cmdInfo = ParseCommand(command, clientManager);
            }
            catch (Exception exc)
            {
                if (!base.immatureId.Equals("-2"))
                    _serializedResponsePackets.Add(Alachisoft.NCache.Common.Util.ResponseHelper.SerializeExceptionResponse(exc, command.requestID, command.commandID));
                return;
            }
            try
            {
                Alachisoft.NCache.Common.ProductVersion _currentVersion = Alachisoft.NCache.Common.ProductVersion.ProductInfo;
                Alachisoft.NCache.Common.Protobuf.Response response = new Alachisoft.NCache.Common.Protobuf.Response();
                Alachisoft.NCache.Common.Protobuf.GetProductVersionResponse getProductVersionResponse = new Alachisoft.NCache.Common.Protobuf.GetProductVersionResponse();

                getProductVersionResponse.productVersion.AddiotionalData = _currentVersion.AdditionalData;
                getProductVersionResponse.productVersion.EditionID = _currentVersion.EditionID;

                getProductVersionResponse.productVersion.MajorVersion1 = this.ParseToByteArray(_currentVersion.MajorVersion1);
                getProductVersionResponse.productVersion.MajorVersion2 = this.ParseToByteArray(_currentVersion.MajorVersion2);
                getProductVersionResponse.productVersion.MinorVersion1 = this.ParseToByteArray(_currentVersion.MinorVersion1);
                getProductVersionResponse.productVersion.MinorVersion2 = this.ParseToByteArray(_currentVersion.MinorVersion2);
                getProductVersionResponse.productVersion.ProductName = _currentVersion.ProductName;

                response.requestId = Convert.ToInt64(cmdInfo.RequestId);
                response.commandID = command.commandID;
                response.getProductVersionResponse = getProductVersionResponse;
                response.responseType = Common.Protobuf.Response.Type.GET_PRODUCT_VERSION;
                _serializedResponsePackets.Add(Alachisoft.NCache.Common.Util.ResponseHelper.SerializeResponse(response));
            }
            catch (Exception exc)
            {
                _serializedResponsePackets.Add(Alachisoft.NCache.Common.Util.ResponseHelper.SerializeExceptionResponse(exc, command.requestID, command.commandID));
            }
        }

        private CommandInfo ParseCommand(Alachisoft.NCache.Common.Protobuf.Command command, ClientManager clientManager)
        {
            CommandInfo cmdInfo = new CommandInfo();

            Alachisoft.NCache.Common.Protobuf.GetProductVersionCommand getProductVersionCommand = command.getProductVersionCommand;
            
            cmdInfo.Password = getProductVersionCommand.pwd;
            cmdInfo.RequestId = getProductVersionCommand.requestId.ToString();
            cmdInfo.UserName = getProductVersionCommand.userId;
           
            return cmdInfo;
        }

        #region Helper Methods
        // This function is needed to parse byte to byte[] because all values in protobuf.ProductVersion are byte[]
        private byte[] ParseToByteArray(byte value)
        {
            byte[] tempArray = new byte[1];
            tempArray[0] = value;
            return tempArray;
        }
        #endregion
    }
}
