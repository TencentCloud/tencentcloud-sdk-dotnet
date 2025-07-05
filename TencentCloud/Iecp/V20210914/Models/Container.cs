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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Container : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 镜像名
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像版本
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// 镜像拉取策略(Always|Never|IfNotPresent)
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// 卷挂载配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// cpu最低配置
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// cpu最高限制
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 内存最低要求
        /// </summary>
        [JsonProperty("MemoryRequest")]
        public string MemoryRequest{ get; set; }

        /// <summary>
        /// 内存最高要求
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public string MemoryLimit{ get; set; }

        /// <summary>
        /// 内存单位
        /// </summary>
        [JsonProperty("MemoryUnit")]
        public string MemoryUnit{ get; set; }

        /// <summary>
        /// gpu最高限制
        /// </summary>
        [JsonProperty("GpuLimit")]
        public string GpuLimit{ get; set; }

        /// <summary>
        /// 资源配置
        /// </summary>
        [JsonProperty("ResourceMapCloud")]
        public KeyValueObj[] ResourceMapCloud{ get; set; }

        /// <summary>
        /// 环境配置
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 工作目录
        /// </summary>
        [JsonProperty("WorkingDir")]
        public string WorkingDir{ get; set; }

        /// <summary>
        /// 命令
        /// </summary>
        [JsonProperty("Commands")]
        public string[] Commands{ get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// 安全配置
        /// </summary>
        [JsonProperty("SecurityContext")]
        public SecurityContext SecurityContext{ get; set; }

        /// <summary>
        /// 就绪探针配置
        /// </summary>
        [JsonProperty("ReadinessProbe")]
        public Probe ReadinessProbe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemoryRequest", this.MemoryRequest);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "MemoryUnit", this.MemoryUnit);
            this.SetParamSimple(map, prefix + "GpuLimit", this.GpuLimit);
            this.SetParamArrayObj(map, prefix + "ResourceMapCloud.", this.ResourceMapCloud);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamSimple(map, prefix + "WorkingDir", this.WorkingDir);
            this.SetParamArraySimple(map, prefix + "Commands.", this.Commands);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamObj(map, prefix + "SecurityContext.", this.SecurityContext);
            this.SetParamObj(map, prefix + "ReadinessProbe.", this.ReadinessProbe);
        }
    }
}

