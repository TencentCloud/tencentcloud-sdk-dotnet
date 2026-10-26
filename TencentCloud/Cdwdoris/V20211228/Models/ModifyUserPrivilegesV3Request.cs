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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserPrivilegesV3Request : AbstractModel
    {
        
        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>用户权限</p>
        /// </summary>
        [JsonProperty("UserPrivileges")]
        public UpdateUserPrivileges UserPrivileges{ get; set; }

        /// <summary>
        /// <p>用户链接来自的 IP</p>
        /// </summary>
        [JsonProperty("WhiteHost")]
        public string WhiteHost{ get; set; }

        /// <summary>
        /// <p>更新类型，默认0，1为更新绑定计算组，2为更新默认计算组，4 为 GrantPrivileges, RevokePrivileges 接口专用批量授权</p><p>枚举值：</p><ul><li>0： 默认</li><li>1： 更新绑定计算组</li><li>2： 更新默认计算组</li><li>4： GrantPrivileges, RevokePrivileges 接口专用批量授权</li></ul>
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// <p>需绑定计算组列表</p>
        /// </summary>
        [JsonProperty("UpdateComputeGroups")]
        public string[] UpdateComputeGroups{ get; set; }

        /// <summary>
        /// <p>默认计算组</p>
        /// </summary>
        [JsonProperty("DefaultComputeGroup")]
        public string DefaultComputeGroup{ get; set; }

        /// <summary>
        /// <p>0: 灵活场景 1: 固定场景</p>
        /// </summary>
        [JsonProperty("ComputeGroupType")]
        public long? ComputeGroupType{ get; set; }

        /// <summary>
        /// <p>本次新增授权的库表，仅 UpdateType=4 时生效</p>
        /// </summary>
        [JsonProperty("GrantPrivileges")]
        public UpdateUserPrivileges GrantPrivileges{ get; set; }

        /// <summary>
        /// <p>本次取消授权的库表，仅 UpdateType=4 时生效</p>
        /// </summary>
        [JsonProperty("RevokePrivileges")]
        public UpdateUserPrivileges RevokePrivileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamObj(map, prefix + "UserPrivileges.", this.UserPrivileges);
            this.SetParamSimple(map, prefix + "WhiteHost", this.WhiteHost);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamArraySimple(map, prefix + "UpdateComputeGroups.", this.UpdateComputeGroups);
            this.SetParamSimple(map, prefix + "DefaultComputeGroup", this.DefaultComputeGroup);
            this.SetParamSimple(map, prefix + "ComputeGroupType", this.ComputeGroupType);
            this.SetParamObj(map, prefix + "GrantPrivileges.", this.GrantPrivileges);
            this.SetParamObj(map, prefix + "RevokePrivileges.", this.RevokePrivileges);
        }
    }
}

