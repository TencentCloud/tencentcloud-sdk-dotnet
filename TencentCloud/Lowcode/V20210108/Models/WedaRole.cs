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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WedaRole : AbstractModel
    {
        
        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 角色标识
        /// </summary>
        [JsonProperty("RoleIdentity")]
        public string RoleIdentity{ get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 父角色id
        /// </summary>
        [JsonProperty("ParentRoleId")]
        public long? ParentRoleId{ get; set; }

        /// <summary>
        /// 子角色id
        /// </summary>
        [JsonProperty("ChildRoleId")]
        public long? ChildRoleId{ get; set; }

        /// <summary>
        /// 环境标识
        /// </summary>
        [JsonProperty("EnvIdentity")]
        public string EnvIdentity{ get; set; }

        /// <summary>
        /// 是否已发布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsReleased")]
        public bool? IsReleased{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RoleIdentity", this.RoleIdentity);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ParentRoleId", this.ParentRoleId);
            this.SetParamSimple(map, prefix + "ChildRoleId", this.ChildRoleId);
            this.SetParamSimple(map, prefix + "EnvIdentity", this.EnvIdentity);
            this.SetParamSimple(map, prefix + "IsReleased", this.IsReleased);
        }
    }
}

