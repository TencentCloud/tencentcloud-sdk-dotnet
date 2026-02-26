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

    public class AigcVideoExtraParam : AbstractModel
    {
        
        /// <summary>
        /// <p>生成视频的分辨率，分辨率与选择模型及设置的视频时长相关。 </p><p>不同模型支持的分辨率选项:</p><ol><li>Kling 720P(默认), 1080P。</li><li>Hailuo 768P(默认), 1080P。</li><li>Vidu 720P(默认)，1080P。</li><li>GV 720P(默认),1080P。</li><li>OS 720P, 图片仅支持1280x720、720x1280，暂不支持指定。</li></ol><p>注意：除模型可支持的分辨率外，还可以生成 2K、4K分辨率。</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>指定所生成视频的宽高比。 </p><p>不同模型对于此参数的支持：</p><ol><li>Kling 仅文生视频支持, 16:9(默认值)、9:16、 1:1。</li><li>Hailuo 暂不支持。</li><li>Vidu 仅文生和参考图生视频 支持[16:9、9:16、4:3、3:4、1:1]，其中仅q2支持4:3、3:4。</li><li>GV 16:9(默认值)、9:16。</li><li>OS 仅文生视频支持, 16:9(默认), 9:16。</li></ol><p>注：关于具体模型支持的宽高比例，可查看具体模型官网介绍获取更完整描述。</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>是否添加图标水印。</p><ol><li>Hailuo 支持此参数。</li><li>Kling 支持此参数。</li><li>Vidu 支持此参数。</li></ol>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>为视频生成音频。接受的值包括 true 或 false。 </p><p>支持此参数的模型：</p><ol><li>GV，默认true。</li><li>OS，默认true。</li></ol>
        /// </summary>
        [JsonProperty("EnableAudio")]
        public bool? EnableAudio{ get; set; }

        /// <summary>
        /// <p>错峰模型，目前仅支持Vidu模型。<br>错峰模式下提交的任务，会在48小时内生成，未能完成的任务会被自动取消。</p>
        /// </summary>
        [JsonProperty("OffPeak")]
        public bool? OffPeak{ get; set; }

        /// <summary>
        /// <p>是否为生成的视频添加背景音乐。默认：false，可选值 true 、false。<br>注意：部分模型的版本支持。</p>
        /// </summary>
        [JsonProperty("EnableBgm")]
        public bool? EnableBgm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamSimple(map, prefix + "EnableAudio", this.EnableAudio);
            this.SetParamSimple(map, prefix + "OffPeak", this.OffPeak);
            this.SetParamSimple(map, prefix + "EnableBgm", this.EnableBgm);
        }
    }
}

