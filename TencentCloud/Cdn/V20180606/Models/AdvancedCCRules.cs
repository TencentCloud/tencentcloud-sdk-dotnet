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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedCCRules : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 探测时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectionTime")]
        public ulong? DetectionTime{ get; set; }

        /// <summary>
        /// 限频阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrequencyLimit")]
        public ulong? FrequencyLimit{ get; set; }

        /// <summary>
        /// IP 惩罚配置开关，取值有：
        /// on：开启
        /// off：关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PunishmentSwitch")]
        public string PunishmentSwitch{ get; set; }

        /// <summary>
        /// IP 惩罚时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PunishmentTime")]
        public ulong? PunishmentTime{ get; set; }

        /// <summary>
        /// 执行动作，intercept|redirect
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 动作为 redirect 时，重定向的url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// 七层限频具体配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Configure")]
        public ScdnSevenLayerRules[] Configure{ get; set; }

        /// <summary>
        /// 自定义cc规则配置开关，取值有：
        /// on：开启
        /// off：关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "DetectionTime", this.DetectionTime);
            this.SetParamSimple(map, prefix + "FrequencyLimit", this.FrequencyLimit);
            this.SetParamSimple(map, prefix + "PunishmentSwitch", this.PunishmentSwitch);
            this.SetParamSimple(map, prefix + "PunishmentTime", this.PunishmentTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamArrayObj(map, prefix + "Configure.", this.Configure);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

