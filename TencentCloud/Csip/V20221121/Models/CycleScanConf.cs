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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CycleScanConf : AbstractModel
    {
        
        /// <summary>
        /// <p>周期扫描开关。0 关闭，1 开启。</p>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// <p>周期扫描的间隔类型。取值：</p><ul><li>DAY：每若干天，IntervalValueList 取间隔天数（如 ["1"] 表示每天）</li><li>WEEK：每周指定星期几，IntervalValueList 取 1~7（周一~周日）</li><li>MONTH：每月指定日期，IntervalValueList 取 1~31</li></ul>
        /// </summary>
        [JsonProperty("IntervalType")]
        public string IntervalType{ get; set; }

        /// <summary>
        /// <p>周期取值列表，含义随 IntervalType 变化：</p><ul><li>IntervalType=DAY：每隔多少天，例如 ["1"] 表示每天</li><li>IntervalType=WEEK：每周的星期几，取值 1~7（周一 ~ 周日）</li><li>IntervalType=MONTH：每月的几号，取值 1~31</li></ul>
        /// </summary>
        [JsonProperty("IntervalValueList")]
        public string[] IntervalValueList{ get; set; }

        /// <summary>
        /// <p>扫描时段起始时间，格式 HH:mm，例如 02:00。</p>
        /// </summary>
        [JsonProperty("ScanStart")]
        public string ScanStart{ get; set; }

        /// <summary>
        /// <p>扫描时段结束时间，格式 HH:mm，例如 06:00。</p>
        /// </summary>
        [JsonProperty("ScanEnd")]
        public string ScanEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "IntervalType", this.IntervalType);
            this.SetParamArraySimple(map, prefix + "IntervalValueList.", this.IntervalValueList);
            this.SetParamSimple(map, prefix + "ScanStart", this.ScanStart);
            this.SetParamSimple(map, prefix + "ScanEnd", this.ScanEnd);
        }
    }
}

