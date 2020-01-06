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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteClusterAsGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，通过[DescribeClusters](https://cloud.tencent.com/document/api/457/31862)接口获取。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群伸缩组ID的列表
        /// </summary>
        [JsonProperty("AutoScalingGroupIds")]
        public string[] AutoScalingGroupIds{ get; set; }

        /// <summary>
        /// 是否保留伸缩组中的节点(默认值： false(不保留))
        /// </summary>
        [JsonProperty("KeepInstance")]
        public bool? KeepInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "AutoScalingGroupIds.", this.AutoScalingGroupIds);
            this.SetParamSimple(map, prefix + "KeepInstance", this.KeepInstance);
        }
    }
}

