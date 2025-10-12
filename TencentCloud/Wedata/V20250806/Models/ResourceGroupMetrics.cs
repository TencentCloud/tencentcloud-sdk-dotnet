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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceGroupMetrics : AbstractModel
    {
        
        /// <summary>
        /// 资源组规格相关：cpu个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// 资源组规格相关：磁盘规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskVolume")]
        public ulong? DiskVolume{ get; set; }

        /// <summary>
        /// 资源组规格相关：内存大小，单位:G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 资源组生命周期, 单位：天
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifeCycle")]
        public ulong? LifeCycle{ get; set; }

        /// <summary>
        /// 资源组规格相关：最高并发
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaximumConcurrency")]
        public ulong? MaximumConcurrency{ get; set; }

        /// <summary>
        /// 资源组状态
        /// 
        /// - 0 --- 初始化中
        /// - 1 --- 运行中
        /// - 2 --- 运行异常
        /// - 3 --- 释放中
        /// - 4 --- 已释放
        /// - 5 --- 创建中
        /// - 6 --- 创建失败
        /// - 7 --- 更新中
        /// - 8 --- 更新失败
        /// - 9 --- 已到期
        /// - 10 --- 释放失败
        /// - 11 --- 使用中
        /// - 12 --- 未使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 指标详情
        /// </summary>
        [JsonProperty("MetricSnapshots")]
        public MetricData[] MetricSnapshots{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "DiskVolume", this.DiskVolume);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "LifeCycle", this.LifeCycle);
            this.SetParamSimple(map, prefix + "MaximumConcurrency", this.MaximumConcurrency);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "MetricSnapshots.", this.MetricSnapshots);
        }
    }
}

