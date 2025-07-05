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

    public class PullSmsReplyStatusByPhoneNumberRequest : AbstractModel
    {
        
        /// <summary>
        /// 拉取起始时间，UNIX 时间戳（时间：秒）。
        /// 注：最大可拉取当前时期前7天的数据。
        /// </summary>
        [JsonProperty("BeginTime")]
        public ulong? BeginTime{ get; set; }

        /// <summary>
        /// 偏移量。
        /// 注：目前固定设置为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 拉取最大条数，最多 100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 下发目的手机号码，依据 E.164 标准为：+[国家（或地区）码][手机号] ，示例如：+8618501234444， 其中前面有一个+号 ，86为国家码，18501234444为手机号。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 短信 SdkAppId 在 [短信控制台](https://console.cloud.tencent.com/smsv2/app-manage)  添加应用后生成的实际 SdkAppId，示例如1400006666。
        /// </summary>
        [JsonProperty("SmsSdkAppId")]
        public string SmsSdkAppId{ get; set; }

        /// <summary>
        /// 拉取截止时间，UNIX 时间戳（时间：秒）。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "SmsSdkAppId", this.SmsSdkAppId);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

