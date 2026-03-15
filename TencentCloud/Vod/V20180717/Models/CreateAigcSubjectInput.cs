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

    public class CreateAigcSubjectInput : AbstractModel
    {
        
        /// <summary>
        /// <p>主体名称。</p>
        /// </summary>
        [JsonProperty("SubjectName")]
        public string SubjectName{ get; set; }

        /// <summary>
        /// <p>主体图片。</p>
        /// </summary>
        [JsonProperty("SubjectImages")]
        public string[] SubjectImages{ get; set; }

        /// <summary>
        /// <p>主体视频。</p>
        /// </summary>
        [JsonProperty("SubjectVideos")]
        public string[] SubjectVideos{ get; set; }

        /// <summary>
        /// <p>主体音色ID。</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubjectName", this.SubjectName);
            this.SetParamArraySimple(map, prefix + "SubjectImages.", this.SubjectImages);
            this.SetParamArraySimple(map, prefix + "SubjectVideos.", this.SubjectVideos);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
        }
    }
}

