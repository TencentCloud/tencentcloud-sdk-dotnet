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

    public class PluginSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>插件运营管理信息</p>
        /// </summary>
        [JsonProperty("Operation")]
        public PluginOperation Operation{ get; set; }

        /// <summary>
        /// <p>插件id</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>插件基础信息</p>
        /// </summary>
        [JsonProperty("Profile")]
        public PluginProfile Profile{ get; set; }

        /// <summary>
        /// <p>插件统计信息</p>
        /// </summary>
        [JsonProperty("Statistics")]
        public PluginStatistics Statistics{ get; set; }

        /// <summary>
        /// <p>插件状态，1:可用，2:不可用 </p><p>枚举值：</p><ul><li>1： 可用</li><li>2： 不可用</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>用户维度的插件状态信息</p>
        /// </summary>
        [JsonProperty("UserState")]
        public PluginUserState UserState{ get; set; }

        /// <summary>
        /// <p>插件配置信息</p>
        /// </summary>
        [JsonProperty("Config")]
        public PluginConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operation.", this.Operation);
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamObj(map, prefix + "Statistics.", this.Statistics);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "UserState.", this.UserState);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

