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

    public class UpdateRoleConsoleLoginRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否可登录，可登录：1，不可登录：0
        /// </summary>
        [JsonProperty("ConsoleLogin")]
        public long? ConsoleLogin{ get; set; }

        /// <summary>
        /// 角色ID，入参 RoleId 与 RoleName 二选一
        /// </summary>
        [JsonProperty("RoleId")]
        public long? RoleId{ get; set; }

        /// <summary>
        /// 角色名，入参 RoleId 与 RoleName 二选一
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleLogin", this.ConsoleLogin);
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
        }
    }
}

