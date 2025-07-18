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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupExDescriptionInfo : AbstractModel
    {
        
        /// <summary>
        /// 人员库自定义描述字段Index，从0开始。
        /// </summary>
        [JsonProperty("GroupExDescriptionIndex")]
        public ulong? GroupExDescriptionIndex{ get; set; }

        /// <summary>
        /// 需要更新的人员库自定义描述字段内容。
        /// </summary>
        [JsonProperty("GroupExDescription")]
        public string GroupExDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupExDescriptionIndex", this.GroupExDescriptionIndex);
            this.SetParamSimple(map, prefix + "GroupExDescription", this.GroupExDescription);
        }
    }
}

