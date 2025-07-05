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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEnvDealRegionRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 订单类型：
        /// ENV_PREPAY_MINIAPP= 预付费环境(微信小程序)
        /// ENV_PREPAY_CLOUD= 预付费环境(腾讯云)
        /// ENV_POSTPAY = 后付费环境
        /// HOSTING_PREPAY = 预付费静态托管
        /// PACKAGE=套餐包
        /// </summary>
        [JsonProperty("DealType")]
        public string DealType{ get; set; }

        /// <summary>
        /// 下单类型：
        /// CREATE = 新购
        /// RENEW = 续费
        /// MODIFY = 套餐调整(升级/降级)
        /// REFUND = 退费
        /// </summary>
        [JsonProperty("DealAction")]
        public string DealAction{ get; set; }

        /// <summary>
        /// 下单地域：
        /// ap-guangzhou = 广州地域
        /// ap-shanghai = 上海地域
        /// ap-beijing = 北京地域
        /// </summary>
        [JsonProperty("DealRegion")]
        public string DealRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "DealType", this.DealType);
            this.SetParamSimple(map, prefix + "DealAction", this.DealAction);
            this.SetParamSimple(map, prefix + "DealRegion", this.DealRegion);
        }
    }
}

