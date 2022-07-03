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

    public class CreateJobConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业Id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 主类
        /// </summary>
        [JsonProperty("EntrypointClass")]
        public string EntrypointClass{ get; set; }

        /// <summary>
        /// 主类入参
        /// </summary>
        [JsonProperty("ProgramArgs")]
        public string ProgramArgs{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 资源引用数组
        /// </summary>
        [JsonProperty("ResourceRefs")]
        public ResourceRef[] ResourceRefs{ get; set; }

        /// <summary>
        /// 作业默认并行度
        /// </summary>
        [JsonProperty("DefaultParallelism")]
        public ulong? DefaultParallelism{ get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// 1: 作业配置达到上限之后，自动删除可删除的最早版本
        /// </summary>
        [JsonProperty("AutoDelete")]
        public long? AutoDelete{ get; set; }

        /// <summary>
        /// 作业使用的 COS 存储桶名
        /// </summary>
        [JsonProperty("COSBucket")]
        public string COSBucket{ get; set; }

        /// <summary>
        /// 是否采集作业日志
        /// </summary>
        [JsonProperty("LogCollect")]
        public bool? LogCollect{ get; set; }

        /// <summary>
        /// JobManager规格
        /// </summary>
        [JsonProperty("JobManagerSpec")]
        public float? JobManagerSpec{ get; set; }

        /// <summary>
        /// TaskManager规格
        /// </summary>
        [JsonProperty("TaskManagerSpec")]
        public float? TaskManagerSpec{ get; set; }

        /// <summary>
        /// CLS日志集ID
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// CLS日志主题ID
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// 日志采集类型 2：CLS；3：COS
        /// </summary>
        [JsonProperty("LogCollectType")]
        public long? LogCollectType{ get; set; }

        /// <summary>
        /// pyflink作业运行时使用的python版本
        /// </summary>
        [JsonProperty("PythonVersion")]
        public string PythonVersion{ get; set; }

        /// <summary>
        /// 工作空间 SerialId
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }

        /// <summary>
        /// 日志级别
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
            this.SetParamArrayObj(map, prefix + "ResourceRefs.", this.ResourceRefs);
            this.SetParamSimple(map, prefix + "DefaultParallelism", this.DefaultParallelism);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "COSBucket", this.COSBucket);
            this.SetParamSimple(map, prefix + "LogCollect", this.LogCollect);
            this.SetParamSimple(map, prefix + "JobManagerSpec", this.JobManagerSpec);
            this.SetParamSimple(map, prefix + "TaskManagerSpec", this.TaskManagerSpec);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "LogCollectType", this.LogCollectType);
            this.SetParamSimple(map, prefix + "PythonVersion", this.PythonVersion);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
        }
    }
}

