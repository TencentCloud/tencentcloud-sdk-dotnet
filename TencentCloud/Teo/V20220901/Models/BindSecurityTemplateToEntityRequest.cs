/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 需要绑定或解绑的策略模板所属站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 绑定至策略模板（或者从策略模板解绑）的域名列表。
        /// </summary>
        [JsonProperty("Entities")]
        public string[] Entities{ get; set; }

        /// <summary>
        /// 绑定或解绑操作选项，取值有：
        /// <li>bind：绑定域名至策略模板；</li>
        /// <li>unbind-keep-policy：将域名从策略模板解绑，解绑时保留当前策略；</li>
        /// <li>unbind-use-default：将域名从策略模板解绑，并使用默认空白策略。</li>注意：解绑操作当前仅支持单个域名解绑。即：当 Operate 参数取值为 unbind-keep-policy 或 unbind-use-default 时，Entities 参数列表仅支持填写一个域名。
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 指定绑定或解绑的策略模板 ID 或站点全局策略
        /// - 如需绑定至策略模板，或从策略模板解绑，请指定策略模板 ID。
        /// - 如需绑定至站点全局策略，或从站点全局策略解绑，请使用 @ZoneLevel@domain 参数值。
        /// 
        /// 注意：解绑后，域名将使用独立策略，并单独计算规则配额，请确保解绑前套餐规则配额充足。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 如指定的域名已经绑定了策略模板，是否替换该模板。支持下列取值：
        /// <li>true： 替换域名当前绑定的模板；</li>
        /// <li>false：不替换域名当前绑定的模板。</li>注意：当选择不替换已有策略模板时，若指定域名已经绑定策略模板，API 将返回错误。
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

