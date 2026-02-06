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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginSetting : AbstractModel
    {
        
        /// <summary>
        /// 登录会话超时，10分钟，20分钟，30分钟，默认20分钟
        /// </summary>
        [JsonProperty("TimeOut")]
        public ulong? TimeOut{ get; set; }

        /// <summary>
        /// 连续密码错误次数，超过锁定账号，3-5
        /// </summary>
        [JsonProperty("LockThreshold")]
        public ulong? LockThreshold{ get; set; }

        /// <summary>
        /// 账号锁定时长，10分钟，20分钟，30分钟
        /// </summary>
        [JsonProperty("LockTime")]
        public ulong? LockTime{ get; set; }

        /// <summary>
        /// 用户多少天不活跃，账号自动锁定
        /// </summary>
        [JsonProperty("InactiveUserLock")]
        public ulong? InactiveUserLock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "LockThreshold", this.LockThreshold);
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "InactiveUserLock", this.InactiveUserLock);
        }
    }
}

