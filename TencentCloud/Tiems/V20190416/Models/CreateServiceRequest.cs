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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 扩缩容配置
        /// </summary>
        [JsonProperty("Scaler")]
        public Scaler Scaler{ get; set; }

        /// <summary>
        /// 服务配置Id
        /// </summary>
        [JsonProperty("ServiceConfigId")]
        public string ServiceConfigId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 扩缩容方式，支持AUTO, MANUAL，分别表示自动扩缩容和手动扩缩容
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }

        /// <summary>
        /// 部署要使用的资源组Id，默认为共享资源组
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 处理器配置, 单位为1/1000核；范围[100, 256000]
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存配置, 单位为1M；范围[100, 256000]
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 集群，不填则使用默认集群
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 默认为空，表示不需要鉴权，TOKEN 表示选择 Token 鉴权方式
        /// </summary>
        [JsonProperty("Authentication")]
        public string Authentication{ get; set; }

        /// <summary>
        /// GPU算力配置，单位为1/1000 卡，范围 [0, 256000]
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// 显存配置, 单位为1M，范围 [0, 256000]
        /// </summary>
        [JsonProperty("GpuMemory")]
        public ulong? GpuMemory{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// GPU类型
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Scaler.", this.Scaler);
            this.SetParamSimple(map, prefix + "ServiceConfigId", this.ServiceConfigId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "Authentication", this.Authentication);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "GpuMemory", this.GpuMemory);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
        }
    }
}

