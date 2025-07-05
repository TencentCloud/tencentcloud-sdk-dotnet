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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttributesOptions : AbstractModel
    {
        
        /// <summary>
        /// 返回年龄信息
        /// </summary>
        [JsonProperty("Age")]
        public bool? Age{ get; set; }

        /// <summary>
        /// 返回随身挎包信息
        /// </summary>
        [JsonProperty("Bag")]
        public bool? Bag{ get; set; }

        /// <summary>
        /// 返回性别信息
        /// </summary>
        [JsonProperty("Gender")]
        public bool? Gender{ get; set; }

        /// <summary>
        /// 返回朝向信息
        /// </summary>
        [JsonProperty("Orientation")]
        public bool? Orientation{ get; set; }

        /// <summary>
        /// 返回上装信息
        /// </summary>
        [JsonProperty("UpperBodyCloth")]
        public bool? UpperBodyCloth{ get; set; }

        /// <summary>
        /// 返回下装信息
        /// </summary>
        [JsonProperty("LowerBodyCloth")]
        public bool? LowerBodyCloth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Bag", this.Bag);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Orientation", this.Orientation);
            this.SetParamSimple(map, prefix + "UpperBodyCloth", this.UpperBodyCloth);
            this.SetParamSimple(map, prefix + "LowerBodyCloth", this.LowerBodyCloth);
        }
    }
}

