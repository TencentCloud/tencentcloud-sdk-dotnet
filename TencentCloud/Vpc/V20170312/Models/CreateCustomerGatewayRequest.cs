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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomerGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 对端网关名称，可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("CustomerGatewayName")]
        public string CustomerGatewayName{ get; set; }

        /// <summary>
        /// 对端网关公网IP。
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// BGP ASN。ASN取值范围为1- 4294967295，其中139341、45090和58835不可用。
        /// </summary>
        [JsonProperty("BgpAsn")]
        public long? BgpAsn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerGatewayName", this.CustomerGatewayName);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "BgpAsn", this.BgpAsn);
        }
    }
}

