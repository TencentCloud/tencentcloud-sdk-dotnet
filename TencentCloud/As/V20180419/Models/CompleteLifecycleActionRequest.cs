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

    public class CompleteLifecycleActionRequest : AbstractModel
    {
        
        /// <summary>
        /// 生命周期挂钩ID。可以通过调用接口 [DescribeLifecycleHooks](https://cloud.tencent.com/document/api/377/34452) ，取返回信息中的 LifecycleHookId 获取生命周期挂钩ID。
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// 生命周期动作的结果，取值范围如下：
        /// <li>CONTINUE: 默认值，表示继续执行扩缩容活动</li>
        /// <li>ABANDON: 针对扩容挂钩，挂钩超时或 LifecycleCommand 执行失败的 CVM 实例会直接释放或移出；而针对缩容挂钩，会继续执行缩容活动。</li>
        /// </summary>
        [JsonProperty("LifecycleActionResult")]
        public string LifecycleActionResult{ get; set; }

        /// <summary>
        /// 实例ID，`InstanceId` 和 `LifecycleActionToken` 参数必须填写其中一个。可通过登录 [控制台](https://console.cloud.tencent.com/cvm/index) 或调用接口 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) ，取返回信息中的 `InstanceId` 获取实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 生命周期动作令牌，`InstanceId` 和 `LifecycleActionToken` 必须填充其中一个。
        /// 该参数获取方式如下：配置 `NotificationTarget ` 参数的挂钩被触发时，向  `NotificationTarget `  参数中指定的消息队列投递包含令牌的消息，消息队列的消费者可从消息中获取令牌。
        /// </summary>
        [JsonProperty("LifecycleActionToken")]
        public string LifecycleActionToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "LifecycleActionResult", this.LifecycleActionResult);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LifecycleActionToken", this.LifecycleActionToken);
        }
    }
}

