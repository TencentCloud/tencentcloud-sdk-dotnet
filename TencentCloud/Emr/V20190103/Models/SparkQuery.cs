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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SparkQuery : AbstractModel
    {
        
        /// <summary>
        /// 执行语句
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// 执行时长（单位毫秒）
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 执行状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 查询ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 扫描分区数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanPartitionNum")]
        public long? ScanPartitionNum{ get; set; }

        /// <summary>
        /// 扫描总行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanRowNum")]
        public long? ScanRowNum{ get; set; }

        /// <summary>
        /// 扫描总文件数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanFileNum")]
        public long? ScanFileNum{ get; set; }

        /// <summary>
        /// 查询扫描总数据量(单位B)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanTotalData")]
        public long? ScanTotalData{ get; set; }

        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string[] ApplicationId{ get; set; }

        /// <summary>
        /// 输出总行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputRowNum")]
        public long? OutputRowNum{ get; set; }

        /// <summary>
        /// 输出总文件数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputFileNum")]
        public long? OutputFileNum{ get; set; }

        /// <summary>
        /// 输出分区数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputPartitionNum")]
        public long? OutputPartitionNum{ get; set; }

        /// <summary>
        /// 输出总数据量（单位B）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputTotalData")]
        public long? OutputTotalData{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ScanPartitionNum", this.ScanPartitionNum);
            this.SetParamSimple(map, prefix + "ScanRowNum", this.ScanRowNum);
            this.SetParamSimple(map, prefix + "ScanFileNum", this.ScanFileNum);
            this.SetParamSimple(map, prefix + "ScanTotalData", this.ScanTotalData);
            this.SetParamArraySimple(map, prefix + "ApplicationId.", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OutputRowNum", this.OutputRowNum);
            this.SetParamSimple(map, prefix + "OutputFileNum", this.OutputFileNum);
            this.SetParamSimple(map, prefix + "OutputPartitionNum", this.OutputPartitionNum);
            this.SetParamSimple(map, prefix + "OutputTotalData", this.OutputTotalData);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

