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

    public class GetInvokeTxRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，固定字段：transaction
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，固定字段：query_txid
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 区块链网络ID，可在区块链网络详情或列表中获取
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 业务所属通道名称，可在通道详情或列表中获取
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 执行该查询交易的节点名称，可以在通道详情中获取该通道上的节点名称极其所属组织名称
        /// </summary>
        [JsonProperty("PeerName")]
        public string PeerName{ get; set; }

        /// <summary>
        /// 执行该查询交易的节点所属组织名称，可以在通道详情中获取该通道上的节点名称极其所属组织名称
        /// </summary>
        [JsonProperty("PeerGroup")]
        public string PeerGroup{ get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty("TxId")]
        public string TxId{ get; set; }

        /// <summary>
        /// 调用合约的组织名称，可以在组织管理列表中获取当前组织的名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PeerName", this.PeerName);
            this.SetParamSimple(map, prefix + "PeerGroup", this.PeerGroup);
            this.SetParamSimple(map, prefix + "TxId", this.TxId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
        }
    }
}

