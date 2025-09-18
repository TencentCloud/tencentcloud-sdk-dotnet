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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceSupportFeatureRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定实例 ID。请登录[Redis控制台](https://console.cloud.tencent.com/redis#/)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 支持查询的功能特性如下所示。
        /// - read-local-node-only：就近接入。
        /// - multi-account：多账号管理。
        /// - auto-failback：故障恢复场景，主节点是否开启自动回切。
        /// </summary>
        [JsonProperty("FeatureName")]
        public string FeatureName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "FeatureName", this.FeatureName);
        }
    }
}

