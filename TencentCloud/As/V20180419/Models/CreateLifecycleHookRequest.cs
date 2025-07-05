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

    public class CreateLifecycleHookRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。可以通过如下方式获取可用的伸缩组ID:
        /// <li>通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 查询伸缩组ID。</li>
        /// <li>通过调用接口 [DescribeAutoScalingGroups](https://cloud.tencent.com/document/api/377/20438) ，取返回信息中的 AutoScalingGroupId 获取伸缩组ID。</li>
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 生命周期挂钩名称。名称仅支持中文、英文、数字、下划线（_）、短横线（-）、小数点（.），最大长度不能超128个字节。
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public string LifecycleHookName{ get; set; }

        /// <summary>
        /// 进行生命周期挂钩的场景，取值范围如下:
        /// <li> INSTANCE_LAUNCHING: 扩容生命周期挂钩</li>
        /// <li>INSTANCE_TERMINATING: 缩容生命周期挂钩</li>
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// 定义伸缩组在生命周期挂钩超时或 LifecycleCommand 执行失败时应采取的操作，取值范围如下：
        /// <li>CONTINUE: 默认值，表示继续执行扩缩容活动</li>
        /// <li>ABANDON: 针对扩容挂钩，挂钩超时或 LifecycleCommand 执行失败的 CVM 实例会直接释放或移出；而针对缩容挂钩，会继续执行缩容活动。</li>
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// 生命周期挂钩超时之前可以经过的最长时间（以秒为单位），范围从30到7200秒，默认值为300秒
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// 弹性伸缩向通知目标发送的附加信息，配置通知时使用，默认值为空字符串，最长不超过 1024 字符。NotificationMetadata 和 LifecycleCommand参数互斥，二者不可同时指定。
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

        /// <summary>
        /// 通知目标。NotificationTarget和LifecycleCommand参数互斥，二者不可同时指定。
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public NotificationTarget NotificationTarget{ get; set; }

        /// <summary>
        /// 进行生命周期挂钩的场景类型，取值范围包括 NORMAL 和 EXTENSION，默认值为 NORMAL。
        /// 说明：设置为EXTENSION值，在 [AttachInstances](https://cloud.tencent.com/document/api/377/20441)、[DetachInstances](https://cloud.tencent.com/document/api/377/20436)、[RemoveInstaces](https://cloud.tencent.com/document/api/377/20431)、[StopAutoScalingInstances](https://cloud.tencent.com/document/api/377/40286)、[StartAutoScalingInstances](https://cloud.tencent.com/document/api/377/40287)、[StartInstanceRefresh](https://cloud.tencent.com/document/api/377/99172) 接口时会触发生命周期挂钩操作，值为NORMAL则不会在这些接口中触发生命周期挂钩。
        /// </summary>
        [JsonProperty("LifecycleTransitionType")]
        public string LifecycleTransitionType{ get; set; }

        /// <summary>
        /// 远程命令执行对象。通知相关参数（NotificationTarget、NotificationMetadata）与该参数互斥，二者不可同时指定。
        /// </summary>
        [JsonProperty("LifecycleCommand")]
        public LifecycleCommand LifecycleCommand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "LifecycleHookName", this.LifecycleHookName);
            this.SetParamSimple(map, prefix + "LifecycleTransition", this.LifecycleTransition);
            this.SetParamSimple(map, prefix + "DefaultResult", this.DefaultResult);
            this.SetParamSimple(map, prefix + "HeartbeatTimeout", this.HeartbeatTimeout);
            this.SetParamSimple(map, prefix + "NotificationMetadata", this.NotificationMetadata);
            this.SetParamObj(map, prefix + "NotificationTarget.", this.NotificationTarget);
            this.SetParamSimple(map, prefix + "LifecycleTransitionType", this.LifecycleTransitionType);
            this.SetParamObj(map, prefix + "LifecycleCommand.", this.LifecycleCommand);
        }
    }
}

