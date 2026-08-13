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

    public class DescribeEdrAlertCountForContainerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>集群 ID 列表（≤500）；非空且 ContainerIds 为空时按集群分组统计</p>
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// <p>容器 ID 列表（≤500）；非空时按容器分组统计（优先级高于 ClusterIds）</p>
        /// </summary>
        [JsonProperty("ContainerIds")]
        public string[] ContainerIds{ get; set; }

        /// <summary>
        /// <li>PolicyType - int - 是否必填：否 - 策略类型</li><li>PolicyName - string - 是否必填：否 - 策略名称</li><li>Domain - string - 是否必填：否 - 域名(先对域名做urlencode,再base64)</li><li>PolicyAction- int - 是否必填：否 - 策略动作</li><li>IsEnabled - int - 是否必填：否 - 是否生效</li><li>ContainerId - string - 是否必填：否 - 容器ID（精确/IN，容器维度筛选）</li><li>ClusterId - string - 是否必填：否 - 集群ID（精确/IN，容器维度筛选）</li><li>ClusterName - string - 是否必填：否 - 集群名称（前缀模糊）</li><li>ContainerName - string - 是否必填：否 - 容器名称（前缀模糊）</li><li>AlertSource - string - 是否必填：否 - 告警来源：HOST-主机告警 / CONTAINER-容器告警，不传返回全部</li>
        /// </summary>
        [JsonProperty("Filters")]
        public EDRFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamArraySimple(map, prefix + "ContainerIds.", this.ContainerIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

