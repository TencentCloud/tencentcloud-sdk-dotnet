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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserMicStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 来自 [腾讯云控制台](https://console.cloud.tencent.com/gamegme) 的 GME 服务提供的 AppID，获取请参考 [语音服务开通指引](https://cloud.tencent.com/document/product/607/10782#.E9.87.8D.E7.82.B9.E5.8F.82.E6.95.B0)。
        /// </summary>
        [JsonProperty("BizId")]
        public long? BizId{ get; set; }

        /// <summary>
        /// 实时语音房间号。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 需要操作的房间内用户以及该用户的目标麦克风状态。
        /// </summary>
        [JsonProperty("Users")]
        public UserMicStatus[] Users{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamArrayObj(map, prefix + "Users.", this.Users);
        }
    }
}

