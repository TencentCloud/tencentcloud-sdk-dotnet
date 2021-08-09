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

    public class UsedVehicleInvoiceInfo : AbstractModel
    {
        
        /// <summary>
        /// 所属税局
        /// </summary>
        [JsonProperty("TaxBureau")]
        public string TaxBureau{ get; set; }

        /// <summary>
        /// 买方单位/个人
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 买方单位代码/身份证号码
        /// </summary>
        [JsonProperty("BuyerNo")]
        public string BuyerNo{ get; set; }

        /// <summary>
        /// 买方单位/个人地址
        /// </summary>
        [JsonProperty("BuyerAddress")]
        public string BuyerAddress{ get; set; }

        /// <summary>
        /// 买方单位电话
        /// </summary>
        [JsonProperty("BuyerTel")]
        public string BuyerTel{ get; set; }

        /// <summary>
        /// 卖方单位/个人
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 卖方单位代码/身份证号码
        /// </summary>
        [JsonProperty("SellerNo")]
        public string SellerNo{ get; set; }

        /// <summary>
        /// 卖方单位/个人地址
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// 卖方单位电话
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// 车牌照号
        /// </summary>
        [JsonProperty("VehicleLicenseNo")]
        public string VehicleLicenseNo{ get; set; }

        /// <summary>
        /// 登记证号
        /// </summary>
        [JsonProperty("RegisterNo")]
        public string RegisterNo{ get; set; }

        /// <summary>
        /// 车架号/车辆识别代码
        /// </summary>
        [JsonProperty("VehicleIdentifyNo")]
        public string VehicleIdentifyNo{ get; set; }

        /// <summary>
        /// 转入地车辆管理所名称
        /// </summary>
        [JsonProperty("ManagementOffice")]
        public string ManagementOffice{ get; set; }

        /// <summary>
        /// 车价合计
        /// </summary>
        [JsonProperty("VehicleTotalPrice")]
        public string VehicleTotalPrice{ get; set; }

        /// <summary>
        /// 经营、拍卖单位
        /// </summary>
        [JsonProperty("Auctioneer")]
        public string Auctioneer{ get; set; }

        /// <summary>
        /// 经营、拍卖单位地址
        /// </summary>
        [JsonProperty("AuctioneerAddress")]
        public string AuctioneerAddress{ get; set; }

        /// <summary>
        /// 经营、拍卖单位纳税人识别号
        /// </summary>
        [JsonProperty("AuctioneerTaxpayerNum")]
        public string AuctioneerTaxpayerNum{ get; set; }

        /// <summary>
        /// 经营、拍卖单位开户银行、账号
        /// </summary>
        [JsonProperty("AuctioneerBankAccount")]
        public string AuctioneerBankAccount{ get; set; }

        /// <summary>
        /// 经营、拍卖单位电话
        /// </summary>
        [JsonProperty("AuctioneerTel")]
        public string AuctioneerTel{ get; set; }

        /// <summary>
        /// 二手车市场
        /// </summary>
        [JsonProperty("Market")]
        public string Market{ get; set; }

        /// <summary>
        /// 二手车市场纳税人识别号
        /// </summary>
        [JsonProperty("MarketTaxpayerNum")]
        public string MarketTaxpayerNum{ get; set; }

        /// <summary>
        /// 二手车市场地址
        /// </summary>
        [JsonProperty("MarketAddress")]
        public string MarketAddress{ get; set; }

        /// <summary>
        /// 二手车市场开户银行账号
        /// </summary>
        [JsonProperty("MarketBankAccount")]
        public string MarketBankAccount{ get; set; }

        /// <summary>
        /// 二手车市场电话
        /// </summary>
        [JsonProperty("MarketTel")]
        public string MarketTel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaxBureau", this.TaxBureau);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerNo", this.BuyerNo);
            this.SetParamSimple(map, prefix + "BuyerAddress", this.BuyerAddress);
            this.SetParamSimple(map, prefix + "BuyerTel", this.BuyerTel);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerNo", this.SellerNo);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "VehicleLicenseNo", this.VehicleLicenseNo);
            this.SetParamSimple(map, prefix + "RegisterNo", this.RegisterNo);
            this.SetParamSimple(map, prefix + "VehicleIdentifyNo", this.VehicleIdentifyNo);
            this.SetParamSimple(map, prefix + "ManagementOffice", this.ManagementOffice);
            this.SetParamSimple(map, prefix + "VehicleTotalPrice", this.VehicleTotalPrice);
            this.SetParamSimple(map, prefix + "Auctioneer", this.Auctioneer);
            this.SetParamSimple(map, prefix + "AuctioneerAddress", this.AuctioneerAddress);
            this.SetParamSimple(map, prefix + "AuctioneerTaxpayerNum", this.AuctioneerTaxpayerNum);
            this.SetParamSimple(map, prefix + "AuctioneerBankAccount", this.AuctioneerBankAccount);
            this.SetParamSimple(map, prefix + "AuctioneerTel", this.AuctioneerTel);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "MarketTaxpayerNum", this.MarketTaxpayerNum);
            this.SetParamSimple(map, prefix + "MarketAddress", this.MarketAddress);
            this.SetParamSimple(map, prefix + "MarketBankAccount", this.MarketBankAccount);
            this.SetParamSimple(map, prefix + "MarketTel", this.MarketTel);
        }
    }
}

