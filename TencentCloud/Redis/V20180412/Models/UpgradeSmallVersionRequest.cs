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

    public class UpgradeSmallVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，请登录[Redis控制台](https://console.cloud.tencent.com/redis/instance/list)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 当前 Redis 小版本。小版本信息，请参见[升级实例版本](https://cloud.tencent.com/document/product/239/46457)。
        /// </summary>
        [JsonProperty("CurrentRedisVersion")]
        public string CurrentRedisVersion{ get; set; }

        /// <summary>
        /// 升级后的 Redis 小版本。小版本信息，请参见[升级实例版本](https://cloud.tencent.com/document/product/239/46457)。
        /// </summary>
        [JsonProperty("UpgradeRedisVersion")]
        public string UpgradeRedisVersion{ get; set; }

        /// <summary>
        /// 指定是否立即升级。
        /// - 1：立即升级。
        /// - 0：维护时间窗口升级。
        /// </summary>
        [JsonProperty("InstanceTypeUpgradeNow")]
        public long? InstanceTypeUpgradeNow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CurrentRedisVersion", this.CurrentRedisVersion);
            this.SetParamSimple(map, prefix + "UpgradeRedisVersion", this.UpgradeRedisVersion);
            this.SetParamSimple(map, prefix + "InstanceTypeUpgradeNow", this.InstanceTypeUpgradeNow);
        }
    }
}

