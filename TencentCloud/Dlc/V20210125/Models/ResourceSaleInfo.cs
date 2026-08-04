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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceSaleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>可售卖资源规格</p>
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public ResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// <p>规格步长</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Step")]
        public long? Step{ get; set; }

        /// <summary>
        /// <p>最大资源数量，仅GU有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxSpec")]
        public long? MaxSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "Step", this.Step);
            this.SetParamSimple(map, prefix + "MaxSpec", this.MaxSpec);
        }
    }
}

