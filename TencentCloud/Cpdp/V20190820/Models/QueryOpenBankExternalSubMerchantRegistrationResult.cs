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

    public class QueryOpenBankExternalSubMerchantRegistrationResult : AbstractModel
    {
        
        /// <summary>
        /// 进件状态。
        /// __SUCCESS__: 进件成功
        /// __FAILED__: 进件失败
        /// __PROCESSING__: 进件中
        /// </summary>
        [JsonProperty("RegistrationStatus")]
        public string RegistrationStatus{ get; set; }

        /// <summary>
        /// 进件返回描述, 例如失败原因等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegistrationMessage")]
        public string RegistrationMessage{ get; set; }

        /// <summary>
        /// 渠道进件号。
        /// </summary>
        [JsonProperty("ChannelRegistrationNo")]
        public string ChannelRegistrationNo{ get; set; }

        /// <summary>
        /// 渠道子商户ID（进件成功返回）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 外部子商户名称（进件成功返回）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutSubMerchantName")]
        public string OutSubMerchantName{ get; set; }

        /// <summary>
        /// 渠道名称（进件成功返回）。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付方式（进件成功返回）。
        /// __EBANK_PAYMENT__: ebank支付
        /// __OPENBANK_PAYMENT__: openbank支付
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 社会信用代码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLicenseNumber")]
        public string BusinessLicenseNumber{ get; set; }

        /// <summary>
        /// 法人姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 第三方渠道查询进件返回数据。详情见附录-复杂类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnData")]
        public string ExternalReturnData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistrationStatus", this.RegistrationStatus);
            this.SetParamSimple(map, prefix + "RegistrationMessage", this.RegistrationMessage);
            this.SetParamSimple(map, prefix + "ChannelRegistrationNo", this.ChannelRegistrationNo);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "OutSubMerchantName", this.OutSubMerchantName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "BusinessLicenseNumber", this.BusinessLicenseNumber);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "ExternalReturnData", this.ExternalReturnData);
        }
    }
}

