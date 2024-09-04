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

    public class UserDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 返回的信息类型，Group：返回的当前用户的工作组信息；DataAuth：返回的当前用户的数据权限信息；EngineAuth：返回的当前用户的引擎权限信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 用户类型：ADMIN：管理员 COMMON：一般用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 用户描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserDescription")]
        public string UserDescription{ get; set; }

        /// <summary>
        /// 数据权限信息集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataPolicyInfo")]
        public Policys DataPolicyInfo{ get; set; }

        /// <summary>
        /// 引擎权限集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnginePolicyInfo")]
        public Policys EnginePolicyInfo{ get; set; }

        /// <summary>
        /// 绑定到该用户的工作组集合信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkGroupInfo")]
        public WorkGroups WorkGroupInfo{ get; set; }

        /// <summary>
        /// 用户别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// 行过滤集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RowFilterInfo")]
        public Policys RowFilterInfo{ get; set; }

        /// <summary>
        /// 账号类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserDescription", this.UserDescription);
            this.SetParamObj(map, prefix + "DataPolicyInfo.", this.DataPolicyInfo);
            this.SetParamObj(map, prefix + "EnginePolicyInfo.", this.EnginePolicyInfo);
            this.SetParamObj(map, prefix + "WorkGroupInfo.", this.WorkGroupInfo);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamObj(map, prefix + "RowFilterInfo.", this.RowFilterInfo);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
        }
    }
}

