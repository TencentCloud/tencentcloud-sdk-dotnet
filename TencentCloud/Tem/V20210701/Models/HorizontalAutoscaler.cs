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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HorizontalAutoscaler : AbstractModel
    {
        
        /// <summary>
        /// 最小实例数（可以不传）
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// 最大实例数（可以不传）
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// 指标度量
        /// CPU（CPU使用率，%）
        /// MEMORY（内存使用率，%）
        /// CPU_CORE_USED（CPU使用量，core）
        /// MEMORY_SIZE_USED(内存使用量，MiB)
        /// NETWORK_BANDWIDTH_RECEIVE(网络入带宽，MBps)
        /// NETWORK_BANDWIDTH_TRANSMIT(网络出带宽，MBps)
        /// NETWORK_TRAFFIC_RECEIVE(网络入流量，MiB/s)
        /// NETWORK_TRAFFIC_TRANSMIT(网络出流量，MiB/s)
        /// NETWORK_PACKETS_RECEIVE(网络入包量，Count/s)
        /// NETWORK_PACKETS_TRANSMIT(网络出包量，Count/s)
        /// FS_IOPS_WRITE(磁盘写次数，Count/s)
        /// FS_IOPS_READ(磁盘读次数，Count/s)
        /// FS_SIZE_WRITE(磁盘写大小，MiB/s)
        /// FS_SIZE_READ(磁盘读大小，MiB/s)
        /// </summary>
        [JsonProperty("Metrics")]
        public string Metrics{ get; set; }

        /// <summary>
        /// 阈值（整数）
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 阈值（小数，优先使用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DoubleThreshold")]
        public float? DoubleThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "Metrics", this.Metrics);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DoubleThreshold", this.DoubleThreshold);
        }
    }
}

