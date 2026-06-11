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

    public class K8sApiAbnormalRuleListItem : AbstractModel
    {
        
        /// <summary>
        /// 是否全部集群生效。true表示全部集群生效，false表示仅指定集群生效
        /// </summary>
        [JsonProperty("EffectAllCluster")]
        public bool? EffectAllCluster{ get; set; }

        /// <summary>
        /// 受影响集群总数
        /// </summary>
        [JsonProperty("EffectClusterCount")]
        public ulong? EffectClusterCount{ get; set; }

        /// <summary>
        /// 编辑账号
        /// </summary>
        [JsonProperty("OprUin")]
        public string OprUin{ get; set; }

        /// <summary>
        /// 规则组中所有执行动作的去重列表。当前黑名单仅包含 RULE_MODE_ALERT（告警）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleActions")]
        public string[] RuleActions{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// 子规则内容列表，从 rule_details JSON 反序列化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleInfoList")]
        public K8sApiAbnormalRuleScopeInfo[] RuleInfoList{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则类型
        /// RT_SYSTEM 系统规则
        /// RT_USER 用户自定义
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EffectAllCluster", this.EffectAllCluster);
            this.SetParamSimple(map, prefix + "EffectClusterCount", this.EffectClusterCount);
            this.SetParamSimple(map, prefix + "OprUin", this.OprUin);
            this.SetParamArraySimple(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArrayObj(map, prefix + "RuleInfoList.", this.RuleInfoList);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

