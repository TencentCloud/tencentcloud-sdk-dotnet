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

namespace TencentCloud.Cis.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Container : AbstractModel
    {
        
        /// <summary>
        /// 容器启动命令
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 容器启动参数
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// 容器环境变量
        /// </summary>
        [JsonProperty("EnvironmentVars")]
        public EnvironmentVar[] EnvironmentVars{ get; set; }

        /// <summary>
        /// 镜像
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 容器名，由小写字母、数字和 - 组成，由小写字母开头，小写字母或数字结尾，且长度不超过 63个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// CPU，单位：核
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 内存，单位：Gi
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// 重启次数
        /// </summary>
        [JsonProperty("RestartCount")]
        public ulong? RestartCount{ get; set; }

        /// <summary>
        /// 当前状态
        /// </summary>
        [JsonProperty("CurrentState")]
        public ContainerState CurrentState{ get; set; }

        /// <summary>
        /// 上一次状态
        /// </summary>
        [JsonProperty("PreviousState")]
        public ContainerState PreviousState{ get; set; }

        /// <summary>
        /// 容器工作目录
        /// </summary>
        [JsonProperty("WorkingDir")]
        public string WorkingDir{ get; set; }

        /// <summary>
        /// 容器ID
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamArrayObj(map, prefix + "EnvironmentVars.", this.EnvironmentVars);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamObj(map, prefix + "CurrentState.", this.CurrentState);
            this.SetParamObj(map, prefix + "PreviousState.", this.PreviousState);
            this.SetParamSimple(map, prefix + "WorkingDir", this.WorkingDir);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
        }
    }
}

