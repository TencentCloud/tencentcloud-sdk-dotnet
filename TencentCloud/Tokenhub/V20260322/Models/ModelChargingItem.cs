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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelChargingItem : AbstractModel
    {
        
        /// <summary>
        /// <p>价格维度标识。取值：Input（输入）、Output（输出）、Cache（缓存命中）、Thinking（思考）、BatchInput（批量输入）、BatchOutput（批量输出）、BatchCache（批量缓存命中）、ImageInput（输入图片）、ImageOutput（输出图片）、Search（搜索调用）。</p>
        /// </summary>
        [JsonProperty("PriceName")]
        public string PriceName{ get; set; }

        /// <summary>
        /// <p>价格维度展示名，后端直接提供当前语言文本（如 输入、Input），前端无需翻译。</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>价格数值。</p>
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// <p>价格单位，后端直接提供当前语言文本（如 元/百万tokens、元/张、积分/次）。</p>
        /// </summary>
        [JsonProperty("PriceUnit")]
        public string PriceUnit{ get; set; }

        /// <summary>
        /// <p>高峰价格，为空表示无高峰定价</p>
        /// </summary>
        [JsonProperty("PeakPrice")]
        public string PeakPrice{ get; set; }

        /// <summary>
        /// <p>规格描述，例如视觉/语音类模型有值（如 有参考视频 540P、图生视频 首帧 720P、动作控制 1080P、有声-未指定音色），其他模型为空。</p>
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// <p>Token 用量描述，例如视觉/语音类模型有值（如 第1秒 62,500 Tokens，后续每秒 15,625 Tokens），其他模型为空。</p>
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// <p>参考费用/预估费用描述，例如视觉/语音类模型有值（如 第1秒 0.625 元，后续每秒 0.15625 元），其他模型为空。</p>
        /// </summary>
        [JsonProperty("ReferencePrice")]
        public string ReferencePrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PriceName", this.PriceName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "PriceUnit", this.PriceUnit);
            this.SetParamSimple(map, prefix + "PeakPrice", this.PeakPrice);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "ReferencePrice", this.ReferencePrice);
        }
    }
}

