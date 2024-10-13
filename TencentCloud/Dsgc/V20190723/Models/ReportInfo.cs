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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [JsonProperty("ReportName")]
        public string ReportName{ get; set; }

        /// <summary>
        /// 报告类型（AssetSorting:资产梳理）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportType")]
        public string ReportType{ get; set; }

        /// <summary>
        /// 报告周期（0单次 1每天 2每周 3每月）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportPeriod")]
        public ulong? ReportPeriod{ get; set; }

        /// <summary>
        /// 执行计划 （0:单次报告 1:定时报告）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportPlan")]
        public ulong? ReportPlan{ get; set; }

        /// <summary>
        /// 报告导出状态（Success 成功, Failed 失败, InProgress 进行中）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportStatus")]
        public string ReportStatus{ get; set; }

        /// <summary>
        /// 任务下次启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimingStartTime")]
        public string TimingStartTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishedTime")]
        public string FinishedTime{ get; set; }

        /// <summary>
        /// 子账号uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 失败信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedMessage")]
        public string FailedMessage{ get; set; }

        /// <summary>
        /// 是否启用（0：否 1：是）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 识别模板名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplianceName")]
        public string ComplianceName{ get; set; }

        /// <summary>
        /// 进度百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgressPercent")]
        public ulong? ProgressPercent{ get; set; }

        /// <summary>
        /// 报告模版名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTemplateName")]
        public string ReportTemplateName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ReportName", this.ReportName);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "ReportPeriod", this.ReportPeriod);
            this.SetParamSimple(map, prefix + "ReportPlan", this.ReportPlan);
            this.SetParamSimple(map, prefix + "ReportStatus", this.ReportStatus);
            this.SetParamSimple(map, prefix + "TimingStartTime", this.TimingStartTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "FinishedTime", this.FinishedTime);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "FailedMessage", this.FailedMessage);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ComplianceName", this.ComplianceName);
            this.SetParamSimple(map, prefix + "ProgressPercent", this.ProgressPercent);
            this.SetParamSimple(map, prefix + "ReportTemplateName", this.ReportTemplateName);
        }
    }
}

