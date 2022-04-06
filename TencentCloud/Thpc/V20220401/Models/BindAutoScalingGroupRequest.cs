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

namespace TencentCloud.Thpc.V20220401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindAutoScalingGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 弹性伸缩启动配置ID。
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 弹性伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 任务连续等待时间，队列的任务处于连续等待的时间。单位秒。默认值120。
        /// </summary>
        [JsonProperty("ExpansionBusyTime")]
        public long? ExpansionBusyTime{ get; set; }

        /// <summary>
        /// 节点连续空闲（未运行作业）时间，一个节点连续处于空闲状态时间。单位秒。默认值300。
        /// </summary>
        [JsonProperty("ShrinkIdleTime")]
        public long? ShrinkIdleTime{ get; set; }

        /// <summary>
        /// 是否开启自动扩容，默认值true。
        /// </summary>
        [JsonProperty("EnableAutoExpansion")]
        public bool? EnableAutoExpansion{ get; set; }

        /// <summary>
        /// 是否开启自动缩容，默认值true。
        /// </summary>
        [JsonProperty("EnableAutoShrink")]
        public bool? EnableAutoShrink{ get; set; }

        /// <summary>
        /// 是否只预检此次请求。
        /// true：发送检查请求，不会绑定弹性伸缩组。检查项包括是否填写了必需参数，请求格式，业务限制。
        /// 如果检查不通过，则返回对应错误码；
        /// 如果检查通过，则返回RequestId。
        /// false（默认）：发送正常请求，通过检查后直接绑定弹性伸缩组。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "ExpansionBusyTime", this.ExpansionBusyTime);
            this.SetParamSimple(map, prefix + "ShrinkIdleTime", this.ShrinkIdleTime);
            this.SetParamSimple(map, prefix + "EnableAutoExpansion", this.EnableAutoExpansion);
            this.SetParamSimple(map, prefix + "EnableAutoShrink", this.EnableAutoShrink);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

