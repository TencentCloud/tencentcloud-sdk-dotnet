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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScreenTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 统计标示 0：全部、1：当前天、2：昨天
        /// </summary>
        [JsonProperty("CountTag")]
        public ulong? CountTag{ get; set; }

        /// <summary>
        /// 总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 运行中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningNum")]
        public ulong? RunningNum{ get; set; }

        /// <summary>
        /// 停止中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppingNum")]
        public ulong? StoppingNum{ get; set; }

        /// <summary>
        /// 已停止
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppedNum")]
        public ulong? StoppedNum{ get; set; }

        /// <summary>
        /// 暂停
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenNum")]
        public ulong? FrozenNum{ get; set; }

        /// <summary>
        /// 无效任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvalidNum")]
        public ulong? InvalidNum{ get; set; }

        /// <summary>
        /// 年任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YearNum")]
        public ulong? YearNum{ get; set; }

        /// <summary>
        /// 月任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonthNum")]
        public ulong? MonthNum{ get; set; }

        /// <summary>
        /// 周任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeekNum")]
        public ulong? WeekNum{ get; set; }

        /// <summary>
        /// 天任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DayNum")]
        public ulong? DayNum{ get; set; }

        /// <summary>
        /// 小时任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HourNum")]
        public ulong? HourNum{ get; set; }

        /// <summary>
        /// 分钟任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinuteNum")]
        public ulong? MinuteNum{ get; set; }

        /// <summary>
        /// 工作流总数
        /// </summary>
        [JsonProperty("WorkflowNum")]
        public ulong? WorkflowNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CountTag", this.CountTag);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "RunningNum", this.RunningNum);
            this.SetParamSimple(map, prefix + "StoppingNum", this.StoppingNum);
            this.SetParamSimple(map, prefix + "StoppedNum", this.StoppedNum);
            this.SetParamSimple(map, prefix + "FrozenNum", this.FrozenNum);
            this.SetParamSimple(map, prefix + "InvalidNum", this.InvalidNum);
            this.SetParamSimple(map, prefix + "YearNum", this.YearNum);
            this.SetParamSimple(map, prefix + "MonthNum", this.MonthNum);
            this.SetParamSimple(map, prefix + "WeekNum", this.WeekNum);
            this.SetParamSimple(map, prefix + "DayNum", this.DayNum);
            this.SetParamSimple(map, prefix + "HourNum", this.HourNum);
            this.SetParamSimple(map, prefix + "MinuteNum", this.MinuteNum);
            this.SetParamSimple(map, prefix + "WorkflowNum", this.WorkflowNum);
        }
    }
}

