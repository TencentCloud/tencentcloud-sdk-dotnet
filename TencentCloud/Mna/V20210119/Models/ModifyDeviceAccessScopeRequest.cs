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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDeviceAccessScopeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>设备ID</p>
        /// </summary>
        [JsonProperty("DeviceIds")]
        public string[] DeviceIds{ get; set; }

        /// <summary>
        /// <p>接入网关类型</p><p>枚举值：</p><ul><li>0： 公有云网关</li><li>1： 客户私有网关</li></ul><p>默认值：0</p><p>如果不传，则默认修改为接入公有云网关。</p>
        /// </summary>
        [JsonProperty("AccessScope")]
        public ulong? AccessScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DeviceIds.", this.DeviceIds);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
        }
    }
}

