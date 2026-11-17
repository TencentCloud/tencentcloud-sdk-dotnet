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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>AgentId</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>Agent 身份画像</p>
        /// </summary>
        [JsonProperty("Profile")]
        public AgentProfile Profile{ get; set; }

        /// <summary>
        /// <p>高级设置;scope=0 时返回</p>
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public AgentAdvancedConfig AdvancedConfig{ get; set; }

        /// <summary>
        /// <p>子 Agent 执行来源</p><p>枚举值：</p><ul><li>0： 应用内子 Agent</li><li>1： 引用已发布的应用</li></ul>
        /// </summary>
        [JsonProperty("ProviderType")]
        public long? ProviderType{ get; set; }

        /// <summary>
        /// <p>引用应用状态，ProviderType=1 时有效</p><p>枚举值：</p><ul><li>0： 来源应用可用</li><li>1： 来源应用不可用</li><li>2： 无权限</li><li>3： 嵌套引用: 来源应用线上生效配置中已含应用类子 Agent</li></ul>
        /// </summary>
        [JsonProperty("ReferenceAppStatus")]
        public long? ReferenceAppStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamObj(map, prefix + "AdvancedConfig.", this.AdvancedConfig);
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "ReferenceAppStatus", this.ReferenceAppStatus);
        }
    }
}

