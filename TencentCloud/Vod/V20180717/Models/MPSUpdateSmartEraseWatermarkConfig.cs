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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MPSUpdateSmartEraseWatermarkConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>水印擦除方式。<br> <strong>自动擦除：</strong>通过A模型自动识别视频中的水印，擦除后生成新的视频。适用于动态水印。 当使用自动擦除时，若您不指定AutoAreas，将对视频全屏进行自动擦除；若指定AutoAreas，将改为对您指定的区域进行自动擦除。<br><strong>指定区域擦除：</strong>针对位置较固定的静态水印，建议您直接指定擦除区域。 当您选择指定区域擦除时，请至少传入一个指定区域。 - auto 自动擦除 - custom 指定区域擦除</p>
        /// </summary>
        [JsonProperty("WatermarkEraseMethod")]
        public string WatermarkEraseMethod{ get; set; }

        /// <summary>
        /// <p>水印擦除模型。 基础版：效果一般，性价比高，适合动画或背景较干净的视频。 高级版：效果更好，适合短剧等现实风格视频。 </p><ul><li>basic 基础版 </li><li>advanced 高级版</li></ul>
        /// </summary>
        [JsonProperty("WatermarkModel")]
        public string WatermarkModel{ get; set; }

        /// <summary>
        /// <p>自动擦除自定义区域。 对选定区域，利用AI模型自动检测其中存在的擦除目标并擦除。 注意，当擦除方式为custom时，此参数将不会生效。清除区域请传入[]，不传时将保持模板区域信息不变。</p>
        /// </summary>
        [JsonProperty("AutoAreas")]
        public MPSEraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// <p>指定擦除自定义区域。 对选定区域，在选定时间段内不进行检测识别直接进行擦除。 注意：清除区域请传入[]，不传时将保持模板区域信息不变。</p>
        /// </summary>
        [JsonProperty("CustomAreas")]
        public MPSEraseTimeArea[] CustomAreas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WatermarkEraseMethod", this.WatermarkEraseMethod);
            this.SetParamSimple(map, prefix + "WatermarkModel", this.WatermarkModel);
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamArrayObj(map, prefix + "CustomAreas.", this.CustomAreas);
        }
    }
}

