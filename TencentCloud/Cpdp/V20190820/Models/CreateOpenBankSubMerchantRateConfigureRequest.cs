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

    public class CreateOpenBankSubMerchantRateConfigureRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道进件序列号。
        /// 填写子商户进件返回的渠道进件编号。
        /// </summary>
        [JsonProperty("ChannelRegistrationNo")]
        public string ChannelRegistrationNo{ get; set; }

        /// <summary>
        /// 外部产品费率申请序列号。
        /// </summary>
        [JsonProperty("OutProductFeeNo")]
        public string OutProductFeeNo{ get; set; }

        /// <summary>
        /// 渠道商户ID。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道子商户ID。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。详见附录-云企付枚举类说明-ChannelName。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付类型。
        /// SWIPE:刷卡
        /// SCAN:扫码
        /// WAP:WAP
        /// PUBLIC:公众号支付
        /// SDK:SDK
        /// MINI_PROGRAM:小程序
        /// 注意：HELIPAY渠道传SDK。
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 支付渠道。
        /// ALIPAY：支付宝 
        /// WXPAY：微信支付 
        /// UNIONPAY：银联
        /// </summary>
        [JsonProperty("PayChannel")]
        public string PayChannel{ get; set; }

        /// <summary>
        /// 计费模式。
        /// SINGLE：按单笔金额计费
        /// RATIO：按单笔费率计费 
        /// RANGE：按分段区间计费
        /// </summary>
        [JsonProperty("FeeMode")]
        public string FeeMode{ get; set; }

        /// <summary>
        /// 费用值，单位（0.01%或分）。
        /// </summary>
        [JsonProperty("FeeValue")]
        public ulong? FeeValue{ get; set; }

        /// <summary>
        /// 支付方式。详见附录-云企付枚举类说明-PaymentMethod。
        /// HELIPAY渠道不需要传入。
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 最低收费金额，单位（分）。
        /// </summary>
        [JsonProperty("MinFee")]
        public ulong? MinFee{ get; set; }

        /// <summary>
        /// 最高收费金额，单位（分）。
        /// </summary>
        [JsonProperty("MaxFee")]
        public ulong? MaxFee{ get; set; }

        /// <summary>
        /// 通知地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 分段计费区间列表。
        /// </summary>
        [JsonProperty("FeeRangeList")]
        public FeeRangInfo[] FeeRangeList{ get; set; }

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
            this.SetParamSimple(map, prefix + "ChannelRegistrationNo", this.ChannelRegistrationNo);
            this.SetParamSimple(map, prefix + "OutProductFeeNo", this.OutProductFeeNo);
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "PayChannel", this.PayChannel);
            this.SetParamSimple(map, prefix + "FeeMode", this.FeeMode);
            this.SetParamSimple(map, prefix + "FeeValue", this.FeeValue);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "MinFee", this.MinFee);
            this.SetParamSimple(map, prefix + "MaxFee", this.MaxFee);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamArrayObj(map, prefix + "FeeRangeList.", this.FeeRangeList);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

