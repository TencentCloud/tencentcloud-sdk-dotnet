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

    public class InvokeRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，固定字段：transaction
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，固定字段：invoke
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 区块链网络ID，可在区块链网络详情或列表中获取
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 业务所属智能合约名称，可在智能合约详情或列表中获取
        /// </summary>
        [JsonProperty("ChaincodeName")]
        public string ChaincodeName{ get; set; }

        /// <summary>
        /// 业务所属通道名称，可在通道详情或列表中获取
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 对该笔交易进行背书的节点列表（包括节点名称和节点所属组织名称，详见数据结构一节），可以在通道详情中获取该通道上的节点名称极其所属组织名称
        /// </summary>
        [JsonProperty("Peers")]
        public PeerSet[] Peers{ get; set; }

        /// <summary>
        /// 该笔交易需要调用的智能合约中的函数名称
        /// </summary>
        [JsonProperty("FuncName")]
        public string FuncName{ get; set; }

        /// <summary>
        /// 调用合约的组织名称，可以在组织管理列表中获取当前组织的名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 被调用的函数参数列表
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// 同步调用标识，可选参数，值为0或者不传表示使用同步方法调用，调用后会等待交易执行后再返回执行结果；值为1时表示使用异步方式调用Invoke，执行后会立即返回交易对应的Txid，后续需要通过GetInvokeTx这个API查询该交易的执行结果。（对于逻辑较为简单的交易，可以使用同步模式；对于逻辑较为复杂的交易，建议使用异步模式，否则容易导致API因等待时间过长，返回等待超时）
        /// </summary>
        [JsonProperty("AsyncFlag")]
        public ulong? AsyncFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ChaincodeName", this.ChaincodeName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArrayObj(map, prefix + "Peers.", this.Peers);
            this.SetParamSimple(map, prefix + "FuncName", this.FuncName);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "AsyncFlag", this.AsyncFlag);
        }
    }
}

