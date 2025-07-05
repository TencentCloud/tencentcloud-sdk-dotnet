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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBiddingSuccessfulDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 得标时间
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("SuccessfulTime")]
        public string SuccessfulTime{ get; set; }

        /// <summary>
        /// 得标价格 单位元
        /// </summary>
        [JsonProperty("SuccessfulPrice")]
        public float? SuccessfulPrice{ get; set; }

        /// <summary>
        ///  注册时间
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("RegTime")]
        public string RegTime{ get; set; }

        /// <summary>
        /// 过期时间
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 删除时间
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("DeleteTime")]
        public string DeleteTime{ get; set; }

        /// <summary>
        /// 付款结束时间
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("PayEndTime")]
        public string PayEndTime{ get; set; }

        /// <summary>
        /// 保证金，是否退款，yes表示退款，no表示不退款
        /// </summary>
        [JsonProperty("BiddingBondRefund")]
        public string BiddingBondRefund{ get; set; }

        /// <summary>
        /// 保证金 单位元
        /// </summary>
        [JsonProperty("BiddingBondPrice")]
        public float? BiddingBondPrice{ get; set; }

        /// <summary>
        /// 状态：5 等待支付 6 等待转移， 7 转移中，8 交易成功，11 尾款阶段持有者索回，12 已违约
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SuccessfulTime", this.SuccessfulTime);
            this.SetParamSimple(map, prefix + "SuccessfulPrice", this.SuccessfulPrice);
            this.SetParamSimple(map, prefix + "RegTime", this.RegTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "PayEndTime", this.PayEndTime);
            this.SetParamSimple(map, prefix + "BiddingBondRefund", this.BiddingBondRefund);
            this.SetParamSimple(map, prefix + "BiddingBondPrice", this.BiddingBondPrice);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

