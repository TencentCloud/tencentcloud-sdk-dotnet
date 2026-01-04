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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PriceTag : AbstractModel
    {
        
        /// <summary>
        /// 计价名称。枚举值如下：
        /// 
        /// - tps：TPS基础价
        /// - stepTps：TPS步长
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 计价类别
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 计费项标签
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 计费项对应的步长数
        /// </summary>
        [JsonProperty("Step")]
        public long? Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

