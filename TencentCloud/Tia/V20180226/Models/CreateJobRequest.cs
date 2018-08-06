/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
        /// 运行任务的集群
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 运行任务的环境
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// 挂载的路径，支持nfs,cos(cos只在tia运行环境中支持)
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
        /// 运行任务的配置信息
        /// </summary>
        [JsonProperty("ScaleTier")]
        public string ScaleTier{ get; set; }

        /// <summary>
        /// （ScaleTier为Custom时）master机器类型
        /// </summary>
        [JsonProperty("MasterType")]
        public string MasterType{ get; set; }

        /// <summary>
        /// （ScaleTier为Custom时）worker机器类型
        /// </summary>
        [JsonProperty("WorkerType")]
        public string WorkerType{ get; set; }

        /// <summary>
        /// （ScaleTier为Custom时）parameter server机器类型
        /// </summary>
        [JsonProperty("ParameterServerType")]
        public string ParameterServerType{ get; set; }

        /// <summary>
        /// （ScaleTier为Custom时）worker机器数量
        /// </summary>
        [JsonProperty("WorkerCount")]
        public ulong? WorkerCount{ get; set; }

        /// <summary>
        /// （ScaleTier为Custom时）parameter server机器数量
        /// </summary>
        [JsonProperty("ParameterServerCount")]
        public ulong? ParameterServerCount{ get; set; }

        /// <summary>
        /// 启动debug mode，默认为false
        /// </summary>
        [JsonProperty("Debug")]
        public bool? Debug{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
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
        }
    }
}

