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

    public class CreateOpenBankPaymentOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 云企付渠道商户号。外部接入平台入驻云企付平台后下发。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。详见附录-云企付枚举类说明-ChannelName。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// __HUIFU__: 汇付斗拱
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 付款方式。详见附录-云企付枚举类说明-PaymentMethod。
        /// __EBANK_PAYMENT__:B2B EBank付款
        /// __OPENBANK_PAYMENT__:B2C  openbank付款
        /// __SAFT_ISV__:支付宝安心发
        /// __TRANS_TO_CHANGE__: 微信支付转账到零钱v2
        /// __TRANS_TO_CHANGE_V3__: 微信支付转账到零钱v3
        /// __ONLINEBANK__: 汇付网银
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 付款模式。默认直接支付，如
        /// __DIRECT__:直接支付
        /// __FREEZE__:担保支付
        /// </summary>
        [JsonProperty("PaymentMode")]
        public string PaymentMode{ get; set; }

        /// <summary>
        /// 外部订单号,只能是数字、大小写字母，且在同一个接入平台下唯一，限定长度40位。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 付款金额，单位分。
        /// </summary>
        [JsonProperty("TotalAmount")]
        public long? TotalAmount{ get; set; }

        /// <summary>
        /// 固定值CNY。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 付款方信息。
        /// </summary>
        [JsonProperty("PayerInfo")]
        public OpenBankPayerInfo PayerInfo{ get; set; }

        /// <summary>
        /// 收款方信息。
        /// </summary>
        [JsonProperty("PayeeInfo")]
        public OpenBankPayeeInfo PayeeInfo{ get; set; }

        /// <summary>
        /// 通知地址，如www.test.com。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 订单过期时间，yyyy-MM-dd HH:mm:ss格式。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 前端成功回调URL。条件可选。
        /// </summary>
        [JsonProperty("FrontUrl")]
        public string FrontUrl{ get; set; }

        /// <summary>
        /// 前端刷新 URL。条件可选。
        /// </summary>
        [JsonProperty("RefreshUrl")]
        public string RefreshUrl{ get; set; }

        /// <summary>
        /// 设备信息，条件可选。
        /// </summary>
        [JsonProperty("SceneInfo")]
        public OpenBankSceneInfo SceneInfo{ get; set; }

        /// <summary>
        /// 商品信息，条件可选。
        /// </summary>
        [JsonProperty("GoodsInfo")]
        public OpenBankGoodsInfo GoodsInfo{ get; set; }

        /// <summary>
        /// 附加信息，查询时原样返回。
        /// </summary>
        [JsonProperty("Attachment")]
        public string Attachment{ get; set; }

        /// <summary>
        /// 若不上传，即使用默认值无需分润
        /// __NO_NEED_SHARE__：无需分润；
        /// __SHARE_BY_INFO__：分润时指定金额，此时如果分润信息 ProfitShareInfo为空，只冻结，不分账给其他商户；需要调用解冻接口。
        /// __SHARE_BY_API__：后续调用分润接口决定分润金额
        /// </summary>
        [JsonProperty("ProfitShareFlag")]
        public string ProfitShareFlag{ get; set; }

        /// <summary>
        /// 分润信息，配合ProfitShareFlag使用。
        /// </summary>
        [JsonProperty("ProfitShareInfoList")]
        public OpenBankProfitShareInfo[] ProfitShareInfoList{ get; set; }

        /// <summary>
        /// 备注信息。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// 缺省默认为生产环境
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "PaymentMode", this.PaymentMode);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamObj(map, prefix + "PayerInfo.", this.PayerInfo);
            this.SetParamObj(map, prefix + "PayeeInfo.", this.PayeeInfo);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "FrontUrl", this.FrontUrl);
            this.SetParamSimple(map, prefix + "RefreshUrl", this.RefreshUrl);
            this.SetParamObj(map, prefix + "SceneInfo.", this.SceneInfo);
            this.SetParamObj(map, prefix + "GoodsInfo.", this.GoodsInfo);
            this.SetParamSimple(map, prefix + "Attachment", this.Attachment);
            this.SetParamSimple(map, prefix + "ProfitShareFlag", this.ProfitShareFlag);
            this.SetParamArrayObj(map, prefix + "ProfitShareInfoList.", this.ProfitShareInfoList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

