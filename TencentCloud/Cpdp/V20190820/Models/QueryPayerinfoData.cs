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

    public class QueryPayerinfoData : AbstractModel
    {
        
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 付款人ID
        /// </summary>
        [JsonProperty("PayerId")]
        public string PayerId{ get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 付款人类型
        /// </summary>
        [JsonProperty("PayerType")]
        public string PayerType{ get; set; }

        /// <summary>
        /// 付款人姓名
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName{ get; set; }

        /// <summary>
        /// 付款人证件类型
        /// </summary>
        [JsonProperty("PayerIdType")]
        public string PayerIdType{ get; set; }

        /// <summary>
        /// 付款人证件号
        /// </summary>
        [JsonProperty("PayerIdNo")]
        public string PayerIdNo{ get; set; }

        /// <summary>
        /// 付款人联系电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerContactNumber")]
        public string PayerContactNumber{ get; set; }

        /// <summary>
        /// 付款人联系邮箱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerEmailAddress")]
        public string PayerEmailAddress{ get; set; }

        /// <summary>
        /// 付款人常驻国家或地区编码
        /// </summary>
        [JsonProperty("PayerCountryCode")]
        public string PayerCountryCode{ get; set; }

        /// <summary>
        /// 付款人联系名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerContactName")]
        public string PayerContactName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "PayerId", this.PayerId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "PayerType", this.PayerType);
            this.SetParamSimple(map, prefix + "PayerName", this.PayerName);
            this.SetParamSimple(map, prefix + "PayerIdType", this.PayerIdType);
            this.SetParamSimple(map, prefix + "PayerIdNo", this.PayerIdNo);
            this.SetParamSimple(map, prefix + "PayerContactNumber", this.PayerContactNumber);
            this.SetParamSimple(map, prefix + "PayerEmailAddress", this.PayerEmailAddress);
            this.SetParamSimple(map, prefix + "PayerCountryCode", this.PayerCountryCode);
            this.SetParamSimple(map, prefix + "PayerContactName", this.PayerContactName);
        }
    }
}

