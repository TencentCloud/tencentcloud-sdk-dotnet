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

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 伸缩组ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 启动配置ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 启动配置名称
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// 生命周期状态，取值如下：
        /// <li>IN_SERVICE：运行中</li>
        /// <li>CREATING：创建中</li>
        /// <li>CREATION_FAILED：创建失败</li>
        /// <li>TERMINATING：中止中</li>
        /// <li>TERMINATION_FAILED：中止失败</li>
        /// <li>ATTACHING：绑定中</li>
        /// <li>ATTACH_FAILED：绑定失败</li>
        /// <li>DETACHING：解绑中</li>
        /// <li>DETACH_FAILED：解绑失败</li>
        /// <li>ATTACHING_LB：绑定LB中</li>
        /// <li>DETACHING_LB：解绑LB中</li>
        /// <li>MODIFYING_LB：修改LB中</li>
        /// <li>STARTING：开机中</li>
        /// <li>START_FAILED：开机失败</li>
        /// <li>STOPPING：关机中</li>
        /// <li>STOP_FAILED：关机失败</li>
        /// <li>STOPPED：已关机</li>
        /// <li>IN_LAUNCHING_HOOK：扩容生命周期挂钩中</li>
        /// <li>IN_TERMINATING_HOOK：缩容生命周期挂钩中</li>
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// 健康状态，取值包括HEALTHY和UNHEALTHY
        /// </summary>
        [JsonProperty("HealthStatus")]
        public string HealthStatus{ get; set; }

        /// <summary>
        /// 是否加入缩容保护
        /// </summary>
        [JsonProperty("ProtectedFromScaleIn")]
        public bool? ProtectedFromScaleIn{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 创建类型，取值包括AUTO_CREATION, MANUAL_ATTACHING。
        /// </summary>
        [JsonProperty("CreationType")]
        public string CreationType{ get; set; }

        /// <summary>
        /// 实例加入时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("VersionNumber")]
        public long? VersionNumber{ get; set; }

        /// <summary>
        /// 伸缩组名称
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// 预热状态，取值如下：
        /// <li>WAITING_ENTER_WARMUP：等待进入预热</li>
        /// <li>NO_NEED_WARMUP：无需预热</li>
        /// <li>IN_WARMUP：预热中</li>
        /// <li>AFTER_WARMUP：完成预热</li>
        /// </summary>
        [JsonProperty("WarmupStatus")]
        public string WarmupStatus{ get; set; }

        /// <summary>
        /// 置放群组id，仅支持指定一个。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "ProtectedFromScaleIn", this.ProtectedFromScaleIn);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreationType", this.CreationType);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "WarmupStatus", this.WarmupStatus);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
        }
    }
}

