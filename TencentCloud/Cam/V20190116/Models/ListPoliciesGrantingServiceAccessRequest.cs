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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListPoliciesGrantingServiceAccessRequest : AbstractModel
    {
        
        /// <summary>
        /// 子账号uin，与RoleId、GroupId三选一必传
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }

        /// <summary>
        /// 角色ID，与TargetUin、GroupId三选一必传
        /// </summary>
        [JsonProperty("RoleId")]
        public ulong? RoleId{ get; set; }

        /// <summary>
        /// 用户组ID，与TargetUin、RoleId三选一必传
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// 服务名，查看服务授权接口详情时需传该字段
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
        }
    }
}

