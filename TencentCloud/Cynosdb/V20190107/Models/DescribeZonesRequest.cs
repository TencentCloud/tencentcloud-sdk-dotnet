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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否包含虚拟区
        /// </summary>
        [JsonProperty("IncludeVirtualZones")]
        public bool? IncludeVirtualZones{ get; set; }

        /// <summary>
        /// 是否展示地域下所有可用区，并显示用户每个可用区权限
        /// </summary>
        [JsonProperty("ShowPermission")]
        public bool? ShowPermission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IncludeVirtualZones", this.IncludeVirtualZones);
            this.SetParamSimple(map, prefix + "ShowPermission", this.ShowPermission);
        }
    }
}

