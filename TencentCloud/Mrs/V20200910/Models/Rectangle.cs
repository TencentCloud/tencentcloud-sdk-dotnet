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

    public class Rectangle : AbstractModel
    {
        
        /// <summary>
        /// x坐标
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// y坐标
        /// </summary>
        [JsonProperty("Y")]
        public long? Y{ get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [JsonProperty("W")]
        public long? W{ get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [JsonProperty("H")]
        public long? H{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "W", this.W);
            this.SetParamSimple(map, prefix + "H", this.H);
        }
    }
}

