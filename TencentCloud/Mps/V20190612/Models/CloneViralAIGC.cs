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

    public class CloneViralAIGC : AbstractModel
    {
        
        /// <summary>
        /// <p>视频时长</p><p>取值范围：[4, 30]</p><p>指定时取值范围随档位不同：flash 为 2-15, pro 为 4-30。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>宽高比。可选 9:16、16:9、3:4、4:3、1:1、21:9、adaptive（自适应参考视频，flash 档不支持）。</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>分辨率。支持720p（默认）/1080p</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>模式。可选 pro（专业版）、 flash（高级版，默认）</p>
        /// </summary>
        [JsonProperty("ModelTier")]
        public string ModelTier{ get; set; }

        /// <summary>
        /// <p>深度估计结果是否含音频， 默认不含</p>
        /// </summary>
        [JsonProperty("DepthWithAudio")]
        public bool? DepthWithAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "ModelTier", this.ModelTier);
            this.SetParamSimple(map, prefix + "DepthWithAudio", this.DepthWithAudio);
        }
    }
}

