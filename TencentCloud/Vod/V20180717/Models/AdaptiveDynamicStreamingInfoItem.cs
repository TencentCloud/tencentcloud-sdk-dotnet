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

    public class AdaptiveDynamicStreamingInfoItem : AbstractModel
    {
        
        /// <summary>
        /// <p>转自适应码流规格。</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>打包格式，取值范围：</p><li>HLS；</li><li>DASH。</li>
        /// </summary>
        [JsonProperty("Package")]
        public string Package{ get; set; }

        /// <summary>
        /// <p>加密类型。</p>
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// <p>播放地址。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>媒体文件大小，单位：字节。</p><li>当媒体文件为 HLS 时，大小是 m3u8 和 ts 文件大小的总和；</li><li>当媒体文件为 DASH 时，大小是 mpd 和分片文件大小的总和；</li><li><font color="red">注意</font>：在 2022-01-10T16:00:00Z 前处理生成的自适应码流文件此字段为0。</li>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>数字水印类型。可选值：</p><li>Trace 表示经过溯源水印处理；</li><li>CopyRight 表示经过版权水印处理；</li><li>None 表示没有经过数字水印处理。</li>
        /// </summary>
        [JsonProperty("DigitalWatermarkType")]
        public string DigitalWatermarkType{ get; set; }

        /// <summary>
        /// <p>子流信息列表。</p>
        /// </summary>
        [JsonProperty("SubStreamSet")]
        public MediaSubStreamInfoItem[] SubStreamSet{ get; set; }

        /// <summary>
        /// <p>版权信息。</p>
        /// </summary>
        [JsonProperty("CopyRightWatermarkText")]
        public string CopyRightWatermarkText{ get; set; }

        /// <summary>
        /// <p>数字水印模板id。</p>
        /// </summary>
        [JsonProperty("BlindWatermarkDefinition")]
        public long? BlindWatermarkDefinition{ get; set; }

        /// <summary>
        /// <p>字幕信息列表。</p>
        /// </summary>
        [JsonProperty("SubtitleSet")]
        public MediaSubtitleItem[] SubtitleSet{ get; set; }

        /// <summary>
        /// <p>默认字幕的唯一标识。</p>
        /// </summary>
        [JsonProperty("DefaultSubtitleId")]
        public string DefaultSubtitleId{ get; set; }

        /// <summary>
        /// <p>DRM加密方法。</p>
        /// </summary>
        [JsonProperty("DrmEncryptType")]
        public string DrmEncryptType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Package", this.Package);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "DigitalWatermarkType", this.DigitalWatermarkType);
            this.SetParamArrayObj(map, prefix + "SubStreamSet.", this.SubStreamSet);
            this.SetParamSimple(map, prefix + "CopyRightWatermarkText", this.CopyRightWatermarkText);
            this.SetParamSimple(map, prefix + "BlindWatermarkDefinition", this.BlindWatermarkDefinition);
            this.SetParamArrayObj(map, prefix + "SubtitleSet.", this.SubtitleSet);
            this.SetParamSimple(map, prefix + "DefaultSubtitleId", this.DefaultSubtitleId);
            this.SetParamSimple(map, prefix + "DrmEncryptType", this.DrmEncryptType);
        }
    }
}

