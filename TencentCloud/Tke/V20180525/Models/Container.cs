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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Container : AbstractModel
    {
        
        /// <summary>
        /// 镜像
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 容器名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 容器启动命令
        /// </summary>
        [JsonProperty("Commands")]
        public string[] Commands{ get; set; }

        /// <summary>
        /// 容器启动参数
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// 容器内操作系统的环境变量
        /// </summary>
        [JsonProperty("EnvironmentVars")]
        public EnvironmentVariable[] EnvironmentVars{ get; set; }

        /// <summary>
        /// CPU，制改容器最多可使用的核数，该值不可超过容器实例的总核数。单位：核。
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 内存，限制该容器最多可使用的内存值，该值不可超过容器实例的总内存值。单位：GiB
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// 数据卷挂载信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// 当前状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentState")]
        public ContainerState CurrentState{ get; set; }

        /// <summary>
        /// 重启次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RestartCount")]
        public ulong? RestartCount{ get; set; }

        /// <summary>
        /// 容器工作目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkingDir")]
        public string WorkingDir{ get; set; }

        /// <summary>
        /// 存活探针
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessProbe")]
        public LivenessOrReadinessProbe LivenessProbe{ get; set; }

        /// <summary>
        /// 就绪探针
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadinessProbe")]
        public LivenessOrReadinessProbe ReadinessProbe{ get; set; }

        /// <summary>
        /// Gpu限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuLimit")]
        public ulong? GpuLimit{ get; set; }

        /// <summary>
        /// 容器的安全上下文
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityContext")]
        public SecurityContext SecurityContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Commands.", this.Commands);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamArrayObj(map, prefix + "EnvironmentVars.", this.EnvironmentVars);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamObj(map, prefix + "CurrentState.", this.CurrentState);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamSimple(map, prefix + "WorkingDir", this.WorkingDir);
            this.SetParamObj(map, prefix + "LivenessProbe.", this.LivenessProbe);
            this.SetParamObj(map, prefix + "ReadinessProbe.", this.ReadinessProbe);
            this.SetParamSimple(map, prefix + "GpuLimit", this.GpuLimit);
            this.SetParamObj(map, prefix + "SecurityContext.", this.SecurityContext);
        }
    }
}

