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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteLoginWhiteCustomEDRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>显式勾选的规则ID列表，最多 1000 个；与 SelectAll 二选一</p>
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// <p>是否跨页全选：true-删除符合 Filters 的全部规则（此时 Filters 必填） false-仅删除 Ids</p>
        /// </summary>
        [JsonProperty("SelectAll")]
        public bool? SelectAll{ get; set; }

        /// <summary>
        /// <p>多账号目标账号 AppId 列表，最多 1000 个；为空表示仅当前账号；传入但全部无权限时返回 InvalidParameter</p>
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>排除的规则ID列表，最多1000个</p>
        /// </summary>
        [JsonProperty("ExcludeIds")]
        public long?[] ExcludeIds{ get; set; }

        /// <summary>
        /// <p>全选条件下的筛选条件</p>
        /// </summary>
        [JsonProperty("Filters")]
        public EDRFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeIds.", this.ExcludeIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

