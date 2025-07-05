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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFleetAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务器舰队 Id
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 服务器舰队描述，最小长度0，最大长度100
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 服务器舰队名称，最小长度1，最大长度50
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 保护策略：不保护NoProtection、完全保护FullProtection、时限保护TimeLimitProtection
        /// </summary>
        [JsonProperty("NewGameSessionProtectionPolicy")]
        public string NewGameSessionProtectionPolicy{ get; set; }

        /// <summary>
        /// 资源创建限制策略
        /// </summary>
        [JsonProperty("ResourceCreationLimitPolicy")]
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy{ get; set; }

        /// <summary>
        /// 时限保护超时时间，默认60分钟，最小值5，最大值1440；当NewGameSessionProtectionPolicy为TimeLimitProtection时参数有效
        /// </summary>
        [JsonProperty("GameServerSessionProtectionTimeLimit")]
        public long? GameServerSessionProtectionTimeLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NewGameSessionProtectionPolicy", this.NewGameSessionProtectionPolicy);
            this.SetParamObj(map, prefix + "ResourceCreationLimitPolicy.", this.ResourceCreationLimitPolicy);
            this.SetParamSimple(map, prefix + "GameServerSessionProtectionTimeLimit", this.GameServerSessionProtectionTimeLimit);
        }
    }
}

