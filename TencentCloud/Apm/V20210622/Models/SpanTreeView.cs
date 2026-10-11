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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpanTreeView : AbstractModel
    {
        
        /// <summary>
        /// 树结构json串
        /// </summary>
        [JsonProperty("TreeData")]
        public string TreeData{ get; set; }

        /// <summary>
        /// 列表
        /// </summary>
        [JsonProperty("ChartData")]
        public ChartData ChartData{ get; set; }

        /// <summary>
        /// Trace概览信息
        /// </summary>
        [JsonProperty("TraceOverview")]
        public TraceOverview TraceOverview{ get; set; }

        /// <summary>
        /// 压缩编码后的树结构json串
        /// </summary>
        [JsonProperty("CompressedTreeData")]
        public string CompressedTreeData{ get; set; }

        /// <summary>
        /// 整条链路的 span 数量是否超过限制
        /// </summary>
        [JsonProperty("CntExceeded")]
        public bool? CntExceeded{ get; set; }

        /// <summary>
        /// 是否有内部查询超时
        /// </summary>
        [JsonProperty("QueryTimeout")]
        public bool? QueryTimeout{ get; set; }

        /// <summary>
        /// 链路中 span 总数量
        /// </summary>
        [JsonProperty("SpanTotalCnt")]
        public long? SpanTotalCnt{ get; set; }

        /// <summary>
        /// 过滤视图的标签值列表
        /// </summary>
        [JsonProperty("FilterViewTagValues")]
        public TagValues[] FilterViewTagValues{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TreeData", this.TreeData);
            this.SetParamObj(map, prefix + "ChartData.", this.ChartData);
            this.SetParamObj(map, prefix + "TraceOverview.", this.TraceOverview);
            this.SetParamSimple(map, prefix + "CompressedTreeData", this.CompressedTreeData);
            this.SetParamSimple(map, prefix + "CntExceeded", this.CntExceeded);
            this.SetParamSimple(map, prefix + "QueryTimeout", this.QueryTimeout);
            this.SetParamSimple(map, prefix + "SpanTotalCnt", this.SpanTotalCnt);
            this.SetParamArrayObj(map, prefix + "FilterViewTagValues.", this.FilterViewTagValues);
        }
    }
}

