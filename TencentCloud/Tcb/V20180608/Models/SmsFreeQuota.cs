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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmsFreeQuota : AbstractModel
    {
        
        /// <summary>
        /// 免费量总条数
        /// </summary>
        [JsonProperty("FreeQuota")]
        public ulong? FreeQuota{ get; set; }

        /// <summary>
        /// 共计已使用总条数
        /// </summary>
        [JsonProperty("TotalUsedQuota")]
        public ulong? TotalUsedQuota{ get; set; }

        /// <summary>
        /// 免费周期起点，0000-00-00 00:00:00 形式
        /// </summary>
        [JsonProperty("CycleStart")]
        public string CycleStart{ get; set; }

        /// <summary>
        /// 免费周期终点，0000-00-00 00:00:00 形式
        /// </summary>
        [JsonProperty("CycleEnd")]
        public string CycleEnd{ get; set; }

        /// <summary>
        /// 今天已使用总条数
        /// </summary>
        [JsonProperty("TodayUsedQuota")]
        public ulong? TodayUsedQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "TotalUsedQuota", this.TotalUsedQuota);
            this.SetParamSimple(map, prefix + "CycleStart", this.CycleStart);
            this.SetParamSimple(map, prefix + "CycleEnd", this.CycleEnd);
            this.SetParamSimple(map, prefix + "TodayUsedQuota", this.TodayUsedQuota);
        }
    }
}

