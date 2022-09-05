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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ACLUserRule : AbstractModel
    {
        
        /// <summary>
        /// 规则名。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 处罚动作。
        /// 1. trans 放行
        /// 2. drop 拦截
        /// 3. monitor 观察
        /// 4. ban IP封禁
        /// 5. redirect 重定向
        /// 6. page 指定页面
        /// 7. alg Javascript挑战
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 规则状态。
        /// 1. on 规则生效
        /// 2. off 规则失效
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// ACL规则。
        /// </summary>
        [JsonProperty("Conditions")]
        public ACLCondition[] Conditions{ get; set; }

        /// <summary>
        /// 规则优先级，0-100。
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// 规则id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 更新时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// ip封禁的惩罚时间，0-2天
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PunishTime")]
        public long? PunishTime{ get; set; }

        /// <summary>
        /// ip封禁的惩罚时间单位。
        /// 1. second 秒
        /// 2. 分钟 minutes
        /// 3. hour 小时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PunishTimeUnit")]
        public string PunishTimeUnit{ get; set; }

        /// <summary>
        /// 自定义返回页面的实例id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageId")]
        public long? PageId{ get; set; }

        /// <summary>
        /// 自定义返回页面的名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 重定向时候的地址，必须为本用户接入的站点子域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// 重定向时候的返回码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseCode")]
        public long? ResponseCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PunishTime", this.PunishTime);
            this.SetParamSimple(map, prefix + "PunishTimeUnit", this.PunishTimeUnit);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
        }
    }
}

