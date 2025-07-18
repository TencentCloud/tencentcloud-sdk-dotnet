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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelDeleteRoleUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// 代理信息此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 角色Id（非超管或法人角色Id）
        /// </summary>
        [JsonProperty("RoleId")]
        public string RoleId{ get; set; }

        /// <summary>
        /// 电子签用户ID列表，与OpenIds参数二选一,优先UserIds参数，最多两百
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 客户系统用户ID列表，与UserIds参数二选一,优先UserIds参数，最多两百
        /// </summary>
        [JsonProperty("OpenIds")]
        public string[] OpenIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "OpenIds.", this.OpenIds);
        }
    }
}

