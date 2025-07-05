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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ElementProfileTreeRes : AbstractModel
    {
        
        /// <summary>
        /// 建筑id
        /// </summary>
        [JsonProperty("BuildingId")]
        public string BuildingId{ get; set; }

        /// <summary>
        /// 父级构件id
        /// </summary>
        [JsonProperty("ParentElementId")]
        public string ParentElementId{ get; set; }

        /// <summary>
        /// 构件树
        /// </summary>
        [JsonProperty("Root")]
        public ElementProfileTreeNode Root{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BuildingId", this.BuildingId);
            this.SetParamSimple(map, prefix + "ParentElementId", this.ParentElementId);
            this.SetParamObj(map, prefix + "Root.", this.Root);
        }
    }
}

