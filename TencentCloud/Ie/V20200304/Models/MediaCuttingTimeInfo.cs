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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCuttingTimeInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间类型，可选值：
        /// PointSet：时间点集合；
        /// IntervalPoint：周期采样点；
        /// SectionSet：时间片段集合。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 截取时间点集合，单位毫秒，Type=PointSet时必选。
        /// </summary>
        [JsonProperty("PointSet")]
        public long?[] PointSet{ get; set; }

        /// <summary>
        /// 周期采样点信息，Type=IntervalPoint时必选。
        /// </summary>
        [JsonProperty("IntervalPoint")]
        public IntervalTime IntervalPoint{ get; set; }

        /// <summary>
        /// 时间区间集合信息，Type=SectionSet时必选。
        /// </summary>
        [JsonProperty("SectionSet")]
        public SectionTime[] SectionSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "PointSet.", this.PointSet);
            this.SetParamObj(map, prefix + "IntervalPoint.", this.IntervalPoint);
            this.SetParamArrayObj(map, prefix + "SectionSet.", this.SectionSet);
        }
    }
}

