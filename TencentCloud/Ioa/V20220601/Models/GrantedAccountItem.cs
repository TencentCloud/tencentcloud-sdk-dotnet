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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GrantedAccountItem : AbstractModel
    {
        
        /// <summary>
        /// 账户Id
        /// </summary>
        [JsonProperty("AccountId")]
        public ulong? AccountId{ get; set; }

        /// <summary>
        /// 用户UserId
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 所属分组Id
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// 分组路劲GroupIdPathArray
        /// </summary>
        [JsonProperty("GroupIdPathArray")]
        public ulong?[] GroupIdPathArray{ get; set; }

        /// <summary>
        /// 所属分组NamePathArray
        /// </summary>
        [JsonProperty("GroupNamePathArray")]
        public string[] GroupNamePathArray{ get; set; }

        /// <summary>
        /// 目录id
        /// </summary>
        [JsonProperty("MenuId")]
        public ulong? MenuId{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 关联id
        /// </summary>
        [JsonProperty("RelationId")]
        public ulong? RelationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "GroupIdPathArray.", this.GroupIdPathArray);
            this.SetParamArraySimple(map, prefix + "GroupNamePathArray.", this.GroupNamePathArray);
            this.SetParamSimple(map, prefix + "MenuId", this.MenuId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RelationId", this.RelationId);
        }
    }
}

