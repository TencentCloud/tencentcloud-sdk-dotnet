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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWorkspacesAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间列表
        /// </summary>
        [JsonProperty("SpaceIds")]
        public string[] SpaceIds{ get; set; }

        /// <summary>
        /// 修改后的工作空间名称。可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SpaceIds.", this.SpaceIds);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
        }
    }
}

