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

    public class GetChaincodeLogForUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，本接口取值：chaincode_mng
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，本接口取值：chaincode_log_for_user
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 区块链网络ID，可在区块链网络详情或列表中获取
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 调用合约的组织名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 业务所属智能合约名称
        /// </summary>
        [JsonProperty("ChaincodeName")]
        public string ChaincodeName{ get; set; }

        /// <summary>
        /// 业务所属智能合约版本
        /// </summary>
        [JsonProperty("ChaincodeVersion")]
        public string ChaincodeVersion{ get; set; }

        /// <summary>
        /// 合约安装节点名称，可以在通道详情中获取该通道上的节点名称
        /// </summary>
        [JsonProperty("PeerName")]
        public string PeerName{ get; set; }

        /// <summary>
        /// 日志开始时间，如"2020-11-24 19:49:25"
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 返回日志行数的最大值，系统设定该参数最大为1000，且一行日志的最大字节数是500，即最大返回50万个字节数的日志数据
        /// </summary>
        [JsonProperty("RowNum")]
        public long? RowNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ChaincodeName", this.ChaincodeName);
            this.SetParamSimple(map, prefix + "ChaincodeVersion", this.ChaincodeVersion);
            this.SetParamSimple(map, prefix + "PeerName", this.PeerName);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "RowNum", this.RowNum);
        }
    }
}

