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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefundTlinxOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 使用门店OpenId
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 使用门店OpenKey
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 原始订单的开发者交易流水号
        /// </summary>
        [JsonProperty("DeveloperNo")]
        public string DeveloperNo{ get; set; }

        /// <summary>
        /// 新退款订单的开发者流水号，同一门店内唯一
        /// </summary>
        [JsonProperty("RefundOutNo")]
        public string RefundOutNo{ get; set; }

        /// <summary>
        /// 退款订单名称，可以为空
        /// </summary>
        [JsonProperty("RefundOrderName")]
        public string RefundOrderName{ get; set; }

        /// <summary>
        /// 退款金额（以分为单位，没有小数点）
        /// </summary>
        [JsonProperty("RefundAmount")]
        public string RefundAmount{ get; set; }

        /// <summary>
        /// 主管密码，对密码进行SHA-1加密，默认为123456
        /// </summary>
        [JsonProperty("ShopPassword")]
        public string ShopPassword{ get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "DeveloperNo", this.DeveloperNo);
            this.SetParamSimple(map, prefix + "RefundOutNo", this.RefundOutNo);
            this.SetParamSimple(map, prefix + "RefundOrderName", this.RefundOrderName);
            this.SetParamSimple(map, prefix + "RefundAmount", this.RefundAmount);
            this.SetParamSimple(map, prefix + "ShopPassword", this.ShopPassword);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

