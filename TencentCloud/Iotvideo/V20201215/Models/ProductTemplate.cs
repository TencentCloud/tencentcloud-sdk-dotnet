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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductTemplate : AbstractModel
    {
        
        /// <summary>
        /// 实体ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 分类字段
        /// </summary>
        [JsonProperty("CategoryKey")]
        public string CategoryKey{ get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// 上层实体ID
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// 物模型
        /// </summary>
        [JsonProperty("ModelTemplate")]
        public string ModelTemplate{ get; set; }

        /// <summary>
        /// 排列顺序
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ListOrder")]
        public long? ListOrder{ get; set; }

        /// <summary>
        /// 分类图标地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// 九宫格图片地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IconUrlGrid")]
        public string IconUrlGrid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "CategoryKey", this.CategoryKey);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "ModelTemplate", this.ModelTemplate);
            this.SetParamSimple(map, prefix + "ListOrder", this.ListOrder);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "IconUrlGrid", this.IconUrlGrid);
        }
    }
}

