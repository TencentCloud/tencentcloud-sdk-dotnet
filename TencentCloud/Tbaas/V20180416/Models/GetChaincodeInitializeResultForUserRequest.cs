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

    public class GetChaincodeInitializeResultForUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，本接口取值：chaincode_mng
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，本接口取值：chaincode_init_result_for_user
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
        /// 业务所属通道名称
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 业务所属合约名称
        /// </summary>
        [JsonProperty("ChaincodeName")]
        public string ChaincodeName{ get; set; }

        /// <summary>
        /// 业务所属智能合约版本
        /// </summary>
        [JsonProperty("ChaincodeVersion")]
        public string ChaincodeVersion{ get; set; }

        /// <summary>
        /// 实例化任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChaincodeName", this.ChaincodeName);
            this.SetParamSimple(map, prefix + "ChaincodeVersion", this.ChaincodeVersion);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

