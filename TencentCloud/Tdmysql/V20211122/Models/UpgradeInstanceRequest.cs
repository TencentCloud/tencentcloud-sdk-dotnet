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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例规格码</p>
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>存储节点磁盘容量，单位GB</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>存储节点CPU核数</p>
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>存储节点内存大小</p>
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>磁盘类型，需要修改磁盘类型时传</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

