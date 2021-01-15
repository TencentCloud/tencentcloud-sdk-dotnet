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

namespace TencentCloud.Apcas.V20201127.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeneralStat : AbstractModel
    {
        
        /// <summary>
        /// 今日调用量
        /// </summary>
        [JsonProperty("TodayAmount")]
        public ulong? TodayAmount{ get; set; }

        /// <summary>
        /// 本周调用量
        /// </summary>
        [JsonProperty("WeekAmount")]
        public ulong? WeekAmount{ get; set; }

        /// <summary>
        /// 本月调用量
        /// </summary>
        [JsonProperty("MonthAmount")]
        public ulong? MonthAmount{ get; set; }

        /// <summary>
        /// 总调用量
        /// </summary>
        [JsonProperty("TotalAmount")]
        public ulong? TotalAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TodayAmount", this.TodayAmount);
            this.SetParamSimple(map, prefix + "WeekAmount", this.WeekAmount);
            this.SetParamSimple(map, prefix + "MonthAmount", this.MonthAmount);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
        }
    }
}

