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

    public class DocToVideoInput : AbstractModel
    {
        
        /// <summary>
        /// <p>用于生成视频的文档链接。</p><p>支持的文档类型：pdf、pptx、docx、png、jpg<br>文档数量限制：3个<br>文档大小限制：10MB<br>文档页数限制：100页</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string[] FileUrl{ get; set; }

        /// <summary>
        /// <p>用于生成视频的prompt信息。</p><p>prompt长度限制：2000字符。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>文档生成视频模型名称</p><p>默认值：Wand</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>文档生成视频模型版本号</p><p>默认值：1.0</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>生成视频的宽高比。</p><p>枚举值：</p><ul><li>16:9： 16:9</li><li>9:16： 9:16</li><li>1:1： 1:1</li></ul><p>默认值：16:9</p>
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// <p>生成视频的语言。</p><p>枚举值：</p><ul><li>zh： 中文</li><li>en： 英文</li><li>ja： 日语</li><li>ko： 韩语</li><li>ru： 俄语</li><li>fr： 法语</li><li>es： 西班牙语</li><li>de： 德语</li></ul><p>默认值：zh</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>生成视频的时长参考。</p><p>非准确的视频时长，仅供大模型参考生成。</p><p>取值范围：[15, 1200]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("ReferenceDuration")]
        public long? ReferenceDuration{ get; set; }

        /// <summary>
        /// <p>是否开启AI配音功能。</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("EnableTTS")]
        public bool? EnableTTS{ get; set; }

        /// <summary>
        /// <p>音色ID。仅开启AI配音功能时有效。</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileUrl.", this.FileUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "ReferenceDuration", this.ReferenceDuration);
            this.SetParamSimple(map, prefix + "EnableTTS", this.EnableTTS);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
        }
    }
}

