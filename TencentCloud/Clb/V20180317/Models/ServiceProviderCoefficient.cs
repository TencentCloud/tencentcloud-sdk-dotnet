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

    public class ServiceProviderCoefficient : AbstractModel
    {
        
        /// <summary>
        /// <p>该 BYOK 实例（ServiceProvider）维度的积分系数。</p><p>可选字段：仅当该实例单独配置了 ServiceProvider 维度系数时返回，返回值即该实例的生效系数；未返回时表示该实例继承所属 ModelAlias 的 <code>Coefficient</code>。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Coefficient")]
        public Coefficient Coefficient{ get; set; }

        /// <summary>
        /// <p>BYOK 实例（ServiceProvider）ID。</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>BYOK 实例（ServiceProvider）名称。</p>
        /// </summary>
        [JsonProperty("ServiceProviderName")]
        public string ServiceProviderName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Coefficient.", this.Coefficient);
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "ServiceProviderName", this.ServiceProviderName);
        }
    }
}

