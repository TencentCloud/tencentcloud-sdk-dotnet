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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamLinkFlowLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 传输流Id。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 统计的开始时间，默认为前一小时，最多支持查询近7天。
        /// UTC时间，如'2020-01-01T12:00:00Z'。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 统计的结束时间，默认为StartTime后一小时，最多支持查询24小时的数据。
        /// UTC时间，如'2020-01-01T12:00:00Z'。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 输入或输出类型，可选[input|output]。
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 主通道或备通道，可选[0|1]。
        /// </summary>
        [JsonProperty("Pipeline")]
        public string[] Pipeline{ get; set; }

        /// <summary>
        /// 每页大小，默认100，范围为[1, 1000]。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 按Timestamp升序或降序排序，默认降序，可选[desc|asc]。
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// 页码，默认1，范围为[1, 1000]。
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArraySimple(map, prefix + "Pipeline.", this.Pipeline);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
        }
    }
}

