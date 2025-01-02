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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名，不支持泛域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 协议，取值范围：HTTP, HTTPS, HTTP&HTTPS
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 路由配置
        /// </summary>
        [JsonProperty("EndpointsConfig")]
        public EndpointsConf[] EndpointsConfig{ get; set; }

        /// <summary>
        /// 证书配置信息，有使用HTTPS协议时候必须传
        /// </summary>
        [JsonProperty("CertConfig")]
        public CertConf CertConfig{ get; set; }

        /// <summary>
        /// web 应用防火墙配置
        /// </summary>
        [JsonProperty("WafConfig")]
        public WafConf WafConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "EndpointsConfig.", this.EndpointsConfig);
            this.SetParamObj(map, prefix + "CertConfig.", this.CertConfig);
            this.SetParamObj(map, prefix + "WafConfig.", this.WafConfig);
        }
    }
}

