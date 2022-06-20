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

    public class InvokeChainMakerDemoContractRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络ID，可在区块链网络详情或列表中获取
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 业务链编号，可在业务链列表中获取
        /// </summary>
        [JsonProperty("ChainId")]
        public string ChainId{ get; set; }

        /// <summary>
        /// 合约名称，可在合约管理中获取
        /// </summary>
        [JsonProperty("ContractName")]
        public string ContractName{ get; set; }

        /// <summary>
        /// 合约方法名
        /// </summary>
        [JsonProperty("FuncName")]
        public string FuncName{ get; set; }

        /// <summary>
        /// 合约方法入参，json格式字符串，key/value都是string类型的map
        /// </summary>
        [JsonProperty("FuncParam")]
        public string FuncParam{ get; set; }

        /// <summary>
        /// 是否异步执行，1为是，否则为0；如果异步执行，可使用返回值中的交易TxID查询执行结果
        /// </summary>
        [JsonProperty("AsyncFlag")]
        public long? AsyncFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "ContractName", this.ContractName);
            this.SetParamSimple(map, prefix + "FuncName", this.FuncName);
            this.SetParamSimple(map, prefix + "FuncParam", this.FuncParam);
            this.SetParamSimple(map, prefix + "AsyncFlag", this.AsyncFlag);
        }
    }
}

