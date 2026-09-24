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

    public class ModifyJobDefinitionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>作业定义 ID。必填。</p>
        /// </summary>
        [JsonProperty("JobDefinitionId")]
        public string JobDefinitionId{ get; set; }

        /// <summary>
        /// <p>作业定义名称。创建后不可修改：仅接受与当前名称相同的值（回显），传不同值报错；不传表示不修改。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>修改后的作业定义描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>引擎大类（当前仅支持 SPARK）。</p>
        /// </summary>
        [JsonProperty("MajorType")]
        public string MajorType{ get; set; }

        /// <summary>
        /// <p>作业子类型，SPARK_SQL / SPARK_BATCH / SPARK_STREAM；非必填。</p>
        /// </summary>
        [JsonProperty("MinorType")]
        public string MinorType{ get; set; }

        /// <summary>
        /// <p>流作业 checkpoint 路径（如 cosn://bucket/path/checkpoint），非必填，传了即覆盖。SPARK_STREAM 定义必须非空；变更等于重置消费进度。</p>
        /// </summary>
        [JsonProperty("CheckpointLocation")]
        public string CheckpointLocation{ get; set; }

        /// <summary>
        /// <p>资源分区代码，仅目标 RunMode=JOB 可传（QueueName 非空时必填）；目标 RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>队列名称，仅目标 RunMode=JOB 可传且须与 PartitionCode 成对；目标 RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>运行时/镜像编码，可选（null=沿用当前值）。仅对 JOB 模式定义生效；目标 RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("RuntimeCode")]
        public string RuntimeCode{ get; set; }

        /// <summary>
        /// <p>内置 Catalog 版本码（取值为 DescribeSysCatalogList 返回的目录子类型），可选（null=沿用当前值）。</p>
        /// </summary>
        [JsonProperty("SysCatalogVersion")]
        public string SysCatalogVersion{ get; set; }

        /// <summary>
        /// <p>自定义 Spark conf（JSON 字符串，亦接受多行 key=value 文本，归一化为 JSON 存储、出参恒为 JSON），非必填，传了即整串覆盖。</p>
        /// </summary>
        [JsonProperty("CustomProperties")]
        public string CustomProperties{ get; set; }

        /// <summary>
        /// <p>环境变量（KEY=VALUE）列表，非必填，传了即整体覆盖。仅对 JOB 模式定义生效；目标 RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public KVPair[] EnvVars{ get; set; }

        /// <summary>
        /// <p>目标运行模式：WAREHOUSE / JOB；未传=保持不变。切换模式时两种模式的参数集严格隔离（切换 WAREHOUSE 须提供 WarehouseId 且禁传 JOB 模式专属字段，反之亦然）。</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>计算仓库 ID。仅目标 RunMode=WAREHOUSE 时可传（必填）；未传 RunMode 或目标为 JOB 时禁止传。</p>
        /// </summary>
        [JsonProperty("WarehouseId")]
        public string WarehouseId{ get; set; }


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
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "RuntimeCode", this.RuntimeCode);
            this.SetParamSimple(map, prefix + "SysCatalogVersion", this.SysCatalogVersion);
            this.SetParamSimple(map, prefix + "CustomProperties", this.CustomProperties);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "WarehouseId", this.WarehouseId);
        }
    }
}

