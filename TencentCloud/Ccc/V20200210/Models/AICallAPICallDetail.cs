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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallAPICallDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>是否异步上报。节点配置「等待接口返回」关闭时为 true，此时不处理响应也不影响流程走向，Status、StatusCode、CostMS 等结果字段均为空，只记录 Attempts 中的请求详情。</p>
        /// </summary>
        [JsonProperty("Async")]
        public bool? Async{ get; set; }

        /// <summary>
        /// <p>本次接口调用的最终状态，重试场景为最后一次尝试的状态，Async 为 true 时为空。后续可能新增取值，请做好兼容。</p><p>枚举值：</p><ul><li>success： 调通且返回 2xx，进入成功分支</li><li>failed： 调用失败或返回非 2xx，进入失败分支</li><li>terminated： 调用过程中被用户新意图打断，无最终结果</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>最终 HTTP 状态码。调不通或异步上报时为 0。</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// <p>失败摘要，格式为 {状态码或错误类型}：{错误信息}。调用成功时为空。</p>
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// <p>接口调用总耗时，包含全部重试。异步上报时为 0。</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("CostMS")]
        public long? CostMS{ get; set; }

        /// <summary>
        /// <p>重试次数。0 表示首次调用即结束，未发生重试。</p>
        /// </summary>
        [JsonProperty("RetryCount")]
        public long? RetryCount{ get; set; }

        /// <summary>
        /// <p>每次尝试的明细，按时间顺序排列，至少包含首次调用。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Attempts")]
        public AICallAPICallAttempt[] Attempts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Async", this.Async);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "CostMS", this.CostMS);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamArrayObj(map, prefix + "Attempts.", this.Attempts);
        }
    }
}

