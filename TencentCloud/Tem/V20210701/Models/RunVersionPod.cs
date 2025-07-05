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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunVersionPod : AbstractModel
    {
        
        /// <summary>
        /// shell地址
        /// </summary>
        [JsonProperty("Webshell")]
        public string Webshell{ get; set; }

        /// <summary>
        /// pod的id
        /// </summary>
        [JsonProperty("PodId")]
        public string PodId{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例的ip
        /// </summary>
        [JsonProperty("PodIp")]
        public string PodIp{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 部署版本
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// 重启次数
        /// </summary>
        [JsonProperty("RestartCount")]
        public long? RestartCount{ get; set; }

        /// <summary>
        /// pod是否就绪
        /// </summary>
        [JsonProperty("Ready")]
        public bool? Ready{ get; set; }

        /// <summary>
        /// 容器状态
        /// </summary>
        [JsonProperty("ContainerState")]
        public string ContainerState{ get; set; }

        /// <summary>
        /// 实例所在节点信息
        /// </summary>
        [JsonProperty("NodeInfo")]
        public NodeInfo NodeInfo{ get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 是否健康
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Unhealthy")]
        public bool? Unhealthy{ get; set; }

        /// <summary>
        /// 不健康时的提示信息
        /// </summary>
        [JsonProperty("UnhealthyWarningMsg")]
        public string UnhealthyWarningMsg{ get; set; }

        /// <summary>
        /// 版本ID
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Webshell", this.Webshell);
            this.SetParamSimple(map, prefix + "PodId", this.PodId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PodIp", this.PodIp);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamSimple(map, prefix + "Ready", this.Ready);
            this.SetParamSimple(map, prefix + "ContainerState", this.ContainerState);
            this.SetParamObj(map, prefix + "NodeInfo.", this.NodeInfo);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Unhealthy", this.Unhealthy);
            this.SetParamSimple(map, prefix + "UnhealthyWarningMsg", this.UnhealthyWarningMsg);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
        }
    }
}

