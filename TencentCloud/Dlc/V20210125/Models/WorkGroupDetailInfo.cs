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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkGroupDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 工作组Id
        /// </summary>
        [JsonProperty("WorkGroupId")]
        public long? WorkGroupId{ get; set; }

        /// <summary>
        /// 工作组名称
        /// </summary>
        [JsonProperty("WorkGroupName")]
        public string WorkGroupName{ get; set; }

        /// <summary>
        /// 包含的信息类型。User：用户信息；DataAuth：数据权限；EngineAuth:引擎权限
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 工作组上绑定的用户集合
        /// </summary>
        [JsonProperty("UserInfo")]
        public Users UserInfo{ get; set; }

        /// <summary>
        /// 数据权限集合
        /// </summary>
        [JsonProperty("DataPolicyInfo")]
        public Policys DataPolicyInfo{ get; set; }

        /// <summary>
        /// 引擎权限集合
        /// </summary>
        [JsonProperty("EnginePolicyInfo")]
        public Policys EnginePolicyInfo{ get; set; }

        /// <summary>
        /// 工作组描述信息
        /// </summary>
        [JsonProperty("WorkGroupDescription")]
        public string WorkGroupDescription{ get; set; }

        /// <summary>
        /// 行过滤信息集合
        /// </summary>
        [JsonProperty("RowFilterInfo")]
        public Policys RowFilterInfo{ get; set; }

        /// <summary>
        /// 数据目录权限集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogPolicyInfo")]
        public Policy CatalogPolicyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkGroupId", this.WorkGroupId);
            this.SetParamSimple(map, prefix + "WorkGroupName", this.WorkGroupName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamObj(map, prefix + "DataPolicyInfo.", this.DataPolicyInfo);
            this.SetParamObj(map, prefix + "EnginePolicyInfo.", this.EnginePolicyInfo);
            this.SetParamSimple(map, prefix + "WorkGroupDescription", this.WorkGroupDescription);
            this.SetParamObj(map, prefix + "RowFilterInfo.", this.RowFilterInfo);
            this.SetParamObj(map, prefix + "CatalogPolicyInfo.", this.CatalogPolicyInfo);
        }
    }
}

