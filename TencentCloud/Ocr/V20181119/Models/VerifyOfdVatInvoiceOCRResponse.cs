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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyOfdVatInvoiceOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 发票类型
        /// 026:增值税电子普通发票
        /// 028:增值税电子专用发票
        /// 010:电子发票（普通发票）
        /// 020:电子发票（增值税专用发票）
        /// 030:电子发票（铁路电子客票）
        /// 040:电子发票（航空运输电子客票行程单）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("InvoiceCode")]
        public string InvoiceCode{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("InvoiceNumber")]
        public string InvoiceNumber{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [JsonProperty("InvoiceCheckCode")]
        public string InvoiceCheckCode{ get; set; }

        /// <summary>
        /// 机器编号
        /// </summary>
        [JsonProperty("MachineNumber")]
        public string MachineNumber{ get; set; }

        /// <summary>
        /// 密码区
        /// </summary>
        [JsonProperty("TaxControlCode")]
        public string TaxControlCode{ get; set; }

        /// <summary>
        /// 购买方
        /// </summary>
        [JsonProperty("Buyer")]
        public VatInvoiceUserInfo Buyer{ get; set; }

        /// <summary>
        /// 销售方
        /// </summary>
        [JsonProperty("Seller")]
        public VatInvoiceUserInfo Seller{ get; set; }

        /// <summary>
        /// 价税合计
        /// </summary>
        [JsonProperty("TaxInclusiveTotalAmount")]
        public string TaxInclusiveTotalAmount{ get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("InvoiceClerk")]
        public string InvoiceClerk{ get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonProperty("Payee")]
        public string Payee{ get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonProperty("Checker")]
        public string Checker{ get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("TaxTotalAmount")]
        public string TaxTotalAmount{ get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("TaxExclusiveTotalAmount")]
        public string TaxExclusiveTotalAmount{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 货物或服务清单
        /// </summary>
        [JsonProperty("GoodsInfos")]
        public VatInvoiceGoodsInfo[] GoodsInfos{ get; set; }

        /// <summary>
        /// 航空运输电子客票行程单信息
        /// </summary>
        [JsonProperty("AirTicketInfo")]
        public AirTicketInfo AirTicketInfo{ get; set; }

        /// <summary>
        /// 铁路电子客票
        /// </summary>
        [JsonProperty("RailwayTicketInfo")]
        public RailwayTicketInfo RailwayTicketInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InvoiceCode", this.InvoiceCode);
            this.SetParamSimple(map, prefix + "InvoiceNumber", this.InvoiceNumber);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "InvoiceCheckCode", this.InvoiceCheckCode);
            this.SetParamSimple(map, prefix + "MachineNumber", this.MachineNumber);
            this.SetParamSimple(map, prefix + "TaxControlCode", this.TaxControlCode);
            this.SetParamObj(map, prefix + "Buyer.", this.Buyer);
            this.SetParamObj(map, prefix + "Seller.", this.Seller);
            this.SetParamSimple(map, prefix + "TaxInclusiveTotalAmount", this.TaxInclusiveTotalAmount);
            this.SetParamSimple(map, prefix + "InvoiceClerk", this.InvoiceClerk);
            this.SetParamSimple(map, prefix + "Payee", this.Payee);
            this.SetParamSimple(map, prefix + "Checker", this.Checker);
            this.SetParamSimple(map, prefix + "TaxTotalAmount", this.TaxTotalAmount);
            this.SetParamSimple(map, prefix + "TaxExclusiveTotalAmount", this.TaxExclusiveTotalAmount);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamArrayObj(map, prefix + "GoodsInfos.", this.GoodsInfos);
            this.SetParamObj(map, prefix + "AirTicketInfo.", this.AirTicketInfo);
            this.SetParamObj(map, prefix + "RailwayTicketInfo.", this.RailwayTicketInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

