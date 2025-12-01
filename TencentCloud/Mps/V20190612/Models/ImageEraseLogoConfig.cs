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

    public class ImageEraseLogoConfig : AbstractModel
    {
        
        /// <summary>
        /// 能力配置开关，可选值：
        /// <li>ON：开启；</li>
        /// <li>OFF：关闭。</li>
        /// 默认值：ON。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 需要擦除的多个框选区域，最多开启16个区域。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageAreaBoxes")]
        public ImageAreaBoxInfo[] ImageAreaBoxes{ get; set; }

        /// <summary>
        /// 图片框选区域类型，可选值：
        /// <li>logo：图标；</li>
        /// <li>text：文字；</li>
        /// <li>watermark：水印；</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectTypes")]
        public string[] DetectTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArrayObj(map, prefix + "ImageAreaBoxes.", this.ImageAreaBoxes);
            this.SetParamArraySimple(map, prefix + "DetectTypes.", this.DetectTypes);
        }
    }
}

