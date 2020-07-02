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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputParams : AbstractModel
    {
        
        /// <summary>
        /// 直播流 ID，由用户自定义设置，该流 ID 不能与用户旁路的流 ID 相同。
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// 取值范围[0,1]， 填0：直播流为音视频(默认); 填1：直播流为纯音频
        /// </summary>
        [JsonProperty("PureAudioStream")]
        public ulong? PureAudioStream{ get; set; }

        /// <summary>
        /// 自定义录制文件名
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 取值范围[0,1]，填0无实际含义; 填1：指定录制文件格式为mp3
        /// </summary>
        [JsonProperty("RecordAudioOnly")]
        public ulong? RecordAudioOnly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "PureAudioStream", this.PureAudioStream);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RecordAudioOnly", this.RecordAudioOnly);
        }
    }
}

