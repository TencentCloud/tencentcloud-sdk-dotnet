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

    public class CloudSubOrder : AbstractModel
    {
        
        /// <summary>
        /// 子订单号。
        /// 长度32个字符供参考，部分渠道存在长度更短的情况接入时请联系开发咨询。
        /// </summary>
        [JsonProperty("SubOutTradeNo")]
        public string SubOutTradeNo{ get; set; }

        /// <summary>
        /// 支付子商户ID。
        /// 米大师计费SubAppId，代表子商户。
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 商品名称。
        /// 业务自定义的子订单商品名称，无需URL编码，长度限制以具体所接入渠道为准。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 商品详情。
        /// 业务自定义的子订单商品详情，无需URL编码，长度限制以具体所接入渠道为准。
        /// </summary>
        [JsonProperty("ProductDetail")]
        public string ProductDetail{ get; set; }

        /// <summary>
        /// 平台应收。
        /// 子订单平台应收金额，单位：分，需要注意的是Amt = PlatformIncome+SubMchIncome。
        /// </summary>
        [JsonProperty("PlatformIncome")]
        public long? PlatformIncome{ get; set; }

        /// <summary>
        /// 商户应收。
        /// 子订单结算应收金额，单位：分，需要注意的是Amt = PlatformIncome+SubMchIncome。
        /// </summary>
        [JsonProperty("SubMchIncome")]
        public long? SubMchIncome{ get; set; }

        /// <summary>
        /// 透传字段。
        /// 发货标识，由开发者在调用米大师下单接口的 时候下发。
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 支付金额。
        /// 子订单支付金额，需要注意的是Amt = PlatformIncome+SubMchIncome。
        /// </summary>
        [JsonProperty("Amt")]
        public long? Amt{ get; set; }

        /// <summary>
        /// 原始金额。
        /// 子订单原始金额，OriginalAmt>=Amt。
        /// </summary>
        [JsonProperty("OriginalAmt")]
        public long? OriginalAmt{ get; set; }

        /// <summary>
        /// 微信子商户号。
        /// </summary>
        [JsonProperty("WxSubMchId")]
        public string WxSubMchId{ get; set; }

        /// <summary>
        /// 结算信息。
        /// 例如是否需要分账、是否需要支付确认等。
        /// </summary>
        [JsonProperty("SettleInfo")]
        public CloudSettleInfo SettleInfo{ get; set; }

        /// <summary>
        /// 附加项信息列表。
        /// 例如溢价信息、抵扣信息、积分信息、补贴信息
        /// 通过该字段可以实现渠道方的优惠抵扣补贴等营销功能。
        /// </summary>
        [JsonProperty("AttachmentInfoList")]
        public CloudAttachmentInfo[] AttachmentInfoList{ get; set; }

        /// <summary>
        /// 渠道透传数据列表。
        /// </summary>
        [JsonProperty("ExternalAttachmentDataList")]
        public CloudExternalAttachmentData[] ExternalAttachmentDataList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubOutTradeNo", this.SubOutTradeNo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductDetail", this.ProductDetail);
            this.SetParamSimple(map, prefix + "PlatformIncome", this.PlatformIncome);
            this.SetParamSimple(map, prefix + "SubMchIncome", this.SubMchIncome);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "OriginalAmt", this.OriginalAmt);
            this.SetParamSimple(map, prefix + "WxSubMchId", this.WxSubMchId);
            this.SetParamObj(map, prefix + "SettleInfo.", this.SettleInfo);
            this.SetParamArrayObj(map, prefix + "AttachmentInfoList.", this.AttachmentInfoList);
            this.SetParamArrayObj(map, prefix + "ExternalAttachmentDataList.", this.ExternalAttachmentDataList);
        }
    }
}

