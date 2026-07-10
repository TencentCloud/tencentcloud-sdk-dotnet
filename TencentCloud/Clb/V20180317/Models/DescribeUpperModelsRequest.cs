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

    public class DescribeUpperModelsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>接入类型：PublicBYOK/PublicCustom/PrivateCustom</p>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>上游 Provider API 地址</p><p>示例：https://api.moonshot.cn</p>
        /// </summary>
        [JsonProperty("ApiBase")]
        public string ApiBase{ get; set; }

        /// <summary>
        /// <p>上游 Provider API Key</p><p>用于鉴权访问上游模型列表接口</p>
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// <p>自定义 Host Header，可选</p><p>仅 VPC 内网场景需要，用于指定请求的 Host 头</p>
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// <p>Key Id 配合ServiceProviderId一同输入，不指定则默认选用最近创建的Key</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>模型列表端点路径，可选</p><p>默认值：/v1/models</p>
        /// </summary>
        [JsonProperty("ModelPath")]
        public string ModelPath{ get; set; }

        /// <summary>
        /// <p>模型协议</p>
        /// </summary>
        [JsonProperty("ModelProtocol")]
        public string ModelProtocol{ get; set; }

        /// <summary>
        /// <p>模型提供商</p>
        /// </summary>
        [JsonProperty("ModelProvider")]
        public string ModelProvider{ get; set; }

        /// <summary>
        /// <p>BYOK 业务 ID，可选</p><p>格式：byok-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "ApiBase", this.ApiBase);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "ModelPath", this.ModelPath);
            this.SetParamSimple(map, prefix + "ModelProtocol", this.ModelProtocol);
            this.SetParamSimple(map, prefix + "ModelProvider", this.ModelProvider);
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
        }
    }
}

