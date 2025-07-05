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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppMetricsDataRequest : AbstractModel
    {
        
        /// <summary>
        /// app 项目ID
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// 查询的表名
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 查询指标 field
        /// </summary>
        [JsonProperty("Fields")]
        public string Fields{ get; set; }

        /// <summary>
        /// 查询的过滤条件
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 查询简单过滤条件
        /// </summary>
        [JsonProperty("FilterSimple")]
        public string FilterSimple{ get; set; }

        /// <summary>
        /// group by 条件
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// order by 条件
        /// </summary>
        [JsonProperty("OrderBy")]
        public string[] OrderBy{ get; set; }

        /// <summary>
        /// limit 参数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// offset 参数
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// group by 参数
        /// </summary>
        [JsonProperty("GroupByModifier")]
        public string GroupByModifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Fields", this.Fields);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "FilterSimple", this.FilterSimple);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamArraySimple(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "GroupByModifier", this.GroupByModifier);
        }
    }
}

