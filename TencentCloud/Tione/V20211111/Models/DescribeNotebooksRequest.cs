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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNotebooksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>TI工作空间ID</p><p>使用非默认空间必须填写工作空间ID，使用默认空间无需填写工作空间ID。</p>
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// <p>偏移量，默认为0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>每页返回的实例数，默认为 10，最小值 0，最大值 100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>输出列表的排列顺序。取值范围：ASC：升序排列 DESC：降序排列。默认为DESC</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>根据哪个字段排序，如：CreateTime、UpdateTime，默认为UpdateTime</p>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// <p>过滤器，eg：[{ &quot;Name&quot;: &quot;Id&quot;, &quot;Values&quot;: [&quot;nb-123456789&quot;] }]</p><p>取值范围<br>Name（名称）：notebook1<br>Id（notebook ID）：nb-123456789<br>Status（状态）：Starting / Running / Stopped / Stopping / Failed / SubmitFailed<br>Creator（创建者 uin）：100014761913<br>ChargeType（计费类型）：PREPAID（预付费）/ POSTPAID_BY_HOUR（后付费）<br>ChargeStatus（计费状态）：NOT_BILLING（未开始计费）/ BILLING（计费中）/ BILLING_STORAGE（存储计费中）/ARREARS_STOP（欠费停止）<br>DefaultCodeRepoId（默认代码仓库ID）：cr-123456789<br>AdditionalCodeRepoId（关联代码仓库ID）：cr-123456789<br>LifecycleScriptId（生命周期ID）：ls-12312312311312</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>标签过滤器，eg：[{ &quot;TagKey&quot;: &quot;TagKeyA&quot;, &quot;TagValue&quot;: [&quot;TagValueA&quot;] }]</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

