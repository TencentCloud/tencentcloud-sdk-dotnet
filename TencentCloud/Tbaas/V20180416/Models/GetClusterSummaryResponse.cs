/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetClusterSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 网络通道总数量
        /// </summary>
        [JsonProperty("TotalChannelCount")]
        public ulong? TotalChannelCount{ get; set; }

        /// <summary>
        /// 当前组织创建的通道数量
        /// </summary>
        [JsonProperty("MyChannelCount")]
        public ulong? MyChannelCount{ get; set; }

        /// <summary>
        /// 当前组织加入的通道数量
        /// </summary>
        [JsonProperty("JoinChannelCount")]
        public ulong? JoinChannelCount{ get; set; }

        /// <summary>
        /// 网络节点总数量
        /// </summary>
        [JsonProperty("TotalPeerCount")]
        public ulong? TotalPeerCount{ get; set; }

        /// <summary>
        /// 当前组织创建的节点数量
        /// </summary>
        [JsonProperty("MyPeerCount")]
        public ulong? MyPeerCount{ get; set; }

        /// <summary>
        /// 其他组织创建的节点数量
        /// </summary>
        [JsonProperty("OrderCount")]
        public ulong? OrderCount{ get; set; }

        /// <summary>
        /// 网络组织总数量
        /// </summary>
        [JsonProperty("TotalGroupCount")]
        public ulong? TotalGroupCount{ get; set; }

        /// <summary>
        /// 当前组织创建的组织数量
        /// </summary>
        [JsonProperty("MyGroupCount")]
        public ulong? MyGroupCount{ get; set; }

        /// <summary>
        /// 网络智能合约总数量
        /// </summary>
        [JsonProperty("TotalChaincodeCount")]
        public ulong? TotalChaincodeCount{ get; set; }

        /// <summary>
        /// 最近7天发起的智能合约数量
        /// </summary>
        [JsonProperty("RecentChaincodeCount")]
        public ulong? RecentChaincodeCount{ get; set; }

        /// <summary>
        /// 当前组织发起的智能合约数量
        /// </summary>
        [JsonProperty("MyChaincodeCount")]
        public ulong? MyChaincodeCount{ get; set; }

        /// <summary>
        /// 当前组织的证书总数量
        /// </summary>
        [JsonProperty("TotalCertCount")]
        public ulong? TotalCertCount{ get; set; }

        /// <summary>
        /// 颁发给当前组织的证书数量
        /// </summary>
        [JsonProperty("TlsCertCount")]
        public ulong? TlsCertCount{ get; set; }

        /// <summary>
        /// 网络背书节点证书数量
        /// </summary>
        [JsonProperty("PeerCertCount")]
        public ulong? PeerCertCount{ get; set; }

        /// <summary>
        /// 当前组织业务证书数量
        /// </summary>
        [JsonProperty("ClientCertCount")]
        public ulong? ClientCertCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalChannelCount", this.TotalChannelCount);
            this.SetParamSimple(map, prefix + "MyChannelCount", this.MyChannelCount);
            this.SetParamSimple(map, prefix + "JoinChannelCount", this.JoinChannelCount);
            this.SetParamSimple(map, prefix + "TotalPeerCount", this.TotalPeerCount);
            this.SetParamSimple(map, prefix + "MyPeerCount", this.MyPeerCount);
            this.SetParamSimple(map, prefix + "OrderCount", this.OrderCount);
            this.SetParamSimple(map, prefix + "TotalGroupCount", this.TotalGroupCount);
            this.SetParamSimple(map, prefix + "MyGroupCount", this.MyGroupCount);
            this.SetParamSimple(map, prefix + "TotalChaincodeCount", this.TotalChaincodeCount);
            this.SetParamSimple(map, prefix + "RecentChaincodeCount", this.RecentChaincodeCount);
            this.SetParamSimple(map, prefix + "MyChaincodeCount", this.MyChaincodeCount);
            this.SetParamSimple(map, prefix + "TotalCertCount", this.TotalCertCount);
            this.SetParamSimple(map, prefix + "TlsCertCount", this.TlsCertCount);
            this.SetParamSimple(map, prefix + "PeerCertCount", this.PeerCertCount);
            this.SetParamSimple(map, prefix + "ClientCertCount", this.ClientCertCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

