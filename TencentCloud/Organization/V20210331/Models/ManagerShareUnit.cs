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

    public class ManagerShareUnit : AbstractModel
    {
        
        /// <summary>
        /// <p>共享单元ID。</p>
        /// </summary>
        [JsonProperty("UnitId")]
        public string UnitId{ get; set; }

        /// <summary>
        /// <p>共享单元名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>共享单元管理员Uin。</p>
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// <p>共享单元管理员OwnerUin。</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public long? OwnerUin{ get; set; }

        /// <summary>
        /// <p>共享单元地域。</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>共享单元资源数。</p>
        /// </summary>
        [JsonProperty("ShareResourceNum")]
        public long? ShareResourceNum{ get; set; }

        /// <summary>
        /// <p>共享单元成员数。</p>
        /// </summary>
        [JsonProperty("ShareMemberNum")]
        public long? ShareMemberNum{ get; set; }

        /// <summary>
        /// <p>共享范围。取值：1-仅允许集团组织内共享 2-允许共享给任意账号</p>
        /// </summary>
        [JsonProperty("ShareScope")]
        public ulong? ShareScope{ get; set; }

        /// <summary>
        /// <p>共享单元部门数。</p>
        /// </summary>
        [JsonProperty("ShareNodeNum")]
        public long? ShareNodeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnitId", this.UnitId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ShareResourceNum", this.ShareResourceNum);
            this.SetParamSimple(map, prefix + "ShareMemberNum", this.ShareMemberNum);
            this.SetParamSimple(map, prefix + "ShareScope", this.ShareScope);
            this.SetParamSimple(map, prefix + "ShareNodeNum", this.ShareNodeNum);
        }
    }
}

