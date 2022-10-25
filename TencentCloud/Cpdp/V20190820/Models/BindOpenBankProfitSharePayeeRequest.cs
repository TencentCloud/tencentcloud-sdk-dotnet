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

    public class BindOpenBankProfitSharePayeeRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号。代理商/集团ID
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 收款人银行账户号。唯一
        /// </summary>
        [JsonProperty("AccountNo")]
        public string AccountNo{ get; set; }

        /// <summary>
        /// 渠道名称
        /// 通联国际: CNP
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 渠道子商户号。商户ID
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 绑定状态通知地址,若为空，即不回调通知。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 分账收款人信息。通联国际必选
        /// </summary>
        [JsonProperty("ProfitSharePayeeInfo")]
        public OpenBankProfitSharePayeeInfo ProfitSharePayeeInfo{ get; set; }

        /// <summary>
        /// 第三方拓展信息。若无特殊说明，可为空
        /// </summary>
        [JsonProperty("ExternalProfitSharingData")]
        public string ExternalProfitSharingData{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填 sandbox。缺省默认调用生产环境
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "AccountNo", this.AccountNo);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamObj(map, prefix + "ProfitSharePayeeInfo.", this.ProfitSharePayeeInfo);
            this.SetParamSimple(map, prefix + "ExternalProfitSharingData", this.ExternalProfitSharingData);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

