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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrtcUsage : AbstractModel
    {
        
        /// <summary>
        /// 时间点，格式为YYYY-MM-DD HH:mm:ss。多天查询时，HH:mm:ss为00:00:00。
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// 时间点时间戳
        /// </summary>
        [JsonProperty("TimeStampKey")]
        public ulong? TimeStampKey{ get; set; }

        /// <summary>
        /// 用量数组。每个数值含义与UsageKey对应。单位:分钟。
        /// </summary>
        [JsonProperty("UsageValue")]
        public float?[] UsageValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeStampKey", this.TimeStampKey);
            this.SetParamArraySimple(map, prefix + "UsageValue.", this.UsageValue);
        }
    }
}

