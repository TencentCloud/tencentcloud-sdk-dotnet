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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobDefinitionItemInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>作业定义唯一标识符（ID）。</p>
        /// </summary>
        [JsonProperty("JobDefinitionId")]
        public string JobDefinitionId{ get; set; }

        /// <summary>
        /// <p>作业定义名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>作业定义描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>作业主类型。</p>
        /// </summary>
        [JsonProperty("MajorType")]
        public string MajorType{ get; set; }

        /// <summary>
        /// <p>作业子类型。</p>
        /// </summary>
        [JsonProperty("MinorType")]
        public string MinorType{ get; set; }

        /// <summary>
        /// <p>流作业 checkpoint 路径（MinorType=SPARK_STREAM 时非空）。同一流作业的多次运行必须复用同一路径，变更等于重置消费进度。</p>
        /// </summary>
        [JsonProperty("CheckpointLocation")]
        public string CheckpointLocation{ get; set; }

        /// <summary>
        /// <p>创建者（子账号 UIN）。</p>
        /// </summary>
        [JsonProperty("CreatorSubUin")]
        public string CreatorSubUin{ get; set; }

        /// <summary>
        /// <p>创建时间（Unix 毫秒时间戳）。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（Unix 毫秒时间戳）。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>分区编码。</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>分区展示名（解析不到时为空）。</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>队列名称。</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>运行模式: JOB | WAREHOUSE.</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>计算仓库 ID, RunMode=WAREHOUSE 时非空.</p>
        /// </summary>
        [JsonProperty("WarehouseId")]
        public string WarehouseId{ get; set; }

        /// <summary>
        /// <p>请求时间窗口（InstanceTimeRange，默认 7 天）内的作业实例数。</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>运行时/镜像编码（可选值见 DescribeSparkRuntimes）。JOB 模式取定义自身配置，WAREHOUSE 模式取所属计算仓库运行时；解析不到时为空。</p>
        /// </summary>
        [JsonProperty("RuntimeCode")]
        public string RuntimeCode{ get; set; }

        /// <summary>
        /// <p>运行时展示名（如 Spark 3.5.5），与 RuntimeCode 配套；解析不到时为空。</p>
        /// </summary>
        [JsonProperty("RuntimeName")]
        public string RuntimeName{ get; set; }

        /// <summary>
        /// <p>计算仓库名称（列表整页按去重后的仓库反查填充；warehouse 模式下非空，仓库已销毁时仍回填历史名称）。</p>
        /// </summary>
        [JsonProperty("WarehouseName")]
        public string WarehouseName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobDefinitionId", this.JobDefinitionId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MajorType", this.MajorType);
            this.SetParamSimple(map, prefix + "MinorType", this.MinorType);
            this.SetParamSimple(map, prefix + "CheckpointLocation", this.CheckpointLocation);
            this.SetParamSimple(map, prefix + "CreatorSubUin", this.CreatorSubUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "WarehouseId", this.WarehouseId);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "RuntimeCode", this.RuntimeCode);
            this.SetParamSimple(map, prefix + "RuntimeName", this.RuntimeName);
            this.SetParamSimple(map, prefix + "WarehouseName", this.WarehouseName);
        }
    }
}

