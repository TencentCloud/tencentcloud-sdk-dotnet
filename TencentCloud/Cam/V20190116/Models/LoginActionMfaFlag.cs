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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginActionMfaFlag : AbstractModel
    {
        
        /// <summary>
        /// 是否设置手机号为登录和敏感操作安全校验方式， 1: 设置，0: 不设置
        /// </summary>
        [JsonProperty("Phone")]
        public ulong? Phone{ get; set; }

        /// <summary>
        /// 是否设置软token为登录和敏感操作安全校验方式， 1: 设置，0: 不设置
        /// </summary>
        [JsonProperty("Stoken")]
        public ulong? Stoken{ get; set; }

        /// <summary>
        /// 是否设置微信为登录和敏感操作安全校验方式， 1: 设置，0: 不设置
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Stoken", this.Stoken);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
        }
    }
}

