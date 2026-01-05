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

namespace TencentCloud.Vdb.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePriceResizeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指定实例所需的 CPU 核数。实例类型不同，支持的 CPU 核数存在差异。
        /// - 计算型： 1、2、4、8、16、24、32。
        /// - 标准型： 1、2、4、8、12、16。
        /// - 存储型： 1、2、4、6、8。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 指定实例所需的内存大小。单位：GB。选择具体规格，请参见[配置规格（选型）](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 指定实例所需的磁盘大小，单位：GB。选择具体规格，请参见[配置规格（选型）](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 指定实例所需配置的节点数量。选择方法，请参见[配置规格（选型）](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("WorkerNodeNum")]
        public ulong? WorkerNodeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "WorkerNodeNum", this.WorkerNodeNum);
        }
    }
}

