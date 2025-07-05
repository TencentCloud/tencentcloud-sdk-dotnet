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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaProcessInfo : AbstractModel
    {
        
        /// <summary>
        /// 编辑处理任务类型，可选值：
        /// MediaEditing：媒体编辑（待上线）；
        /// MediaCutting：媒体剪切；
        /// MediaJoining：媒体拼接。
        /// MediaRecognition: 媒体识别。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频剪切任务参数，Type=MediaCutting时必选。
        /// </summary>
        [JsonProperty("MediaCuttingInfo")]
        public MediaCuttingInfo MediaCuttingInfo{ get; set; }

        /// <summary>
        /// 视频拼接任务参数，Type=MediaJoining时必选。
        /// </summary>
        [JsonProperty("MediaJoiningInfo")]
        public MediaJoiningInfo MediaJoiningInfo{ get; set; }

        /// <summary>
        /// 媒体识别任务参数，Type=MediaRecognition时必选
        /// </summary>
        [JsonProperty("MediaRecognitionInfo")]
        public MediaRecognitionInfo MediaRecognitionInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "MediaCuttingInfo.", this.MediaCuttingInfo);
            this.SetParamObj(map, prefix + "MediaJoiningInfo.", this.MediaJoiningInfo);
            this.SetParamObj(map, prefix + "MediaRecognitionInfo.", this.MediaRecognitionInfo);
        }
    }
}

