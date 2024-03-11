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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SponsorInfo : AbstractModel
    {
        
        /// <summary>
        /// 助力场景建议填写：活动发起人微信OpenId。
        /// </summary>
        [JsonProperty("SponsorOpenId")]
        public string SponsorOpenId{ get; set; }

        /// <summary>
        /// 助力场景建议填写：发起人设备号
        /// </summary>
        [JsonProperty("SponsorDeviceNumber")]
        public string SponsorDeviceNumber{ get; set; }

        /// <summary>
        /// 助力场景建议填写：发起人的MD5手机号
        /// </summary>
        [JsonProperty("SponsorPhone")]
        public string SponsorPhone{ get; set; }

        /// <summary>
        /// 助力场景建议填写：发起人IP
        /// </summary>
        [JsonProperty("SponsorIp")]
        public string SponsorIp{ get; set; }

        /// <summary>
        /// 助力场景建议填写：活动链接
        /// </summary>
        [JsonProperty("CampaignUrl")]
        public string CampaignUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SponsorOpenId", this.SponsorOpenId);
            this.SetParamSimple(map, prefix + "SponsorDeviceNumber", this.SponsorDeviceNumber);
            this.SetParamSimple(map, prefix + "SponsorPhone", this.SponsorPhone);
            this.SetParamSimple(map, prefix + "SponsorIp", this.SponsorIp);
            this.SetParamSimple(map, prefix + "CampaignUrl", this.CampaignUrl);
        }
    }
}

