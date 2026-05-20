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

    public class ModifyCloudNativeAPIGatewayLLMModelAPIRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关 id。</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>模型 API ID，全局唯一标识。</p>
        /// </summary>
        [JsonProperty("ModelAPIId")]
        public string ModelAPIId{ get; set; }

        /// <summary>
        /// <p>修改模型 API 名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>为API设置统一的前缀，格式：以/开头，支持字母、数字、短横线。</p>
        /// </summary>
        [JsonProperty("BasePath")]
        public string BasePath{ get; set; }

        /// <summary>
        /// <p>模型 API 的相关描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>关联的模型服务列表（支持填多个模型服务）</p>
        /// </summary>
        [JsonProperty("ListModelServiceId")]
        public string[] ListModelServiceId{ get; set; }

        /// <summary>
        /// <p>模型服务路由策略（是指如何路由到模型服务）</p>
        /// </summary>
        [JsonProperty("ModelServiceRoute")]
        public CloudNativeAPIGatewayLLMModelServiceRoute ModelServiceRoute{ get; set; }

        /// <summary>
        /// <p>headers 路由匹配</p>
        /// </summary>
        [JsonProperty("MatchHeaders")]
        public AIGWKVMatch[] MatchHeaders{ get; set; }

        /// <summary>
        /// <p>跨服务 fallback</p>
        /// </summary>
        [JsonProperty("EnableCrossServiceFallback")]
        public bool? EnableCrossServiceFallback{ get; set; }

        /// <summary>
        /// <p>跨服务 fallback 配置</p>
        /// </summary>
        [JsonProperty("CrossServiceFallbackConfig")]
        public AIGWCrossServiceFallbackConfig CrossServiceFallbackConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ModelAPIId", this.ModelAPIId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BasePath", this.BasePath);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "ListModelServiceId.", this.ListModelServiceId);
            this.SetParamObj(map, prefix + "ModelServiceRoute.", this.ModelServiceRoute);
            this.SetParamArrayObj(map, prefix + "MatchHeaders.", this.MatchHeaders);
            this.SetParamSimple(map, prefix + "EnableCrossServiceFallback", this.EnableCrossServiceFallback);
            this.SetParamObj(map, prefix + "CrossServiceFallbackConfig.", this.CrossServiceFallbackConfig);
        }
    }
}

