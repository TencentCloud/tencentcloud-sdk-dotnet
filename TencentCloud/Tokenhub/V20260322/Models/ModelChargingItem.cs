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
        /// 价格维度标识。取值：Input（输入）、Output（输出）、Cache（缓存命中）、Thinking（思考）、BatchInput（批量输入）、BatchOutput（批量输出）、BatchCache（批量缓存命中）、ImageInput（输入图片）、ImageOutput（输出图片）、Search（搜索调用）。
        /// </summary>
        [JsonProperty("PriceName")]
        public string PriceName{ get; set; }

        /// <summary>
        /// 价格维度展示名，后端直接提供当前语言文本（如 输入、Input），前端无需翻译。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 价格数值。
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 价格单位，后端直接提供当前语言文本（如 元/百万tokens、元/张、积分/次）。
        /// </summary>
        [JsonProperty("PriceUnit")]
        public string PriceUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PriceName", this.PriceName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "PriceUnit", this.PriceUnit);
        }
    }
}

