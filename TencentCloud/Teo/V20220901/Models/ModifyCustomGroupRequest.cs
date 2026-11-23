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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCustomGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>自定义组唯一标识 ID。</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>自定义组名称。该字段不填时则保留原值。</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>指定本次对 GroupItems 的更新方式。</p><p>枚举值：</p><ul><li>Replace： 使用 GroupItems 全量替换原有条目列表</li><li>Append： 追加 GroupItems 到组条目列表中</li><li>Remove： 从原有条目列表中移除与 GroupItems 中 Content 和 ItemType 均相同的条目。若指定条目不存在，则忽略该条目</li></ul><p>默认值：Replace</p>
        /// </summary>
        [JsonProperty("GroupItemOperation")]
        public string GroupItemOperation{ get; set; }

        /// <summary>
        /// <p>自定义组条目列表。该字段不填时则保留原值。</p>
        /// </summary>
        [JsonProperty("GroupItems")]
        public CustomGroupItem[] GroupItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupItemOperation", this.GroupItemOperation);
            this.SetParamArrayObj(map, prefix + "GroupItems.", this.GroupItems);
        }
    }
}

