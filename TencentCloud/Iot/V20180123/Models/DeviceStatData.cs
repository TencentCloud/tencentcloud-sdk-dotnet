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

namespace TencentCloud.Iot.V20180123.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceStatData : AbstractModel
    {
        
        /// <summary>
        /// 时间点
        /// </summary>
        [JsonProperty("Datetime")]
        public string Datetime{ get; set; }

        /// <summary>
        /// 在线设备数
        /// </summary>
        [JsonProperty("DeviceOnline")]
        public ulong? DeviceOnline{ get; set; }

        /// <summary>
        /// 激活设备数
        /// </summary>
        [JsonProperty("DeviceActive")]
        public ulong? DeviceActive{ get; set; }

        /// <summary>
        /// 设备总数
        /// </summary>
        [JsonProperty("DeviceTotal")]
        public ulong? DeviceTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Datetime", this.Datetime);
            this.SetParamSimple(map, prefix + "DeviceOnline", this.DeviceOnline);
            this.SetParamSimple(map, prefix + "DeviceActive", this.DeviceActive);
            this.SetParamSimple(map, prefix + "DeviceTotal", this.DeviceTotal);
        }
    }
}

