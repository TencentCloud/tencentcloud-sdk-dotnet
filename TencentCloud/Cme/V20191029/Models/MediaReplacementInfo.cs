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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaReplacementInfo : AbstractModel
    {
        
        /// <summary>
        /// 替换的媒体类型，取值有：
        /// <li>CMEMaterialId：替换的媒体类型为媒体 ID；</li>
        /// <li>ImageUrl：替换的媒体类型为图片 URL；</li>
        /// 
        /// 注：默认为 CMEMaterialId 。
        /// </summary>
        [JsonProperty("MediaType")]
        public string MediaType{ get; set; }

        /// <summary>
        /// 媒体 ID。
        /// 当媒体类型取值为 CMEMaterialId 时有效。
        /// </summary>
        [JsonProperty("MaterialId")]
        public string MaterialId{ get; set; }

        /// <summary>
        /// 媒体 URL。
        /// 当媒体类型取值为 ImageUrl 时有效，
        /// 图片仅支持 jpg、png 格式，且大小不超过 2M 。
        /// </summary>
        [JsonProperty("MediaUrl")]
        public string MediaUrl{ get; set; }

        /// <summary>
        /// 替换媒体选取的开始时间，单位为秒，默认为 0。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 预处理操作。
        /// 注：目前该功能暂不支持，请勿使用。
        /// </summary>
        [JsonProperty("PreprocessOperation")]
        public MediaPreprocessOperation PreprocessOperation{ get; set; }

        /// <summary>
        /// 静音开关，仅对视频类型媒体生效。取值有：
        /// <li>ON：视频媒体开启静音，该段媒体在导出中会屏蔽音频；</li>
        /// <li>OFF：视频媒体关闭静音；</li>
        /// 
        /// 注：默认为 OFF，即不对视频媒体的音频做静音处理。
        /// </summary>
        [JsonProperty("MuteSwitch")]
        public string MuteSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "MediaUrl", this.MediaUrl);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamObj(map, prefix + "PreprocessOperation.", this.PreprocessOperation);
            this.SetParamSimple(map, prefix + "MuteSwitch", this.MuteSwitch);
        }
    }
}

