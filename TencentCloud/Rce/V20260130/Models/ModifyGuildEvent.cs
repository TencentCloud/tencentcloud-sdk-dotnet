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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGuildEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>修改后的公会名，允许空串</p>
        /// </summary>
        [JsonProperty("GuildNameAfter")]
        public string GuildNameAfter{ get; set; }

        /// <summary>
        /// <p>修改后的公会签名，允许空串</p>
        /// </summary>
        [JsonProperty("GuildSignatureAfter")]
        public string GuildSignatureAfter{ get; set; }

        /// <summary>
        /// <p>所属服务器ID，允许空串</p>
        /// </summary>
        [JsonProperty("ServerId")]
        public string ServerId{ get; set; }

        /// <summary>
        /// <p>编辑者账号信息</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>公会信息</p>
        /// </summary>
        [JsonProperty("Guild")]
        public Guild Guild{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GuildNameAfter", this.GuildNameAfter);
            this.SetParamSimple(map, prefix + "GuildSignatureAfter", this.GuildSignatureAfter);
            this.SetParamSimple(map, prefix + "ServerId", this.ServerId);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamObj(map, prefix + "Guild.", this.Guild);
        }
    }
}

