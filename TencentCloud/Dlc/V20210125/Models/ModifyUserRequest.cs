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

    public class ModifyUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户Id，和CAM侧Uin匹配
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户描述
        /// </summary>
        [JsonProperty("UserDescription")]
        public string UserDescription{ get; set; }

        /// <summary>
        /// 用户来源类型TencentAccount（普通腾讯云用户） / EntraAccount（微软用户）
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
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
        }
    }
}

