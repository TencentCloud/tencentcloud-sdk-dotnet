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

namespace TencentCloud.Tia.V20180226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 运行任务的集群，详见 [使用集群](https://cloud.tencent.com/document/product/851/17317)
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 运行任务的环境，详见 [运行环境](https://cloud.tencent.com/document/product/851/17320)
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// 挂载的路径，支持 NFS，[CFS](https://cloud.tencent.com/product/cfs) 和 [COS](https://cloud.tencent.com/product/cos)，其中 COS 只在 [TI-A 定制环境](https://cloud.tencent.com/document/product/851/17320#ti-a-.E5.AE.9A.E5.88.B6.E7.8E.AF.E5.A2.83) 中支持
        /// </summary>
        [JsonProperty("PackageDir")]
        public string[] PackageDir{ get; set; }

        /// <summary>
        /// 任务启动命令
        /// </summary>
        [JsonProperty("Command")]
        public string[] Command{ get; set; }

        /// <summary>
        /// 任务启动参数
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// 运行任务的配置信息，详见 [训练规模](https://cloud.tencent.com/document/product/851/17319)
        /// </summary>
        [JsonProperty("ScaleTier")]
        public string ScaleTier{ get; set; }

        /// <summary>
        /// Master 机器类型，ScaleTier 取值为 `CUSTOM` 时必填，详见 [训练规模](https://cloud.tencent.com/document/product/851/17319)
        /// </summary>
        [JsonProperty("MasterType")]
        public string MasterType{ get; set; }

        /// <summary>
        /// Worker 机器类型，ScaleTier 取值为 `CUSTOM` 时必填，详见 [训练规模](https://cloud.tencent.com/document/product/851/17319)
        /// </summary>
        [JsonProperty("WorkerType")]
        public string WorkerType{ get; set; }

        /// <summary>
        /// Parameter server 机器类型，ScaleTier 取值为 `CUSTOM` 时必填,详见 [训练规模](https://cloud.tencent.com/document/product/851/17319)
        /// </summary>
        [JsonProperty("ParameterServerType")]
        public string ParameterServerType{ get; set; }

        /// <summary>
        /// Worker 机器数量，ScaleTier 取值为 `CUSTOM` 时必填,详见 [训练规模](https://cloud.tencent.com/document/product/851/17319)
        /// </summary>
        [JsonProperty("WorkerCount")]
        public ulong? WorkerCount{ get; set; }

        /// <summary>
        /// Parameter server 机器数量，ScaleTier 取值为 `CUSTOM` 时必填,详见 [训练规模](https://cloud.tencent.com/document/product/851/17319)
        /// </summary>
        [JsonProperty("ParameterServerCount")]
        public ulong? ParameterServerCount{ get; set; }

        /// <summary>
        /// 启动 debug 模式，默认为 false
        /// </summary>
        [JsonProperty("Debug")]
        public bool? Debug{ get; set; }

        /// <summary>
        /// 运行任务的其他配置信息
        /// </summary>
        [JsonProperty("RuntimeConf")]
        public string[] RuntimeConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamArraySimple(map, prefix + "PackageDir.", this.PackageDir);
            this.SetParamArraySimple(map, prefix + "Command.", this.Command);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "ScaleTier", this.ScaleTier);
            this.SetParamSimple(map, prefix + "MasterType", this.MasterType);
            this.SetParamSimple(map, prefix + "WorkerType", this.WorkerType);
            this.SetParamSimple(map, prefix + "ParameterServerType", this.ParameterServerType);
            this.SetParamSimple(map, prefix + "WorkerCount", this.WorkerCount);
            this.SetParamSimple(map, prefix + "ParameterServerCount", this.ParameterServerCount);
            this.SetParamSimple(map, prefix + "Debug", this.Debug);
            this.SetParamArraySimple(map, prefix + "RuntimeConf.", this.RuntimeConf);
        }
    }
}

