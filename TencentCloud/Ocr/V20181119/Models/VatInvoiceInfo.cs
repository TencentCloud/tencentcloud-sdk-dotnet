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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VatInvoiceInfo : AbstractModel
    {
        
        /// <summary>
        /// 校验码
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 发票联次
        /// </summary>
        [JsonProperty("FormType")]
        public string FormType{ get; set; }

        /// <summary>
        /// 车船税
        /// </summary>
        [JsonProperty("TravelTax")]
        public string TravelTax{ get; set; }

        /// <summary>
        /// 购买方地址电话
        /// </summary>
        [JsonProperty("BuyerAddrTel")]
        public string BuyerAddrTel{ get; set; }

        /// <summary>
        /// 购买方银行账号
        /// </summary>
        [JsonProperty("BuyerBankAccount")]
        public string BuyerBankAccount{ get; set; }

        /// <summary>
        /// 公司印章内容
        /// </summary>
        [JsonProperty("CompanySealContent")]
        public string CompanySealContent{ get; set; }

        /// <summary>
        /// 税务局章内容
        /// </summary>
        [JsonProperty("TaxSealContent")]
        public string TaxSealContent{ get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 是否存在二维码（0：没有，1：有）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// 是否有代开标记（0：没有，1：有）
        /// </summary>
        [JsonProperty("AgentMark")]
        public long? AgentMark{ get; set; }

        /// <summary>
        /// 是否有通行费标记（0：没有，1：有）
        /// </summary>
        [JsonProperty("TransitMark")]
        public long? TransitMark{ get; set; }

        /// <summary>
        /// 是否有成品油标记（0：没有，1：有）
        /// </summary>
        [JsonProperty("OilMark")]
        public long? OilMark{ get; set; }

        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 机打发票号码
        /// </summary>
        [JsonProperty("NumberConfirm")]
        public string NumberConfirm{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 价税合计（小写）
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 价税合计（大写）
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// 税前金额
        /// </summary>
        [JsonProperty("PretaxAmount")]
        public string PretaxAmount{ get; set; }

        /// <summary>
        /// 合计税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 机器编号
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// 密码区
        /// </summary>
        [JsonProperty("Ciphertext")]
        public string Ciphertext{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 销售方纳税人识别号
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// 销售方地址电话
        /// </summary>
        [JsonProperty("SellerAddrTel")]
        public string SellerAddrTel{ get; set; }

        /// <summary>
        /// 销售方银行账号
        /// </summary>
        [JsonProperty("SellerBankAccount")]
        public string SellerBankAccount{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 购买方纳税人识别号
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 增值税发票项目信息
        /// </summary>
        [JsonProperty("VatInvoiceItemInfos")]
        public VatInvoiceItemInfo[] VatInvoiceItemInfos{ get; set; }

        /// <summary>
        /// 机打发票代码
        /// </summary>
        [JsonProperty("CodeConfirm")]
        public string CodeConfirm{ get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonProperty("Receiptor")]
        public string Receiptor{ get; set; }

        /// <summary>
        /// 是否有全电纸质票（0：没有，1：有）
        /// </summary>
        [JsonProperty("ElectronicFullMark")]
        public long? ElectronicFullMark{ get; set; }

        /// <summary>
        /// 全电号码
        /// </summary>
        [JsonProperty("ElectronicFullNumber")]
        public string ElectronicFullNumber{ get; set; }

        /// <summary>
        /// 发票联名
        /// </summary>
        [JsonProperty("FormName")]
        public string FormName{ get; set; }

        /// <summary>
        /// 是否有区块链标记（0：没有，1：有）	
        /// </summary>
        [JsonProperty("BlockChainMark")]
        public long? BlockChainMark{ get; set; }

        /// <summary>
        /// 是否有收购标记（0：没有，1：有）	
        /// </summary>
        [JsonProperty("AcquisitionMark")]
        public long? AcquisitionMark{ get; set; }

        /// <summary>
        /// 小计金额
        /// </summary>
        [JsonProperty("SubTotal")]
        public string SubTotal{ get; set; }

        /// <summary>
        /// 小计税额
        /// </summary>
        [JsonProperty("SubTax")]
        public string SubTax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "FormType", this.FormType);
            this.SetParamSimple(map, prefix + "TravelTax", this.TravelTax);
            this.SetParamSimple(map, prefix + "BuyerAddrTel", this.BuyerAddrTel);
            this.SetParamSimple(map, prefix + "BuyerBankAccount", this.BuyerBankAccount);
            this.SetParamSimple(map, prefix + "CompanySealContent", this.CompanySealContent);
            this.SetParamSimple(map, prefix + "TaxSealContent", this.TaxSealContent);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "AgentMark", this.AgentMark);
            this.SetParamSimple(map, prefix + "TransitMark", this.TransitMark);
            this.SetParamSimple(map, prefix + "OilMark", this.OilMark);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "NumberConfirm", this.NumberConfirm);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "Ciphertext", this.Ciphertext);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerAddrTel", this.SellerAddrTel);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamArrayObj(map, prefix + "VatInvoiceItemInfos.", this.VatInvoiceItemInfos);
            this.SetParamSimple(map, prefix + "CodeConfirm", this.CodeConfirm);
            this.SetParamSimple(map, prefix + "Receiptor", this.Receiptor);
            this.SetParamSimple(map, prefix + "ElectronicFullMark", this.ElectronicFullMark);
            this.SetParamSimple(map, prefix + "ElectronicFullNumber", this.ElectronicFullNumber);
            this.SetParamSimple(map, prefix + "FormName", this.FormName);
            this.SetParamSimple(map, prefix + "BlockChainMark", this.BlockChainMark);
            this.SetParamSimple(map, prefix + "AcquisitionMark", this.AcquisitionMark);
            this.SetParamSimple(map, prefix + "SubTotal", this.SubTotal);
            this.SetParamSimple(map, prefix + "SubTax", this.SubTax);
        }
    }
}

