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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ColorInfo : AbstractModel
    {
        
        /// <summary>
        /// RGB颜色值（16进制），例如：291A18。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 当前颜色标签所占比例。
        /// </summary>
        [JsonProperty("Percentage")]
        public float? Percentage{ get; set; }

        /// <summary>
        /// 颜色标签。蜜柚色，米驼色等。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "Label", this.Label);
        }
    }
}

