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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubTaskTranscodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 子任务名称。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 目标文件信息。
        /// </summary>
        [JsonProperty("TargetInfo")]
        public TargetInfo TargetInfo{ get; set; }

        /// <summary>
        /// 视频剪辑信息。注意：如果填写了EditInfo，则VideoInfo和AudioInfo必填
        /// </summary>
        [JsonProperty("EditInfo")]
        public EditInfo EditInfo{ get; set; }

        /// <summary>
        /// 视频转码信息，不填保持和源文件一致。
        /// </summary>
        [JsonProperty("VideoInfo")]
        public VideoInfo VideoInfo{ get; set; }

        /// <summary>
        /// 音频转码信息，不填保持和源文件一致。
        /// </summary>
        [JsonProperty("AudioInfo")]
        public AudioInfo AudioInfo{ get; set; }

        /// <summary>
        /// 指定封装信息。
        /// </summary>
        [JsonProperty("MuxInfo")]
        public MuxInfo MuxInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
            this.SetParamObj(map, prefix + "EditInfo.", this.EditInfo);
            this.SetParamObj(map, prefix + "VideoInfo.", this.VideoInfo);
            this.SetParamObj(map, prefix + "AudioInfo.", this.AudioInfo);
            this.SetParamObj(map, prefix + "MuxInfo.", this.MuxInfo);
        }
    }
}

