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

    public class AgentPlugin : AbstractModel
    {
        
        /// <summary>
        /// 插件基本配置
        /// </summary>
        [JsonProperty("Config")]
        public AgentPluginConfig Config{ get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 插件图标url
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// 插件描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>插件产品分类</p><p>枚举值：</p><ul><li>0： 普通插件</li><li>1： 连接器类插件</li></ul>
        /// </summary>
        [JsonProperty("PluginClass")]
        public long? PluginClass{ get; set; }

        /// <summary>
        /// <p>插件状态</p><p>枚举值：</p><ul><li>0： 未知</li><li>1： 可用</li><li>2： 不可用</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>插件鉴权配置状态</p><p>枚举值：</p><ul><li>0： 不需要授权</li><li>1： 未配置</li><li>2： 已配置</li></ul>
        /// </summary>
        [JsonProperty("AuthConfigStatus")]
        public long? AuthConfigStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PluginClass", this.PluginClass);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AuthConfigStatus", this.AuthConfigStatus);
        }
    }
}

