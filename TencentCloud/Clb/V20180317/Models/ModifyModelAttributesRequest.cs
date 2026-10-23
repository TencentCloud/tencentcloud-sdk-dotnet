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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyModelAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>BYOK的ID</p><p>参数格式：byok-kot39u7j</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>BYOK的自定义名字</p><p>入参限制：1～255个字符</p>
        /// </summary>
        [JsonProperty("ServiceProviderName")]
        public string ServiceProviderName{ get; set; }

        /// <summary>
        /// <p>多协议 Api Base URL</p>
        /// </summary>
        [JsonProperty("ApiBases")]
        public ApiBaseItem[] ApiBases{ get; set; }

        /// <summary>
        /// <p>非chat输出模态的Api Base URL</p>
        /// </summary>
        [JsonProperty("ApiBase")]
        public string ApiBase{ get; set; }

        /// <summary>
        /// <p>非chat输出模态的请求后缀</p>
        /// </summary>
        [JsonProperty("EndpointPath")]
        public string EndpointPath{ get; set; }

        /// <summary>
        /// <p>所属厂商</p>
        /// </summary>
        [JsonProperty("ModelProvider")]
        public string ModelProvider{ get; set; }

        /// <summary>
        /// <p>协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>所使用的CMR 私网管道 ID</p>
        /// </summary>
        [JsonProperty("CMRPrivateNetworkTunnelId")]
        public string CMRPrivateNetworkTunnelId{ get; set; }

        /// <summary>
        /// <p>携带的Host Header</p>
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// <p>是否需要进行ssl校验</p>
        /// </summary>
        [JsonProperty("VerifySSL")]
        public bool? VerifySSL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "ServiceProviderName", this.ServiceProviderName);
            this.SetParamArrayObj(map, prefix + "ApiBases.", this.ApiBases);
            this.SetParamSimple(map, prefix + "ApiBase", this.ApiBase);
            this.SetParamSimple(map, prefix + "EndpointPath", this.EndpointPath);
            this.SetParamSimple(map, prefix + "ModelProvider", this.ModelProvider);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "CMRPrivateNetworkTunnelId", this.CMRPrivateNetworkTunnelId);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
            this.SetParamSimple(map, prefix + "VerifySSL", this.VerifySSL);
        }
    }
}

