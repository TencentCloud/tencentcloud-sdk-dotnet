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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmsAmountDataStruct : AbstractModel
    {
        
        /// <summary>
        /// 短信活动配额
        /// </summary>
        [JsonProperty("SmsCampaignAmount")]
        public ulong? SmsCampaignAmount{ get; set; }

        /// <summary>
        /// 短信活动消耗配额
        /// </summary>
        [JsonProperty("SmsCampaignConsume")]
        public ulong? SmsCampaignConsume{ get; set; }

        /// <summary>
        /// 短信发送额度
        /// </summary>
        [JsonProperty("SmsSendAmount")]
        public ulong? SmsSendAmount{ get; set; }

        /// <summary>
        /// 短信发送消耗额度
        /// </summary>
        [JsonProperty("SmsSendConsume")]
        public ulong? SmsSendConsume{ get; set; }

        /// <summary>
        /// 超短活动额度
        /// </summary>
        [JsonProperty("MmsCampaignAmount")]
        public ulong? MmsCampaignAmount{ get; set; }

        /// <summary>
        /// 超短活动消耗额度
        /// </summary>
        [JsonProperty("MmsCampaignConsume")]
        public ulong? MmsCampaignConsume{ get; set; }

        /// <summary>
        /// 超短短信额度
        /// </summary>
        [JsonProperty("MmsSendAmount")]
        public ulong? MmsSendAmount{ get; set; }

        /// <summary>
        /// 超短短信消耗额度
        /// </summary>
        [JsonProperty("MmsSendConsume")]
        public ulong? MmsSendConsume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SmsCampaignAmount", this.SmsCampaignAmount);
            this.SetParamSimple(map, prefix + "SmsCampaignConsume", this.SmsCampaignConsume);
            this.SetParamSimple(map, prefix + "SmsSendAmount", this.SmsSendAmount);
            this.SetParamSimple(map, prefix + "SmsSendConsume", this.SmsSendConsume);
            this.SetParamSimple(map, prefix + "MmsCampaignAmount", this.MmsCampaignAmount);
            this.SetParamSimple(map, prefix + "MmsCampaignConsume", this.MmsCampaignConsume);
            this.SetParamSimple(map, prefix + "MmsSendAmount", this.MmsSendAmount);
            this.SetParamSimple(map, prefix + "MmsSendConsume", this.MmsSendConsume);
        }
    }
}

