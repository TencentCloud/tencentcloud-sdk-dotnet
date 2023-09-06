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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 程序包ID
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// 部署组启动参数
        /// </summary>
        [JsonProperty("StartupParameters")]
        public string StartupParameters{ get; set; }

        /// <summary>
        /// 部署应用描述信息
        /// </summary>
        [JsonProperty("DeployDesc")]
        public string DeployDesc{ get; set; }

        /// <summary>
        /// 是否允许强制启动
        /// </summary>
        [JsonProperty("ForceStart")]
        public bool? ForceStart{ get; set; }

        /// <summary>
        /// 是否开启健康检查
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// 开启健康检查时，配置健康检查
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// 部署方式，0表示快速更新，1表示滚动更新
        /// </summary>
        [JsonProperty("UpdateType")]
        public ulong? UpdateType{ get; set; }

        /// <summary>
        /// 是否启用beta批次
        /// </summary>
        [JsonProperty("DeployBetaEnable")]
        public bool? DeployBetaEnable{ get; set; }

        /// <summary>
        /// 滚动发布每个批次参与的实例比率
        /// </summary>
        [JsonProperty("DeployBatch")]
        public float?[] DeployBatch{ get; set; }

        /// <summary>
        /// 滚动发布的执行方式，auto表示自动， manual表示手动
        /// </summary>
        [JsonProperty("DeployExeMode")]
        public string DeployExeMode{ get; set; }

        /// <summary>
        /// 滚动发布每个批次的时间间隔
        /// </summary>
        [JsonProperty("DeployWaitTime")]
        public ulong? DeployWaitTime{ get; set; }

        /// <summary>
        /// 启动脚本 base64编码
        /// </summary>
        [JsonProperty("StartScript")]
        public string StartScript{ get; set; }

        /// <summary>
        /// 停止脚本 base64编码
        /// </summary>
        [JsonProperty("StopScript")]
        public string StopScript{ get; set; }

        /// <summary>
        /// 是否进行增量部署，默认为false，全量更新
        /// </summary>
        [JsonProperty("IncrementalDeployment")]
        public bool? IncrementalDeployment{ get; set; }

        /// <summary>
        /// JDK名称: konaJDK或openJDK
        /// </summary>
        [JsonProperty("JdkName")]
        public string JdkName{ get; set; }

        /// <summary>
        /// konaJDK版本：8、11和17
        /// openJDK版本：8、17
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }

        /// <summary>
        /// 部署agent的类型、版本
        /// </summary>
        [JsonProperty("AgentProfileList")]
        public AgentProfile[] AgentProfileList{ get; set; }

        /// <summary>
        /// 预热参数配置
        /// </summary>
        [JsonProperty("WarmupSetting")]
        public WarmupSetting WarmupSetting{ get; set; }

        /// <summary>
        /// 开启分批健康检查
        /// </summary>
        [JsonProperty("EnableBatchHealthCheck")]
        public bool? EnableBatchHealthCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "StartupParameters", this.StartupParameters);
            this.SetParamSimple(map, prefix + "DeployDesc", this.DeployDesc);
            this.SetParamSimple(map, prefix + "ForceStart", this.ForceStart);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "DeployBetaEnable", this.DeployBetaEnable);
            this.SetParamArraySimple(map, prefix + "DeployBatch.", this.DeployBatch);
            this.SetParamSimple(map, prefix + "DeployExeMode", this.DeployExeMode);
            this.SetParamSimple(map, prefix + "DeployWaitTime", this.DeployWaitTime);
            this.SetParamSimple(map, prefix + "StartScript", this.StartScript);
            this.SetParamSimple(map, prefix + "StopScript", this.StopScript);
            this.SetParamSimple(map, prefix + "IncrementalDeployment", this.IncrementalDeployment);
            this.SetParamSimple(map, prefix + "JdkName", this.JdkName);
            this.SetParamSimple(map, prefix + "JdkVersion", this.JdkVersion);
            this.SetParamArrayObj(map, prefix + "AgentProfileList.", this.AgentProfileList);
            this.SetParamObj(map, prefix + "WarmupSetting.", this.WarmupSetting);
            this.SetParamSimple(map, prefix + "EnableBatchHealthCheck", this.EnableBatchHealthCheck);
        }
    }
}

