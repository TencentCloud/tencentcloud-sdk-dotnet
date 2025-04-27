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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetInstancesProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。可以通过如下方式获取可用的伸缩组ID:
        /// <li>通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 查询伸缩组ID。</li>
        /// <li>通过调用接口 [DescribeAutoScalingGroups](https://cloud.tencent.com/document/api/377/20438) ，取返回信息中的 AutoScalingGroupId 获取伸缩组ID。</li>
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 实例ID。可以通过以下方式获取可用的实例ID：
        /// <li>通过登录[控制台](https://console.cloud.tencent.com/cvm/index)查询实例ID。</li>
        /// <li>通过调用接口 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) ，取返回信息中的 `InstanceId` 获取实例ID。</li>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 实例是否需要设置保护。
        /// </summary>
        [JsonProperty("ProtectedFromScaleIn")]
        public bool? ProtectedFromScaleIn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "ProtectedFromScaleIn", this.ProtectedFromScaleIn);
        }
    }
}

