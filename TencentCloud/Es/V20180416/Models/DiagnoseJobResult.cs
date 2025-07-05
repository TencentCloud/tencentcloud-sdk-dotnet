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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiagnoseJobResult : AbstractModel
    {
        
        /// <summary>
        /// 诊断项名
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 诊断项状态：-2失败，-1待重试，0运行中，1成功
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 诊断项得分
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 诊断摘要
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 诊断建议
        /// </summary>
        [JsonProperty("Advise")]
        public string Advise{ get; set; }

        /// <summary>
        /// 诊断详情
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 诊断指标详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricDetails")]
        public MetricDetail[] MetricDetails{ get; set; }

        /// <summary>
        /// 诊断日志详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogDetails")]
        public LogDetail[] LogDetails{ get; set; }

        /// <summary>
        /// 诊断配置详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettingDetails")]
        public SettingDetail[] SettingDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "Advise", this.Advise);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamArrayObj(map, prefix + "MetricDetails.", this.MetricDetails);
            this.SetParamArrayObj(map, prefix + "LogDetails.", this.LogDetails);
            this.SetParamArrayObj(map, prefix + "SettingDetails.", this.SettingDetails);
        }
    }
}

