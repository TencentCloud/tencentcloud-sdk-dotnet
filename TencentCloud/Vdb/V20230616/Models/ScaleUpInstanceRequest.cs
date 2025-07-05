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

    public class ScaleUpInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定需升级配置的实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指定升级配置后的 CPU 核数。
        /// - 节点规格可选项（CPU & 内存）必须 >= 当前配置。
        /// - 可选择的规格信息，请参见[选择节点规格与数量](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 指定升级配置后的内存大小，单位为：GB。
        /// - 节点规格可选项（CPU & 内存）必须 >= 当前配置。
        /// - 不同实例类型对 CPU 与内存资源的配置比例有不同的要求。例如，计算型实例，CPU 与内存的分配比例要求为 1:2。CPU 被指定为 4 核，那么内存则应被指定为 8GB。节点规格的详细信息，请参见[选择节点规格与数量](https://cloud.tencent.com/document/product/1709/113399)。
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// 指定升级配置后的磁盘容量。
        /// - 单位：GB。
        /// - 取值范围为：[10,1000]。
        /// - 取值必须为10的倍数。
        /// </summary>
        [JsonProperty("StorageSize")]
        public ulong? StorageSize{ get; set; }

        /// <summary>
        /// 指定垂直扩容升级节点配置的时间。
        /// - false：默认值，指在下一个维护时间段内执行升配节点规格的任务。实例列表中“状态”列将显示“待执行配置变更”，等到维护时间窗内启动任务。维护时间的更多信息，请参见维护时间窗。
        /// - true：立即执行升级配置的任务，请确保此时没有重大业务操作。
        /// </summary>
        [JsonProperty("RunNow")]
        public bool? RunNow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "RunNow", this.RunNow);
        }
    }
}

