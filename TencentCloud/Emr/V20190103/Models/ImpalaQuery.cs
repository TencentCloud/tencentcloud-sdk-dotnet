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

    public class ImpalaQuery : AbstractModel
    {
        
        /// <summary>
        /// 执行语句
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// 查询ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 执行状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 获取行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RowsFetched")]
        public long? RowsFetched{ get; set; }

        /// <summary>
        /// 用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 默认DB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultDB")]
        public string DefaultDB{ get; set; }

        /// <summary>
        /// 执行的Coordinator节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Coordinator")]
        public string Coordinator{ get; set; }

        /// <summary>
        /// 单节点内存峰值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxNodePeakMemoryUsage")]
        public string MaxNodePeakMemoryUsage{ get; set; }

        /// <summary>
        /// 查询类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 扫描的HDFS行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanHDFSRows")]
        public long? ScanHDFSRows{ get; set; }

        /// <summary>
        /// 扫描的Kudu行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanKUDURows")]
        public long? ScanKUDURows{ get; set; }

        /// <summary>
        /// 扫描的总行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanRowsTotal")]
        public long? ScanRowsTotal{ get; set; }

        /// <summary>
        /// 读取的总字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalBytesRead")]
        public long? TotalBytesRead{ get; set; }

        /// <summary>
        /// 发送的总字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalBytesSent")]
        public long? TotalBytesSent{ get; set; }

        /// <summary>
        /// CPU总时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCpuTime")]
        public long? TotalCpuTime{ get; set; }

        /// <summary>
        /// 内部数据发送总量(Bytes)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalInnerBytesSent")]
        public long? TotalInnerBytesSent{ get; set; }

        /// <summary>
        /// 内部扫描数据发送总量(Bytes)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalScanBytesSent")]
        public long? TotalScanBytesSent{ get; set; }

        /// <summary>
        /// 预估单节点内存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EstimatedPerHostMemBytes")]
        public long? EstimatedPerHostMemBytes{ get; set; }

        /// <summary>
        /// 从缓存中获取的数据行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumRowsFetchedFromCache")]
        public long? NumRowsFetchedFromCache{ get; set; }

        /// <summary>
        /// 会话ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 单节点内存峰值和(Bytes)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PerNodePeakMemoryBytesSum")]
        public long? PerNodePeakMemoryBytesSum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "RowsFetched", this.RowsFetched);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "DefaultDB", this.DefaultDB);
            this.SetParamSimple(map, prefix + "Coordinator", this.Coordinator);
            this.SetParamSimple(map, prefix + "MaxNodePeakMemoryUsage", this.MaxNodePeakMemoryUsage);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "ScanHDFSRows", this.ScanHDFSRows);
            this.SetParamSimple(map, prefix + "ScanKUDURows", this.ScanKUDURows);
            this.SetParamSimple(map, prefix + "ScanRowsTotal", this.ScanRowsTotal);
            this.SetParamSimple(map, prefix + "TotalBytesRead", this.TotalBytesRead);
            this.SetParamSimple(map, prefix + "TotalBytesSent", this.TotalBytesSent);
            this.SetParamSimple(map, prefix + "TotalCpuTime", this.TotalCpuTime);
            this.SetParamSimple(map, prefix + "TotalInnerBytesSent", this.TotalInnerBytesSent);
            this.SetParamSimple(map, prefix + "TotalScanBytesSent", this.TotalScanBytesSent);
            this.SetParamSimple(map, prefix + "EstimatedPerHostMemBytes", this.EstimatedPerHostMemBytes);
            this.SetParamSimple(map, prefix + "NumRowsFetchedFromCache", this.NumRowsFetchedFromCache);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "PerNodePeakMemoryBytesSum", this.PerNodePeakMemoryBytesSum);
        }
    }
}

