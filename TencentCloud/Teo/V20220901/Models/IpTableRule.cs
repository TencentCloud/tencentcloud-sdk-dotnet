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

    public class IpTableRule : AbstractModel
    {
        
        /// <summary>
        /// 动作，取值有：
        /// <li> drop：拦截；</li>
        /// <li> trans：放行；</li>
        /// <li> monitor：观察。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 根据类型匹配，取值有：
        /// <li>ip：客户端 IP 进行匹配；</li>
        /// <li>area：客户端 IP 所属地区匹配；</li>
        /// <li>asn：客户端所属的自治系统进行匹配；</li>
        /// <li>referer：请求头 Referer 进行匹配；</li>
        /// <li>ua：请求头 User-Agent 进行匹配；</li>
        /// <li>url：请求 URL 进行匹配。</li>
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string MatchFrom{ get; set; }

        /// <summary>
        /// 规则的匹配方式。取值有：
        /// <li> match：匹配，适用于 MatchFrom 为 ip；</li>
        /// <li> not_match：不匹配，适用于 MatchFrom 为 ip；</li>
        /// <li> include_area：地域包含，适用于 MatchFrom 为 area；</li>
        /// <li> not_include_area：地域不包含，适用于 MatchFrom 为 area；</li>
        /// <li> asn_match：ASN 包含，适用于 MatchFrom 为 asn；</li>
        /// <li> asn_not_match：ASN 不包含，适用于 MatchFrom 为 asn；</li>
        /// <li> equal：等于，适用于 MatchFrom 为 ua , referer；</li>
        /// <li> not_equal：不等于，适用于 MatchFrom 为 ua , referer；</li>
        /// <li> include：通配符匹配，适用于 MatchFrom 为 ua , referer , url；</li>
        /// <li> not_include：通配符不匹配，适用于 MatchFrom 为 ua , referer；</li>
        /// <li> is_emty：配置内容为空，适用于 MatchFrom 为 ua , referer；</li>
        /// <li> not_exists：配置内容不存在，适用于 MatchFrom 为 ua , referer。</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 规则id。仅出参使用。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 更新时间。仅出参使用。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 规则启用状态。取值有：
        /// <li> on：启用；</li>
        /// <li> off：未启用。</li>
        /// 当入参缺省时，按 on 取值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 规则名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 匹配内容。支持多值输入。
        /// <li>当输入多个匹配值时，请使用英文逗号分隔；</li>
        /// <li>当 MatchFrom 为 ua 时，不支持多值输入；</li>
        /// <li>当 Operator 为 is_empty 或 not_exists 时，本字段入参值无效。</li>
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "MatchFrom", this.MatchFrom);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
        }
    }
}

