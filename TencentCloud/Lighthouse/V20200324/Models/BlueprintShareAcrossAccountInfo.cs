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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlueprintShareAcrossAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// 镜像共享的账户ID。
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 镜像共享时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

