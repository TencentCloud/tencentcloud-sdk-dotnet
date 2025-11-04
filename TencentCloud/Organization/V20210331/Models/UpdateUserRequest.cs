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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 用户 ID。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户的名。
        /// </summary>
        [JsonProperty("NewFirstName")]
        public string NewFirstName{ get; set; }

        /// <summary>
        /// 用户的姓。
        /// </summary>
        [JsonProperty("NewLastName")]
        public string NewLastName{ get; set; }

        /// <summary>
        /// 用户的显示名称。
        /// </summary>
        [JsonProperty("NewDisplayName")]
        public string NewDisplayName{ get; set; }

        /// <summary>
        /// 用户的描述。
        /// </summary>
        [JsonProperty("NewDescription")]
        public string NewDescription{ get; set; }

        /// <summary>
        /// 用户的电子邮箱。
        /// </summary>
        [JsonProperty("NewEmail")]
        public string NewEmail{ get; set; }

        /// <summary>
        /// 是否需要重置密码
        /// </summary>
        [JsonProperty("NeedResetPassword")]
        public bool? NeedResetPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "NewFirstName", this.NewFirstName);
            this.SetParamSimple(map, prefix + "NewLastName", this.NewLastName);
            this.SetParamSimple(map, prefix + "NewDisplayName", this.NewDisplayName);
            this.SetParamSimple(map, prefix + "NewDescription", this.NewDescription);
            this.SetParamSimple(map, prefix + "NewEmail", this.NewEmail);
            this.SetParamSimple(map, prefix + "NeedResetPassword", this.NeedResetPassword);
        }
    }
}

