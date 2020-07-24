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

    public class CreateSinglePayRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务流水号，历史唯一
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 付方账户号
        /// </summary>
        [JsonProperty("PayAccountNumber")]
        public string PayAccountNumber{ get; set; }

        /// <summary>
        /// 付方账户名称
        /// </summary>
        [JsonProperty("PayAccountName")]
        public string PayAccountName{ get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

        /// <summary>
        /// 收方账户号
        /// </summary>
        [JsonProperty("RecvAccountNumber")]
        public string RecvAccountNumber{ get; set; }

        /// <summary>
        /// 收方账户名称
        /// </summary>
        [JsonProperty("RecvAccountName")]
        public string RecvAccountName{ get; set; }

        /// <summary>
        /// 付方账户CNAPS号
        /// </summary>
        [JsonProperty("PayBankCnaps")]
        public string PayBankCnaps{ get; set; }

        /// <summary>
        /// 付方账户银行大类，PayBankCnaps为空时必传（见常见问题-银企直连银行类型）
        /// </summary>
        [JsonProperty("PayBankType")]
        public string PayBankType{ get; set; }

        /// <summary>
        /// 付方账户银行所在省，PayBankCnaps为空时必传（见常见问题-银企直连省份枚举信息）
        /// </summary>
        [JsonProperty("PayBankProvince")]
        public string PayBankProvince{ get; set; }

        /// <summary>
        /// 付方账户银行所在地区，PayBankCnaps为空时必传（见常见问题-银企直连城市枚举信息）
        /// </summary>
        [JsonProperty("PayBankCity")]
        public string PayBankCity{ get; set; }

        /// <summary>
        /// 收方账户CNAPS号
        /// </summary>
        [JsonProperty("RecvBankCnaps")]
        public string RecvBankCnaps{ get; set; }

        /// <summary>
        /// 收方账户银行大类，RecvBankCnaps为空时必传（见常见问题-银企直连银行类型）
        /// </summary>
        [JsonProperty("RecvBankType")]
        public string RecvBankType{ get; set; }

        /// <summary>
        /// 收方账户银行所在省，RecvBankCnaps为空时必传（见常见问题-银企直连省份枚举信息）
        /// </summary>
        [JsonProperty("RecvBankProvince")]
        public string RecvBankProvince{ get; set; }

        /// <summary>
        /// 收方账户银行所在地区，RecvBankCnaps为空时必传（见常见问题-银企直连城市枚举信息）
        /// </summary>
        [JsonProperty("RecvBankCity")]
        public string RecvBankCity{ get; set; }

        /// <summary>
        /// 收款方证件类型（见常见问题-银企直连证件类型枚举信息）
        /// </summary>
        [JsonProperty("RecvCertType")]
        public string RecvCertType{ get; set; }

        /// <summary>
        /// 收款方证件号码
        /// </summary>
        [JsonProperty("RecvCertNo")]
        public string RecvCertNo{ get; set; }

        /// <summary>
        /// 摘要信息
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "PayAccountNumber", this.PayAccountNumber);
            this.SetParamSimple(map, prefix + "PayAccountName", this.PayAccountName);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "RecvAccountNumber", this.RecvAccountNumber);
            this.SetParamSimple(map, prefix + "RecvAccountName", this.RecvAccountName);
            this.SetParamSimple(map, prefix + "PayBankCnaps", this.PayBankCnaps);
            this.SetParamSimple(map, prefix + "PayBankType", this.PayBankType);
            this.SetParamSimple(map, prefix + "PayBankProvince", this.PayBankProvince);
            this.SetParamSimple(map, prefix + "PayBankCity", this.PayBankCity);
            this.SetParamSimple(map, prefix + "RecvBankCnaps", this.RecvBankCnaps);
            this.SetParamSimple(map, prefix + "RecvBankType", this.RecvBankType);
            this.SetParamSimple(map, prefix + "RecvBankProvince", this.RecvBankProvince);
            this.SetParamSimple(map, prefix + "RecvBankCity", this.RecvBankCity);
            this.SetParamSimple(map, prefix + "RecvCertType", this.RecvCertType);
            this.SetParamSimple(map, prefix + "RecvCertNo", this.RecvCertNo);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

