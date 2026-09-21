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

    public class BeautyConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>美颜效果</p>
        /// </summary>
        [JsonProperty("BeautyEffectItems")]
        public BeautyEffectItemConfig[] BeautyEffectItems{ get; set; }

        /// <summary>
        /// <p>美颜滤镜</p>
        /// </summary>
        [JsonProperty("BeautyFilterItems")]
        public BeautyFilterItemConfig[] BeautyFilterItems{ get; set; }

        /// <summary>
        /// <p>美颜类型</p><p>枚举值：</p><ul><li>auto： 智能自动美颜</li></ul><p>传入美颜参数时，忽略该参数。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "BeautyEffectItems.", this.BeautyEffectItems);
            this.SetParamArrayObj(map, prefix + "BeautyFilterItems.", this.BeautyFilterItems);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

