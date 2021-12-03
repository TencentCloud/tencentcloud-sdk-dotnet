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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStatisticSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 录制设备总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordingDevice")]
        public ulong? RecordingDevice{ get; set; }

        /// <summary>
        /// 非录制设备总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonRecordingDevice")]
        public ulong? NonRecordingDevice{ get; set; }

        /// <summary>
        /// 观看流量总数。为直播观看流量与点播观看流量之和。单位：GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WatchFlux")]
        public float? WatchFlux{ get; set; }

        /// <summary>
        /// 累计有效存储容量总数。单位：GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageUsage")]
        public float? StorageUsage{ get; set; }

        /// <summary>
        /// X-P2P分享流量。单位 Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P2PFluxTotal")]
        public float? P2PFluxTotal{ get; set; }

        /// <summary>
        /// X-P2P峰值带宽。 单位bps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P2PPeakValue")]
        public float? P2PPeakValue{ get; set; }

        /// <summary>
        /// RTMP推流路数 ( 直播推流)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivePushTotal")]
        public long? LivePushTotal{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordingDevice", this.RecordingDevice);
            this.SetParamSimple(map, prefix + "NonRecordingDevice", this.NonRecordingDevice);
            this.SetParamSimple(map, prefix + "WatchFlux", this.WatchFlux);
            this.SetParamSimple(map, prefix + "StorageUsage", this.StorageUsage);
            this.SetParamSimple(map, prefix + "P2PFluxTotal", this.P2PFluxTotal);
            this.SetParamSimple(map, prefix + "P2PPeakValue", this.P2PPeakValue);
            this.SetParamSimple(map, prefix + "LivePushTotal", this.LivePushTotal);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

