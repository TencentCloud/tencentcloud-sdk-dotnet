/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class ApplyOpenBankSettleOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部结算流水号
        /// </summary>
        [JsonProperty("OutSettleId")]
        public string OutSettleId{ get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [JsonProperty("SettleAmount")]
        public long? SettleAmount{ get; set; }

        /// <summary>
        /// 渠道名称。详见附录-枚举类型-ChannelName。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 渠道子商户号
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 结算备注
        /// </summary>
        [JsonProperty("SettleDetail")]
        public string SettleDetail{ get; set; }

        /// <summary>
        /// 结算成功回调地址
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 结算第三方渠道扩展信息。通联国际必选
        /// </summary>
        [JsonProperty("ExternalSettleData")]
        public string ExternalSettleData{ get; set; }

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
            this.SetParamSimple(map, prefix + "OutSettleId", this.OutSettleId);
            this.SetParamSimple(map, prefix + "SettleAmount", this.SettleAmount);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "SettleDetail", this.SettleDetail);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ExternalSettleData", this.ExternalSettleData);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

