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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceRackOn : AbstractModel
    {
        
        /// <summary>
        /// 设备sn
        /// </summary>
        [JsonProperty("DeviceSn")]
        public string DeviceSn{ get; set; }

        /// <summary>
        /// 目标机架
        /// </summary>
        [JsonProperty("DstRackName")]
        public string DstRackName{ get; set; }

        /// <summary>
        /// 目标机位,服务器必传,网络设备不用传
        /// </summary>
        [JsonProperty("DstPositionCode")]
        public string DstPositionCode{ get; set; }

        /// <summary>
        /// 设备ip
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceSn", this.DeviceSn);
            this.SetParamSimple(map, prefix + "DstRackName", this.DstRackName);
            this.SetParamSimple(map, prefix + "DstPositionCode", this.DstPositionCode);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
        }
    }
}

