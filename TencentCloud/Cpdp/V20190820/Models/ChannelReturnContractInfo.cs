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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelReturnContractInfo : AbstractModel
    {
        
        /// <summary>
        /// 平台合约状态
        /// 协议状态，枚举值：
        /// CONTRACT_STATUS_SIGNED：已签约
        /// CONTRACT_STATUS_TERMINATED：未签约
        /// CONTRACT_STATUS_PENDING：签约进行中
        /// </summary>
        [JsonProperty("ContractStatus")]
        public string ContractStatus{ get; set; }

        /// <summary>
        /// 米大师内部存放的合约信息
        /// </summary>
        [JsonProperty("ChannelContractInfo")]
        public ChannelContractInfo ChannelContractInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContractStatus", this.ContractStatus);
            this.SetParamObj(map, prefix + "ChannelContractInfo.", this.ChannelContractInfo);
        }
    }
}

