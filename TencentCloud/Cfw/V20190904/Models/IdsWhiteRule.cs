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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IdsWhiteRule : AbstractModel
    {
        
        /// <summary>
        /// 策略备注，最多 200 个字符；可省略或传空字符串。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 策略截止时间，北京时间（UTC+8）YYYY-MM-DD HH:MM:SS，必须晚于当前时间；永久有效传 3000-01-01 00:00:00。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 使用 JSON integer 表示生效范围位图，取值 1–31；各项按位相加：1 互联网旁路、2 NAT、4 VPC、8 互联网串行、16 NDR。
        /// 例如：12 表示 VPC+互联网串行，31 表示全部范围。
        /// 匹配条件支持的范围：
        /// - 源/目的 IP、域名、IPS 规则：支持 1、2、4、8、16 及其组合。
        /// - 威胁情报：固定为 1。
        /// - 资产：使用 4、16 或 20。
        /// - UserAgent、Url、XForwardedFor、HostName、FileName、FileMd5：固定为 16；RuleType=9 同样固定为 16。
        /// </summary>
        [JsonProperty("FwType")]
        public long? FwType{ get; set; }

        /// <summary>
        /// 匹配条件。按 RuleType 填写对应字段，无值字段省略。除 UserAgent 外，同字段多值用逗号分隔；UserAgent 多值用 <#cfw-splite#>。
        /// </summary>
        [JsonProperty("Info")]
        public WhiteRuleInfo Info{ get; set; }

        /// <summary>
        /// 策略名称，填写 1–50 个字符。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamObj(map, prefix + "Info.", this.Info);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
        }
    }
}

