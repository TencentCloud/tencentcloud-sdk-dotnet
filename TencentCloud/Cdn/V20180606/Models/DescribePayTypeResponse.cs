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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePayTypeResponse : AbstractModel
    {
        
        /// <summary>
        /// 计费类型：
        /// flux：流量计费
        /// bandwidth：带宽计费
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 计费周期：
        /// day：日结计费
        /// month：月结计费
        /// </summary>
        [JsonProperty("BillingCycle")]
        public string BillingCycle{ get; set; }

        /// <summary>
        /// 计费方式：
        /// monthMax：日峰值月平均计费，月结模式
        /// day95：日 95 带宽计费，月结模式
        /// month95：月95带宽计费，月结模式
        /// sum：总流量计费，日结与月结均有流量计费模式
        /// max：峰值带宽计费，日结模式
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "BillingCycle", this.BillingCycle);
            this.SetParamSimple(map, prefix + "StatType", this.StatType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

