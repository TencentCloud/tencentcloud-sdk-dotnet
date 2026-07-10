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

    public class CreateModelRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>接入类型：PublicBYOK/PublicCustom/PrivateCustom</p>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>模型提供商</p>
        /// </summary>
        [JsonProperty("ModelProvider")]
        public string ModelProvider{ get; set; }

        /// <summary>
        /// <p>通用模型标识列表</p>
        /// </summary>
        [JsonProperty("ModelIds")]
        public ModelItem[] ModelIds{ get; set; }

        /// <summary>
        /// <p>Key 列表</p>
        /// </summary>
        [JsonProperty("Keys")]
        public KeyItem[] Keys{ get; set; }

        /// <summary>
        /// <p>BYOK ID(在自定义模型时在部署网络后必须填写)</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>服务供应商(创建BYOK自定义名称)。</p>
        /// </summary>
        [JsonProperty("ServiceProviderName")]
        public string ServiceProviderName{ get; set; }

        /// <summary>
        /// <p>模型协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>API Base URL</p>
        /// </summary>
        [JsonProperty("ApiBase")]
        public string ApiBase{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>转发请求时添加的Host请求头</p>
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// <p>标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>是否校验服务提供商的SSL证书</p>
        /// </summary>
        [JsonProperty("VerifySSL")]
        public bool? VerifySSL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "ModelProvider", this.ModelProvider);
            this.SetParamArrayObj(map, prefix + "ModelIds.", this.ModelIds);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "ServiceProviderName", this.ServiceProviderName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ApiBase", this.ApiBase);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VerifySSL", this.VerifySSL);
        }
    }
}

