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

    public class KBCategory : AbstractModel
    {
        
        /// <summary>
        /// <p>是否可新增</p>
        /// </summary>
        [JsonProperty("CanAdd")]
        public bool? CanAdd{ get; set; }

        /// <summary>
        /// <p>是否可删除</p>
        /// </summary>
        [JsonProperty("CanDelete")]
        public bool? CanDelete{ get; set; }

        /// <summary>
        /// <p>是否可编辑</p>
        /// </summary>
        [JsonProperty("CanEdit")]
        public bool? CanEdit{ get; set; }

        /// <summary>
        /// <p>分类 ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>子分类列表</p>
        /// </summary>
        [JsonProperty("ChildList")]
        public KBCategory[] ChildList{ get; set; }

        /// <summary>
        /// <p>是否为叶子节点（无子分类）</p>
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// <p>分类对象的数量</p>
        /// </summary>
        [JsonProperty("ItemCount")]
        public ulong? ItemCount{ get; set; }

        /// <summary>
        /// <p>元数据配置（该分类被设置为元数据时的配置信息）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaValue")]
        public MetaValue MetaValue{ get; set; }

        /// <summary>
        /// <p>分类名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanAdd", this.CanAdd);
            this.SetParamSimple(map, prefix + "CanDelete", this.CanDelete);
            this.SetParamSimple(map, prefix + "CanEdit", this.CanEdit);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamArrayObj(map, prefix + "ChildList.", this.ChildList);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
            this.SetParamObj(map, prefix + "MetaValue.", this.MetaValue);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

