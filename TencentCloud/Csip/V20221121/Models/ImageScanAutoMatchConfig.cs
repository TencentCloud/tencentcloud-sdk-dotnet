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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageScanAutoMatchConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>匹配方式</p><p>枚举值：</p><ul><li>BY_CLUSTER： 按集群选择</li><li>RUNNING_CONTAINER： 容器集群上运行的镜像</li><li>LATEST_VERSION： 最新版本镜像</li><li>LOCAL_HOST： 主机节点上运行的镜像</li></ul>
        /// </summary>
        [JsonProperty("Modes")]
        public string[] Modes{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("Clusters")]
        public string[] Clusters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Modes.", this.Modes);
            this.SetParamArraySimple(map, prefix + "Clusters.", this.Clusters);
        }
    }
}

