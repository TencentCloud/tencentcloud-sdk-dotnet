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

    public class MotorVehicleSaleInvoice : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

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
        /// 税前金额
        /// </summary>
        [JsonProperty("PretaxAmount")]
        public string PretaxAmount{ get; set; }

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
        /// 销售方名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 销售方单位代码
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// 销售方开户行
        /// </summary>
        [JsonProperty("SellerBank")]
        public string SellerBank{ get; set; }

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
        /// 购买方身份证号码/组织机构代码
        /// </summary>
        [JsonProperty("BuyerID")]
        public string BuyerID{ get; set; }

        /// <summary>
        /// 主管税务机关
        /// </summary>
        [JsonProperty("TaxAuthorities")]
        public string TaxAuthorities{ get; set; }

        /// <summary>
        /// 主管税务机关代码
        /// </summary>
        [JsonProperty("TaxAuthoritiesCode")]
        public string TaxAuthoritiesCode{ get; set; }

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
        /// 发动机号码
        /// </summary>
        [JsonProperty("VehicleEngineCode")]
        public string VehicleEngineCode{ get; set; }

        /// <summary>
        /// 合格证号
        /// </summary>
        [JsonProperty("CertificateNumber")]
        public string CertificateNumber{ get; set; }

        /// <summary>
        /// 商检单号
        /// </summary>
        [JsonProperty("InspectionNumber")]
        public string InspectionNumber{ get; set; }

        /// <summary>
        /// 机器编号
        /// </summary>
        [JsonProperty("MachineID")]
        public string MachineID{ get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

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
        /// 合计税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// 吨位
        /// </summary>
        [JsonProperty("Tonnage")]
        public string Tonnage{ get; set; }

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
        /// 开票人
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 完税凭证号码
        /// </summary>
        [JsonProperty("TaxNum")]
        public string TaxNum{ get; set; }

        /// <summary>
        /// 限乘人数
        /// </summary>
        [JsonProperty("MaxPeopleNum")]
        public string MaxPeopleNum{ get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

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
        /// 是否存在二维码（1：有，0：无）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "SellerBank", this.SellerBank);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "BuyerID", this.BuyerID);
            this.SetParamSimple(map, prefix + "TaxAuthorities", this.TaxAuthorities);
            this.SetParamSimple(map, prefix + "TaxAuthoritiesCode", this.TaxAuthoritiesCode);
            this.SetParamSimple(map, prefix + "VIN", this.VIN);
            this.SetParamSimple(map, prefix + "VehicleModel", this.VehicleModel);
            this.SetParamSimple(map, prefix + "VehicleEngineCode", this.VehicleEngineCode);
            this.SetParamSimple(map, prefix + "CertificateNumber", this.CertificateNumber);
            this.SetParamSimple(map, prefix + "InspectionNumber", this.InspectionNumber);
            this.SetParamSimple(map, prefix + "MachineID", this.MachineID);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "Tonnage", this.Tonnage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FormType", this.FormType);
            this.SetParamSimple(map, prefix + "FormName", this.FormName);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "TaxNum", this.TaxNum);
            this.SetParamSimple(map, prefix + "MaxPeopleNum", this.MaxPeopleNum);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "MachineNumber", this.MachineNumber);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
        }
    }
}

