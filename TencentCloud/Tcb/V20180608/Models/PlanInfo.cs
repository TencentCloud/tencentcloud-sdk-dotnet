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

    public class PlanInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>套餐标识</p>
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// <p>套餐中文名称</p>
        /// </summary>
        [JsonProperty("PackageTitle")]
        public string PackageTitle{ get; set; }

        /// <summary>
        /// <p>套餐描述</p>
        /// </summary>
        [JsonProperty("PackageDescription")]
        public string PackageDescription{ get; set; }

        /// <summary>
        /// <p>单位原价</p>
        /// </summary>
        [JsonProperty("UnitPrice")]
        public string UnitPrice{ get; set; }

        /// <summary>
        /// <p>套餐类型</p>
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// <p>json格式化用户资源限制</p>
        /// </summary>
        [JsonProperty("ResourceLimit")]
        public string ResourceLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageTitle", this.PackageTitle);
            this.SetParamSimple(map, prefix + "PackageDescription", this.PackageDescription);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ResourceLimit", this.ResourceLimit);
        }
    }
}

