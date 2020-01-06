/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class FaceConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// 人脸识别任务开关，可选值：
        /// <li>ON：开启智能人脸识别任务；</li>
        /// <li>OFF：关闭智能人脸识别任务。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 人脸识别过滤分数，当识别结果达到该分数以上，返回识别结果。默认 95 分。取值范围：0 - 100。
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 默认人物过滤标签，指定需要返回的默认人物的标签。如果未填或者为空，则全部默认人物结果都返回。标签可选值：
        /// <li>entertainment：娱乐明星；</li>
        /// <li>sport：体育明星；</li>
        /// <li>politician：政治人物。</li>
        /// </summary>
        [JsonProperty("DefaultLibraryLabelSet")]
        public string[] DefaultLibraryLabelSet{ get; set; }

        /// <summary>
        /// 用户自定义人物过滤标签，指定需要返回的用户自定义人物的标签。如果未填或者为空，则全部自定义人物结果都返回。
        /// 标签个数最多 10 个，每个标签长度最多 16 个字符。
        /// </summary>
        [JsonProperty("UserDefineLibraryLabelSet")]
        public string[] UserDefineLibraryLabelSet{ get; set; }

        /// <summary>
        /// 人物库选择，可选值：
        /// <li>Default：使用默认人物库；</li>
        /// <li>UserDefine：使用用户自定义人物库。</li>
        /// <li>All：同时使用默认人物库和用户自定义人物库。</li>
        /// 默认值：All，使用系统默认人物库及用户自定义人物库。
        /// </summary>
        [JsonProperty("FaceLibrary")]
        public string FaceLibrary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "DefaultLibraryLabelSet.", this.DefaultLibraryLabelSet);
            this.SetParamArraySimple(map, prefix + "UserDefineLibraryLabelSet.", this.UserDefineLibraryLabelSet);
            this.SetParamSimple(map, prefix + "FaceLibrary", this.FaceLibrary);
        }
    }
}

