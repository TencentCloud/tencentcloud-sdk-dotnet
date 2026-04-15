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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ItemCoordinate : AbstractModel
    {
        
        /// <summary>
        /// <p>指标项名称坐标</p>
        /// </summary>
        [JsonProperty("Name")]
        public Coordinate Name{ get; set; }

        /// <summary>
        /// <p>指标结果称坐标</p>
        /// </summary>
        [JsonProperty("Result")]
        public Coordinate Result{ get; set; }

        /// <summary>
        /// <p>指标项范围坐标</p>
        /// </summary>
        [JsonProperty("Range")]
        public Coordinate Range{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamObj(map, prefix + "Result.", this.Result);
            this.SetParamObj(map, prefix + "Range.", this.Range);
        }
    }
}

