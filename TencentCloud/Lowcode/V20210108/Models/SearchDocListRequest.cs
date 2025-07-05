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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchDocListRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonProperty("CollectionView")]
        public string CollectionView{ get; set; }

        /// <summary>
        /// 搜索模式
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 搜索值
        /// </summary>
        [JsonProperty("SearchValue")]
        public string SearchValue{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public ulong? PageNo{ get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "CollectionView", this.CollectionView);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "SearchValue", this.SearchValue);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

