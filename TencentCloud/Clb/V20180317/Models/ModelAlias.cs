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

    public class ModelAlias : AbstractModel
    {
        
        /// <summary>
        /// <p>模型积分系数配置，包含 <code>InputCoefficient</code>、<code>InputCachedCoefficient</code> 和 <code>OutputCoefficient</code>。</p><p>未配置时输入系数默认为 25，缓存命中输入系数默认为 3，输出系数默认为 100。</p>
        /// </summary>
        [JsonProperty("Coefficient")]
        public Coefficient Coefficient{ get; set; }

        /// <summary>
        /// <p>模型别名名称。</p><p>若用户配置了模型别名，则为该别名；未配置时为原始模型名称。</p>
        /// </summary>
        [JsonProperty("ModelAliasName")]
        public string ModelAliasName{ get; set; }

        /// <summary>
        /// <p>该模型别名下各 BYOK 实例（ServiceProvider）的积分系数明细，体现 ModelAlias 与 ServiceProvider 的层级关系。</p><p>默认返回该别名引用的全部实例；某实例返回 <code>Coefficient</code> 表示其单独配置了 ServiceProvider 维度系数，否则继承顶层 ModelAlias 的 <code>Coefficient</code>。</p><p>该别名当前无有效 BYOK 引用时返回空数组。</p>
        /// </summary>
        [JsonProperty("ServiceProviderCoefficientSet")]
        public ServiceProviderCoefficient[] ServiceProviderCoefficientSet{ get; set; }

        /// <summary>
        /// <p>模型来源。</p><p>枚举值：</p><ul><li>BYOK：用户 BYOK 配置的模型。</li></ul>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>状态</p><p>枚举值：</p><ul><li>Active： 正常可用</li><li>Configuring： 变配中</li><li>ConfigureFailed： 变配失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Coefficient.", this.Coefficient);
            this.SetParamSimple(map, prefix + "ModelAliasName", this.ModelAliasName);
            this.SetParamArrayObj(map, prefix + "ServiceProviderCoefficientSet.", this.ServiceProviderCoefficientSet);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

