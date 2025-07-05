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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewAndroidInstancesAccessTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// token
        /// </summary>
        [JsonProperty("AccessToken")]
        public string AccessToken{ get; set; }

        /// <summary>
        /// 有效期，默认为 12 小时，最大为 24 小时。支持 s（秒）、m（分）、h（小时）等单位，比如 12h 表示 12 小时，1h2m3s 表示一小时两分三秒
        /// </summary>
        [JsonProperty("ExpirationDuration")]
        public string ExpirationDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessToken", this.AccessToken);
            this.SetParamSimple(map, prefix + "ExpirationDuration", this.ExpirationDuration);
        }
    }
}

