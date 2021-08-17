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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRotationDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 否允许轮转，true表示开启轮转，false表示禁止轮转。
        /// </summary>
        [JsonProperty("EnableRotation")]
        public bool? EnableRotation{ get; set; }

        /// <summary>
        /// 轮转的频率，以天为单位，默认为1天。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// 最近一次轮转的时间，显式可见的时间字符串，格式 2006-01-02 15:04:05。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestRotateTime")]
        public string LatestRotateTime{ get; set; }

        /// <summary>
        /// 下一次开始轮转的时间，显式可见的时间字符串，格式 2006-01-02 15:04:05。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextRotateBeginTime")]
        public string NextRotateBeginTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnableRotation", this.EnableRotation);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "LatestRotateTime", this.LatestRotateTime);
            this.SetParamSimple(map, prefix + "NextRotateBeginTime", this.NextRotateBeginTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

