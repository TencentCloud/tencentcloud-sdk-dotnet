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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlertInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 告警名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 告警来源
        /// CFW:云防火墙
        /// WAF:Web应用防火墙
        /// CWP:主机安全
        /// CSIP:云安全中心
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 告警等级
        /// 1:提示
        /// 2:低危
        /// 3:中危
        /// 4:高危
        /// 5:严重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 攻击者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Attacker")]
        public RoleInfo Attacker{ get; set; }

        /// <summary>
        /// 受害者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Victim")]
        public RoleInfo Victim{ get; set; }

        /// <summary>
        /// 证据数据(例如攻击内容等，base64编码)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvidenceData")]
        public string EvidenceData{ get; set; }

        /// <summary>
        /// 证据位置(例如协议端口)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvidenceLocation")]
        public string EvidenceLocation{ get; set; }

        /// <summary>
        /// 证据路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvidencePath")]
        public string EvidencePath{ get; set; }

        /// <summary>
        /// 首次告警时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近告警时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 告警次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 紧急缓解建议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrgentSuggestion")]
        public string UrgentSuggestion{ get; set; }

        /// <summary>
        /// 根治建议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemediationSuggestion")]
        public string RemediationSuggestion{ get; set; }

        /// <summary>
        /// 处理状态
        /// 0：未处置，1：已忽略，2：已处置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 告警处理类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// 告警大类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 告警小类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 下拉字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public AlertExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// 聚合字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 告警日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// appid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// 账户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 账户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 行为
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// 风险排查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskInvestigation")]
        public string RiskInvestigation{ get; set; }

        /// <summary>
        /// 风险处置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskTreatment")]
        public string RiskTreatment{ get; set; }

        /// <summary>
        /// 日志类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 语句检索
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogSearch")]
        public string LogSearch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamObj(map, prefix + "Attacker.", this.Attacker);
            this.SetParamObj(map, prefix + "Victim.", this.Victim);
            this.SetParamSimple(map, prefix + "EvidenceData", this.EvidenceData);
            this.SetParamSimple(map, prefix + "EvidenceLocation", this.EvidenceLocation);
            this.SetParamSimple(map, prefix + "EvidencePath", this.EvidencePath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "UrgentSuggestion", this.UrgentSuggestion);
            this.SetParamSimple(map, prefix + "RemediationSuggestion", this.RemediationSuggestion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RiskInvestigation", this.RiskInvestigation);
            this.SetParamSimple(map, prefix + "RiskTreatment", this.RiskTreatment);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "LogSearch", this.LogSearch);
        }
    }
}

