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

    public class BindAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// 主播Id
        /// </summary>
        [JsonProperty("AnchorId")]
        public string AnchorId{ get; set; }

        /// <summary>
        /// 1 微信企业付款 
        /// 2 支付宝转账 
        /// 3 平安银企直连代发转账
        /// </summary>
        [JsonProperty("TransferType")]
        public long? TransferType{ get; set; }

        /// <summary>
        /// 收款方标识。
        /// 微信为open_id；
        /// 支付宝为会员alipay_user_id;
        /// 平安为收款方银行账号;
        /// </summary>
        [JsonProperty("AccountNo")]
        public string AccountNo{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnchorId", this.AnchorId);
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "AccountNo", this.AccountNo);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
        }
    }
}

