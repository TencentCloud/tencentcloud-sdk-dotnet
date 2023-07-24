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

namespace TencentCloud.Cloudstudio.V20230508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWorkspaceTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间 SpaceKey
        /// </summary>
        [JsonProperty("SpaceKey")]
        public string SpaceKey{ get; set; }

        /// <summary>
        /// token过期时间，单位是秒，默认 3600
        /// </summary>
        [JsonProperty("TokenExpiredLimitSec")]
        public ulong? TokenExpiredLimitSec{ get; set; }

        /// <summary>
        /// token 授权策略，可选值为 workspace-run-only, all。默认为 all
        /// </summary>
        [JsonProperty("Policies")]
        public string[] Policies{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceKey", this.SpaceKey);
            this.SetParamSimple(map, prefix + "TokenExpiredLimitSec", this.TokenExpiredLimitSec);
            this.SetParamArraySimple(map, prefix + "Policies.", this.Policies);
        }
    }
}

