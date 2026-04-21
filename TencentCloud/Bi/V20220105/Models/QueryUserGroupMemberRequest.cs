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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryUserGroupMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户组id集合
        /// </summary>
        [JsonProperty("GroupIds")]
        public long?[] GroupIds{ get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonProperty("PageNo")]
        public ulong? PageNo{ get; set; }

        /// <summary>
        /// 是否需要分页
        /// </summary>
        [JsonProperty("AllPage")]
        public bool? AllPage{ get; set; }

        /// <summary>
        /// 用户组节点信息
        /// </summary>
        [JsonProperty("Nodes")]
        public UserGroupTreeNodeDTO[] Nodes{ get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [JsonProperty("TagValueList")]
        public ResourceTagValue[] TagValueList{ get; set; }

        /// <summary>
        /// 需要过滤的用户组
        /// </summary>
        [JsonProperty("FilterGroupIds")]
        public long?[] FilterGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "AllPage", this.AllPage);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamArrayObj(map, prefix + "TagValueList.", this.TagValueList);
            this.SetParamArraySimple(map, prefix + "FilterGroupIds.", this.FilterGroupIds);
        }
    }
}

