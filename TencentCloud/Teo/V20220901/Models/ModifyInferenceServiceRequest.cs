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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInferenceServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>推理服务 ID。</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>模型服务需要监听的端口。仅支持 1-65535 之间的整数。</p>
        /// </summary>
        [JsonProperty("ListenPort")]
        public long? ListenPort{ get; set; }

        /// <summary>
        /// <p>推理服务的请求路径列表。最多支持 20 个路径。</p>
        /// </summary>
        [JsonProperty("RequestPaths")]
        public string[] RequestPaths{ get; set; }

        /// <summary>
        /// <p>推理服务的容器配置。当前仅支持设置 1 个容器。</p>
        /// </summary>
        [JsonProperty("Containers")]
        public InferenceContainerConfigForModify[] Containers{ get; set; }

        /// <summary>
        /// <p>推理服务的资源配置。</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public InferenceResourceConfigForModify ResourceConfig{ get; set; }

        /// <summary>
        /// <p>描述信息。长度限制不超过 60 个字符。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ListenPort", this.ListenPort);
            this.SetParamArraySimple(map, prefix + "RequestPaths.", this.RequestPaths);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

