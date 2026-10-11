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

    public class JobDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>作业唯一标识.</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>作业名称.</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>创建/提交者子账号 UIN。</p>
        /// </summary>
        [JsonProperty("CreatorSubUin")]
        public string CreatorSubUin{ get; set; }

        /// <summary>
        /// <p>作业状态.</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>引擎大类.</p>
        /// </summary>
        [JsonProperty("MajorType")]
        public string MajorType{ get; set; }

        /// <summary>
        /// <p>引擎子类型.</p>
        /// </summary>
        [JsonProperty("MinorType")]
        public string MinorType{ get; set; }

        /// <summary>
        /// <p>运行模式（WAREHOUSE / JOB）.</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>计算仓库 ID，RunMode=WAREHOUSE 时非空.</p>
        /// </summary>
        [JsonProperty("WarehouseId")]
        public string WarehouseId{ get; set; }

        /// <summary>
        /// <p>资源分区编码.</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>资源分区展示名（解析不到时为空）.</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>队列名称.</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>流作业 checkpoint 路径（MinorType=SPARK_STREAM 时非空）。同一流作业的多次运行必须复用同一路径，变更等于重置消费进度。</p>
        /// </summary>
        [JsonProperty("CheckpointLocation")]
        public string CheckpointLocation{ get; set; }

        /// <summary>
        /// <p>创建时间（Unix 毫秒时间戳）.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>提交时间（Unix 毫秒时间戳）.</p>
        /// </summary>
        [JsonProperty("SubmitTime")]
        public long? SubmitTime{ get; set; }

        /// <summary>
        /// <p>完成时间（Unix 毫秒时间戳）.</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public long? FinishTime{ get; set; }

        /// <summary>
        /// <p>运行时长（毫秒）.</p>
        /// </summary>
        [JsonProperty("RunningTimeMs")]
        public long? RunningTimeMs{ get; set; }

        /// <summary>
        /// <p>计算仓库名称（详情接口反查填充，warehouse 模式下非空）.</p>
        /// </summary>
        [JsonProperty("WarehouseName")]
        public string WarehouseName{ get; set; }

        /// <summary>
        /// <p>流程 ID。</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>执行 ID。</p>
        /// </summary>
        [JsonProperty("ExecutionId")]
        public string ExecutionId{ get; set; }

        /// <summary>
        /// <p>作业来源。</p>
        /// </summary>
        [JsonProperty("JobSource")]
        public string JobSource{ get; set; }

        /// <summary>
        /// <p>排队等待时长（毫秒）。</p>
        /// </summary>
        [JsonProperty("WaitingTimeMs")]
        public long? WaitingTimeMs{ get; set; }

        /// <summary>
        /// <p>Spark UI 历史链接。</p>
        /// </summary>
        [JsonProperty("HistoryUrl")]
        public string HistoryUrl{ get; set; }

        /// <summary>
        /// <p>失败时的错误信息。</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>自定义 Spark conf（JSON 字符串，由 job_config 组装）.</p>
        /// </summary>
        [JsonProperty("CustomProperties")]
        public string CustomProperties{ get; set; }

        /// <summary>
        /// <p>环境变量.</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public KVPair[] EnvVars{ get; set; }

        /// <summary>
        /// <p>运行时/镜像。</p>
        /// </summary>
        [JsonProperty("RuntimeCode")]
        public string RuntimeCode{ get; set; }

        /// <summary>
        /// <p>运行时展示名（如 Spark 3.5.5），与 RuntimeCode 配套；解析不到时为空。</p>
        /// </summary>
        [JsonProperty("RuntimeName")]
        public string RuntimeName{ get; set; }

        /// <summary>
        /// <p>Catalog 版本码。</p>
        /// </summary>
        [JsonProperty("SysCatalogVersion")]
        public string SysCatalogVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "CreatorSubUin", this.CreatorSubUin);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "MajorType", this.MajorType);
            this.SetParamSimple(map, prefix + "MinorType", this.MinorType);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "WarehouseId", this.WarehouseId);
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "CheckpointLocation", this.CheckpointLocation);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SubmitTime", this.SubmitTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "RunningTimeMs", this.RunningTimeMs);
            this.SetParamSimple(map, prefix + "WarehouseName", this.WarehouseName);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ExecutionId", this.ExecutionId);
            this.SetParamSimple(map, prefix + "JobSource", this.JobSource);
            this.SetParamSimple(map, prefix + "WaitingTimeMs", this.WaitingTimeMs);
            this.SetParamSimple(map, prefix + "HistoryUrl", this.HistoryUrl);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "CustomProperties", this.CustomProperties);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamSimple(map, prefix + "RuntimeCode", this.RuntimeCode);
            this.SetParamSimple(map, prefix + "RuntimeName", this.RuntimeName);
            this.SetParamSimple(map, prefix + "SysCatalogVersion", this.SysCatalogVersion);
        }
    }
}

