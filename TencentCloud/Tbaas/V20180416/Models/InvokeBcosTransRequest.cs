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

    public class InvokeBcosTransRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络ID，可在区块链网络详情或列表中获取
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 群组编号，可在群组列表中获取
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 合约地址，可在合约详情获取
        /// </summary>
        [JsonProperty("ContractAddress")]
        public string ContractAddress{ get; set; }

        /// <summary>
        /// 合约Abi的json数组格式的字符串，可在合约详情获取
        /// </summary>
        [JsonProperty("AbiInfo")]
        public string AbiInfo{ get; set; }

        /// <summary>
        /// 合约方法名
        /// </summary>
        [JsonProperty("FuncName")]
        public string FuncName{ get; set; }

        /// <summary>
        /// 签名用户编号，可在私钥管理页面获取
        /// </summary>
        [JsonProperty("SignUserId")]
        public string SignUserId{ get; set; }

        /// <summary>
        /// 合约方法入参，json格式字符串
        /// </summary>
        [JsonProperty("FuncParam")]
        public string FuncParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ContractAddress", this.ContractAddress);
            this.SetParamSimple(map, prefix + "AbiInfo", this.AbiInfo);
            this.SetParamSimple(map, prefix + "FuncName", this.FuncName);
            this.SetParamSimple(map, prefix + "SignUserId", this.SignUserId);
            this.SetParamSimple(map, prefix + "FuncParam", this.FuncParam);
        }
    }
}

