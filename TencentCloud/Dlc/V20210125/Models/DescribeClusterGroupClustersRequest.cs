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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterGroupClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>计算组 ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>返回样例 ClusterId 的最大数量（默认 5）</p>
        /// </summary>
        [JsonProperty("SampleLimit")]
        public long? SampleLimit{ get; set; }

        /// <summary>
        /// <p>Cluster 状态列表</p><p>枚举值：</p><ul><li>running： 运行中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SampleLimit", this.SampleLimit);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
        }
    }
}

