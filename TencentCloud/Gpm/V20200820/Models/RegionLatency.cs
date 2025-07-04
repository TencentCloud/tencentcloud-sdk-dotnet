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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionLatency : AbstractModel
    {
        
        /// <summary>
        /// 地域
        /// ap-beijing          华北地区(北京)
        /// ap-chengdu          西南地区(成都)
        /// ap-guangzhou          华南地区(广州)
        /// ap-hongkong          港澳台地区(中国香港)
        /// ap-seoul          亚太地区(首尔)
        /// ap-shanghai          华东地区(上海)
        /// ap-singapore          东南亚地区(新加坡)
        /// eu-frankfurt          欧洲地区(法兰克福)
        /// na-siliconvalley          美国西部(硅谷)
        /// na-toronto          北美地区(多伦多)
        /// ap-mumbai          亚太地区(孟买)
        /// na-ashburn          美国东部(弗吉尼亚)
        /// ap-bangkok          亚太地区(曼谷)
        /// eu-moscow          欧洲地区(莫斯科)
        /// ap-tokyo          亚太地区(东京)
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 毫秒延迟 0～999999
        /// </summary>
        [JsonProperty("Latency")]
        public ulong? Latency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
        }
    }
}

