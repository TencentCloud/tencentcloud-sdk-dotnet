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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePayMerchantRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台编号
        /// </summary>
        [JsonProperty("PlatformCode")]
        public string PlatformCode{ get; set; }

        /// <summary>
        /// 渠道方收款商户编号，由渠道方(银行)提 供。
        /// </summary>
        [JsonProperty("ChannelMerchantNo")]
        public string ChannelMerchantNo{ get; set; }

        /// <summary>
        /// 是否需要向渠道进行 商户信息验证 1:验证
        /// 0:不验证
        /// </summary>
        [JsonProperty("ChannelCheckFlag")]
        public string ChannelCheckFlag{ get; set; }

        /// <summary>
        /// 收款商户名称
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 是否开通 B2B 支付 1:开通 0:不开通 缺省:1
        /// </summary>
        [JsonProperty("BusinessPayFlag")]
        public string BusinessPayFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformCode", this.PlatformCode);
            this.SetParamSimple(map, prefix + "ChannelMerchantNo", this.ChannelMerchantNo);
            this.SetParamSimple(map, prefix + "ChannelCheckFlag", this.ChannelCheckFlag);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "BusinessPayFlag", this.BusinessPayFlag);
        }
    }
}

