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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyGroup : AbstractModel
    {
        
        /// <summary>
        /// 是否可设为默认告警策略
        /// </summary>
        [JsonProperty("CanSetDefault")]
        public bool? CanSetDefault{ get; set; }

        /// <summary>
        /// 告警策略组ID
        /// </summary>
        [JsonProperty("GroupID")]
        public long? GroupID{ get; set; }

        /// <summary>
        /// 告警策略组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public long? InsertTime{ get; set; }

        /// <summary>
        /// 是否为默认告警策略
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// 告警策略启用状态
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 最后修改人UIN
        /// </summary>
        [JsonProperty("LastEditUin")]
        public long? LastEditUin{ get; set; }

        /// <summary>
        /// 未屏蔽的实例数
        /// </summary>
        [JsonProperty("NoShieldedInstanceCount")]
        public long? NoShieldedInstanceCount{ get; set; }

        /// <summary>
        /// 父策略组ID
        /// </summary>
        [JsonProperty("ParentGroupID")]
        public long? ParentGroupID{ get; set; }

        /// <summary>
        /// 所属项目ID
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// 告警接收对象信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverInfos")]
        public PolicyGroupReceiverInfo[] ReceiverInfos{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 总绑定实例数
        /// </summary>
        [JsonProperty("TotalInstanceCount")]
        public long? TotalInstanceCount{ get; set; }

        /// <summary>
        /// 视图
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// 是否为与关系规则
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanSetDefault", this.CanSetDefault);
            this.SetParamSimple(map, prefix + "GroupID", this.GroupID);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "LastEditUin", this.LastEditUin);
            this.SetParamSimple(map, prefix + "NoShieldedInstanceCount", this.NoShieldedInstanceCount);
            this.SetParamSimple(map, prefix + "ParentGroupID", this.ParentGroupID);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamArrayObj(map, prefix + "ReceiverInfos.", this.ReceiverInfos);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TotalInstanceCount", this.TotalInstanceCount);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
        }
    }
}

