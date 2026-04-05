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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RebootHPCNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群Id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>节点Id，例如ins-d1fc42ss</p>
        /// </summary>
        [JsonProperty("NodeIds")]
        public string[] NodeIds{ get; set; }

        /// <summary>
        /// <p>重启的关机类型。</p><p>枚举值：</p><ul><li>SOFT： 软关机</li><li>HARD： 硬关机</li><li>SOFT_FIRST： 优先软关机，失败再执行硬关机</li></ul><p>默认值：SOFT</p>
        /// </summary>
        [JsonProperty("StopType")]
        public string StopType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "NodeIds.", this.NodeIds);
            this.SetParamSimple(map, prefix + "StopType", this.StopType);
        }
    }
}

