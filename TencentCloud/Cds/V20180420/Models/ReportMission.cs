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

namespace TencentCloud.Cds.V20180420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportMission : AbstractModel
    {
        
        /// <summary>
        /// 报表任务id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// 报表类型 1:单次报表 2:周期报表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// 报告说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 报表模板 1:综合分析报告 2:等保合规报告
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 包含资产
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetsList")]
        public AssetsInfo[] AssetsList{ get; set; }

        /// <summary>
        /// 下次启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextStartTime")]
        public long? NextStartTime{ get; set; }

        /// <summary>
        /// 任务状态 1:生成中 2:待生成3:已生成4:生成失败5:已暂停
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MissionStatus")]
        public long? MissionStatus{ get; set; }

        /// <summary>
        /// 任务状态说明 仅生成中和生成失败有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MissionStatusMessage")]
        public string MissionStatusMessage{ get; set; }

        /// <summary>
        /// 已生成报表数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportCount")]
        public long? ReportCount{ get; set; }

        /// <summary>
        /// 任务起停 1:关闭 2:开启 仅周期报表有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MissionStart")]
        public long? MissionStart{ get; set; }

        /// <summary>
        /// 统计周期 1:24小时 7:近一周 30:近30天 90:近90天 180:
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CntDay")]
        public long? CntDay{ get; set; }

        /// <summary>
        /// 重复周期 1:每天 2:每周 3:每月
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CntCycle")]
        public ulong? CntCycle{ get; set; }

        /// <summary>
        /// 执行日期 重复周期为天：无意义 周：星期几 1-7  月每月
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CntTime")]
        public ulong? CntTime{ get; set; }

        /// <summary>
        /// 执行时间 格式15:04 到分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CntDate")]
        public string CntDate{ get; set; }

        /// <summary>
        /// 创建者 0:内置 其余存放用户(uin)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Receivers")]
        public string Receivers{ get; set; }

        /// <summary>
        /// Notification  int  1关闭 2开启 不变更为0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Notification")]
        public long? Notification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArrayObj(map, prefix + "AssetsList.", this.AssetsList);
            this.SetParamSimple(map, prefix + "NextStartTime", this.NextStartTime);
            this.SetParamSimple(map, prefix + "MissionStatus", this.MissionStatus);
            this.SetParamSimple(map, prefix + "MissionStatusMessage", this.MissionStatusMessage);
            this.SetParamSimple(map, prefix + "ReportCount", this.ReportCount);
            this.SetParamSimple(map, prefix + "MissionStart", this.MissionStart);
            this.SetParamSimple(map, prefix + "CntDay", this.CntDay);
            this.SetParamSimple(map, prefix + "CntCycle", this.CntCycle);
            this.SetParamSimple(map, prefix + "CntTime", this.CntTime);
            this.SetParamSimple(map, prefix + "CntDate", this.CntDate);
            this.SetParamSimple(map, prefix + "Receivers", this.Receivers);
            this.SetParamSimple(map, prefix + "Notification", this.Notification);
        }
    }
}

