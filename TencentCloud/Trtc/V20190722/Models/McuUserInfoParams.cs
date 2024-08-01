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

    public class McuUserInfoParams : AbstractModel
    {
        
        /// <summary>
        /// 用户参数。
        /// </summary>
        [JsonProperty("UserInfo")]
        public MixUserInfo UserInfo{ get; set; }

        /// <summary>
        /// 混音的音量调整：取值范围是0到100，100为原始上行音量，不填默认为100，值越小则音量越低。
        /// 注：该参数只在音量白名单下配置生效，其他场景配置无效。
        /// </summary>
        [JsonProperty("SoundLevel")]
        public ulong? SoundLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "SoundLevel", this.SoundLevel);
        }
    }
}

