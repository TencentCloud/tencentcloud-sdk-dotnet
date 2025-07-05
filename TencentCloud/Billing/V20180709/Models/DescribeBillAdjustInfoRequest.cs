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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillAdjustInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 格式：yyyy-MM
        /// 账单月份，month和timeFrom&timeTo必传一个，如果有传timeFrom&timeTo则month字段无效
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd
        /// 开始时间，month和timeFrom&timeTo必传一个，如果有该字段则month字段无效。timeFrom和timeTo必须一起传，且为相同月份，不支持跨月查询，查询结果是整月数据
        /// </summary>
        [JsonProperty("TimeFrom")]
        public string TimeFrom{ get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd
        /// 截止时间，month和timeFrom&timeTo必传一个，如果有该字段则month字段无效。timeFrom和timeTo必须一起传，且为相同月份，不支持跨月查询，查询结果是整月数据
        /// </summary>
        [JsonProperty("TimeTo")]
        public string TimeTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "TimeFrom", this.TimeFrom);
            this.SetParamSimple(map, prefix + "TimeTo", this.TimeTo);
        }
    }
}

