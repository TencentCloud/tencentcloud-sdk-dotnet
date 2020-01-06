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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachRolePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// 角色ID，用于指定角色，入参 AttachRoleId 与 AttachRoleName 二选一
        /// </summary>
        [JsonProperty("AttachRoleId")]
        public string AttachRoleId{ get; set; }

        /// <summary>
        /// 角色名称，用于指定角色，入参 AttachRoleId 与 AttachRoleName 二选一
        /// </summary>
        [JsonProperty("AttachRoleName")]
        public string AttachRoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "AttachRoleId", this.AttachRoleId);
            this.SetParamSimple(map, prefix + "AttachRoleName", this.AttachRoleName);
        }
    }
}

