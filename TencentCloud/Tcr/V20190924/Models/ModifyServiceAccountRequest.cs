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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyServiceAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 服务级账号名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 服务级账号描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 有效期(单位：天)，从当前时间开始计算，优先级高于ExpiresAt
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 过期时间（时间戳，单位:毫秒）
        /// </summary>
        [JsonProperty("ExpiresAt")]
        public long? ExpiresAt{ get; set; }

        /// <summary>
        /// 是否禁用服务级账号
        /// </summary>
        [JsonProperty("Disable")]
        public bool? Disable{ get; set; }

        /// <summary>
        /// 策略列表
        /// </summary>
        [JsonProperty("Permissions")]
        public Permission[] Permissions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ExpiresAt", this.ExpiresAt);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamArrayObj(map, prefix + "Permissions.", this.Permissions);
        }
    }
}

