/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户Id，和子用户uin相同
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户描述信息，方便区分不同用户
        /// </summary>
        [JsonProperty("UserDescription")]
        public string UserDescription{ get; set; }

        /// <summary>
        /// 单独给用户绑定的权限集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicySet")]
        public Policy[] PolicySet{ get; set; }

        /// <summary>
        /// 当前用户的创建者
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 创建时间，格式如2021-07-28 16:19:32
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 关联的工作组集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkGroupSet")]
        public WorkGroupMessage[] WorkGroupSet{ get; set; }

        /// <summary>
        /// 是否是主账号
        /// </summary>
        [JsonProperty("IsOwner")]
        public bool? IsOwner{ get; set; }

        /// <summary>
        /// 用户类型。ADMIN：管理员 COMMON：普通用户。
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 用户别名
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserDescription", this.UserDescription);
            this.SetParamArrayObj(map, prefix + "PolicySet.", this.PolicySet);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "WorkGroupSet.", this.WorkGroupSet);
            this.SetParamSimple(map, prefix + "IsOwner", this.IsOwner);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
        }
    }
}

