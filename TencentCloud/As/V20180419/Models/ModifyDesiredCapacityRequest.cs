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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDesiredCapacityRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 或调用接口 [DescribeAutoScalingGroups](https://cloud.tencent.com/document/api/377/20438) ，取返回信息中的 AutoScalingGroupId 获取伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 期望实例数，取值范围 [0,2000]，同时需满足 MaxSize >= DesiredCapacity >= MinSize 。
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// 最小实例数，取值范围为 [0,2000]，同时需满足 MaxSize >= DesiredCapacity >= MinSize 。
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// 最大实例数，取值范围为 [0,2000]，同时需满足 MaxSize >= DesiredCapacity >= MinSize 。
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
        }
    }
}

