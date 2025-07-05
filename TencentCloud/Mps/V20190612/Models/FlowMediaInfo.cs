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

    public class FlowMediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间戳，单位是秒。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 总带宽。
        /// </summary>
        [JsonProperty("Network")]
        public long? Network{ get; set; }

        /// <summary>
        /// 传输流的视频数据。
        /// </summary>
        [JsonProperty("Video")]
        public FlowMediaVideo[] Video{ get; set; }

        /// <summary>
        /// 传输流的音频数据。
        /// </summary>
        [JsonProperty("Audio")]
        public FlowMediaAudio[] Audio{ get; set; }

        /// <summary>
        /// 标志同一次推流。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 客户端IP。
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamArrayObj(map, prefix + "Video.", this.Video);
            this.SetParamArrayObj(map, prefix + "Audio.", this.Audio);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
        }
    }
}

