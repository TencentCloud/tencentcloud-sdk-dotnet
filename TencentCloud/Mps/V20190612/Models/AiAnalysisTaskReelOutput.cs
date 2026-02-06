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
        /// 解说视频路径。
        /// </summary>
        [JsonProperty("VideoPath")]
        public string VideoPath{ get; set; }

        /// <summary>
        /// 解说视频路径列表。
        /// 
        /// **注意**：
        /// 1. 当返回一个文件时，`VideoPath `返回一个文件路径，`VideoPaths `也会填充同样路径的一个元素。
        /// 2. 当返回多个文件时，`VideoPath `返回为空字符串，`VideoPaths `返回多文件路径列表。
        /// </summary>
        [JsonProperty("VideoPaths")]
        public string[] VideoPaths{ get; set; }

        /// <summary>
        /// 脚本文件路径
        /// </summary>
        [JsonProperty("ScriptPath")]
        public string ScriptPath{ get; set; }

        /// <summary>
        /// 解说视频存储位置。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoPath", this.VideoPath);
            this.SetParamArraySimple(map, prefix + "VideoPaths.", this.VideoPaths);
            this.SetParamSimple(map, prefix + "ScriptPath", this.ScriptPath);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
        }
    }
}

