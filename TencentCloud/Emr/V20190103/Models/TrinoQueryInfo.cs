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

    public class TrinoQueryInfo : AbstractModel
    {
        
        /// <summary>
        /// catalog
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// 提交IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIpAddr")]
        public string ClientIpAddr{ get; set; }

        /// <summary>
        /// 切片数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompletedSplits")]
        public string CompletedSplits{ get; set; }

        /// <summary>
        /// CPU时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuTime")]
        public long? CpuTime{ get; set; }

        /// <summary>
        /// 累计内存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CumulativeMemory")]
        public long? CumulativeMemory{ get; set; }

        /// <summary>
        /// 执行时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DurationMillis")]
        public long? DurationMillis{ get; set; }

        /// <summary>
        /// 结束时间 (s)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 查询ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 内部传输量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternalNetworkBytes")]
        public long? InternalNetworkBytes{ get; set; }

        /// <summary>
        /// 输出字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputBytes")]
        public long? OutputBytes{ get; set; }

        /// <summary>
        /// 峰值内存量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeakUserMemoryBytes")]
        public long? PeakUserMemoryBytes{ get; set; }

        /// <summary>
        /// 物理输入量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhysicalInputBytes")]
        public long? PhysicalInputBytes{ get; set; }

        /// <summary>
        /// 处理输入量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessedInputBytes")]
        public long? ProcessedInputBytes{ get; set; }

        /// <summary>
        /// 编译时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlCompileTime")]
        public long? SqlCompileTime{ get; set; }

        /// <summary>
        /// 开始时间 (s)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 执行状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 执行语句
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// 提交用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 写入字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WrittenBytes")]
        public long? WrittenBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "ClientIpAddr", this.ClientIpAddr);
            this.SetParamSimple(map, prefix + "CompletedSplits", this.CompletedSplits);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "CumulativeMemory", this.CumulativeMemory);
            this.SetParamSimple(map, prefix + "DurationMillis", this.DurationMillis);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InternalNetworkBytes", this.InternalNetworkBytes);
            this.SetParamSimple(map, prefix + "OutputBytes", this.OutputBytes);
            this.SetParamSimple(map, prefix + "PeakUserMemoryBytes", this.PeakUserMemoryBytes);
            this.SetParamSimple(map, prefix + "PhysicalInputBytes", this.PhysicalInputBytes);
            this.SetParamSimple(map, prefix + "ProcessedInputBytes", this.ProcessedInputBytes);
            this.SetParamSimple(map, prefix + "SqlCompileTime", this.SqlCompileTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "WrittenBytes", this.WrittenBytes);
        }
    }
}

