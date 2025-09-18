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

    public class UpgradeVersionToMultiAvailabilityZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，请登录 [Redis 控制台](https://console.cloud.tencent.com/redis/instance/list)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 升级多可用区之后是否支持就近访问功能。
        /// - true：支持就近访问功能。升级过程，需同时升级 Proxy 版本和 Redis 内核小版本，涉及数据搬迁，可能会长达数小时。
        /// - false：无需支持就近访问功能。升级多可用区仅涉及管理元数据迁移，对服务没有影响，升级过程通常在3分钟内完成。默认为 false。
        /// </summary>
        [JsonProperty("UpgradeProxyAndRedisServer")]
        public bool? UpgradeProxyAndRedisServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpgradeProxyAndRedisServer", this.UpgradeProxyAndRedisServer);
        }
    }
}

