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

    public class DescribeUserGroupTreeListRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 是否分页
        /// </summary>
        [JsonProperty("AllPage")]
        public long? AllPage{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 标签过滤条件
        /// </summary>
        [JsonProperty("TagValueList")]
        public ResourceTagValue[] TagValueList{ get; set; }

        /// <summary>
        /// 节点集合
        /// </summary>
        [JsonProperty("Nodes")]
        public UserGroupTreeNodeDTO[] Nodes{ get; set; }

        /// <summary>
        /// 用户组id集合
        /// </summary>
        [JsonProperty("GroupIds")]
        public long?[] GroupIds{ get; set; }

        /// <summary>
        /// 查询下一个code
        /// </summary>
        [JsonProperty("QueryNextNode")]
        public bool? QueryNextNode{ get; set; }

        /// <summary>
        /// 父id集合
        /// </summary>
        [JsonProperty("ParentIds")]
        public long?[] ParentIds{ get; set; }

        /// <summary>
        /// 是否查询所有节点
        /// </summary>
        [JsonProperty("QueryAllNode")]
        public bool? QueryAllNode{ get; set; }

        /// <summary>
        /// 过滤组id集合
        /// </summary>
        [JsonProperty("FilterGroupIds")]
        public long?[] FilterGroupIds{ get; set; }

        /// <summary>
        /// 模糊搜索关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AllPage", this.AllPage);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "TagValueList.", this.TagValueList);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "QueryNextNode", this.QueryNextNode);
            this.SetParamArraySimple(map, prefix + "ParentIds.", this.ParentIds);
            this.SetParamSimple(map, prefix + "QueryAllNode", this.QueryAllNode);
            this.SetParamArraySimple(map, prefix + "FilterGroupIds.", this.FilterGroupIds);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

