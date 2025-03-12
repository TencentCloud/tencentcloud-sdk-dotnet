/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DatabaseTableObject : AbstractModel
    {
        
        /// <summary>
        /// 迁移对象类型 all(全实例)，partial(部分对象)
        /// </summary>
        [JsonProperty("ObjectMode")]
        public string ObjectMode{ get; set; }

        /// <summary>
        /// 迁移对象，当 ObjectMode 为 partial 时，不为空
        /// </summary>
        [JsonProperty("Databases")]
        public DBItem[] Databases{ get; set; }

        /// <summary>
        /// 高级对象类型，如trigger、function、procedure、event。注意：如果要迁移同步高级对象，此配置中应该包含对应的高级对象类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvancedObjects")]
        public string[] AdvancedObjects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectMode", this.ObjectMode);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArraySimple(map, prefix + "AdvancedObjects.", this.AdvancedObjects);
        }
    }
}

