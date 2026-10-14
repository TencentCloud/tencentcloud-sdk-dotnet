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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KBSpaceShare : AbstractModel
    {
        
        /// <summary>
        /// <p>是否已被其他空间引用</p>
        /// </summary>
        [JsonProperty("IsSpaceShared")]
        public bool? IsSpaceShared{ get; set; }

        /// <summary>
        /// <p>被引用空间信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SharedSpaceList")]
        public Identity[] SharedSpaceList{ get; set; }

        /// <summary>
        /// <p>共享状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubStatus")]
        public KBShareStatus SubStatus{ get; set; }

        /// <summary>
        /// <p>是否允许操作</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSpaceShared", this.IsSpaceShared);
            this.SetParamArrayObj(map, prefix + "SharedSpaceList.", this.SharedSpaceList);
            this.SetParamObj(map, prefix + "SubStatus.", this.SubStatus);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

