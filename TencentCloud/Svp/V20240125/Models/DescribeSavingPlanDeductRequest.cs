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

namespace TencentCloud.Svp.V20240125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSavingPlanDeductRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 每页数量，最大值为200
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 节省计划使用开始的查询结束时间
        /// </summary>
        [JsonProperty("StartEndDate")]
        public string StartEndDate{ get; set; }

        /// <summary>
        /// 节省计划使用开始的查询开始时间
        /// </summary>
        [JsonProperty("StartStartDate")]
        public string StartStartDate{ get; set; }

        /// <summary>
        /// 地域编码
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 节省计划资源id
        /// </summary>
        [JsonProperty("SpId")]
        public string SpId{ get; set; }

        /// <summary>
        /// 抵扣查询结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("DeductEndDate")]
        public string DeductEndDate{ get; set; }

        /// <summary>
        /// 抵扣查询开始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("DeductStartDate")]
        public string DeductStartDate{ get; set; }

        /// <summary>
        /// 节省计划使用结束的查询结束时间
        /// </summary>
        [JsonProperty("EndEndDate")]
        public string EndEndDate{ get; set; }

        /// <summary>
        /// 节省计划使用结束的查询开始时间
        /// </summary>
        [JsonProperty("EndStartDate")]
        public string EndStartDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "StartEndDate", this.StartEndDate);
            this.SetParamSimple(map, prefix + "StartStartDate", this.StartStartDate);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SpId", this.SpId);
            this.SetParamSimple(map, prefix + "DeductEndDate", this.DeductEndDate);
            this.SetParamSimple(map, prefix + "DeductStartDate", this.DeductStartDate);
            this.SetParamSimple(map, prefix + "EndEndDate", this.EndEndDate);
            this.SetParamSimple(map, prefix + "EndStartDate", this.EndStartDate);
        }
    }
}

