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

    public class CasterMarkWordInfo : AbstractModel
    {
        
        /// <summary>
        /// 文字水印Index。
        /// </summary>
        [JsonProperty("MarkWordIndex")]
        public long? MarkWordIndex{ get; set; }

        /// <summary>
        /// 文字水印内容。
        /// </summary>
        [JsonProperty("MarkWordText")]
        public string MarkWordText{ get; set; }

        /// <summary>
        /// 文字水印的字号。
        /// 范围[16, 60]
        /// </summary>
        [JsonProperty("MarkWordFontSize")]
        public ulong? MarkWordFontSize{ get; set; }

        /// <summary>
        /// 文字水印的颜色，值为HEX颜色代码
        /// </summary>
        [JsonProperty("MarkWordFontColor")]
        public string MarkWordFontColor{ get; set; }

        /// <summary>
        /// 文字水印的字体类型。
        /// 范围[1,2]。
        /// 1. 宋体
        /// 2. 黑体
        /// </summary>
        [JsonProperty("MarkWordFontType")]
        public ulong? MarkWordFontType{ get; set; }

        /// <summary>
        /// 文字水印的x坐标位置，单位百分比。
        /// 范围[0.0, 1.0]
        /// </summary>
        [JsonProperty("MarkWordLocationX")]
        public float? MarkWordLocationX{ get; set; }

        /// <summary>
        /// 文字水印的Y坐标位置，单位百分比。
        /// 范围[0.0, 1.0]
        /// </summary>
        [JsonProperty("MarkWordLocationY")]
        public float? MarkWordLocationY{ get; set; }

        /// <summary>
        /// 是否开启文字跑马灯功能。
        /// 默认为false。
        /// </summary>
        [JsonProperty("MarkWordRollEnable")]
        public bool? MarkWordRollEnable{ get; set; }

        /// <summary>
        /// 跑马灯文字显示一遍的时间，单位为秒。
        /// 默认为5s。
        /// 范围[5, 600]。
        /// </summary>
        [JsonProperty("MarkWordRollOnceTime")]
        public ulong? MarkWordRollOnceTime{ get; set; }

        /// <summary>
        /// 跑马灯文字的方向。
        /// 默认值为0。
        /// 范围[0,1]。
        /// 0 从左到右
        /// 1 从右到左
        /// </summary>
        [JsonProperty("MarkWordRollDirection")]
        public long? MarkWordRollDirection{ get; set; }

        /// <summary>
        /// 跑马灯文字显示的起始x坐标，单位百分比。
        /// 范围[0.0, 1.0]
        /// </summary>
        [JsonProperty("MarkWordRollStartLocationX")]
        public float? MarkWordRollStartLocationX{ get; set; }

        /// <summary>
        /// 跑马灯文字显示的截止x坐标，单位百分比。
        /// 范围[0.0, 1.0]
        /// </summary>
        [JsonProperty("MarkWordRollEndLocationX")]
        public float? MarkWordRollEndLocationX{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarkWordIndex", this.MarkWordIndex);
            this.SetParamSimple(map, prefix + "MarkWordText", this.MarkWordText);
            this.SetParamSimple(map, prefix + "MarkWordFontSize", this.MarkWordFontSize);
            this.SetParamSimple(map, prefix + "MarkWordFontColor", this.MarkWordFontColor);
            this.SetParamSimple(map, prefix + "MarkWordFontType", this.MarkWordFontType);
            this.SetParamSimple(map, prefix + "MarkWordLocationX", this.MarkWordLocationX);
            this.SetParamSimple(map, prefix + "MarkWordLocationY", this.MarkWordLocationY);
            this.SetParamSimple(map, prefix + "MarkWordRollEnable", this.MarkWordRollEnable);
            this.SetParamSimple(map, prefix + "MarkWordRollOnceTime", this.MarkWordRollOnceTime);
            this.SetParamSimple(map, prefix + "MarkWordRollDirection", this.MarkWordRollDirection);
            this.SetParamSimple(map, prefix + "MarkWordRollStartLocationX", this.MarkWordRollStartLocationX);
            this.SetParamSimple(map, prefix + "MarkWordRollEndLocationX", this.MarkWordRollEndLocationX);
        }
    }
}

