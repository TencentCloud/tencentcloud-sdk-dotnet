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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindSecurityTemplateToEntityRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要绑定或解绑的域名所属站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>绑定至策略模板（或者从策略模板解绑）的域名列表。</p>
        /// </summary>
        [JsonProperty("Entities")]
        public string[] Entities{ get; set; }

        /// <summary>
        /// <p>绑定或解绑操作选项。</p><p>枚举值：</p><ul><li>bind： 绑定域名至策略模板。</li><li>unbind-keep-policy： 将域名从策略模板解绑，解绑时保留当前策略。</li><li>unbind-use-default： 将域名从策略模板解绑，并使用默认空白策略。</li></ul>
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// <p>指定绑定或解绑的策略模板 ID 或站点全局策略。<li>如需绑定至策略模板，或从策略模板解绑，请指定策略模板 ID；</li><li>如需绑定至站点全局策略，或从站点全局策略解绑，请使用 @ZoneLevel@domain 参数值。</li></p><p>注意：解绑后，域名将使用独立策略，并单独计算规则配额，请确保解绑前套餐规则配额充足。</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>传入域名如果已经绑定了策略模板（含站点级防护策略），通过设置该参数表示是否替换该模板。</p><p>枚举值：</p><ul><li>true： 替换域名当前绑定的模板。</li><li>false： 不替换域名当前绑定的模板。</li></ul><p>默认值：true</p><p>注意：当设置为 false 时，若传入域名已经绑定策略模板，API  将返回错误；站点级防护策略也为一种策略模板。</p>
        /// </summary>
        [JsonProperty("OverWrite")]
        public bool? OverWrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Entities.", this.Entities);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "OverWrite", this.OverWrite);
        }
    }
}

