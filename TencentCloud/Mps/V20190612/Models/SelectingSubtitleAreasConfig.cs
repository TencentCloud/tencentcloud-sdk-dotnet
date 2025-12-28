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

    public class SelectingSubtitleAreasConfig : AbstractModel
    {
        
        /// <summary>
        /// 自动选择自定义区域。
        /// 对选定区域，利用AI模型自动检测其中存在的选择目标并提取。
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// 示例视频或图片的宽，单位像素值
        /// </summary>
        [JsonProperty("SampleWidth")]
        public ulong? SampleWidth{ get; set; }

        /// <summary>
        /// 示例视频或图片的高，单位像素值
        /// </summary>
        [JsonProperty("SampleHeight")]
        public ulong? SampleHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamSimple(map, prefix + "SampleWidth", this.SampleWidth);
            this.SetParamSimple(map, prefix + "SampleHeight", this.SampleHeight);
        }
    }
}

