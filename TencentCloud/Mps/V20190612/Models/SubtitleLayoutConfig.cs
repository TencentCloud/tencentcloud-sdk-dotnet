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

    public class SubtitleLayoutConfig : AbstractModel
    {
        
        /// <summary>
        /// 字幕排列配置开关，0关闭，1开启，默认0
        /// </summary>
        [JsonProperty("SubtitleLayoutConfigSwitch")]
        public long? SubtitleLayoutConfigSwitch{ get; set; }

        /// <summary>
        /// 行间距。正整数。
        /// - 代表像素值时， [0, 1000]。
        /// - 代表百分数时，[0, 100]。不填默认0。
        /// </summary>
        [JsonProperty("LineSpacing")]
        public long? LineSpacing{ get; set; }

        /// <summary>
        /// LineSpacing单位，0 像素，1百分比，默认为0，像素
        /// </summary>
        [JsonProperty("LineSpacingUnit")]
        public long? LineSpacingUnit{ get; set; }

        /// <summary>
        /// 对齐方式，取值：top: 顶部对齐，字幕顶部按位置固定，底部随行数变化。bottom: 底部对齐，字幕底部按位置固定，顶部随行数变化。不填默认底部对齐。
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleLayoutConfigSwitch", this.SubtitleLayoutConfigSwitch);
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
            this.SetParamSimple(map, prefix + "LineSpacingUnit", this.LineSpacingUnit);
            this.SetParamSimple(map, prefix + "Alignment", this.Alignment);
        }
    }
}

