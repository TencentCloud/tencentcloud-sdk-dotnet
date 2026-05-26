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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSpecsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>全能型副本数，当前支持范围：1-3，默认为3</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }

        /// <summary>
        /// <p>独享实例</p>
        /// </summary>
        [JsonProperty("IsExclusiveInstance")]
        public long? IsExclusiveInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
            this.SetParamSimple(map, prefix + "IsExclusiveInstance", this.IsExclusiveInstance);
        }
    }
}

