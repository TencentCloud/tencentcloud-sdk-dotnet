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

    public class AICallAPICallAttempt : AbstractModel
    {
        
        /// <summary>
        /// <p>尝试序号，从 1 开始，1 表示首次调用。</p>
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }

        /// <summary>
        /// <p>本次尝试的发起时间戳，Unix 毫秒级时间戳。</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// <p>本次尝试的结果状态，取值同 APICall.Status。</p><p>枚举值：</p><ul><li>success： 调通且返回 2xx，进入成功分支</li><li>failed： 调用失败或返回非 2xx，进入失败分支</li><li>internal_fail： 内部调用失败</li><li>terminated： 调用过程中被用户新意图打断，无最终结果</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>本次尝试的 HTTP 状态码。调不通时为 0。</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// <p>本次尝试调不通时的错误类型，取值同 APICall.ErrorType。</p><p>枚举值：</p><ul><li>timeout： 请求超时</li><li>connect_failed： 建立连接失败</li><li>dns_failed： DNS 解析失败</li><li>tls_failed： TLS 证书校验失败</li><li>other： 其他错误</li></ul>
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>本次尝试的失败摘要，格式为 {状态码或错误类型}：{错误信息}。本次尝试成功时为空。</p>
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// <p>本次尝试耗时。</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("CostMS")]
        public long? CostMS{ get; set; }

        /// <summary>
        /// <p>本次尝试的请求详情。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Request")]
        public AICallAPICallRequestDetail Request{ get; set; }

        /// <summary>
        /// <p>本次尝试的响应详情。调不通（Status 为 unreachable）或异步上报时为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Response")]
        public AICallAPICallResponseDetail Response{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "CostMS", this.CostMS);
            this.SetParamObj(map, prefix + "Request.", this.Request);
            this.SetParamObj(map, prefix + "Response.", this.Response);
        }
    }
}

