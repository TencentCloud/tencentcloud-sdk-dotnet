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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceGraphEntitiesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>实体列表</p>
        /// </summary>
        [JsonProperty("EntityInfos")]
        public EntityInfo[] EntityInfos{ get; set; }

        /// <summary>
        /// <p>是否还有下一页</p><p>枚举值：</p><ul><li>0： 没有下一页</li><li>1： 还有下一页</li></ul>
        /// </summary>
        [JsonProperty("HasMore")]
        public ulong? HasMore{ get; set; }

        /// <summary>
        /// <p>分页的游标，有值则下次分页请求原样带上，无值则表示无下一页</p>
        /// </summary>
        [JsonProperty("NextCursor")]
        public string NextCursor{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "EntityInfos.", this.EntityInfos);
            this.SetParamSimple(map, prefix + "HasMore", this.HasMore);
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

