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

    public class CreateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>作业名称，长度 ≤256；可省略，省略时服务端回退为 JobId。</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>流作业 checkpoint 路径（如 cosn://bucket/path/checkpoint）。MinorType=SPARK_STREAM 时必填；同一作业的多次运行必须复用同一路径，变更等于重置消费进度。</p>
        /// </summary>
        [JsonProperty("CheckpointLocation")]
        public string CheckpointLocation{ get; set; }

        /// <summary>
        /// <p>引擎大类，非必传，缺省 SPARK；当前仅支持 SPARK。</p>
        /// </summary>
        [JsonProperty("MajorType")]
        public string MajorType{ get; set; }

        /// <summary>
        /// <p>作业子类型，决定入口形态：SPARK_SQL（SQL 作业，Entrypoint.Statement 必填）/ SPARK_BATCH（批处理作业，Entrypoint.EntryFile 必填）/ SPARK_STREAM（流作业，EntryFile 与 CheckpointLocation 必填）。</p>
        /// </summary>
        [JsonProperty("MinorType")]
        public string MinorType{ get; set; }

        /// <summary>
        /// <p>工作流实例关联 ID（长度 ≤64）：同一工作流/会话的多条 SQL 作业传相同 FlowId，可共享同一 Spark 会话、复用已就绪引擎。MinorType=SPARK_SQL 时必填；FlowId 非空时必须同时传 ExecutionId。WAREHOUSE 模式下 FlowId 即会话句柄（一个 FlowId 只对应一个会话）：会话过期或已销毁后须换新 FlowId，否则返回 FailedOperation.FlowIdNotExists。</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>工作流内部执行标识（长度 ≤64），同一 FlowId 下每次提交须唯一（如自增序号/UUID）。用于重复提交防重：同一账号下命中未删除的同 (FlowId, ExecutionId) 作业时返回 FailedOperation.FlowExecutionConflict。FlowId 非空时必填（SPARK_SQL 因 FlowId 必填而必填）。</p>
        /// </summary>
        [JsonProperty("ExecutionId")]
        public string ExecutionId{ get; set; }

        /// <summary>
        /// <p>运行模式，必填。WAREHOUSE / JOB.</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>计算仓库 ID。RunMode=WAREHOUSE 时必填（仓库需处于 RUNNING，或 STOPPED 且 AutoStart 开启（提交后冷启动拉起））；RunMode=JOB 时必须为空。</p>
        /// </summary>
        [JsonProperty("WarehouseId")]
        public string WarehouseId{ get; set; }

        /// <summary>
        /// <p>运行时/镜像编码（可选值见 DescribeSparkRuntimes）。RunMode=JOB 时必填；RunMode=WAREHOUSE 时忽略。</p>
        /// </summary>
        [JsonProperty("RuntimeCode")]
        public string RuntimeCode{ get; set; }

        /// <summary>
        /// <p>内置 Catalog 版本码（取值为 DescribeSysCatalogList 返回的目录子类型）。RunMode=JOB 时条件必填：未传时若可用（enabled）SysCatalog 唯一则自动选中，多个/零个报错；RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("SysCatalogVersion")]
        public string SysCatalogVersion{ get; set; }

        /// <summary>
        /// <p>资源分区代码，仅 RunMode=JOB 可传（QueueName 非空时必填）；RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>队列名称，必须与 PartitionCode 成对使用（RunMode=JOB 下可选）；RunMode=WAREHOUSE 下被仓库反查值覆盖，无需传。</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>自定义 Spark conf（JSON 字符串，亦接受多行 key=value 文本，归一化为 JSON 存储、出参恒为 JSON），作为 SPARK_CUSTOM 配置通道落库，两种运行模式均生效。</p>
        /// </summary>
        [JsonProperty("CustomProperties")]
        public string CustomProperties{ get; set; }

        /// <summary>
        /// <p>环境变量（KEY=VALUE）列表。仅 RunMode=JOB 可传；RunMode=WAREHOUSE 时禁止传。</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public KVPair[] EnvVars{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "CheckpointLocation", this.CheckpointLocation);
            this.SetParamSimple(map, prefix + "MajorType", this.MajorType);
            this.SetParamSimple(map, prefix + "MinorType", this.MinorType);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ExecutionId", this.ExecutionId);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "WarehouseId", this.WarehouseId);
            this.SetParamSimple(map, prefix + "RuntimeCode", this.RuntimeCode);
            this.SetParamSimple(map, prefix + "SysCatalogVersion", this.SysCatalogVersion);
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "CustomProperties", this.CustomProperties);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
        }
    }
}

