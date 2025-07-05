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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoLiveStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备的唯一标识
        /// </summary>
        [JsonProperty("WID")]
        public string WID{ get; set; }

        /// <summary>
        /// 枚举如下：
        /// flv
        /// rtmp
        /// hls
        /// webrtc
        /// raw (视频原始帧)
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 工作空间Id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 主码流传0，子码流传1，默认主码流
        /// </summary>
        [JsonProperty("StreamId")]
        public long? StreamId{ get; set; }

        /// <summary>
        /// 设备所在环境，公有云私有化项目传0或者不传，混合云项目一般传空间id
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WID", this.WID);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Env", this.Env);
        }
    }
}

