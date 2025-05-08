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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigRule : AbstractModel
    {
        
        /// <summary>
        /// 规则标识
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则参数
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// 规则触发条件
        /// </summary>
        [JsonProperty("SourceCondition")]
        public SourceConditionForManage[] SourceCondition{ get; set; }

        /// <summary>
        /// 规则支持的资源类型，规则仅对指定资源类型的资源生效。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string[] ResourceType{ get; set; }

        /// <summary>
        /// 规则所属标签
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// 规则风险等级
        /// 1:低风险
        /// 2:中风险
        /// 3:高风险
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 规则对应的函数
        /// </summary>
        [JsonProperty("ServiceFunction")]
        public string ServiceFunction{ get; set; }

        /// <summary>
        /// 创建时间
        /// 格式：YYYY-MM-DD h:i:s
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// ACTIVE：启用
        /// NO_ACTIVE：停止
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 合规： 'COMPLIANT'
        /// 不合规： 'NON_COMPLIANT'
        /// 无法应用规则： 'NOT_APPLICABLE'
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string ComplianceResult{ get; set; }

        /// <summary>
        /// ["",""]
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }

        /// <summary>
        /// 规则评估时间
        /// 格式：YYYY-MM-DD h:i:s
        /// </summary>
        [JsonProperty("ConfigRuleInvokedTime")]
        public string ConfigRuleInvokedTime{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// CUSTOMIZE：自定义规则、
        /// SYSTEM：托管规则
        /// </summary>
        [JsonProperty("IdentifierType")]
        public string IdentifierType{ get; set; }

        /// <summary>
        /// 合规包ID
        /// </summary>
        [JsonProperty("CompliancePackId")]
        public string CompliancePackId{ get; set; }

        /// <summary>
        /// 触发类型
        /// ScheduledNotification：周期触发、
        /// ConfigurationItemChangeNotification：变更触发
        /// </summary>
        [JsonProperty("TriggerType")]
        public TriggerType[] TriggerType{ get; set; }

        /// <summary>
        /// 参数详情
        /// </summary>
        [JsonProperty("ManageInputParameter")]
        public InputParameterForManage[] ManageInputParameter{ get; set; }

        /// <summary>
        /// 合规包名称
        /// </summary>
        [JsonProperty("CompliancePackName")]
        public string CompliancePackName{ get; set; }

        /// <summary>
        /// 关联地域
        /// </summary>
        [JsonProperty("RegionsScope")]
        public string[] RegionsScope{ get; set; }

        /// <summary>
        /// 关联标签
        /// </summary>
        [JsonProperty("TagsScope")]
        public Tag[] TagsScope{ get; set; }

        /// <summary>
        ///  规则对指定资源ID无效，即不对该资源执行评估。
        /// </summary>
        [JsonProperty("ExcludeResourceIdsScope")]
        public string[] ExcludeResourceIdsScope{ get; set; }

        /// <summary>
        /// 账号组ID
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public string AccountGroupId{ get; set; }

        /// <summary>
        /// 账号组名称
        /// </summary>
        [JsonProperty("AccountGroupName")]
        public string AccountGroupName{ get; set; }

        /// <summary>
        /// 规则所属用户ID
        /// </summary>
        [JsonProperty("RuleOwnerId")]
        public ulong? RuleOwnerId{ get; set; }

        /// <summary>
        /// 预设规则支持的触发方式
        /// ScheduledNotification：周期触发
        /// ConfigurationItemChangeNotification：变更触发
        /// </summary>
        [JsonProperty("ManageTriggerType")]
        public string[] ManageTriggerType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamArrayObj(map, prefix + "SourceCondition.", this.SourceCondition);
            this.SetParamArraySimple(map, prefix + "ResourceType.", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ServiceFunction", this.ServiceFunction);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ComplianceResult", this.ComplianceResult);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
            this.SetParamSimple(map, prefix + "ConfigRuleInvokedTime", this.ConfigRuleInvokedTime);
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "IdentifierType", this.IdentifierType);
            this.SetParamSimple(map, prefix + "CompliancePackId", this.CompliancePackId);
            this.SetParamArrayObj(map, prefix + "TriggerType.", this.TriggerType);
            this.SetParamArrayObj(map, prefix + "ManageInputParameter.", this.ManageInputParameter);
            this.SetParamSimple(map, prefix + "CompliancePackName", this.CompliancePackName);
            this.SetParamArraySimple(map, prefix + "RegionsScope.", this.RegionsScope);
            this.SetParamArrayObj(map, prefix + "TagsScope.", this.TagsScope);
            this.SetParamArraySimple(map, prefix + "ExcludeResourceIdsScope.", this.ExcludeResourceIdsScope);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "AccountGroupName", this.AccountGroupName);
            this.SetParamSimple(map, prefix + "RuleOwnerId", this.RuleOwnerId);
            this.SetParamArraySimple(map, prefix + "ManageTriggerType.", this.ManageTriggerType);
        }
    }
}

