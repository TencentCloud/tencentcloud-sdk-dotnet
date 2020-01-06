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

    public class UpgradeLifecycleHookRequest : AbstractModel
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
        /// 进行生命周期挂钩的场景，取值范围包括“INSTANCE_LAUNCHING”和“INSTANCE_TERMINATING”
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// 定义伸缩组在生命周期挂钩超时的情况下应采取的操作，取值范围是“CONTINUE”或“ABANDON”，默认值为“CONTINUE”
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// 生命周期挂钩超时之前可以经过的最长时间（以秒为单位），范围从30到3600秒，默认值为300秒
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// 弹性伸缩向通知目标发送的附加信息，默认值为''
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

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
            this.SetParamSimple(map, prefix + "LifecycleTransition", this.LifecycleTransition);
            this.SetParamSimple(map, prefix + "DefaultResult", this.DefaultResult);
            this.SetParamSimple(map, prefix + "HeartbeatTimeout", this.HeartbeatTimeout);
            this.SetParamSimple(map, prefix + "NotificationMetadata", this.NotificationMetadata);
            this.SetParamObj(map, prefix + "NotificationTarget.", this.NotificationTarget);
        }
    }
}

