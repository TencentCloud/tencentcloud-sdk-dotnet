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

    public class CreateCloudNativeAPIGatewayLLMModelAPIRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关 id。</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>AI 网关 LLM 模型 API 的唯一标识名称，格式规则：最长60个字符，支持中英文大小写、数字及分隔符（“-”、“_”)，不能以数字和分隔符开头，不能以分隔符结尾。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>选择业务场景,  选项：Chat（聊天）。</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>业务场景对应的请求协议，选项：OpenAI（目前只支持 OpenAI）。</p>
        /// </summary>
        [JsonProperty("RequestProtocol")]
        public string RequestProtocol{ get; set; }

        /// <summary>
        /// <p>初始化关联的模型服务列表。</p>
        /// </summary>
        [JsonProperty("ListModelServiceId")]
        public string[] ListModelServiceId{ get; set; }

        /// <summary>
        /// <p>路由列表</p>
        /// </summary>
        [JsonProperty("RouteList")]
        public DefaultKongRoute[] RouteList{ get; set; }

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
        /// <p>模型服务路由策略（是指如何路由到模型服务）</p>
        /// </summary>
        [JsonProperty("ModelServiceRoute")]
        public CloudNativeAPIGatewayLLMModelServiceRoute ModelServiceRoute{ get; set; }

        /// <summary>
        /// <p>路由 Header 匹配规则</p>
        /// </summary>
        [JsonProperty("MatchHeaders")]
        public AIGWKVMatch[] MatchHeaders{ get; set; }

        /// <summary>
        /// <p>跨服务 fallback 开关</p>
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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "RequestProtocol", this.RequestProtocol);
            this.SetParamArraySimple(map, prefix + "ListModelServiceId.", this.ListModelServiceId);
            this.SetParamArrayObj(map, prefix + "RouteList.", this.RouteList);
            this.SetParamSimple(map, prefix + "BasePath", this.BasePath);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "ModelServiceRoute.", this.ModelServiceRoute);
            this.SetParamArrayObj(map, prefix + "MatchHeaders.", this.MatchHeaders);
            this.SetParamSimple(map, prefix + "EnableCrossServiceFallback", this.EnableCrossServiceFallback);
            this.SetParamObj(map, prefix + "CrossServiceFallbackConfig.", this.CrossServiceFallbackConfig);
        }
    }
}

