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

    public class BindAcctRequest : AbstractModel
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
        /// 1 – 小额转账验证
        /// 2 – 短信验证
        /// 每个结算账户每天只能使用一次小额转账验证
        /// </summary>
        [JsonProperty("BindType")]
        public long? BindType{ get; set; }

        /// <summary>
        /// 用于提现
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("SettleAcctNo")]
        public string SettleAcctNo{ get; set; }

        /// <summary>
        /// 结算账户户名
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("SettleAcctName")]
        public string SettleAcctName{ get; set; }

        /// <summary>
        /// 1 – 本行账户
        /// 2 – 他行账户
        /// </summary>
        [JsonProperty("SettleAcctType")]
        public long? SettleAcctType{ get; set; }

        /// <summary>
        /// 证件类型，见《证件类型》表
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// 证件号码
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("IdCode")]
        public string IdCode{ get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [JsonProperty("AcctBranchName")]
        public string AcctBranchName{ get; set; }

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
        /// 用于短信验证
        /// BindType==2时必填
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 超级网银行号和大小额行号
        /// 二选一
        /// </summary>
        [JsonProperty("CnapsBranchId")]
        public string CnapsBranchId{ get; set; }

        /// <summary>
        /// 超级网银行号和大小额行号
        /// 二选一
        /// </summary>
        [JsonProperty("EiconBankBranchId")]
        public string EiconBankBranchId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamSimple(map, prefix + "SettleAcctNo", this.SettleAcctNo);
            this.SetParamSimple(map, prefix + "SettleAcctName", this.SettleAcctName);
            this.SetParamSimple(map, prefix + "SettleAcctType", this.SettleAcctType);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "IdCode", this.IdCode);
            this.SetParamSimple(map, prefix + "AcctBranchName", this.AcctBranchName);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "CnapsBranchId", this.CnapsBranchId);
            this.SetParamSimple(map, prefix + "EiconBankBranchId", this.EiconBankBranchId);
        }
    }
}

