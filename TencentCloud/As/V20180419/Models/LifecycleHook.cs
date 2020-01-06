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

    public class LifecycleHook : AbstractModel
    {
        
        /// <summary>
        /// 生命周期挂钩ID
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// 生命周期挂钩名称
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public string LifecycleHookName{ get; set; }

        /// <summary>
        /// 伸缩组ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 生命周期挂钩默认结果
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// 生命周期挂钩等待超时时间
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// 生命周期挂钩适用场景
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// 通知目标的附加信息
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 通知目标
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public NotificationTarget NotificationTarget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "LifecycleHookName", this.LifecycleHookName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "DefaultResult", this.DefaultResult);
            this.SetParamSimple(map, prefix + "HeartbeatTimeout", this.HeartbeatTimeout);
            this.SetParamSimple(map, prefix + "LifecycleTransition", this.LifecycleTransition);
            this.SetParamSimple(map, prefix + "NotificationMetadata", this.NotificationMetadata);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamObj(map, prefix + "NotificationTarget.", this.NotificationTarget);
        }
    }
}

