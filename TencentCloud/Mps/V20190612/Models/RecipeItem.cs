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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecipeItem : AbstractModel
    {
        
        /// <summary>
        /// <p>子图类型</p><p>枚举值：</p><ul><li>hero： 商品主图</li><li>detail： 商品细节图</li><li>selling： 核心卖点图</li><li>atmosphere： 场景氛围图</li><li>angles： 多角度图</li><li>scene： 使用场景图</li></ul>
        /// </summary>
        [JsonProperty("Theme")]
        public string Theme{ get; set; }

        /// <summary>
        /// <p>对应子图数量。</p><p>取值范围：[1, 4]</p><p>单位：张</p><p>单种子图最多4张，子图总数必须在4-12张范围内。</p>
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Theme", this.Theme);
            this.SetParamSimple(map, prefix + "Num", this.Num);
        }
    }
}

