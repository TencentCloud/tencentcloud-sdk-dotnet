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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveTimeShiftWriteSizeInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间点，
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 支持最近六个月的查询，查询开始和结束时间跨度不支持超过31天。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间点，
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 支持最近六个月的查询，查询开始和结束时间跨度不支持超过31天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// 维度
        /// Area地区、Domain 域名、StorageDays 时移天数
        /// </summary>
        [JsonProperty("Dimensions")]
        public string[] Dimensions{ get; set; }

        /// <summary>
        /// 时移天数。
        /// </summary>
        [JsonProperty("StorageDays")]
        public long?[] StorageDays{ get; set; }

        /// <summary>
        /// 时间跨度（分钟）
        /// 默认5，可选 5、60或者1440。
        /// </summary>
        [JsonProperty("Granularity")]
        public long? Granularity{ get; set; }

        /// <summary>
        /// 区域
        /// 可选Mainland、Oversea。
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
            this.SetParamArraySimple(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "StorageDays.", this.StorageDays);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
        }
    }
}

