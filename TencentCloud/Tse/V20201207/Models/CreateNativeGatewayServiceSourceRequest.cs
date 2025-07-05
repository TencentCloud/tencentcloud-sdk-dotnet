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

    public class CreateNativeGatewayServiceSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关实例ID
        /// </summary>
        [JsonProperty("GatewayID")]
        public string GatewayID{ get; set; }

        /// <summary>
        /// 服务来源类型，参考值：
        /// - TSE-Nacos 
        /// - TSE-Consul 
        /// - TSE-PolarisMesh
        /// - Customer-Nacos
        /// - Customer-Consul
        /// - Customer-PolarisMesh
        /// - TSF
        /// - TKE
        /// - EKS
        /// - PrivateDNS
        /// - Customer-DNS
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 服务来源实例ID，当SourceType的值不为PrivateDNS或Customer-DNS时，必填
        /// </summary>
        [JsonProperty("SourceID")]
        public string SourceID{ get; set; }

        /// <summary>
        /// 服务来源实例名称，当SourceType的值不为PrivateDNS时，必填
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 服务来源实例额外信息
        /// </summary>
        [JsonProperty("SourceInfo")]
        public SourceInfo SourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayID", this.GatewayID);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceID", this.SourceID);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamObj(map, prefix + "SourceInfo.", this.SourceInfo);
        }
    }
}

