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

    public class AiAnalysisTaskReelOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>解说视频路径。</p>
        /// </summary>
        [JsonProperty("VideoPath")]
        public string VideoPath{ get; set; }

        /// <summary>
        /// <p>解说视频路径列表。</p><p><strong>注意</strong>：</p><ol><li>当返回一个文件时，<code>VideoPath</code>返回一个文件路径，<code>VideoPaths</code>也会填充同样路径的一个元素。</li><li>当返回多个文件时，<code>VideoPath</code>返回为空字符串，<code>VideoPaths</code>返回多文件路径列表。</li></ol>
        /// </summary>
        [JsonProperty("VideoPaths")]
        public string[] VideoPaths{ get; set; }

        /// <summary>
        /// <p>脚本文件路径</p>
        /// </summary>
        [JsonProperty("ScriptPath")]
        public string ScriptPath{ get; set; }

        /// <summary>
        /// <p>多个脚本文件路径</p>
        /// </summary>
        [JsonProperty("ScriptPaths")]
        public string[] ScriptPaths{ get; set; }

        /// <summary>
        /// <p>解说视频存储位置。</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>输出视频字幕文件</p>
        /// </summary>
        [JsonProperty("OutputSubtitlePath")]
        public string OutputSubtitlePath{ get; set; }

        /// <summary>
        /// <p>多个输出视频字幕文件，与输出的VideoPaths对应</p>
        /// </summary>
        [JsonProperty("OutputSubtitlePaths")]
        public string[] OutputSubtitlePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoPath", this.VideoPath);
            this.SetParamArraySimple(map, prefix + "VideoPaths.", this.VideoPaths);
            this.SetParamSimple(map, prefix + "ScriptPath", this.ScriptPath);
            this.SetParamArraySimple(map, prefix + "ScriptPaths.", this.ScriptPaths);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputSubtitlePath", this.OutputSubtitlePath);
            this.SetParamArraySimple(map, prefix + "OutputSubtitlePaths.", this.OutputSubtitlePaths);
        }
    }
}

