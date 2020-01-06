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

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务创建时间，格式为：2006-01-02 15:04:05.999999999 -0700 MST
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务开始时间，格式为：2006-01-02 15:04:05.999999999 -0700 MST
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间，格式为：2006-01-02 15:04:05.999999999 -0700 MST
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务状态，可能的状态为Created（已创建），Running（运行中），Succeeded（运行完成：成功），Failed（运行完成：失败）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 任务状态信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

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
        /// 挂载的路径
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
        /// 任务删除时间，格式为：2006-01-02 15:04:05.999999999 -0700 MST
        /// </summary>
        [JsonProperty("DelTime")]
        public string DelTime{ get; set; }

        /// <summary>
        /// 创建任务的AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 创建任务的Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 创建任务的Debug模式
        /// </summary>
        [JsonProperty("Debug")]
        public bool? Debug{ get; set; }

        /// <summary>
        /// Runtime的额外配置信息
        /// </summary>
        [JsonProperty("RuntimeConf")]
        public string[] RuntimeConf{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ScaleTier", this.ScaleTier);
            this.SetParamSimple(map, prefix + "MasterType", this.MasterType);
            this.SetParamSimple(map, prefix + "WorkerType", this.WorkerType);
            this.SetParamSimple(map, prefix + "ParameterServerType", this.ParameterServerType);
            this.SetParamSimple(map, prefix + "WorkerCount", this.WorkerCount);
            this.SetParamSimple(map, prefix + "ParameterServerCount", this.ParameterServerCount);
            this.SetParamArraySimple(map, prefix + "PackageDir.", this.PackageDir);
            this.SetParamArraySimple(map, prefix + "Command.", this.Command);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "DelTime", this.DelTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Debug", this.Debug);
            this.SetParamArraySimple(map, prefix + "RuntimeConf.", this.RuntimeConf);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

