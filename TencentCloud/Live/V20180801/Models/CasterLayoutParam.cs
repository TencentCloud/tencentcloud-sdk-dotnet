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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CasterLayoutParam : AbstractModel
    {
        
        /// <summary>
        /// 布局层ID。
        /// 在画面最终渲染时，将按ID从小到大的顺序，由下至上渲染。
        /// </summary>
        [JsonProperty("LayerId")]
        public long? LayerId{ get; set; }

        /// <summary>
        /// 布局层宽度。单位为百分比，范围[0.0,1.0]，表示该层在最终画面上所占的比例值。
        /// </summary>
        [JsonProperty("LayerWidth")]
        public float? LayerWidth{ get; set; }

        /// <summary>
        /// 布局层高度。单位为百分比，范围[0.0,1.0]， 表示该层在最终画面上所占的比例值。
        /// </summary>
        [JsonProperty("LayerHeight")]
        public float? LayerHeight{ get; set; }

        /// <summary>
        /// 布局层位置x坐标。单位为百分比，范围[0.0,1.0]，表示该层在最终画面上x坐标所占的比例值。
        /// </summary>
        [JsonProperty("LayerLocationX")]
        public float? LayerLocationX{ get; set; }

        /// <summary>
        /// 布局层位置Y坐标。单位为百分比，范围[0.0,1.0]， 表示该层在最终画面Y坐标上所占的比例值。
        /// </summary>
        [JsonProperty("LayerLocationY")]
        public float? LayerLocationY{ get; set; }

        /// <summary>
        /// 是否启用抠图。
        /// </summary>
        [JsonProperty("UsePortraitSegment")]
        public bool? UsePortraitSegment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayerId", this.LayerId);
            this.SetParamSimple(map, prefix + "LayerWidth", this.LayerWidth);
            this.SetParamSimple(map, prefix + "LayerHeight", this.LayerHeight);
            this.SetParamSimple(map, prefix + "LayerLocationX", this.LayerLocationX);
            this.SetParamSimple(map, prefix + "LayerLocationY", this.LayerLocationY);
            this.SetParamSimple(map, prefix + "UsePortraitSegment", this.UsePortraitSegment);
        }
    }
}

