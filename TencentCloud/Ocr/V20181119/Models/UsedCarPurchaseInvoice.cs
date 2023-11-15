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

    public class UsedCarPurchaseInvoice : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 是否存在二维码（0：没有，1：有）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

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
        /// 销货单位名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// 销售方单位代码/个人身份证号
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 购买方单位代码/个人身份证号
        /// </summary>
        [JsonProperty("BuyerID")]
        public string BuyerID{ get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        [JsonProperty("BuyerAddress")]
        public string BuyerAddress{ get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [JsonProperty("BuyerTel")]
        public string BuyerTel{ get; set; }

        /// <summary>
        /// 二手车市场
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 二手车市场纳税人识别号
        /// </summary>
        [JsonProperty("CompanyTaxID")]
        public string CompanyTaxID{ get; set; }

        /// <summary>
        /// 二手车市场开户银行和账号
        /// </summary>
        [JsonProperty("CompanyBankAccount")]
        public string CompanyBankAccount{ get; set; }

        /// <summary>
        /// 二手车市场电话
        /// </summary>
        [JsonProperty("CompanyTel")]
        public string CompanyTel{ get; set; }

        /// <summary>
        /// 二手车市场地址
        /// </summary>
        [JsonProperty("CompanyAddress")]
        public string CompanyAddress{ get; set; }

        /// <summary>
        /// 转入地车辆管理所名称
        /// </summary>
        [JsonProperty("TransferAdministrationName")]
        public string TransferAdministrationName{ get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("LicensePlate")]
        public string LicensePlate{ get; set; }

        /// <summary>
        /// 登记证号
        /// </summary>
        [JsonProperty("RegistrationNumber")]
        public string RegistrationNumber{ get; set; }

        /// <summary>
        /// 车辆识别代码
        /// </summary>
        [JsonProperty("VIN")]
        public string VIN{ get; set; }

        /// <summary>
        /// 厂牌型号
        /// </summary>
        [JsonProperty("VehicleModel")]
        public string VehicleModel{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 发票联次
        /// </summary>
        [JsonProperty("FormType")]
        public string FormType{ get; set; }

        /// <summary>
        /// 发票联名
        /// </summary>
        [JsonProperty("FormName")]
        public string FormName{ get; set; }

        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// 经营拍卖单位
        /// </summary>
        [JsonProperty("AuctionOrgName")]
        public string AuctionOrgName{ get; set; }

        /// <summary>
        /// 经营拍卖单位地址
        /// </summary>
        [JsonProperty("AuctionOrgAddress")]
        public string AuctionOrgAddress{ get; set; }

        /// <summary>
        /// 经营拍卖单位纳税人识别号
        /// </summary>
        [JsonProperty("AuctionOrgTaxID")]
        public string AuctionOrgTaxID{ get; set; }

        /// <summary>
        /// 经营拍卖单位开户银行账号
        /// </summary>
        [JsonProperty("AuctionOrgBankAccount")]
        public string AuctionOrgBankAccount{ get; set; }

        /// <summary>
        /// 经营拍卖单位电话
        /// </summary>
        [JsonProperty("AuctionOrgPhone")]
        public string AuctionOrgPhone{ get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 税控码
        /// </summary>
        [JsonProperty("TaxCode")]
        public string TaxCode{ get; set; }

        /// <summary>
        /// 机器编号
        /// </summary>
        [JsonProperty("MachineSerialNumber")]
        public string MachineSerialNumber{ get; set; }

        /// <summary>
        /// 机打发票代码
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// 机打发票号码
        /// </summary>
        [JsonProperty("MachineNumber")]
        public string MachineNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerID", this.BuyerID);
            this.SetParamSimple(map, prefix + "BuyerAddress", this.BuyerAddress);
            this.SetParamSimple(map, prefix + "BuyerTel", this.BuyerTel);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyTaxID", this.CompanyTaxID);
            this.SetParamSimple(map, prefix + "CompanyBankAccount", this.CompanyBankAccount);
            this.SetParamSimple(map, prefix + "CompanyTel", this.CompanyTel);
            this.SetParamSimple(map, prefix + "CompanyAddress", this.CompanyAddress);
            this.SetParamSimple(map, prefix + "TransferAdministrationName", this.TransferAdministrationName);
            this.SetParamSimple(map, prefix + "LicensePlate", this.LicensePlate);
            this.SetParamSimple(map, prefix + "RegistrationNumber", this.RegistrationNumber);
            this.SetParamSimple(map, prefix + "VIN", this.VIN);
            this.SetParamSimple(map, prefix + "VehicleModel", this.VehicleModel);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FormType", this.FormType);
            this.SetParamSimple(map, prefix + "FormName", this.FormName);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "AuctionOrgName", this.AuctionOrgName);
            this.SetParamSimple(map, prefix + "AuctionOrgAddress", this.AuctionOrgAddress);
            this.SetParamSimple(map, prefix + "AuctionOrgTaxID", this.AuctionOrgTaxID);
            this.SetParamSimple(map, prefix + "AuctionOrgBankAccount", this.AuctionOrgBankAccount);
            this.SetParamSimple(map, prefix + "AuctionOrgPhone", this.AuctionOrgPhone);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "TaxCode", this.TaxCode);
            this.SetParamSimple(map, prefix + "MachineSerialNumber", this.MachineSerialNumber);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "MachineNumber", this.MachineNumber);
        }
    }
}

