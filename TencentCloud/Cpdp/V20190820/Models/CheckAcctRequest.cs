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

    public class CheckAcctRequest : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 1：小额鉴权
        /// 2：短信校验鉴权
        /// </summary>
        [JsonProperty("BindType")]
        public long? BindType{ get; set; }

        /// <summary>
        /// 结算账户账号
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("SettleAcctNo")]
        public string SettleAcctNo{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 短信验证码
        /// BindType==2必填
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 币种 RMB
        /// BindType==1必填
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 单位
        /// 1：元，2：角，3：分
        /// BindType==1必填
        /// </summary>
        [JsonProperty("CurrencyUnit")]
        public long? CurrencyUnit{ get; set; }

        /// <summary>
        /// 金额
        /// BindType==1必填
        /// </summary>
        [JsonProperty("CurrencyAmt")]
        public string CurrencyAmt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamSimple(map, prefix + "SettleAcctNo", this.SettleAcctNo);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "CurrencyUnit", this.CurrencyUnit);
            this.SetParamSimple(map, prefix + "CurrencyAmt", this.CurrencyAmt);
        }
    }
}

