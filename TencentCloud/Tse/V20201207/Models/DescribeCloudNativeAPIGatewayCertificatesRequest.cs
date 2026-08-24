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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewayCertificatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>列表数量</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>列表offset</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>过滤条件，多个过滤条件之间是与的关系，支持BindDomain ，Name</p>
        /// </summary>
        [JsonProperty("Filters")]
        public ListFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>证书类型</p><p>枚举值：</p><ul><li>SVR： 服务证书</li><li>CA： CA证书</li></ul>
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// <p>证书用途</p><p>枚举值：</p><ul><li>SERVER： 用作服务端证书</li><li>CLIENT： 用作客户端证书</li></ul>
        /// </summary>
        [JsonProperty("CertUsage")]
        public string CertUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "CertUsage", this.CertUsage);
        }
    }
}

