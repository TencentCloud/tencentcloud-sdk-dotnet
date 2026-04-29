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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDeviceTrustStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>设备状态，1表示拉黑，0表示加白</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>设备MID列表</p>
        /// </summary>
        [JsonProperty("DeviceIDList")]
        public string[] DeviceIDList{ get; set; }

        /// <summary>
        /// <p>设备拉黑有效期，UnixTime, 单位是 ms,0表示永久有效，默认值是0</p>
        /// </summary>
        [JsonProperty("BlackStatusDeadline")]
        public long? BlackStatusDeadline{ get; set; }

        /// <summary>
        /// <p>DescribeAccuserList返回的Id 列表</p>
        /// </summary>
        [JsonProperty("IdList")]
        public long?[] IdList{ get; set; }

        /// <summary>
        /// <p>默认值：0，根据id更新，1根据DeviceIDList</p>
        /// </summary>
        [JsonProperty("UpdateFlags")]
        public long? UpdateFlags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "DeviceIDList.", this.DeviceIDList);
            this.SetParamSimple(map, prefix + "BlackStatusDeadline", this.BlackStatusDeadline);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
            this.SetParamSimple(map, prefix + "UpdateFlags", this.UpdateFlags);
        }
    }
}

