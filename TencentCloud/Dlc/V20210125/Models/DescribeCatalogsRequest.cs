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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCatalogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据目录 ID</p>
        /// </summary>
        [JsonProperty("CatalogId")]
        public string CatalogId{ get; set; }

        /// <summary>
        /// <p>数据目录名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>操作人 uin</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>排序字段，支持 CreateTime / UpdateTime（默认 UpdateTime）</p>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// <p>true:升序（默认）/ false:降序</p>
        /// </summary>
        [JsonProperty("Asc")]
        public string Asc{ get; set; }

        /// <summary>
        /// <p>分页大小</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>分页偏移</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>状态：0 注册中 / 1 待测试 / 2 连接成功 / 3 连接失败 / 4 删除中 / 5 已删除</p><p>枚举值：</p><ul><li>0： 注册中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>数据目录类型</p><p>枚举值：</p><ul><li>LAKEHOUSE： lakehouse类型</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>在这个时间之后创建（时间戳）</p>
        /// </summary>
        [JsonProperty("CreatedAfter")]
        public ulong? CreatedAfter{ get; set; }

        /// <summary>
        /// <p>在这个时间之前创建（时间戳）</p>
        /// </summary>
        [JsonProperty("CreatedBefore")]
        public ulong? CreatedBefore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogId", this.CatalogId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreatedAfter", this.CreatedAfter);
            this.SetParamSimple(map, prefix + "CreatedBefore", this.CreatedBefore);
        }
    }
}

