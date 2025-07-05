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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExchangeInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 源实例信息
        /// </summary>
        [JsonProperty("SrcInstanceInfo")]
        public RollbackInstanceInfo SrcInstanceInfo{ get; set; }

        /// <summary>
        /// 目标实例信息
        /// </summary>
        [JsonProperty("DstInstanceInfo")]
        public RollbackInstanceInfo DstInstanceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SrcInstanceInfo.", this.SrcInstanceInfo);
            this.SetParamObj(map, prefix + "DstInstanceInfo.", this.DstInstanceInfo);
        }
    }
}

