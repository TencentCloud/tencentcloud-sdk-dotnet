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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelStatus : AbstractModel
    {
        
        /// <summary>
        /// 专属并发数
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }

        /// <summary>
        /// 是否专属并发
        /// </summary>
        [JsonProperty("IsExclusive")]
        public bool? IsExclusive{ get; set; }

        /// <summary>
        /// 资源状态。1-资源可用, 2-资源已用尽
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public long? ResourceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
            this.SetParamSimple(map, prefix + "IsExclusive", this.IsExclusive);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
        }
    }
}

