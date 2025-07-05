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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendStatusStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间，格式为yyyymmddhh，精确到小时，例如2024050113，表示2024年5月1号13时。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 结束时间，格式为yyyymmddhh，精确到小时，例如2024050118，表示2024年5月1号18时。
        /// 注：EndTime 必须大于等于 BeginTime。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 短信 SdkAppId 在 [短信控制台](https://console.cloud.tencent.com/smsv2/app-manage)  添加应用后生成的实际 SdkAppId，示例如1400006666。
        /// </summary>
        [JsonProperty("SmsSdkAppId")]
        public string SmsSdkAppId{ get; set; }

        /// <summary>
        /// 最大上限。
        /// 注：目前固定设置为0。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量。
        /// 注：目前固定设置为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SmsSdkAppId", this.SmsSdkAppId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

