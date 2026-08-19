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

    public class BaselineSystemCategory : AbstractModel
    {
        
        /// <summary>
        /// <p>该父分类下的子分类列表（每个子分类含其内置检测项 ID 列表）。</p>
        /// </summary>
        [JsonProperty("SubCategoryList")]
        public BaselineSubCategory[] SubCategoryList{ get; set; }

        /// <summary>
        /// <p>系统父分类基础信息（ID、名称、描述、CheckAssetType）。</p>
        /// </summary>
        [JsonProperty("Category")]
        public BaselineCategory Category{ get; set; }

        /// <summary>
        /// <p>检测项个数</p>
        /// </summary>
        [JsonProperty("ItemCount")]
        public ulong? ItemCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SubCategoryList.", this.SubCategoryList);
            this.SetParamObj(map, prefix + "Category.", this.Category);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
        }
    }
}

