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

    public class AIGWSensitiveWordRoute : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>命中敏感词后的候选模型服务 ID 列表。Enabled=true 时必填，成员不得为空或重复；数量受网关模型服务绑定配额限制。</p>
        /// </summary>
        [JsonProperty("ModelServiceRefs")]
        public string[] ModelServiceRefs{ get; set; }

        /// <summary>
        /// <p>与 ModelServiceRefs 一一对应的模型服务名称列表，仅由查询接口返回；不作为请求路由配置。</p>
        /// </summary>
        [JsonProperty("ModelServiceNames")]
        public string[] ModelServiceNames{ get; set; }

        /// <summary>
        /// <p>路由方法</p><p>枚举值：</p><ul><li>Weighted： 权重路由</li><li>ModelName： 按模型名称路由</li></ul>
        /// </summary>
        [JsonProperty("SelectedTypes")]
        public string[] SelectedTypes{ get; set; }

        /// <summary>
        /// <p>权重路由配置</p>
        /// </summary>
        [JsonProperty("WeightedConfig")]
        public CloudNativeAPIGatewayLLMModelServiceRouteWeightedStrategy[] WeightedConfig{ get; set; }

        /// <summary>
        /// <p>按请求模型名称匹配目标模型服务的路由配置，在 SelectedTypes=[ModelName] 时使用。</p>
        /// </summary>
        [JsonProperty("ModelNameConfig")]
        public CloudNativeAPIGatewayLLMModelServiceRouteModelNameStrategy[] ModelNameConfig{ get; set; }

        /// <summary>
        /// <p>敏感词路由单模型直选时的标准模型名称。仅在 Enabled=true、SelectedTypes 为空且 ModelServiceRefs 只有一个模型服务时可设置；使用 Weighted 或 ModelName 策略时应在相应配置条目中填写。仅对应 TIONE 模型服务时可配置。非空值最长 256 字节，支持中文、英文、数字、下划线和短横线，须以中文、英文或数字开头。同一网关内不同模型 API 不得使用相同的标准模型名称；同一模型 API 内同一模型服务在多处配置时须保持一致。</p>
        /// </summary>
        [JsonProperty("StandardModelName")]
        public string StandardModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "ModelServiceRefs.", this.ModelServiceRefs);
            this.SetParamArraySimple(map, prefix + "ModelServiceNames.", this.ModelServiceNames);
            this.SetParamArraySimple(map, prefix + "SelectedTypes.", this.SelectedTypes);
            this.SetParamArrayObj(map, prefix + "WeightedConfig.", this.WeightedConfig);
            this.SetParamArrayObj(map, prefix + "ModelNameConfig.", this.ModelNameConfig);
            this.SetParamSimple(map, prefix + "StandardModelName", this.StandardModelName);
        }
    }
}

