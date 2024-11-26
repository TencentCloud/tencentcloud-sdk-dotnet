/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 布局层宽度。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1920]。
        /// 当该值为小于1大于0的小数时，单位为百分比，表示该层在最终画面上所占的比例值。
        /// </summary>
        [JsonProperty("LayerWidth")]
        public float? LayerWidth{ get; set; }

        /// <summary>
        /// 布局层高度.
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1920]。
        /// 当该值为小于1大于0的小数时，单位为百分比，表示该层在最终画面上所占的比例值。
        /// </summary>
        [JsonProperty("LayerHeight")]
        public float? LayerHeight{ get; set; }

        /// <summary>
        /// 布局层位置x坐标。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1920]。
        /// 当该值为小于1大于0的小数时，单位为百分比，表示该层在最终画面上x坐标所占的比例值。
        /// </summary>
        [JsonProperty("LayerLocationX")]
        public float? LayerLocationX{ get; set; }

        /// <summary>
        /// 布局层位置Y坐标。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1920]。
        /// 当该值为小于1大于0的小数时，单位为百分比，表示该层在最终画面Y坐标上所占的比例值。
        /// </summary>
        [JsonProperty("LayerLocationY")]
        public float? LayerLocationY{ get; set; }

        /// <summary>
        /// 是否启用抠图。
        /// 注意：此字段可能返回 null，表示取不到有效值。
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

