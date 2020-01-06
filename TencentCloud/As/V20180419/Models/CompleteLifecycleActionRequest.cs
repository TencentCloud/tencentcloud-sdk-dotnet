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

    public class CompleteLifecycleActionRequest : AbstractModel
    {
        
        /// <summary>
        /// 生命周期挂钩ID
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// 生命周期动作的结果，取值范围为“CONTINUE”或“ABANDON”
        /// </summary>
        [JsonProperty("LifecycleActionResult")]
        public string LifecycleActionResult{ get; set; }

        /// <summary>
        /// 实例ID，“InstanceId”和“LifecycleActionToken”必须填充其中一个
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// “InstanceId”和“LifecycleActionToken”必须填充其中一个
        /// </summary>
        [JsonProperty("LifecycleActionToken")]
        public string LifecycleActionToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "LifecycleActionResult", this.LifecycleActionResult);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LifecycleActionToken", this.LifecycleActionToken);
        }
    }
}

