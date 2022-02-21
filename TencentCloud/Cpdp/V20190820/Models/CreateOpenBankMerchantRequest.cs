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

    public class CreateOpenBankMerchantRequest : AbstractModel
    {
        
        /// <summary>
        /// 外部商户ID。
        /// </summary>
        [JsonProperty("OutMerchantId")]
        public string OutMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 外部商户名称。
        /// </summary>
        [JsonProperty("OutMerchantName")]
        public string OutMerchantName{ get; set; }

        /// <summary>
        /// 第三方渠道商户信息。详情见附录-复杂类型。
        /// </summary>
        [JsonProperty("ExternalMerchantInfo")]
        public string ExternalMerchantInfo{ get; set; }

        /// <summary>
        /// 外部商户简称。
        /// </summary>
        [JsonProperty("OutMerchantShortName")]
        public string OutMerchantShortName{ get; set; }

        /// <summary>
        /// 外部商户描述
        /// </summary>
        [JsonProperty("OutMerchantDescription")]
        public string OutMerchantDescription{ get; set; }

        /// <summary>
        /// 环境类型。
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutMerchantId", this.OutMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "OutMerchantName", this.OutMerchantName);
            this.SetParamSimple(map, prefix + "ExternalMerchantInfo", this.ExternalMerchantInfo);
            this.SetParamSimple(map, prefix + "OutMerchantShortName", this.OutMerchantShortName);
            this.SetParamSimple(map, prefix + "OutMerchantDescription", this.OutMerchantDescription);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

