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

    public class OpenBankProfitSharePayeeInfo : AbstractModel
    {
        
        /// <summary>
        /// 收款人账户名称
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 银行名称
        /// 可大体识别银行就行
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 账户货币
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 账户类型。
        /// 00:借记卡
        /// 01:存折 
        /// 02:信用卡 
        /// 03:准贷记卡 
        /// 04:预付卡费 
        /// 05:境外卡
        /// </summary>
        [JsonProperty("Nature")]
        public string Nature{ get; set; }

        /// <summary>
        /// 账户地区/受益人所在国家。参考附录“国家代码”表——“代码”字段
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 账户开户所在国家
        /// 参考附录“国家代码”表——“代码”字段
        /// </summary>
        [JsonProperty("DepositCountry")]
        public string DepositCountry{ get; set; }

        /// <summary>
        /// 合作有效期
        /// yyyy-MM-dd
        /// </summary>
        [JsonProperty("ExpireDate")]
        public string ExpireDate{ get; set; }

        /// <summary>
        /// 0:个人(对私) 1:公司(对公)
        /// </summary>
        [JsonProperty("Flag")]
        public string Flag{ get; set; }

        /// <summary>
        /// 开户行地址
        /// 账户地区非中国必填，【账户名+开户行地址不可超过114个字符（只允许【英文字母数字空格.,/-()'】），否则可能导致境外银行付款失败】
        /// </summary>
        [JsonProperty("BankAddress")]
        public string BankAddress{ get; set; }

        /// <summary>
        /// 客户地址
        /// 非中国内地账户的客户地址不能为空
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 账户属性
        /// 账户开户所在国家为中国则必填。
        /// 1-离岸账户 0-在岸账户
        /// </summary>
        [JsonProperty("IsOSA")]
        public string IsOSA{ get; set; }

        /// <summary>
        /// 账户省份
        /// 参考附录“地区代码”
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 账户城市
        /// 参考附录“地区代码
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 证件号/统一信用证代码
        /// 如果country与depositcountry字段都是CHN时，必填
        /// 对公账户填统一信用证代码，对私账户填身份证号码
        /// 离岸账户非必填
        /// </summary>
        [JsonProperty("LegalIdNo")]
        public string LegalIdNo{ get; set; }

        /// <summary>
        /// 手机号。
        /// 账户地区是日本则必填
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 参考接口说明。
        /// </summary>
        [JsonProperty("BicCode")]
        public string BicCode{ get; set; }

        /// <summary>
        /// 参考接口说明。
        /// </summary>
        [JsonProperty("SwiftCode")]
        public string SwiftCode{ get; set; }

        /// <summary>
        /// 大额支付行号/支付行号
        /// 参考接口说明。境外（大额支付行号）参考附录【大额行号】，境内（支付行号）参考附录【支付行号】
        /// </summary>
        [JsonProperty("Cnaps")]
        public string Cnaps{ get; set; }

        /// <summary>
        /// 中转行号，参考接口说明。
        /// </summary>
        [JsonProperty("TransferBankNo")]
        public string TransferBankNo{ get; set; }

        /// <summary>
        /// 关联附件。上传的文件ID
        /// </summary>
        [JsonProperty("Fid")]
        public string Fid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "Nature", this.Nature);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "DepositCountry", this.DepositCountry);
            this.SetParamSimple(map, prefix + "ExpireDate", this.ExpireDate);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "BankAddress", this.BankAddress);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "IsOSA", this.IsOSA);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "LegalIdNo", this.LegalIdNo);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "BicCode", this.BicCode);
            this.SetParamSimple(map, prefix + "SwiftCode", this.SwiftCode);
            this.SetParamSimple(map, prefix + "Cnaps", this.Cnaps);
            this.SetParamSimple(map, prefix + "TransferBankNo", this.TransferBankNo);
            this.SetParamSimple(map, prefix + "Fid", this.Fid);
        }
    }
}

