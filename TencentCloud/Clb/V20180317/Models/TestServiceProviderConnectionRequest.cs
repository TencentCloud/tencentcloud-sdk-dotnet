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

    public class TestServiceProviderConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要探测的模型列表</p><p>入参限制：上限为20个模型</p>
        /// </summary>
        [JsonProperty("Models")]
        public string[] Models{ get; set; }

        /// <summary>
        /// <p>需要探测的Key</p>
        /// </summary>
        [JsonProperty("ProviderKey")]
        public string ProviderKey{ get; set; }

        /// <summary>
        /// <p>需要探测的KeyId，和ProviderKey二者传一个即可</p>
        /// </summary>
        [JsonProperty("ProviderKeyId")]
        public string ProviderKeyId{ get; set; }

        /// <summary>
        /// <p>BYOK类型，当ProviderKey存在时必传</p>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>模型的厂商</p>
        /// </summary>
        [JsonProperty("ModelProvider")]
        public string ModelProvider{ get; set; }

        /// <summary>
        /// <p>模型厂商协议，当ProviderKey存在时必传</p>
        /// </summary>
        [JsonProperty("ModelProtocol")]
        public string ModelProtocol{ get; set; }

        /// <summary>
        /// <p>BYOK类型，当AccessType为PublicCustom时生效</p>
        /// </summary>
        [JsonProperty("ApiBase")]
        public string ApiBase{ get; set; }

        /// <summary>
        /// <p>请求携带的Host头部，当AccessType为PrivateCustom时生效</p>
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// <p>BYOK的ID，当AccessType为PrivateCustom时生效</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>是否校验服务提供商的SSL证书</p><p>默认值：AccessType取值为：</p><ul><li>PublicBYOK时，该参数无效；</li><li>PublicCustom时，该参数默认为true；</li><li>PrivateCustom时，该参数默认为false；</li></ul>
        /// </summary>
        [JsonProperty("VerifySSL")]
        public bool? VerifySSL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Models.", this.Models);
            this.SetParamSimple(map, prefix + "ProviderKey", this.ProviderKey);
            this.SetParamSimple(map, prefix + "ProviderKeyId", this.ProviderKeyId);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "ModelProvider", this.ModelProvider);
            this.SetParamSimple(map, prefix + "ModelProtocol", this.ModelProtocol);
            this.SetParamSimple(map, prefix + "ApiBase", this.ApiBase);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "VerifySSL", this.VerifySSL);
        }
    }
}

