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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalProcessRuleExtSetItem : AbstractModel
    {
        
        /// <summary>
        /// 用户自定义策略子规则列表。IsDefault=false时有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChildRules")]
        public AbnormalProcessChildRuleInfo[] ChildRules{ get; set; }

        /// <summary>
        /// 编辑用户名称
        /// </summary>
        [JsonProperty("EditUserName")]
        public string EditUserName{ get; set; }

        /// <summary>
        /// 策略生效镜像数量
        /// </summary>
        [JsonProperty("EffectImageCount")]
        public ulong? EffectImageCount{ get; set; }

        /// <summary>
        /// true: 默认策略，false:自定义策略
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 是否为全部镜像规则。true表示对所有镜像生效
        /// </summary>
        [JsonProperty("IsGlobal")]
        public bool? IsGlobal{ get; set; }

        /// <summary>
        /// true: 策略启用，false：策略禁用
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// 规则组中所有执行动作的去重列表。RULE_MODE_ALERT:告警 RULE_MODE_HOLDUP:拦截
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleActions")]
        public string[] RuleActions{ get; set; }

        /// <summary>
        /// 策略Id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 策略名字
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 系统策略子规则列表。IsDefault=true时有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemChildRules")]
        public AbnormalProcessSystemChildRuleInfo[] SystemChildRules{ get; set; }

        /// <summary>
        /// 策略更新时间, 存在为空的情况
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ChildRules.", this.ChildRules);
            this.SetParamSimple(map, prefix + "EditUserName", this.EditUserName);
            this.SetParamSimple(map, prefix + "EffectImageCount", this.EffectImageCount);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamArraySimple(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "SystemChildRules.", this.SystemChildRules);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

