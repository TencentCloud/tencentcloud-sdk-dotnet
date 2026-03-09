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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CaptchaStatisticObj : AbstractModel
    {
        
        /// <summary>
        /// <p>请求总量</p>
        /// </summary>
        [JsonProperty("ActionTotal")]
        public long? ActionTotal{ get; set; }

        /// <summary>
        /// <p>验证总量</p>
        /// </summary>
        [JsonProperty("VerifyTotal")]
        public long? VerifyTotal{ get; set; }

        /// <summary>
        /// <p>验证通过总量</p>
        /// </summary>
        [JsonProperty("VerifyThroughTotal")]
        public long? VerifyThroughTotal{ get; set; }

        /// <summary>
        /// <p>验证拦截总量</p>
        /// </summary>
        [JsonProperty("VerifyInterceptTotal")]
        public long? VerifyInterceptTotal{ get; set; }

        /// <summary>
        /// <p>票据校验总量</p>
        /// </summary>
        [JsonProperty("TicketTotal")]
        public long? TicketTotal{ get; set; }

        /// <summary>
        /// <p>票据通过总量</p>
        /// </summary>
        [JsonProperty("TicketThroughTotal")]
        public long? TicketThroughTotal{ get; set; }

        /// <summary>
        /// <p>票据拦截总量</p>
        /// </summary>
        [JsonProperty("TicketInterceptTotal")]
        public long? TicketInterceptTotal{ get; set; }

        /// <summary>
        /// <p>请求趋势图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestTrend")]
        public RequestTrendObj[] RequestTrend{ get; set; }

        /// <summary>
        /// <p>拦截率趋势图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InterceptPerTrend")]
        public InterceptPerTrendObj[] InterceptPerTrend{ get; set; }

        /// <summary>
        /// <p>票据校验趋势图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TicketCheckTrend")]
        public TicketCheckTrendObj[] TicketCheckTrend{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionTotal", this.ActionTotal);
            this.SetParamSimple(map, prefix + "VerifyTotal", this.VerifyTotal);
            this.SetParamSimple(map, prefix + "VerifyThroughTotal", this.VerifyThroughTotal);
            this.SetParamSimple(map, prefix + "VerifyInterceptTotal", this.VerifyInterceptTotal);
            this.SetParamSimple(map, prefix + "TicketTotal", this.TicketTotal);
            this.SetParamSimple(map, prefix + "TicketThroughTotal", this.TicketThroughTotal);
            this.SetParamSimple(map, prefix + "TicketInterceptTotal", this.TicketInterceptTotal);
            this.SetParamArrayObj(map, prefix + "RequestTrend.", this.RequestTrend);
            this.SetParamArrayObj(map, prefix + "InterceptPerTrend.", this.InterceptPerTrend);
            this.SetParamArrayObj(map, prefix + "TicketCheckTrend.", this.TicketCheckTrend);
        }
    }
}

