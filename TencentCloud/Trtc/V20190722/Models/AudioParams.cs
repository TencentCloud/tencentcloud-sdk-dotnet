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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioParams : AbstractModel
    {
        
        /// <summary>
        /// 音频采样率枚举值:(注意1 代表48000HZ, 2 代表44100HZ, 3 代表16000HZ)
        /// 1：48000Hz（默认）;
        /// 2：44100Hz
        /// 3：16000Hz。
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 声道数枚举值:
        /// 1：单声道;
        /// 2：双声道（默认）。
        /// </summary>
        [JsonProperty("Channel")]
        public ulong? Channel{ get; set; }

        /// <summary>
        /// 音频码率: 取值范围[32000, 128000] ，单位bps，默认64000bps。
        /// </summary>
        [JsonProperty("BitRate")]
        public ulong? BitRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "BitRate", this.BitRate);
        }
    }
}

