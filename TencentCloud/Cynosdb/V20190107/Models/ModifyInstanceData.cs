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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceData : AbstractModel
    {
        
        /// <summary>
        /// 变配后CPU
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 变配后内存
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 变配后存储上限
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// 变配前CPU
        /// </summary>
        [JsonProperty("OldCpu")]
        public long? OldCpu{ get; set; }

        /// <summary>
        /// 变配前内存
        /// </summary>
        [JsonProperty("OldMemory")]
        public long? OldMemory{ get; set; }

        /// <summary>
        /// 变配前存储上限
        /// </summary>
        [JsonProperty("OldStorageLimit")]
        public long? OldStorageLimit{ get; set; }

        /// <summary>
        /// 变配前实例机器类型
        /// </summary>
        [JsonProperty("OldDeviceType")]
        public string OldDeviceType{ get; set; }

        /// <summary>
        /// 变配后实例机器类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 升级方式。升级完成后切换或维护时间内切换
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// libra节点数量
        /// </summary>
        [JsonProperty("LibraNodeCount")]
        public long? LibraNodeCount{ get; set; }

        /// <summary>
        /// 原libra节点数量
        /// </summary>
        [JsonProperty("OldLibraNodeCount")]
        public long? OldLibraNodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "OldCpu", this.OldCpu);
            this.SetParamSimple(map, prefix + "OldMemory", this.OldMemory);
            this.SetParamSimple(map, prefix + "OldStorageLimit", this.OldStorageLimit);
            this.SetParamSimple(map, prefix + "OldDeviceType", this.OldDeviceType);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamSimple(map, prefix + "LibraNodeCount", this.LibraNodeCount);
            this.SetParamSimple(map, prefix + "OldLibraNodeCount", this.OldLibraNodeCount);
        }
    }
}

