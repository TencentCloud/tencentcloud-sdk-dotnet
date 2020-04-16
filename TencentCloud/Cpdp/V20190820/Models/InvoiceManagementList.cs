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

    public class InvoiceManagementList : AbstractModel
    {
        
        /// <summary>
        /// 发票ID
        /// </summary>
        [JsonProperty("InvoiceId")]
        public string InvoiceId{ get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [JsonProperty("SellerName")]
        public string SellerName{ get; set; }

        /// <summary>
        /// 业务开票号
        /// </summary>
        [JsonProperty("OrderSn")]
        public string OrderSn{ get; set; }

        /// <summary>
        /// 开票平台ID
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }

        /// <summary>
        /// 腾讯云AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 开票号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvoiceSn")]
        public string InvoiceSn{ get; set; }

        /// <summary>
        /// 开票代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvoiceCode")]
        public string InvoiceCode{ get; set; }

        /// <summary>
        /// 红冲状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedStatus")]
        public long? RedStatus{ get; set; }

        /// <summary>
        /// 开票通知时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotifyTime")]
        public string NotifyTime{ get; set; }

        /// <summary>
        /// 含税总金额
        /// </summary>
        [JsonProperty("AmountHasTax")]
        public string AmountHasTax{ get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [JsonProperty("InvoiceType")]
        public long? InvoiceType{ get; set; }

        /// <summary>
        /// 开票状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvoiceStatus")]
        public long? InvoiceStatus{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoiceId", this.InvoiceId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "SellerName", this.SellerName);
            this.SetParamSimple(map, prefix + "OrderSn", this.OrderSn);
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InvoiceSn", this.InvoiceSn);
            this.SetParamSimple(map, prefix + "InvoiceCode", this.InvoiceCode);
            this.SetParamSimple(map, prefix + "RedStatus", this.RedStatus);
            this.SetParamSimple(map, prefix + "NotifyTime", this.NotifyTime);
            this.SetParamSimple(map, prefix + "AmountHasTax", this.AmountHasTax);
            this.SetParamSimple(map, prefix + "InvoiceType", this.InvoiceType);
            this.SetParamSimple(map, prefix + "InvoiceStatus", this.InvoiceStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

