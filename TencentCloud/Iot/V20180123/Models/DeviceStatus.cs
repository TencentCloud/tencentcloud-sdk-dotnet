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

    public class DeviceStatus : AbstractModel
    {
        
        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备状态（inactive, online, offline）
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 首次上线时间
        /// </summary>
        [JsonProperty("FirstOnline")]
        public string FirstOnline{ get; set; }

        /// <summary>
        /// 最后上线时间
        /// </summary>
        [JsonProperty("LastOnline")]
        public string LastOnline{ get; set; }

        /// <summary>
        /// 上线次数
        /// </summary>
        [JsonProperty("OnlineTimes")]
        public ulong? OnlineTimes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FirstOnline", this.FirstOnline);
            this.SetParamSimple(map, prefix + "LastOnline", this.LastOnline);
            this.SetParamSimple(map, prefix + "OnlineTimes", this.OnlineTimes);
        }
    }
}

