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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserConfSyncStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>用户AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>是否允许管理员同步</p>
        /// </summary>
        [JsonProperty("AllowSync")]
        public bool? AllowSync{ get; set; }

        /// <summary>
        /// <p>是否在配置中</p>
        /// </summary>
        [JsonProperty("InConf")]
        public bool? InConf{ get; set; }

        /// <summary>
        /// <p>是否被其他管理员同步</p>
        /// </summary>
        [JsonProperty("ManagedByOther")]
        public bool? ManagedByOther{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AllowSync", this.AllowSync);
            this.SetParamSimple(map, prefix + "InConf", this.InConf);
            this.SetParamSimple(map, prefix + "ManagedByOther", this.ManagedByOther);
        }
    }
}

