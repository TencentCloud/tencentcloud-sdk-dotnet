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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTWeSeeTaskStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 算法类型。可选值：
        /// 
        /// - `VID_COMP`：视频理解
        /// - `IMG_COMP`：图片理解
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 套餐规格。可选值：
        /// 
        /// - `POSTPAID`：后付费（适用于视频理解、图片理解）
        /// - `BASIC`：包年包月基础版（适用于视频理解）
        /// </summary>
        [JsonProperty("ServiceTier")]
        public string ServiceTier{ get; set; }

        /// <summary>
        /// 起始时间 UNIX 时间戳，单位：秒
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间 UNIX 时间戳，单位：秒
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 数据点间隔，单位：秒；-1 表示汇总，只返回 1 个数据点
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ServiceTier", this.ServiceTier);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}

