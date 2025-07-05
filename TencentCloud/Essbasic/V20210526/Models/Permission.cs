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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Permission : AbstractModel
    {
        
        /// <summary>
        /// 权限名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 权限key
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 权限类型 1前端，2后端
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        [JsonProperty("Hide")]
        public long? Hide{ get; set; }

        /// <summary>
        /// 数据权限标签 1:表示根节点，2:表示叶子结点
        /// </summary>
        [JsonProperty("DataLabel")]
        public long? DataLabel{ get; set; }

        /// <summary>
        /// 数据权限独有，1:关联其他模块鉴权，2:表示关联自己模块鉴权
        /// </summary>
        [JsonProperty("DataType")]
        public long? DataType{ get; set; }

        /// <summary>
        /// 数据权限独有，表示数据范围，1：全公司，2:部门及下级部门，3:自己
        /// </summary>
        [JsonProperty("DataRange")]
        public long? DataRange{ get; set; }

        /// <summary>
        /// 关联权限, 表示这个功能权限要受哪个数据权限管控
        /// </summary>
        [JsonProperty("DataTo")]
        public string DataTo{ get; set; }

        /// <summary>
        /// 父级权限key
        /// </summary>
        [JsonProperty("ParentKey")]
        public string ParentKey{ get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        [JsonProperty("IsChecked")]
        public bool? IsChecked{ get; set; }

        /// <summary>
        /// 子权限集合
        /// </summary>
        [JsonProperty("Children")]
        public Permission[] Children{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Hide", this.Hide);
            this.SetParamSimple(map, prefix + "DataLabel", this.DataLabel);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "DataRange", this.DataRange);
            this.SetParamSimple(map, prefix + "DataTo", this.DataTo);
            this.SetParamSimple(map, prefix + "ParentKey", this.ParentKey);
            this.SetParamSimple(map, prefix + "IsChecked", this.IsChecked);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
        }
    }
}

