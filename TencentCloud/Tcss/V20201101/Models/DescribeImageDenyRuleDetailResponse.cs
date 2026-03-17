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

    public class DescribeImageDenyRuleDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则类型 RULE_RISK：风险， RULE_PRIVILEGE：特权
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 生效的镜像数量
        /// </summary>
        [JsonProperty("EffectImageCount")]
        public long? EffectImageCount{ get; set; }

        /// <summary>
        /// 是否对全部扫描镜像生效。0:全选镜像，1:自选镜像
        /// </summary>
        [JsonProperty("IsEffectAllImage")]
        public long? IsEffectAllImage{ get; set; }

        /// <summary>
        /// 规则开始生效时间
        /// </summary>
        [JsonProperty("EffectTime")]
        public string EffectTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 操作用户
        /// </summary>
        [JsonProperty("OperationUin")]
        public string OperationUin{ get; set; }

        /// <summary>
        /// 生效状态 IN_THE_TEST ：观察中，IN_EFFECT：生效中
        /// </summary>
        [JsonProperty("EffectStatus")]
        public string EffectStatus{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("RuleDescription")]
        public string RuleDescription{ get; set; }

        /// <summary>
        /// 启用状态 0:开启，1:关闭
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 漏洞，0:未选中，1:选中
        /// </summary>
        [JsonProperty("Vul")]
        public long? Vul{ get; set; }

        /// <summary>
        /// cve编号
        /// </summary>
        [JsonProperty("CVEIDSet")]
        public string[] CVEIDSet{ get; set; }

        /// <summary>
        /// 组件编号
        /// </summary>
        [JsonProperty("ComponentSet")]
        public string[] ComponentSet{ get; set; }

        /// <summary>
        /// 漏洞分类
        /// </summary>
        [JsonProperty("VulClassSet")]
        public string[] VulClassSet{ get; set; }

        /// <summary>
        /// 漏洞等级
        /// </summary>
        [JsonProperty("VulLevelSet")]
        public string[] VulLevelSet{ get; set; }

        /// <summary>
        /// 漏洞标签
        /// </summary>
        [JsonProperty("VulLabelSet")]
        public string[] VulLabelSet{ get; set; }

        /// <summary>
        /// 木马，0:未选中，1:选中
        /// </summary>
        [JsonProperty("Virus")]
        public long? Virus{ get; set; }

        /// <summary>
        /// 木马md5列表
        /// </summary>
        [JsonProperty("VirusMD5Set")]
        public string[] VirusMD5Set{ get; set; }

        /// <summary>
        /// 木马等级
        /// </summary>
        [JsonProperty("VirusLevelSet")]
        public string[] VirusLevelSet{ get; set; }

        /// <summary>
        /// 病毒名
        /// </summary>
        [JsonProperty("VirusName")]
        public string[] VirusName{ get; set; }

        /// <summary>
        /// 敏感信息，0:未选中，1:选中
        /// </summary>
        [JsonProperty("Risk")]
        public long? Risk{ get; set; }

        /// <summary>
        /// 敏感等级
        /// </summary>
        [JsonProperty("RiskLevelSet")]
        public string[] RiskLevelSet{ get; set; }

        /// <summary>
        /// 敏感信息分类
        /// </summary>
        [JsonProperty("RiskType")]
        public string[] RiskType{ get; set; }

        /// <summary>
        /// 特权启动 0:不允许，1:允许
        /// </summary>
        [JsonProperty("PrivilegeRun")]
        public long? PrivilegeRun{ get; set; }

        /// <summary>
        /// 特权类型,
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivilegeDetail")]
        public string[] PrivilegeDetail{ get; set; }

        /// <summary>
        /// 镜像ID列表
        /// </summary>
        [JsonProperty("EffectImageSet")]
        public string[] EffectImageSet{ get; set; }

        /// <summary>
        /// 多少天后生效
        /// </summary>
        [JsonProperty("EffectDay")]
        public ulong? EffectDay{ get; set; }

        /// <summary>
        /// 规则RuelD
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "EffectImageCount", this.EffectImageCount);
            this.SetParamSimple(map, prefix + "IsEffectAllImage", this.IsEffectAllImage);
            this.SetParamSimple(map, prefix + "EffectTime", this.EffectTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperationUin", this.OperationUin);
            this.SetParamSimple(map, prefix + "EffectStatus", this.EffectStatus);
            this.SetParamSimple(map, prefix + "RuleDescription", this.RuleDescription);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vul", this.Vul);
            this.SetParamArraySimple(map, prefix + "CVEIDSet.", this.CVEIDSet);
            this.SetParamArraySimple(map, prefix + "ComponentSet.", this.ComponentSet);
            this.SetParamArraySimple(map, prefix + "VulClassSet.", this.VulClassSet);
            this.SetParamArraySimple(map, prefix + "VulLevelSet.", this.VulLevelSet);
            this.SetParamArraySimple(map, prefix + "VulLabelSet.", this.VulLabelSet);
            this.SetParamSimple(map, prefix + "Virus", this.Virus);
            this.SetParamArraySimple(map, prefix + "VirusMD5Set.", this.VirusMD5Set);
            this.SetParamArraySimple(map, prefix + "VirusLevelSet.", this.VirusLevelSet);
            this.SetParamArraySimple(map, prefix + "VirusName.", this.VirusName);
            this.SetParamSimple(map, prefix + "Risk", this.Risk);
            this.SetParamArraySimple(map, prefix + "RiskLevelSet.", this.RiskLevelSet);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "PrivilegeRun", this.PrivilegeRun);
            this.SetParamArraySimple(map, prefix + "PrivilegeDetail.", this.PrivilegeDetail);
            this.SetParamArraySimple(map, prefix + "EffectImageSet.", this.EffectImageSet);
            this.SetParamSimple(map, prefix + "EffectDay", this.EffectDay);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

