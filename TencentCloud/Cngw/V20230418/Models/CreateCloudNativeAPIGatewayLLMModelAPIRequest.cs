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

namespace TencentCloud.Cngw.V20230418.Models
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
        /// <p>模型 API 名称，最长 60 字符。同一网关下唯一。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>业务场景。</p><p>枚举值：</p><ul><li>Chat：聊天</li><li>Image：图像（需要网关版本 ≥ 3.9.3）</li></ul>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>请求协议（小写）。当前仅支持：</p><ul><li>openai</li></ul>
        /// </summary>
        [JsonProperty("RequestProtocol")]
        public string RequestProtocol{ get; set; }

        /// <summary>
        /// <p>关联的模型服务 ID 列表，长度 1-10。</p><p>注：字段名建议改为 ModelServiceIds，当前保留用于兼容。</p>
        /// </summary>
        [JsonProperty("ListModelServiceId")]
        public string[] ListModelServiceId{ get; set; }

        /// <summary>
        /// <p>路由列表，至少 1 条。每条包含 Methods/Paths/Hosts 等 Kong 路由属性。</p>
        /// </summary>
        [JsonProperty("RouteList")]
        public DefaultKongRoute[] RouteList{ get; set; }

        /// <summary>
        /// <p>统一前缀路径（可选）。例如 /v1/openai。</p>
        /// </summary>
        [JsonProperty("BasePath")]
        public string BasePath{ get; set; }

        /// <summary>
        /// <p>模型 API 描述。最长 200 字符。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>多模型服务路由策略。ListModelServiceId 多于 1 项时必填。</p>
        /// </summary>
        [JsonProperty("ModelServiceRoute")]
        public CloudNativeAPIGatewayLLMModelServiceRoute ModelServiceRoute{ get; set; }

        /// <summary>
        /// <p>Header 路由匹配规则。当前仅支持 Operator=exact。</p>
        /// </summary>
        [JsonProperty("MatchHeaders")]
        public AIGWKVMatch[] MatchHeaders{ get; set; }

        /// <summary>
        /// <p>是否启用跨服务 Fallback。开启后需提供 CrossServiceFallbackConfig。</p>
        /// </summary>
        [JsonProperty("EnableCrossServiceFallback")]
        public bool? EnableCrossServiceFallback{ get; set; }

        /// <summary>
        /// <p>跨服务 Fallback 配置。EnableCrossServiceFallback=true 时必填。</p>
        /// </summary>
        [JsonProperty("CrossServiceFallbackConfig")]
        public AIGWCrossServiceFallbackConfig CrossServiceFallbackConfig{ get; set; }

        /// <summary>
        /// <p>标签过滤策略。需要网关版本 ≥ 3.9.4。</p>
        /// </summary>
        [JsonProperty("TagFilter")]
        public AIGWTagFilter TagFilter{ get; set; }

        /// <summary>
        /// <p>日志输出配置（请求/响应 payload 落 LLM Log）。需要网关版本 ≥ 3.9.4。</p>
        /// </summary>
        [JsonProperty("LogConfig")]
        public AIGWLogConfig LogConfig{ get; set; }


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
            this.SetParamObj(map, prefix + "TagFilter.", this.TagFilter);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
        }
    }
}

