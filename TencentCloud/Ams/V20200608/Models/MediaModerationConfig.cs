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

namespace TencentCloud.Ams.V20200608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaModerationConfig : AbstractModel
    {
        
        /// <summary>
        /// 音频截帧频率。默认一分钟
        /// </summary>
        [JsonProperty("AudioFrequency")]
        public long? AudioFrequency{ get; set; }

        /// <summary>
        /// 图片取帧频率, 单位（秒/帧），默认 5， 可选 1 ～ 300
        /// </summary>
        [JsonProperty("ImageFrequency")]
        public long? ImageFrequency{ get; set; }

        /// <summary>
        /// 异步回调地址。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 临时文件存储位置
        /// </summary>
        [JsonProperty("SegmentOutput")]
        public FileOutput SegmentOutput{ get; set; }

        /// <summary>
        /// 是否使用OCR，默认为true
        /// </summary>
        [JsonProperty("UseOCR")]
        public bool? UseOCR{ get; set; }

        /// <summary>
        /// 是否使用音频。（音频场景下，该值永远为true）
        /// </summary>
        [JsonProperty("UseAudio")]
        public bool? UseAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioFrequency", this.AudioFrequency);
            this.SetParamSimple(map, prefix + "ImageFrequency", this.ImageFrequency);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "SegmentOutput.", this.SegmentOutput);
            this.SetParamSimple(map, prefix + "UseOCR", this.UseOCR);
            this.SetParamSimple(map, prefix + "UseAudio", this.UseAudio);
        }
    }
}

