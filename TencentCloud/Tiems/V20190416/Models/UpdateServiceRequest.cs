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

    public class UpdateServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务Id
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

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
        /// 支持AUTO, MANUAL，分别表示自动扩缩容，手动扩缩容
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }

        /// <summary>
        /// 支持STOP(停止) RESUME(重启)
        /// </summary>
        [JsonProperty("ServiceAction")]
        public string ServiceAction{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// GPU卡类型
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// 处理器配置，单位为 1/1000 核
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存配置，单位为1M
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 显卡配置，单位为 1/1000 卡
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamObj(map, prefix + "Scaler.", this.Scaler);
            this.SetParamSimple(map, prefix + "ServiceConfigId", this.ServiceConfigId);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamSimple(map, prefix + "ServiceAction", this.ServiceAction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
        }
    }
}

