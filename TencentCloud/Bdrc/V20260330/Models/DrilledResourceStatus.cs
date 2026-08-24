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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrilledResourceStatus : AbstractModel
    {
        
        /// <summary>
        /// 演练组关联的演练资源的状态
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public string ResourceStatus{ get; set; }

        /// <summary>
        /// 演练组关联演练资源处于某个状态的数量
        /// </summary>
        [JsonProperty("ResourceCount")]
        public ulong? ResourceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "ResourceCount", this.ResourceCount);
        }
    }
}

