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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiffIPWhitelist : AbstractModel
    {
        
        /// <summary>
        /// 最新IP白名单列表。
        /// </summary>
        [JsonProperty("LatestIPWhitelist")]
        public IPWhitelist LatestIPWhitelist{ get; set; }

        /// <summary>
        /// 最新IP白名单列表相比于当前IP白名单列表，新增部分。
        /// </summary>
        [JsonProperty("AddedIPWhitelist")]
        public IPWhitelist AddedIPWhitelist{ get; set; }

        /// <summary>
        /// 最新IP白名单列表相比于当前IP白名单列表，删减部分。
        /// </summary>
        [JsonProperty("RemovedIPWhitelist")]
        public IPWhitelist RemovedIPWhitelist{ get; set; }

        /// <summary>
        /// 最新IP白名单列表相比于当前IP白名单列表，不变部分。
        /// </summary>
        [JsonProperty("NoChangeIPWhitelist")]
        public IPWhitelist NoChangeIPWhitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LatestIPWhitelist.", this.LatestIPWhitelist);
            this.SetParamObj(map, prefix + "AddedIPWhitelist.", this.AddedIPWhitelist);
            this.SetParamObj(map, prefix + "RemovedIPWhitelist.", this.RemovedIPWhitelist);
            this.SetParamObj(map, prefix + "NoChangeIPWhitelist.", this.NoChangeIPWhitelist);
        }
    }
}

