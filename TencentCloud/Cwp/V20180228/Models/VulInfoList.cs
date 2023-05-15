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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulInfoList : AbstractModel
    {
        
        /// <summary>
        /// 漏洞包含的事件id串，多个用“,”分割
        /// </summary>
        [JsonProperty("Ids")]
        public string Ids{ get; set; }

        /// <summary>
        /// 漏洞名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 0: 待处理 1:忽略  3:已修复  5:检测中 6:修复中  8:修复失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞披露事件
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 最后检测时间
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 影响主机数
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// 漏洞等级 1:低 2:中 3:高 4:严重
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 废弃字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("From")]
        public ulong? From{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// 废弃字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishTimeWisteria")]
        public string PublishTimeWisteria{ get; set; }

        /// <summary>
        /// 废弃字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NameWisteria")]
        public string NameWisteria{ get; set; }

        /// <summary>
        /// 废弃字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescriptWisteria")]
        public string DescriptWisteria{ get; set; }

        /// <summary>
        /// 聚合后事件状态串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusStr")]
        public string StatusStr{ get; set; }

        /// <summary>
        /// cve编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// CVSS评分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// 漏洞标签 多个逗号分割
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// 是否能自动修复且包含能自动修复的主机， 0=否  1=是
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixSwitch")]
        public ulong? FixSwitch{ get; set; }

        /// <summary>
        /// 最后扫描任务的id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 是否支持防御， 0:不支持 1:支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportDefense")]
        public ulong? IsSupportDefense{ get; set; }

        /// <summary>
        /// 已防御的攻击次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefenseAttackCount")]
        public ulong? DefenseAttackCount{ get; set; }

        /// <summary>
        /// 首次出现时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstAppearTime")]
        public string FirstAppearTime{ get; set; }

        /// <summary>
        /// 漏洞类别 1: web-cms漏洞 2:应用漏洞  4: Linux软件漏洞 5: Windows系统漏洞
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// 攻击热度级别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackLevel")]
        public ulong? AttackLevel{ get; set; }

        /// <summary>
        /// 漏洞修复后是否需要重启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixNoNeedRestart")]
        public bool? FixNoNeedRestart{ get; set; }

        /// <summary>
        /// 检测方式0 - 版本比对, 1 - POC验证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ids", this.Ids);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "PublishTimeWisteria", this.PublishTimeWisteria);
            this.SetParamSimple(map, prefix + "NameWisteria", this.NameWisteria);
            this.SetParamSimple(map, prefix + "DescriptWisteria", this.DescriptWisteria);
            this.SetParamSimple(map, prefix + "StatusStr", this.StatusStr);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
            this.SetParamSimple(map, prefix + "FixSwitch", this.FixSwitch);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "IsSupportDefense", this.IsSupportDefense);
            this.SetParamSimple(map, prefix + "DefenseAttackCount", this.DefenseAttackCount);
            this.SetParamSimple(map, prefix + "FirstAppearTime", this.FirstAppearTime);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "AttackLevel", this.AttackLevel);
            this.SetParamSimple(map, prefix + "FixNoNeedRestart", this.FixNoNeedRestart);
            this.SetParamSimple(map, prefix + "Method", this.Method);
        }
    }
}

