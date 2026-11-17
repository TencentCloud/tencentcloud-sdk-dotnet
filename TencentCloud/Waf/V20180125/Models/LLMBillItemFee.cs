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

    public class LLMBillItemFee : AbstractModel
    {
        
        /// <summary>
        /// 提示词攻击防护费用（元）
        /// </summary>
        [JsonProperty("PromptAttackFee")]
        public string PromptAttackFee{ get; set; }

        /// <summary>
        /// 内容合规检测（文本）费用（元）
        /// </summary>
        [JsonProperty("ContentTextFee")]
        public string ContentTextFee{ get; set; }

        /// <summary>
        /// 内容合规检测（图片）费用（元）
        /// </summary>
        [JsonProperty("ContentImageFee")]
        public string ContentImageFee{ get; set; }

        /// <summary>
        /// 敏感数据检测费用（元）
        /// </summary>
        [JsonProperty("SensitiveDataFee")]
        public string SensitiveDataFee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PromptAttackFee", this.PromptAttackFee);
            this.SetParamSimple(map, prefix + "ContentTextFee", this.ContentTextFee);
            this.SetParamSimple(map, prefix + "ContentImageFee", this.ContentImageFee);
            this.SetParamSimple(map, prefix + "SensitiveDataFee", this.SensitiveDataFee);
        }
    }
}

