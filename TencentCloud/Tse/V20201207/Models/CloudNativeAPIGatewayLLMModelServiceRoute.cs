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

    public class CloudNativeAPIGatewayLLMModelServiceRoute : AbstractModel
    {
        
        /// <summary>
        /// 生效的路由算法类型：权重路由，模型名称路由、参数路由等Weighted/ModelName/Query (预留多个，暂时只能填写一个)
        /// </summary>
        [JsonProperty("SelectedTypes")]
        public string[] SelectedTypes{ get; set; }

        /// <summary>
        /// 权重路由配置，最多10个
        /// </summary>
        [JsonProperty("WeightedConfig")]
        public CloudNativeAPIGatewayLLMModelServiceRouteWeightedStrategy[] WeightedConfig{ get; set; }

        /// <summary>
        /// 模型名称路由配置，最多10个
        /// </summary>
        [JsonProperty("ModelNameConfig")]
        public CloudNativeAPIGatewayLLMModelServiceRouteModelNameStrategy[] ModelNameConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SelectedTypes.", this.SelectedTypes);
            this.SetParamArrayObj(map, prefix + "WeightedConfig.", this.WeightedConfig);
            this.SetParamArrayObj(map, prefix + "ModelNameConfig.", this.ModelNameConfig);
        }
    }
}

