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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceUser : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户角色 1所有者，0：其他分享者
        /// </summary>
        [JsonProperty("Role")]
        public long? Role{ get; set; }

        /// <summary>
        /// 家庭ID，所有者带该参数
        /// </summary>
        [JsonProperty("FamilyId")]
        public string FamilyId{ get; set; }

        /// <summary>
        /// 家庭名称，所有者带该参数
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "FamilyId", this.FamilyId);
            this.SetParamSimple(map, prefix + "FamilyName", this.FamilyName);
        }
    }
}

