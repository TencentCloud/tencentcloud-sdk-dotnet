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

    public class ModelChatContentPart : AbstractModel
    {
        
        /// <summary>
        /// <p>内容类型</p><p>枚举值：</p><ul><li>text： 文本内容</li><li>input_image： 图片输入</li><li>input_video： 视频输入</li><li>input_audio： 音频输入</li><li>input_file： 文件输入</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>文本消息</p><p>Type=text 时必填</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>图片输入</p><p>Type=input_image 时必填</p>
        /// </summary>
        [JsonProperty("InputImage")]
        public ModelChatInputImage InputImage{ get; set; }

        /// <summary>
        /// <p>视频输入</p><p>Type=input_video 时必填</p>
        /// </summary>
        [JsonProperty("InputVideo")]
        public ModelChatInputVideo InputVideo{ get; set; }

        /// <summary>
        /// <p>音频输入</p><p>Type=input_audio 时必填</p>
        /// </summary>
        [JsonProperty("InputAudio")]
        public ModelChatInputAudio InputAudio{ get; set; }

        /// <summary>
        /// <p>文件输入</p><p>Type=input_file 时必填</p>
        /// </summary>
        [JsonProperty("InputFile")]
        public ModelChatInputFile InputFile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "InputImage.", this.InputImage);
            this.SetParamObj(map, prefix + "InputVideo.", this.InputVideo);
            this.SetParamObj(map, prefix + "InputAudio.", this.InputAudio);
            this.SetParamObj(map, prefix + "InputFile.", this.InputFile);
        }
    }
}

