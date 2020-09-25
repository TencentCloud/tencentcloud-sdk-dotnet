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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceCreationLimitPolicy : AbstractModel
    {
        
        /// <summary>
        /// 创建数量，最小值1，默认2
        /// </summary>
        [JsonProperty("NewGameServerSessionsPerCreator")]
        public ulong? NewGameServerSessionsPerCreator{ get; set; }

        /// <summary>
        /// 单位时间，最小值1，默认3
        /// </summary>
        [JsonProperty("PolicyPeriodInMinutes")]
        public ulong? PolicyPeriodInMinutes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NewGameServerSessionsPerCreator", this.NewGameServerSessionsPerCreator);
            this.SetParamSimple(map, prefix + "PolicyPeriodInMinutes", this.PolicyPeriodInMinutes);
        }
    }
}

