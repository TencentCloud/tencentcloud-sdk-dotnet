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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MgoKeySchema : AbstractModel
    {
        
        /// <summary>
        /// <p>索引字段</p>
        /// </summary>
        [JsonProperty("MgoIndexKeys")]
        public MgoIndexKeys[] MgoIndexKeys{ get; set; }

        /// <summary>
        /// <p>是否唯一索引</p>
        /// </summary>
        [JsonProperty("MgoIsUnique")]
        public bool? MgoIsUnique{ get; set; }

        /// <summary>
        /// <p>是否稀疏索引</p>
        /// </summary>
        [JsonProperty("MgoIsSparse")]
        public bool? MgoIsSparse{ get; set; }

        /// <summary>
        /// <p>稀疏索引表达式</p>
        /// </summary>
        [JsonProperty("PartialFilterExpression")]
        public string PartialFilterExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "MgoIndexKeys.", this.MgoIndexKeys);
            this.SetParamSimple(map, prefix + "MgoIsUnique", this.MgoIsUnique);
            this.SetParamSimple(map, prefix + "MgoIsSparse", this.MgoIsSparse);
            this.SetParamSimple(map, prefix + "PartialFilterExpression", this.PartialFilterExpression);
        }
    }
}

