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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据不一致的表详情
        /// </summary>
        [JsonProperty("Difference")]
        public DifferenceDetail Difference{ get; set; }

        /// <summary>
        /// 跳过校验的表详情
        /// </summary>
        [JsonProperty("Skipped")]
        public SkippedDetail Skipped{ get; set; }

        /// <summary>
        /// 数据库不一致的详情，mongodb业务用到
        /// </summary>
        [JsonProperty("DifferenceAdvancedObjects")]
        public DifferenceAdvancedObjectsDetail DifferenceAdvancedObjects{ get; set; }

        /// <summary>
        /// 数据不一致的详情，mongodb业务用到
        /// </summary>
        [JsonProperty("DifferenceData")]
        public DifferenceDataDetail DifferenceData{ get; set; }

        /// <summary>
        /// 数据行不一致的详情，mongodb业务用到
        /// </summary>
        [JsonProperty("DifferenceRow")]
        public DifferenceRowDetail DifferenceRow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Difference.", this.Difference);
            this.SetParamObj(map, prefix + "Skipped.", this.Skipped);
            this.SetParamObj(map, prefix + "DifferenceAdvancedObjects.", this.DifferenceAdvancedObjects);
            this.SetParamObj(map, prefix + "DifferenceData.", this.DifferenceData);
            this.SetParamObj(map, prefix + "DifferenceRow.", this.DifferenceRow);
        }
    }
}

