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

    public class VolcParam : AbstractModel
    {
        
        /// <summary>
        /// <p>火山引擎 AppID。</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>房间号。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// <p>进房 Token。</p><p>需要开启鉴权，生成 Token时，注意RoomId 、UserId 需要对应上。详见：https://www.volcengine.com/docs/6348/70121</p>
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// <p>分配给拉流端的UserId。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>订阅用户名单。</p><p>当前名单列表为空时，默认为全订阅；当名单列表有用户id,则只会订阅列表中用户。</p>
        /// </summary>
        [JsonProperty("TrustedUserIdList")]
        public string TrustedUserIdList{ get; set; }

        /// <summary>
        /// <p>不订阅用户名单</p>
        /// </summary>
        [JsonProperty("UntrustedUserIdList")]
        public string UntrustedUserIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "TrustedUserIdList", this.TrustedUserIdList);
            this.SetParamSimple(map, prefix + "UntrustedUserIdList", this.UntrustedUserIdList);
        }
    }
}

