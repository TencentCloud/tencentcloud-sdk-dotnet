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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudBaseRunSideSpec : AbstractModel
    {
        
        /// <summary>
        /// 容器镜像
        /// </summary>
        [JsonProperty("ContainerImage")]
        public string ContainerImage{ get; set; }

        /// <summary>
        /// 容器端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public long? ContainerPort{ get; set; }

        /// <summary>
        /// 容器的名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// kv的json字符串
        /// </summary>
        [JsonProperty("EnvVar")]
        public string EnvVar{ get; set; }

        /// <summary>
        /// InitialDelaySeconds 延迟多长时间启动健康检查
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// CPU大小
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存大小（单位：M）
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// 安全特性
        /// </summary>
        [JsonProperty("Security")]
        public CloudBaseSecurityContext Security{ get; set; }

        /// <summary>
        /// 挂载信息
        /// </summary>
        [JsonProperty("VolumeMountInfos")]
        public CloudBaseRunVolumeMount[] VolumeMountInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContainerImage", this.ContainerImage);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "EnvVar", this.EnvVar);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamObj(map, prefix + "Security.", this.Security);
            this.SetParamArrayObj(map, prefix + "VolumeMountInfos.", this.VolumeMountInfos);
        }
    }
}

