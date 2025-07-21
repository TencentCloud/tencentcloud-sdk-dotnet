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

namespace TencentCloud.Securitylake.V20240117.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityAlarmTable : AbstractModel
    {
        
        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 告警名称
        /// </summary>
        [JsonProperty("AlarmName")]
        public string AlarmName{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("AlarmId")]
        public long? AlarmId{ get; set; }

        /// <summary>
        /// 安全性
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 子分类
        /// </summary>
        [JsonProperty("SubCategory")]
        public string SubCategory{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 有效载荷
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 可信度
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 规则主题
        /// </summary>
        [JsonProperty("RuleTopic")]
        public string RuleTopic{ get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [JsonProperty("HandleTime")]
        public string HandleTime{ get; set; }

        /// <summary>
        /// 建议
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// APPID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// 规则类型
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 攻击次数
        /// </summary>
        [JsonProperty("AttackNum")]
        public long? AttackNum{ get; set; }

        /// <summary>
        /// 告警数量
        /// </summary>
        [JsonProperty("AlarmCount")]
        public long? AlarmCount{ get; set; }

        /// <summary>
        /// ATT&CK子技术
        /// </summary>
        [JsonProperty("AttackSubTechnique")]
        public string AttackSubTechnique{ get; set; }

        /// <summary>
        /// ATT&CK技术
        /// </summary>
        [JsonProperty("AttackTechnique")]
        public string AttackTechnique{ get; set; }

        /// <summary>
        /// ATT&CK战术
        /// </summary>
        [JsonProperty("AttackTactic")]
        public string AttackTactic{ get; set; }

        /// <summary>
        /// ATT&CK子技术名称
        /// </summary>
        [JsonProperty("AttackSubTechniqueName")]
        public string AttackSubTechniqueName{ get; set; }

        /// <summary>
        /// ATT&CK技术名称
        /// </summary>
        [JsonProperty("AttackTechniqueName")]
        public string AttackTechniqueName{ get; set; }

        /// <summary>
        /// 凭证访问
        /// </summary>
        [JsonProperty("AttackTacticName")]
        public string AttackTacticName{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 规则表达式
        /// </summary>
        [JsonProperty("RuleExpression")]
        public string RuleExpression{ get; set; }

        /// <summary>
        /// 表达式类型
        /// </summary>
        [JsonProperty("ExpressionType")]
        public string ExpressionType{ get; set; }

        /// <summary>
        /// 下钻表达式
        /// </summary>
        [JsonProperty("DrillDownExpression")]
        public string DrillDownExpression{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("SrcPort")]
        public long? SrcPort{ get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("DstPort")]
        public long? DstPort{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 主机资产
        /// </summary>
        [JsonProperty("HostAsset")]
        public string HostAsset{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("SdlId")]
        public string SdlId{ get; set; }

        /// <summary>
        /// 自定义富化字段信息
        /// </summary>
        [JsonProperty("RichCustomInfos")]
        public string[] RichCustomInfos{ get; set; }

        /// <summary>
        /// 攻击者ip
        /// </summary>
        [JsonProperty("AttackerIp")]
        public string AttackerIp{ get; set; }

        /// <summary>
        /// 攻击者资产ID
        /// </summary>
        [JsonProperty("AttackerAsset")]
        public string AttackerAsset{ get; set; }

        /// <summary>
        /// 受害者ip
        /// </summary>
        [JsonProperty("VictimIp")]
        public string VictimIp{ get; set; }

        /// <summary>
        /// 受害者资产ID
        /// </summary>
        [JsonProperty("VictimAsset")]
        public string VictimAsset{ get; set; }

        /// <summary>
        /// 攻击方向
        /// </summary>
        [JsonProperty("AttackDirection")]
        public string AttackDirection{ get; set; }

        /// <summary>
        /// 流量方向
        /// </summary>
        [JsonProperty("TrafficDirection")]
        public string TrafficDirection{ get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("SecurityGroupAlertInfos")]
        public SecurityGroupAlertInfo[] SecurityGroupAlertInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "AlarmName", this.AlarmName);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "SubCategory", this.SubCategory);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleTopic", this.RuleTopic);
            this.SetParamSimple(map, prefix + "HandleTime", this.HandleTime);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "AttackNum", this.AttackNum);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "AttackSubTechnique", this.AttackSubTechnique);
            this.SetParamSimple(map, prefix + "AttackTechnique", this.AttackTechnique);
            this.SetParamSimple(map, prefix + "AttackTactic", this.AttackTactic);
            this.SetParamSimple(map, prefix + "AttackSubTechniqueName", this.AttackSubTechniqueName);
            this.SetParamSimple(map, prefix + "AttackTechniqueName", this.AttackTechniqueName);
            this.SetParamSimple(map, prefix + "AttackTacticName", this.AttackTacticName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RuleExpression", this.RuleExpression);
            this.SetParamSimple(map, prefix + "ExpressionType", this.ExpressionType);
            this.SetParamSimple(map, prefix + "DrillDownExpression", this.DrillDownExpression);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "SrcPort", this.SrcPort);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "HostAsset", this.HostAsset);
            this.SetParamSimple(map, prefix + "SdlId", this.SdlId);
            this.SetParamArraySimple(map, prefix + "RichCustomInfos.", this.RichCustomInfos);
            this.SetParamSimple(map, prefix + "AttackerIp", this.AttackerIp);
            this.SetParamSimple(map, prefix + "AttackerAsset", this.AttackerAsset);
            this.SetParamSimple(map, prefix + "VictimIp", this.VictimIp);
            this.SetParamSimple(map, prefix + "VictimAsset", this.VictimAsset);
            this.SetParamSimple(map, prefix + "AttackDirection", this.AttackDirection);
            this.SetParamSimple(map, prefix + "TrafficDirection", this.TrafficDirection);
            this.SetParamArrayObj(map, prefix + "SecurityGroupAlertInfos.", this.SecurityGroupAlertInfos);
        }
    }
}

