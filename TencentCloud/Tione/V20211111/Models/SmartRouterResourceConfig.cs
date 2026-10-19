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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartRouterResourceConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>副本数，最小 1，建议 &gt;=2 以确保高可用；Scheduler（EPP）默认 2（保障 EPP 高可用与 Gossip 同步）</p>
        /// </summary>
        [JsonProperty("Replicas")]
        public ulong? Replicas{ get; set; }

        /// <summary>
        /// <p>处理器资源，单位为 1/1000 核（milliCPU），与 EMS 一致</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// <p>内存资源，单位为 1MB，与 EMS 一致</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>自定义环境变量，用于覆盖 Deployment 内置默认环境变量。Gateway 典型用途：覆盖 BACKEND_SERVICE_HOST 等；Scheduler 典型用途：覆盖 LRU_CAPACITY、BLOCK_SIZE_TOKENS 等</p>
        /// </summary>
        [JsonProperty("Env")]
        public EnvVar[] Env{ get; set; }

        /// <summary>
        /// <p>实例类型/规格，用于指定组件运行的机器规格</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>sidecar 容器配置，复用推理服务同款 SidecarSpec；未设置或 ImageInfo.ImageUrl 为空时不创建 sidecar 容器。sidecar 容器环境变量与组件主容器保持一致，不单独下发</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sidecar")]
        public SidecarSpec Sidecar{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "Sidecar.", this.Sidecar);
        }
    }
}

