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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendStatusStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 拉取起始时间，yyyymmddhh 需要拉取的起始时间，精确到小时。
        /// </summary>
        [JsonProperty("StartDateTime")]
        public ulong? StartDateTime{ get; set; }

        /// <summary>
        /// 结束时间，yyyymmddhh 需要拉取的截止时间，精确到小时
        /// 注：EndDataTime 必须大于 StartDateTime。
        /// </summary>
        [JsonProperty("EndDataTime")]
        public ulong? EndDataTime{ get; set; }

        /// <summary>
        /// 短信SdkAppid在 [短信控制台](https://console.cloud.tencent.com/sms/smslist) 添加应用后生成的实际SdkAppid，示例如1400006666。
        /// </summary>
        [JsonProperty("SmsSdkAppid")]
        public string SmsSdkAppid{ get; set; }

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
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartDateTime", this.StartDateTime);
            this.SetParamSimple(map, prefix + "EndDataTime", this.EndDataTime);
            this.SetParamSimple(map, prefix + "SmsSdkAppid", this.SmsSdkAppid);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

