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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobConfig : AbstractModel
    {
        
        /// <summary>
        /// 作业Id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 主类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EntrypointClass")]
        public string EntrypointClass{ get; set; }

        /// <summary>
        /// 主类入参
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramArgs")]
        public string ProgramArgs{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 作业配置创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 作业配置的版本号
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// 作业默认并行度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultParallelism")]
        public ulong? DefaultParallelism{ get; set; }

        /// <summary>
        /// 系统参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// 引用资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceRefDetails")]
        public ResourceRefDetail[] ResourceRefDetails{ get; set; }

        /// <summary>
        /// 创建者uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 作业配置上次启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 作业绑定的存储桶
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("COSBucket")]
        public string COSBucket{ get; set; }

        /// <summary>
        /// 是否启用日志收集，0-未启用，1-已启用，2-历史集群未设置日志集，3-历史集群已开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogCollect")]
        public long? LogCollect{ get; set; }

        /// <summary>
        /// 作业的最大并行度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxParallelism")]
        public ulong? MaxParallelism{ get; set; }

        /// <summary>
        /// JobManager规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobManagerSpec")]
        public float? JobManagerSpec{ get; set; }

        /// <summary>
        /// TaskManager规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskManagerSpec")]
        public float? TaskManagerSpec{ get; set; }

        /// <summary>
        /// CLS日志集ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// CLS日志主题ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// pyflink作业运行的python版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PythonVersion")]
        public string PythonVersion{ get; set; }

        /// <summary>
        /// Oceanus 平台恢复作业开关 1:开启 -1: 关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRecover")]
        public long? AutoRecover{ get; set; }

        /// <summary>
        /// 日志级别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogLevel")]
        public string LogLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "EntrypointClass", this.EntrypointClass);
            this.SetParamSimple(map, prefix + "ProgramArgs", this.ProgramArgs);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "DefaultParallelism", this.DefaultParallelism);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamArrayObj(map, prefix + "ResourceRefDetails.", this.ResourceRefDetails);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "COSBucket", this.COSBucket);
            this.SetParamSimple(map, prefix + "LogCollect", this.LogCollect);
            this.SetParamSimple(map, prefix + "MaxParallelism", this.MaxParallelism);
            this.SetParamSimple(map, prefix + "JobManagerSpec", this.JobManagerSpec);
            this.SetParamSimple(map, prefix + "TaskManagerSpec", this.TaskManagerSpec);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "PythonVersion", this.PythonVersion);
            this.SetParamSimple(map, prefix + "AutoRecover", this.AutoRecover);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
        }
    }
}

