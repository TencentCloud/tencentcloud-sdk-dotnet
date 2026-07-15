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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleOceanusClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群的目标CU，需大于12CU，并且集群CU需要满足 12 + 7*n (n&gt;=0)</p>
        /// </summary>
        [JsonProperty("NewCU")]
        public long? NewCU{ get; set; }

        /// <summary>
        /// <p>扩容集群或者缩容集群</p><p>枚举值：</p><ul><li>ScaleDown： 缩容集群</li><li>ScaleUp： 扩容集群</li></ul><p>默认值：ScaleUp</p>
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NewCU", this.NewCU);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
        }
    }
}

