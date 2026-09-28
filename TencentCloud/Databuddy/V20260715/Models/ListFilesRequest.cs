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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间id</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>父目录，不填默认查询根节点</p>
        /// </summary>
        [JsonProperty("Parent")]
        public FolderLocator Parent{ get; set; }

        /// <summary>
        /// <p>按文件类型过滤</p>
        /// </summary>
        [JsonProperty("FileTypes")]
        public string[] FileTypes{ get; set; }

        /// <summary>
        /// <p>文件名模糊匹配</p>
        /// </summary>
        [JsonProperty("NameKeyword")]
        public string NameKeyword{ get; set; }

        /// <summary>
        /// <p>按所有者UIN过滤，多值为或关系</p>
        /// </summary>
        [JsonProperty("OwnerUserUins")]
        public string[] OwnerUserUins{ get; set; }

        /// <summary>
        /// <p>是否只列出文件夹，默认 false</p>
        /// </summary>
        [JsonProperty("OnlyFolder")]
        public bool? OnlyFolder{ get; set; }

        /// <summary>
        /// <p>排序字段列表，如创建时间 [{Name: &#39;CreateTime&#39;, Direction: &#39;DESC&#39;}]，文件名称 [{Name: &#39;Name&#39;, Direction: &#39;ASC&#39;}]</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }

        /// <summary>
        /// <p>页码，默认1，最小值1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页条数，默认10，最小值10，最大值100</p><p>取值范围：[10, 100]</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "Parent.", this.Parent);
            this.SetParamArraySimple(map, prefix + "FileTypes.", this.FileTypes);
            this.SetParamSimple(map, prefix + "NameKeyword", this.NameKeyword);
            this.SetParamArraySimple(map, prefix + "OwnerUserUins.", this.OwnerUserUins);
            this.SetParamSimple(map, prefix + "OnlyFolder", this.OnlyFolder);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

