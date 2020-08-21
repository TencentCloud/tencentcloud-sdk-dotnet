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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamControl : AbstractModel
    {
        
        /// <summary>
        /// 视频流ID
        /// 视频流ID的取值含义如下：
        /// 1. tic_record_user - 表示白板视频流
        /// 2. tic_substream - 表示辅路视频流
        /// 3. 特定用户ID - 表示指定用户的视频流
        /// 
        /// 在实际录制过程中，视频流ID的匹配规则为前缀匹配，只要真实流ID的前缀与指定的流ID一致就认为匹配成功。
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// 设置是否对此路流开启录制。
        /// 
        /// true - 表示不对这路流进行录制，录制结果将不包含这路流的视频。
        /// false - 表示需要对这路流进行录制，录制结果会包含这路流的视频。
        /// 
        /// 默认为 false。
        /// </summary>
        [JsonProperty("DisableRecord")]
        public bool? DisableRecord{ get; set; }

        /// <summary>
        /// 设置是否禁用这路流的音频录制。
        /// 
        /// true - 表示不对这路流的音频进行录制，录制结果里这路流的视频将会没有声音。
        /// false - 录制视频会保留音频，如果设置为true，则录制视频会丢弃这路流的音频。
        /// 
        /// 默认为 false。
        /// </summary>
        [JsonProperty("DisableAudio")]
        public bool? DisableAudio{ get; set; }

        /// <summary>
        /// 设置当前流录制视频是否只录制小画面。
        /// 
        /// true - 录制小画面。设置为true时，请确保上行端同时上行了小画面，否则录制视频可能是黑屏。
        /// false - 录制大画面。
        /// 
        /// 默认为 false。
        /// </summary>
        [JsonProperty("PullSmallVideo")]
        public bool? PullSmallVideo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamSimple(map, prefix + "DisableAudio", this.DisableAudio);
            this.SetParamSimple(map, prefix + "PullSmallVideo", this.PullSmallVideo);
        }
    }
}

