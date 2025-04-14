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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRequestDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求量统计起始时间，格式：2020-11-22 00:00:00
        /// </summary>
        [JsonProperty("TimeRangeBegin")]
        public string TimeRangeBegin{ get; set; }

        /// <summary>
        /// 筛选参数：
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 请求量统计结束时间，格式：2020-11-22 23:59:59
        /// </summary>
        [JsonProperty("TimeRangeEnd")]
        public string TimeRangeEnd{ get; set; }

        /// <summary>
        /// 是否导出：true导出，false不导出
        /// </summary>
        [JsonProperty("Export")]
        public bool? Export{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeRangeBegin", this.TimeRangeBegin);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "TimeRangeEnd", this.TimeRangeEnd);
            this.SetParamSimple(map, prefix + "Export", this.Export);
        }
    }
}

