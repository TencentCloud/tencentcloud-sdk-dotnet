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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeActionLibraryListRequest : AbstractModel
    {
        
        /// <summary>
        /// 0-100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 默认值0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 对象类型ID
        /// </summary>
        [JsonProperty("ObjectType")]
        public ulong? ObjectType{ get; set; }

        /// <summary>
        /// Keyword取值{"动作名称": "a_title", "描述": "a_desc", "动作类型": "a_type", "创建时间": "a_create_time", "二级分类": "a_resource_type"}
        /// </summary>
        [JsonProperty("Filters")]
        public ActionFilter[] Filters{ get; set; }

        /// <summary>
        /// 动作分类，1表示故障动作，2表示恢复动作
        /// </summary>
        [JsonProperty("Attribute")]
        public long?[] Attribute{ get; set; }

        /// <summary>
        /// 筛选项 -动作ID
        /// </summary>
        [JsonProperty("ActionIds")]
        public ulong?[] ActionIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "Attribute.", this.Attribute);
            this.SetParamArraySimple(map, prefix + "ActionIds.", this.ActionIds);
        }
    }
}

