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

    public class ImageResizeConfig : AbstractModel
    {
        
        /// <summary>
        /// 能力配置开关，可选值：
        /// <li>ON：开启</li>
        /// <li>OFF：关闭</li>
        /// 默认值：ON。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 输出图片模式，可选模式：
        /// <li>percent: 指定缩放倍率，可以为小数</li>
        /// <li>mfit: 缩放至指定宽高的较大矩形</li>
        /// <li>lfit: 缩放至指定宽高的较小矩形</li>
        /// <li>fill: 缩放至指定宽高的较大矩形，并居中裁剪指定宽高</li>
        /// <li>pad: 缩放至指定宽高的较小矩形，并填充到指定宽高</li>
        /// <li>fixed: 缩放至固定宽高，强制缩放</li>
        /// 默认值：percent。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 缩放倍率，可以为小数，当Mode为percent时使用。
        /// 
        /// 默认值：1.0。
        /// 取值范围：[0.1，10.0]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// 目标图片宽度。
        /// 
        /// 取值范围：[1，16384]。
        /// 注意：此字段在Mode非percent时优先使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 目标图片高度。
        /// 
        /// 取值范围：[1，16384]。
        /// 注意：此字段在Mode非percent时优先使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 目标图片长边。
        /// 
        /// 取值范围：[1，16384]。
        /// 注意：此字段在Mode非percent且未配置Width和Height时使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LongSide")]
        public ulong? LongSide{ get; set; }

        /// <summary>
        /// 目标图片短边。
        /// 
        /// 取值范围：[1，16384]。
        /// 注意：此字段在Mode非percent且未配置Width和Height时使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShortSide")]
        public ulong? ShortSide{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "LongSide", this.LongSide);
            this.SetParamSimple(map, prefix + "ShortSide", this.ShortSide);
        }
    }
}

