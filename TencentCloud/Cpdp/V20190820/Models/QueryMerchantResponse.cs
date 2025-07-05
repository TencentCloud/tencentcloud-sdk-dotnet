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

    public class QueryMerchantResponse : AbstractModel
    {
        
        /// <summary>
        /// 分配给商户的 AppId，该 AppId 为后续各项 交易的商户标识。
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 收款商户名称。
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// B2B 支付标志。是否开通 B2B 支付， 1:开通 0:不开通。
        /// </summary>
        [JsonProperty("BusinessPayFlag")]
        public string BusinessPayFlag{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "BusinessPayFlag", this.BusinessPayFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

