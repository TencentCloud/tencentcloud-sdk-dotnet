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

    public class QueryMemberTransactionRequest : AbstractModel
    {
        
        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(2)，功能标志（1: 下单预支付; 2: 确认并付款; 3: 退款; 6: 直接支付T+1; 9: 直接支付T+0）
        /// </summary>
        [JsonProperty("FunctionFlag")]
        public string FunctionFlag{ get; set; }

        /// <summary>
        /// STRING(50)，转出方的见证子账户的账号（付款方）
        /// </summary>
        [JsonProperty("OutSubAcctNo")]
        public string OutSubAcctNo{ get; set; }

        /// <summary>
        /// STRING(32)，转出方的交易网会员代码
        /// </summary>
        [JsonProperty("OutMemberCode")]
        public string OutMemberCode{ get; set; }

        /// <summary>
        /// STRING(150)，转出方的见证子账户的户名（户名是绑卡时上送的账户名称，如果未绑卡，就送OpenCustAcctId接口上送的用户昵称UserNickname）
        /// </summary>
        [JsonProperty("OutSubAcctName")]
        public string OutSubAcctName{ get; set; }

        /// <summary>
        /// STRING(50)，转入方的见证子账户的账号（收款方）
        /// </summary>
        [JsonProperty("InSubAcctNo")]
        public string InSubAcctNo{ get; set; }

        /// <summary>
        /// STRING(32)，转入方的交易网会员代码
        /// </summary>
        [JsonProperty("InMemberCode")]
        public string InMemberCode{ get; set; }

        /// <summary>
        /// STRING(150)，转入方的见证子账户的户名（户名是绑卡时上送的账户名称，如果未绑卡，就送OpenCustAcctId接口上送的用户昵称UserNickname）
        /// </summary>
        [JsonProperty("InSubAcctName")]
        public string InSubAcctName{ get; set; }

        /// <summary>
        /// STRING(20)，交易金额
        /// </summary>
        [JsonProperty("TranAmt")]
        public string TranAmt{ get; set; }

        /// <summary>
        /// STRING(20)，交易费用（平台收取交易费用）
        /// </summary>
        [JsonProperty("TranFee")]
        public string TranFee{ get; set; }

        /// <summary>
        /// STRING(20)，交易类型（01: 普通交易）
        /// </summary>
        [JsonProperty("TranType")]
        public string TranType{ get; set; }

        /// <summary>
        /// STRING(3)，币种（默认: RMB）
        /// </summary>
        [JsonProperty("Ccy")]
        public string Ccy{ get; set; }

        /// <summary>
        /// STRING(50)，订单号（功能标志为1,2,3时必输）
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }

        /// <summary>
        /// STRING(500)，订单内容
        /// </summary>
        [JsonProperty("OrderContent")]
        public string OrderContent{ get; set; }

        /// <summary>
        /// STRING(300)，备注（建议可送订单号，可在对账文件的备注字段获取到）
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// STRING(1027)，保留域（若需短信验证码则此项必输短信指令号）
        /// </summary>
        [JsonProperty("ReservedMsg")]
        public string ReservedMsg{ get; set; }

        /// <summary>
        /// STRING(300)，网银签名（若需短信验证码则此项必输）
        /// </summary>
        [JsonProperty("WebSign")]
        public string WebSign{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "FunctionFlag", this.FunctionFlag);
            this.SetParamSimple(map, prefix + "OutSubAcctNo", this.OutSubAcctNo);
            this.SetParamSimple(map, prefix + "OutMemberCode", this.OutMemberCode);
            this.SetParamSimple(map, prefix + "OutSubAcctName", this.OutSubAcctName);
            this.SetParamSimple(map, prefix + "InSubAcctNo", this.InSubAcctNo);
            this.SetParamSimple(map, prefix + "InMemberCode", this.InMemberCode);
            this.SetParamSimple(map, prefix + "InSubAcctName", this.InSubAcctName);
            this.SetParamSimple(map, prefix + "TranAmt", this.TranAmt);
            this.SetParamSimple(map, prefix + "TranFee", this.TranFee);
            this.SetParamSimple(map, prefix + "TranType", this.TranType);
            this.SetParamSimple(map, prefix + "Ccy", this.Ccy);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
            this.SetParamSimple(map, prefix + "OrderContent", this.OrderContent);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
            this.SetParamSimple(map, prefix + "WebSign", this.WebSign);
        }
    }
}

