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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEdrAlertExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>PolicyType - int - 是否必填：否 - 策略类型PolicyName - string - 是否必填：否 - 策略名称Domain - string - 是否必填：否 - 域名(先对域名做urlencode,再base64)PolicyAction- int - 是否必填：否 - 策略动作IsEnabled - int - 是否必填：否 - 是否生效</p>
        /// </summary>
        [JsonProperty("Filters")]
        public EDRFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>限制条数,默认10,最大100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量,默认0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>排序方式: [ASC:升序|DESC:降序]</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>可选排序列: [LatestDetectTime]</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// <p>自定义任务名，允许重复；传空自动生成默认名 alert_{appid}_{时间戳}（如 alert_1234567890_20260501114522）；仅支持数字/字母/下划线/短横线/中文，≤100 字符（按字符/rune 计，中文按 1 个字符），校验失败返回 InvalidParameter（文案 TextEdrExportJobNameInvalid）</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
        }
    }
}

