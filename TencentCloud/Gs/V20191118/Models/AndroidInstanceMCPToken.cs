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

    public class AndroidInstanceMCPToken : AbstractModel
    {
        
        /// <summary>
        /// <p>内部 ID，格式 k_ + 16 位 hex</p>
        /// </summary>
        [JsonProperty("TokenId")]
        public string TokenId{ get; set; }

        /// <summary>
        /// <p>ROOT / USER（大小写敏感），默认 USER。ROOT 可访问该 AppId 下全部实例</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>备注名</p>
        /// </summary>
        [JsonProperty("TokenName")]
        public string TokenName{ get; set; }

        /// <summary>
        /// <p>USER 角色可访问的实例白名单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowedInstanceIds")]
        public string[] AllowedInstanceIds{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：ISO8601 字符串；</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>过期时间</p><p>参数格式：ISO8601 字符串；永不过期时为空串</p>
        /// </summary>
        [JsonProperty("ExpiresTime")]
        public string ExpiresTime{ get; set; }

        /// <summary>
        /// <p>或 EXPIRED；EXPIRED 由 ExpiresTime 推导。已删除的不出现在列表里</p><p>枚举值：</p><ul><li>ACTIVE： 正常可用的</li><li>EXPIRED： 过期的</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TokenId", this.TokenId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "TokenName", this.TokenName);
            this.SetParamArraySimple(map, prefix + "AllowedInstanceIds.", this.AllowedInstanceIds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpiresTime", this.ExpiresTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

