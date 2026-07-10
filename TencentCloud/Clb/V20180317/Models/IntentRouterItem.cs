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

    public class IntentRouterItem : AbstractModel
    {
        
        /// <summary>
        /// <p>创建时间（ISO 8601格式）。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>意图路由ID（ir-xxx格式）。</p>
        /// </summary>
        [JsonProperty("IntentRouterId")]
        public string IntentRouterId{ get; set; }

        /// <summary>
        /// <p>路由名称（例如 IntentRouter/customer-support）。</p>
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// <p>意图路由描述。</p>
        /// </summary>
        [JsonProperty("RouterDescribe")]
        public string RouterDescribe{ get; set; }

        /// <summary>
        /// <p>状态。</p><p>枚举值：</p><ul><li>Provisioning：创建中</li><li>Active：正常</li><li>Configuring：配置中</li><li>ConfigureFailed：配置失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>分层配置列表。</p>
        /// </summary>
        [JsonProperty("Tiers")]
        public IntentRouterTierItem[] Tiers{ get; set; }

        /// <summary>
        /// <p>更新时间（ISO 8601格式）。</p>
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "IntentRouterId", this.IntentRouterId);
            this.SetParamSimple(map, prefix + "RouteName", this.RouteName);
            this.SetParamSimple(map, prefix + "RouterDescribe", this.RouterDescribe);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tiers.", this.Tiers);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
        }
    }
}

