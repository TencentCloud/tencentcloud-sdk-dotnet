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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LLMTokenUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>今日提示词攻击防护 token 消耗量</p>
        /// </summary>
        [JsonProperty("PromptUsage")]
        public long? PromptUsage{ get; set; }

        /// <summary>
        /// <p>今日内容安全文本检测 token 消耗量</p>
        /// </summary>
        [JsonProperty("ContentTextUsage")]
        public long? ContentTextUsage{ get; set; }

        /// <summary>
        /// <p>今日敏感数据检测 token 消耗量</p>
        /// </summary>
        [JsonProperty("SensitiveDataUsage")]
        public long? SensitiveDataUsage{ get; set; }

        /// <summary>
        /// <p>今日图片送检量（单位：张）</p>
        /// </summary>
        [JsonProperty("ContentImageUsage")]
        public long? ContentImageUsage{ get; set; }

        /// <summary>
        /// <p>该实例近7天token总量趋势（按天，缺失日期补0）</p>
        /// </summary>
        [JsonProperty("TokenTrend")]
        public LLMTokenTrendItem[] TokenTrend{ get; set; }

        /// <summary>
        /// <p>该实例近7天图片送检趋势（按天，缺失日期补0）</p>
        /// </summary>
        [JsonProperty("ImageTrend")]
        public LLMImageTrendItem[] ImageTrend{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PromptUsage", this.PromptUsage);
            this.SetParamSimple(map, prefix + "ContentTextUsage", this.ContentTextUsage);
            this.SetParamSimple(map, prefix + "SensitiveDataUsage", this.SensitiveDataUsage);
            this.SetParamSimple(map, prefix + "ContentImageUsage", this.ContentImageUsage);
            this.SetParamArrayObj(map, prefix + "TokenTrend.", this.TokenTrend);
            this.SetParamArrayObj(map, prefix + "ImageTrend.", this.ImageTrend);
        }
    }
}

