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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetSyncFlags : AbstractModel
    {
        
        /// <summary>
        /// 是否已完成角色授权
        /// </summary>
        [JsonProperty("RoleGranted")]
        public bool? RoleGranted{ get; set; }

        /// <summary>
        /// 是否已开启自动资产同步
        /// </summary>
        [JsonProperty("AutoSync")]
        public bool? AutoSync{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleGranted", this.RoleGranted);
            this.SetParamSimple(map, prefix + "AutoSync", this.AutoSync);
        }
    }
}

