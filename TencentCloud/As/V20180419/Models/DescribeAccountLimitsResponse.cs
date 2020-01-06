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

    public class DescribeAccountLimitsResponse : AbstractModel
    {
        
        /// <summary>
        /// 用户账户被允许创建的启动配置最大数量
        /// </summary>
        [JsonProperty("MaxNumberOfLaunchConfigurations")]
        public long? MaxNumberOfLaunchConfigurations{ get; set; }

        /// <summary>
        /// 用户账户启动配置的当前数量
        /// </summary>
        [JsonProperty("NumberOfLaunchConfigurations")]
        public long? NumberOfLaunchConfigurations{ get; set; }

        /// <summary>
        /// 用户账户被允许创建的伸缩组最大数量
        /// </summary>
        [JsonProperty("MaxNumberOfAutoScalingGroups")]
        public long? MaxNumberOfAutoScalingGroups{ get; set; }

        /// <summary>
        /// 用户账户伸缩组的当前数量
        /// </summary>
        [JsonProperty("NumberOfAutoScalingGroups")]
        public long? NumberOfAutoScalingGroups{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxNumberOfLaunchConfigurations", this.MaxNumberOfLaunchConfigurations);
            this.SetParamSimple(map, prefix + "NumberOfLaunchConfigurations", this.NumberOfLaunchConfigurations);
            this.SetParamSimple(map, prefix + "MaxNumberOfAutoScalingGroups", this.MaxNumberOfAutoScalingGroups);
            this.SetParamSimple(map, prefix + "NumberOfAutoScalingGroups", this.NumberOfAutoScalingGroups);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

