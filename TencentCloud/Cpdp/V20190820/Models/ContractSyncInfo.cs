/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class ContractSyncInfo : AbstractModel
    {
        
        /// <summary>
        /// 第三方渠道合约信息
        /// </summary>
        [JsonProperty("ExternalReturnContractInfo")]
        public ExternalReturnContractInfo ExternalReturnContractInfo{ get; set; }

        /// <summary>
        /// 第三方渠道用户信息
        /// </summary>
        [JsonProperty("ExternalContractUserInfo")]
        public ExternalContractUserInfo[] ExternalContractUserInfo{ get; set; }

        /// <summary>
        /// 签约方式，枚举值，
        /// <br/>CONTRACT_METHOD_WECHAT_INVALID: 无效
        /// CONTRACT_METHOD_WECHAT_APP: 微信APP
        /// CONTRACT_METHOD_WECHAT_PUBLIC: 微信公众号
        /// CONTRACT_METHOD_WECHAT_MINIPROGRAM: 微信小程序
        /// CONTRACT_METHOD_WECHAT_H5: 微信H5
        /// </summary>
        [JsonProperty("ContractMethod")]
        public string ContractMethod{ get; set; }

        /// <summary>
        /// 在米大师侧分配的场景id
        /// </summary>
        [JsonProperty("ContractSceneId")]
        public string ContractSceneId{ get; set; }

        /// <summary>
        /// 调用方从第三方渠道查询到的签约数据，由各个渠道定义
        /// </summary>
        [JsonProperty("ExternalReturnContractData")]
        public string ExternalReturnContractData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ExternalReturnContractInfo.", this.ExternalReturnContractInfo);
            this.SetParamArrayObj(map, prefix + "ExternalContractUserInfo.", this.ExternalContractUserInfo);
            this.SetParamSimple(map, prefix + "ContractMethod", this.ContractMethod);
            this.SetParamSimple(map, prefix + "ContractSceneId", this.ContractSceneId);
            this.SetParamSimple(map, prefix + "ExternalReturnContractData", this.ExternalReturnContractData);
        }
    }
}

