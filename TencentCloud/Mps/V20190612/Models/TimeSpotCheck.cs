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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimeSpotCheck : AbstractModel
    {
        
        /// <summary>
        /// 每次循环检测的时长。取值范围（单位s）：
        /// 
        /// - 最小值：10
        /// - 最大值：86400
        /// </summary>
        [JsonProperty("CheckDuration")]
        public ulong? CheckDuration{ get; set; }

        /// <summary>
        /// 抽检间隔，表示在一次检测结束后，等待多长时间后，再次检测。取值范围（单位 s）：
        /// - 最小值：10
        /// - 最大值：3600
        /// </summary>
        [JsonProperty("CheckInterval")]
        public ulong? CheckInterval{ get; set; }

        /// <summary>
        /// 片头跳过时长。取值范围（单位 s）：
        /// - 最小值：1
        /// - 最大值：1800
        /// </summary>
        [JsonProperty("SkipDuration")]
        public ulong? SkipDuration{ get; set; }

        /// <summary>
        /// 循环次数。取值范围:
        /// - 最小值：0
        /// - 最大值：1000
        /// 
        /// 取值为 0 或为空时，表示循环至视频结束。
        /// </summary>
        [JsonProperty("CirclesNumber")]
        public ulong? CirclesNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckDuration", this.CheckDuration);
            this.SetParamSimple(map, prefix + "CheckInterval", this.CheckInterval);
            this.SetParamSimple(map, prefix + "SkipDuration", this.SkipDuration);
            this.SetParamSimple(map, prefix + "CirclesNumber", this.CirclesNumber);
        }
    }
}

