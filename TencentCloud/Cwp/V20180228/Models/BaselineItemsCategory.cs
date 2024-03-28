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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineItemsCategory : AbstractModel
    {
        
        /// <summary>
        /// 基线检测项父分类id
        /// </summary>
        [JsonProperty("ParentCategoryId")]
        public long? ParentCategoryId{ get; set; }

        /// <summary>
        /// 基线检测项父分类名称
        /// </summary>
        [JsonProperty("ParentCategoryName")]
        public string ParentCategoryName{ get; set; }

        /// <summary>
        /// 基线检测项子分类数目
        /// </summary>
        [JsonProperty("CategoryCount")]
        public long? CategoryCount{ get; set; }

        /// <summary>
        /// 基线检测项子分类列表
        /// </summary>
        [JsonProperty("CategoryLists")]
        public BaselineCategory[] CategoryLists{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParentCategoryId", this.ParentCategoryId);
            this.SetParamSimple(map, prefix + "ParentCategoryName", this.ParentCategoryName);
            this.SetParamSimple(map, prefix + "CategoryCount", this.CategoryCount);
            this.SetParamArrayObj(map, prefix + "CategoryLists.", this.CategoryLists);
        }
    }
}

