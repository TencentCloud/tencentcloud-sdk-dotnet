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

    public class DescribeTableContentPreviewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>表ID</p>
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// <p>组件类型枚举值，支持的值有 HDFS/HBASE/HIVE/KAFKA</p>
        /// </summary>
        [JsonProperty("TechnologyType")]
        public string TechnologyType{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>资源类型枚举值，支持的值有TOPIC/PATH/TABLE/DATABASE</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>表名</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>项目id</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>预览的行数，默认10行</p>
        /// </summary>
        [JsonProperty("RowNum")]
        public long? RowNum{ get; set; }

        /// <summary>
        /// <p>数据库名，kafka或其他无数据库概念的不填</p>
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>异步查询预览结果时填写</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>分区信息</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>资源组ID</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>执行SQL</p>
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// <p>引擎名</p>
        /// </summary>
        [JsonProperty("EngineId")]
        public string EngineId{ get; set; }

        /// <summary>
        /// <p>引擎类型详情</p><ul><li>SparkSQL：SparkSQL</li><li>PrestoSQL：Presto</li><li>SparkBatch：Spark作业</li><li>StandardPresto：Presto</li><li>StandardSpark：Spark</li></ul>
        /// </summary>
        [JsonProperty("EngineTypeDetail")]
        public string EngineTypeDetail{ get; set; }

        /// <summary>
        /// <p>数据源ID</p>
        /// </summary>
        [JsonProperty("DatasourceId")]
        public ulong? DatasourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TechnologyType", this.TechnologyType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RowNum", this.RowNum);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "EngineId", this.EngineId);
            this.SetParamSimple(map, prefix + "EngineTypeDetail", this.EngineTypeDetail);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
        }
    }
}

