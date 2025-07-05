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

    public class EyeChildItem : AbstractModel
    {
        
        /// <summary>
        /// 球镜
        /// </summary>
        [JsonProperty("Sph")]
        public BaseItem3[] Sph{ get; set; }

        /// <summary>
        /// 柱镜
        /// </summary>
        [JsonProperty("Cyl")]
        public BaseItem3[] Cyl{ get; set; }

        /// <summary>
        /// 轴位
        /// </summary>
        [JsonProperty("Ax")]
        public BaseItem3[] Ax{ get; set; }

        /// <summary>
        /// 等效球镜
        /// </summary>
        [JsonProperty("Se")]
        public BaseItem2 Se{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Sph.", this.Sph);
            this.SetParamArrayObj(map, prefix + "Cyl.", this.Cyl);
            this.SetParamArrayObj(map, prefix + "Ax.", this.Ax);
            this.SetParamObj(map, prefix + "Se.", this.Se);
        }
    }
}

