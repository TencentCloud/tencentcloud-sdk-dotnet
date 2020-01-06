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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// 应用程序信息
        /// </summary>
        [JsonProperty("Application")]
        public Application Application{ get; set; }

        /// <summary>
        /// 任务名称，在一个作业内部唯一
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务实例运行个数
        /// </summary>
        [JsonProperty("TaskInstanceNum")]
        public ulong? TaskInstanceNum{ get; set; }

        /// <summary>
        /// 运行环境信息，ComputeEnv 和 EnvId 必须指定一个（且只有一个）参数。
        /// </summary>
        [JsonProperty("ComputeEnv")]
        public AnonymousComputeEnv ComputeEnv{ get; set; }

        /// <summary>
        /// 计算环境ID，ComputeEnv 和 EnvId 必须指定一个（且只有一个）参数。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 重定向信息
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public RedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// 重定向本地信息
        /// </summary>
        [JsonProperty("RedirectLocalInfo")]
        public RedirectLocalInfo RedirectLocalInfo{ get; set; }

        /// <summary>
        /// 输入映射
        /// </summary>
        [JsonProperty("InputMappings")]
        public InputMapping[] InputMappings{ get; set; }

        /// <summary>
        /// 输出映射
        /// </summary>
        [JsonProperty("OutputMappings")]
        public OutputMapping[] OutputMappings{ get; set; }

        /// <summary>
        /// 输出映射配置
        /// </summary>
        [JsonProperty("OutputMappingConfigs")]
        public OutputMappingConfig[] OutputMappingConfigs{ get; set; }

        /// <summary>
        /// 自定义环境变量
        /// </summary>
        [JsonProperty("EnvVars")]
        public EnvVar[] EnvVars{ get; set; }

        /// <summary>
        /// 授权信息
        /// </summary>
        [JsonProperty("Authentications")]
        public Authentication[] Authentications{ get; set; }

        /// <summary>
        /// TaskInstance失败后处理方式，取值包括TERMINATE（默认）、INTERRUPT、FAST_INTERRUPT。
        /// </summary>
        [JsonProperty("FailedAction")]
        public string FailedAction{ get; set; }

        /// <summary>
        /// 任务失败后的最大重试次数，默认为0
        /// </summary>
        [JsonProperty("MaxRetryCount")]
        public ulong? MaxRetryCount{ get; set; }

        /// <summary>
        /// 任务启动后的超时时间，单位秒，默认为86400秒
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 任务最大并发数限制，默认没有限制。
        /// </summary>
        [JsonProperty("MaxConcurrentNum")]
        public ulong? MaxConcurrentNum{ get; set; }

        /// <summary>
        /// 任务完成后，重启计算节点。适用于指定计算环境执行任务。
        /// </summary>
        [JsonProperty("RestartComputeNode")]
        public bool? RestartComputeNode{ get; set; }

        /// <summary>
        /// 启动任务过程中，创建计算资源如CVM失败后的最大重试次数，默认为0。
        /// </summary>
        [JsonProperty("ResourceMaxRetryCount")]
        public ulong? ResourceMaxRetryCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Application.", this.Application);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskInstanceNum", this.TaskInstanceNum);
            this.SetParamObj(map, prefix + "ComputeEnv.", this.ComputeEnv);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamObj(map, prefix + "RedirectLocalInfo.", this.RedirectLocalInfo);
            this.SetParamArrayObj(map, prefix + "InputMappings.", this.InputMappings);
            this.SetParamArrayObj(map, prefix + "OutputMappings.", this.OutputMappings);
            this.SetParamArrayObj(map, prefix + "OutputMappingConfigs.", this.OutputMappingConfigs);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamArrayObj(map, prefix + "Authentications.", this.Authentications);
            this.SetParamSimple(map, prefix + "FailedAction", this.FailedAction);
            this.SetParamSimple(map, prefix + "MaxRetryCount", this.MaxRetryCount);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "MaxConcurrentNum", this.MaxConcurrentNum);
            this.SetParamSimple(map, prefix + "RestartComputeNode", this.RestartComputeNode);
            this.SetParamSimple(map, prefix + "ResourceMaxRetryCount", this.ResourceMaxRetryCount);
        }
    }
}

