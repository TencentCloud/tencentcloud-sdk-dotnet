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

    public class AgoraParam : AbstractModel
    {
        
        /// <summary>
        /// <p>声网提供的应用标识</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>声网提供的频道名</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>声网录制的频道模式， 可选值如下：（默认值为0） 0: 通信（默认）,即常见的 1 对 1 单聊或群聊， 频道内任何用户可以自由说话； 1: 直播，有两种用户角色: 主播和观众。</p><p>枚举值：</p><ul><li>0:： 通信（默认）</li><li>1： 直播</li></ul>
        /// </summary>
        [JsonProperty("ChannelProfile")]
        public ulong? ChannelProfile{ get; set; }

        /// <summary>
        /// <p>绑定频道生成的临时Token</p>
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// <p>用户ID</p>
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// <p>信任用户的列表</p>
        /// </summary>
        [JsonProperty("TrustedUserIdList")]
        public ulong?[] TrustedUserIdList{ get; set; }

        /// <summary>
        /// <p>非信任用户的列表</p>
        /// </summary>
        [JsonProperty("UntrustedUserIdList")]
        public ulong?[] UntrustedUserIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "ChannelProfile", this.ChannelProfile);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamArraySimple(map, prefix + "TrustedUserIdList.", this.TrustedUserIdList);
            this.SetParamArraySimple(map, prefix + "UntrustedUserIdList.", this.UntrustedUserIdList);
        }
    }
}

