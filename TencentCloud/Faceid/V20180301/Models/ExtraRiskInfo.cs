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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtraRiskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>客户业务域内稳定且唯一的人员标识，用于把同一人员的多次位置上报关联起来，判断是否存在异常位移。</p><p>入参限制：长度 ≤ 128 字符；不可含控制字符（ASCII &lt; 0x20 或 0x7F）；建议传脱敏标识，勿传明文身份证号/手机号</p>
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// <p>设备采集时的纬度，WGS84 十进制度    </p><p>入参限制：与 Longitude 必须成对出现；取值 [-90, 90]；须为有效数字，不接受 NaN/Inf；JSON 中按字符串传（如 &quot;22.5431&quot;）</p>
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// <p>设备采集时的经度，WGS84 十进制度    </p><p>入参限制：与 Latitude 必须成对出现；取值 [-180, 180]；其余同上</p>
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// <p>设备采集时的公网出口 IP    </p><p>入参限制：长度 ≤ 64；须为可解析的 IPv4/IPv6；私网、回环、链路本地、组播地址视为不可定位</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
        }
    }
}

