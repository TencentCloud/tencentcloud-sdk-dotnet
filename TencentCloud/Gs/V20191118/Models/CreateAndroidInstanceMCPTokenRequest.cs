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

    public class CreateAndroidInstanceMCPTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ROOT / USER（大小写敏感），默认 USER。ROOT 可访问该 AppId 下全部实例</p><p>枚举值：</p><ul><li>ROOT： 可访问该 AppId 下全部实例</li><li>USER： 可访问本角色实例白名单内的实例</li></ul><p>默认值：USER</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>有效期（秒）；0 或不传表示永不过期（负值等同不过期）</p>
        /// </summary>
        [JsonProperty("ExpireSeconds")]
        public long? ExpireSeconds{ get; set; }

        /// <summary>
        /// <p>备注名</p>
        /// </summary>
        [JsonProperty("TokenName")]
        public string TokenName{ get; set; }

        /// <summary>
        /// <p>USER 角色可访问的实例白名单</p>
        /// </summary>
        [JsonProperty("AllowedInstanceIds")]
        public string[] AllowedInstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "ExpireSeconds", this.ExpireSeconds);
            this.SetParamSimple(map, prefix + "TokenName", this.TokenName);
            this.SetParamArraySimple(map, prefix + "AllowedInstanceIds.", this.AllowedInstanceIds);
        }
    }
}

