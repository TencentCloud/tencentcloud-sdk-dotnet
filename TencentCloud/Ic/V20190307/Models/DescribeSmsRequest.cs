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

namespace TencentCloud.Ic.V20190307.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSmsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("Sdkappid")]
        public long? Sdkappid{ get; set; }

        /// <summary>
        /// 卡片ID
        /// </summary>
        [JsonProperty("Iccid")]
        public string Iccid{ get; set; }

        /// <summary>
        /// 卡片号码
        /// </summary>
        [JsonProperty("Msisdn")]
        public string Msisdn{ get; set; }

        /// <summary>
        /// 短信类型
        /// </summary>
        [JsonProperty("SmsType")]
        public long? SmsType{ get; set; }

        /// <summary>
        /// 开始时间  YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 结束时间  YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 小于200
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sdkappid", this.Sdkappid);
            this.SetParamSimple(map, prefix + "Iccid", this.Iccid);
            this.SetParamSimple(map, prefix + "Msisdn", this.Msisdn);
            this.SetParamSimple(map, prefix + "SmsType", this.SmsType);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

