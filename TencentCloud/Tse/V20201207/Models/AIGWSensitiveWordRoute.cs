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
        /// <p>是否开启敏感词路由</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>目标模型服务列表</p>
        /// </summary>
        [JsonProperty("ModelServiceRefs")]
        public string[] ModelServiceRefs{ get; set; }

        /// <summary>
        /// <p>目标模型服务名，查询的时候会填充</p>
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
        /// <p>模型名称路由权重</p>
        /// </summary>
        [JsonProperty("ModelNameConfig")]
        public CloudNativeAPIGatewayLLMModelServiceRouteModelNameStrategy[] ModelNameConfig{ get; set; }


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
        }
    }
}

