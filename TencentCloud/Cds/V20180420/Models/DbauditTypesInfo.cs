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

namespace TencentCloud.Cds.V20180420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DbauditTypesInfo : AbstractModel
    {
        
        /// <summary>
        /// 规格描述
        /// </summary>
        [JsonProperty("InstanceVersionName")]
        public string InstanceVersionName{ get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("InstanceVersionKey")]
        public string InstanceVersionKey{ get; set; }

        /// <summary>
        /// 最大吞吐量
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// 最大实例数
        /// </summary>
        [JsonProperty("MaxInstances")]
        public ulong? MaxInstances{ get; set; }

        /// <summary>
        /// 入库速率（每小时）
        /// </summary>
        [JsonProperty("InsertSpeed")]
        public ulong? InsertSpeed{ get; set; }

        /// <summary>
        /// 最大在线存储量，单位：条
        /// </summary>
        [JsonProperty("OnlineStorageCapacity")]
        public ulong? OnlineStorageCapacity{ get; set; }

        /// <summary>
        /// 最大归档存储量，单位：条
        /// </summary>
        [JsonProperty("ArchivingStorageCapacity")]
        public ulong? ArchivingStorageCapacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceVersionName", this.InstanceVersionName);
            this.SetParamSimple(map, prefix + "InstanceVersionKey", this.InstanceVersionKey);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "MaxInstances", this.MaxInstances);
            this.SetParamSimple(map, prefix + "InsertSpeed", this.InsertSpeed);
            this.SetParamSimple(map, prefix + "OnlineStorageCapacity", this.OnlineStorageCapacity);
            this.SetParamSimple(map, prefix + "ArchivingStorageCapacity", this.ArchivingStorageCapacity);
        }
    }
}

