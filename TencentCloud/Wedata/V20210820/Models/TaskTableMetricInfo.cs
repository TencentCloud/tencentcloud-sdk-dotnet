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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskTableMetricInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 总记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRecordNum")]
        public long? TotalRecordNum{ get; set; }

        /// <summary>
        /// 总字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRecordByteNum")]
        public long? TotalRecordByteNum{ get; set; }

        /// <summary>
        /// 总脏记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalDirtyRecordNum")]
        public long? TotalDirtyRecordNum{ get; set; }

        /// <summary>
        /// Schema名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// topic名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Collection名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Collection")]
        public string Collection{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("DataSourceName")]
        public string DataSourceName{ get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 逻辑库名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogicDatabase")]
        public string LogicDatabase{ get; set; }

        /// <summary>
        /// 逻辑表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogicTable")]
        public string LogicTable{ get; set; }

        /// <summary>
        /// 逻辑schema名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogicSchema")]
        public string LogicSchema{ get; set; }

        /// <summary>
        /// 物理表信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTableMetricInfos")]
        public TaskTableMetricInfo[] TaskTableMetricInfos{ get; set; }

        /// <summary>
        /// 同步状态，0-未知，1-正常， 2-异常
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyncStatus")]
        public long? SyncStatus{ get; set; }

        /// <summary>
        /// Target数据库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetDatabaseName")]
        public string TargetDatabaseName{ get; set; }

        /// <summary>
        /// Target表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetTableName")]
        public string TargetTableName{ get; set; }

        /// <summary>
        /// Write总记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WriteTotalRecordNum")]
        public long? WriteTotalRecordNum{ get; set; }

        /// <summary>
        /// Write总字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WriteTotalRecordByteNum")]
        public string WriteTotalRecordByteNum{ get; set; }

        /// <summary>
        /// TargetSchema名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSchemaName")]
        public string TargetSchemaName{ get; set; }

        /// <summary>
        /// Targettopic名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetTopic")]
        public string TargetTopic{ get; set; }

        /// <summary>
        /// TargetCollection名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetCollection")]
        public string TargetCollection{ get; set; }

        /// <summary>
        /// 数据源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetDataSourceName")]
        public string TargetDataSourceName{ get; set; }

        /// <summary>
        /// 节点id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetNodeId")]
        public string TargetNodeId{ get; set; }

        /// <summary>
        /// 读取条数的速度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRecordSpeed")]
        public float? TotalRecordSpeed{ get; set; }

        /// <summary>
        /// 写入条数的速度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WriteTotalRecordSpeed")]
        public float? WriteTotalRecordSpeed{ get; set; }

        /// <summary>
        /// 异常原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExceptionReason")]
        public string ExceptionReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TotalRecordNum", this.TotalRecordNum);
            this.SetParamSimple(map, prefix + "TotalRecordByteNum", this.TotalRecordByteNum);
            this.SetParamSimple(map, prefix + "TotalDirtyRecordNum", this.TotalDirtyRecordNum);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Collection", this.Collection);
            this.SetParamSimple(map, prefix + "DataSourceName", this.DataSourceName);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "LogicDatabase", this.LogicDatabase);
            this.SetParamSimple(map, prefix + "LogicTable", this.LogicTable);
            this.SetParamSimple(map, prefix + "LogicSchema", this.LogicSchema);
            this.SetParamArrayObj(map, prefix + "TaskTableMetricInfos.", this.TaskTableMetricInfos);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "TargetDatabaseName", this.TargetDatabaseName);
            this.SetParamSimple(map, prefix + "TargetTableName", this.TargetTableName);
            this.SetParamSimple(map, prefix + "WriteTotalRecordNum", this.WriteTotalRecordNum);
            this.SetParamSimple(map, prefix + "WriteTotalRecordByteNum", this.WriteTotalRecordByteNum);
            this.SetParamSimple(map, prefix + "TargetSchemaName", this.TargetSchemaName);
            this.SetParamSimple(map, prefix + "TargetTopic", this.TargetTopic);
            this.SetParamSimple(map, prefix + "TargetCollection", this.TargetCollection);
            this.SetParamSimple(map, prefix + "TargetDataSourceName", this.TargetDataSourceName);
            this.SetParamSimple(map, prefix + "TargetNodeId", this.TargetNodeId);
            this.SetParamSimple(map, prefix + "TotalRecordSpeed", this.TotalRecordSpeed);
            this.SetParamSimple(map, prefix + "WriteTotalRecordSpeed", this.WriteTotalRecordSpeed);
            this.SetParamSimple(map, prefix + "ExceptionReason", this.ExceptionReason);
        }
    }
}

