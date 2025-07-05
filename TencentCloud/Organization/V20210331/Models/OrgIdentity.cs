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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrgIdentity : AbstractModel
    {
        
        /// <summary>
        /// 身份ID。
        /// </summary>
        [JsonProperty("IdentityId")]
        public long? IdentityId{ get; set; }

        /// <summary>
        /// 身份名称。
        /// </summary>
        [JsonProperty("IdentityAliasName")]
        public string IdentityAliasName{ get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 身份策略。
        /// </summary>
        [JsonProperty("IdentityPolicy")]
        public IdentityPolicy[] IdentityPolicy{ get; set; }

        /// <summary>
        /// 身份类型。 1-预设、 2-自定义
        /// </summary>
        [JsonProperty("IdentityType")]
        public ulong? IdentityType{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityId", this.IdentityId);
            this.SetParamSimple(map, prefix + "IdentityAliasName", this.IdentityAliasName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "IdentityPolicy.", this.IdentityPolicy);
            this.SetParamSimple(map, prefix + "IdentityType", this.IdentityType);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

