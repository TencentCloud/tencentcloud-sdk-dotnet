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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyPathLifecyclePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>生命周期管理策略ID</p>
        /// </summary>
        [JsonProperty("LifecyclePolicyID")]
        public string LifecyclePolicyID{ get; set; }

        /// <summary>
        /// <p>生命周期管理策略所关联的目录路径列表，每个路径必须以 /cfs/ 开头，代表文件存储实例内部的逻辑路径，而非本地挂载点路径。</p><p>示例：</p><ul><li>若挂载的是CFS根目录 /，需关联挂载路径下的 test1/test2，则入参值为 /cfs/test1/test2</li><li>若挂载的是CFS子目录 /subdir，需关联挂载路径下的 test1/test2，则入参值为 /cfs/subdir/test1/test2</li></ul>
        /// </summary>
        [JsonProperty("Paths")]
        public PathInfo[] Paths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecyclePolicyID", this.LifecyclePolicyID);
            this.SetParamArrayObj(map, prefix + "Paths.", this.Paths);
        }
    }
}

