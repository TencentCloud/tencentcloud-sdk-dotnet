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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobsRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业ID列表，与Filters参数不能同时指定。
        /// </summary>
        [JsonProperty("JobIds")]
        public string[] JobIds{ get; set; }

        /// <summary>
        /// 过滤条件
        /// <li> job-id - String - 是否必填：否 -（过滤条件）按照作业ID过滤。</li>
        /// <li> job-name - String - 是否必填：否 -（过滤条件）按照作业名称过滤。</li>
        /// <li> job-state - String - 是否必填：否 -（过滤条件）按照作业状态过滤。</li>
        /// 
        ///     - SUBMITTED：已提交；
        ///     - PENDING：等待中；
        ///     - RUNNABLE：可运行；
        ///     - STARTING：启动中；
        ///     - RUNNING：运行中；
        ///     - SUCCEED：成功；
        ///     - FAILED：失败；
        ///     - FAILED_INTERRUPTED：失败后保留实例。
        /// 
        /// <li> zone - String - 是否必填：否 -（过滤条件）按照[可用区](https://cloud.tencent.com/document/product/213/15707)过滤。</li>
        /// <li> tag-key - String - 是否必填：否 -（过滤条件）按照标签键进行过滤。</li>
        /// <li> tag-value - String - 是否必填：否 -（过滤条件）按照标签值进行过滤。</li>
        /// <li> tag:tag-key - String - 是否必填：否 -（过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。</li>
        /// 与JobIds参数不能同时指定。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回job数量限制，最大值: 100，默认值: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "JobIds.", this.JobIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

