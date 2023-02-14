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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRoomStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 峰值在线成员人数。
        /// </summary>
        [JsonProperty("PeakMemberNumber")]
        public ulong? PeakMemberNumber{ get; set; }

        /// <summary>
        /// 累计在线人数。
        /// </summary>
        [JsonProperty("MemberNumber")]
        public ulong? MemberNumber{ get; set; }

        /// <summary>
        /// 记录总数。包含进入房间或者应到未到的。
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 成员记录列表。
        /// </summary>
        [JsonProperty("MemberRecords")]
        public MemberRecord[] MemberRecords{ get; set; }

        /// <summary>
        /// 秒级unix时间戳，实际房间开始时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealStartTime")]
        public ulong? RealStartTime{ get; set; }

        /// <summary>
        /// 秒级unix时间戳，实际房间结束时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealEndTime")]
        public ulong? RealEndTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "PeakMemberNumber", this.PeakMemberNumber);
            this.SetParamSimple(map, prefix + "MemberNumber", this.MemberNumber);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "MemberRecords.", this.MemberRecords);
            this.SetParamSimple(map, prefix + "RealStartTime", this.RealStartTime);
            this.SetParamSimple(map, prefix + "RealEndTime", this.RealEndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

