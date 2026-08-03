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

    public class GetExampleDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>案例ID</p>
        /// </summary>
        [JsonProperty("ExampleId")]
        public string ExampleId{ get; set; }

        /// <summary>
        /// <p>标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>README</p>
        /// </summary>
        [JsonProperty("Readme")]
        public string Readme{ get; set; }

        /// <summary>
        /// <p>案例归档URL</p>
        /// </summary>
        [JsonProperty("CodeArchiveUrl")]
        public string CodeArchiveUrl{ get; set; }

        /// <summary>
        /// <p>图片URL</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>实验室镜像</p>
        /// </summary>
        [JsonProperty("LabImage")]
        public string LabImage{ get; set; }

        /// <summary>
        /// <p>资源配置</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>分类</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>案例标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>难度</p>
        /// </summary>
        [JsonProperty("Difficulty")]
        public string Difficulty{ get; set; }

        /// <summary>
        /// <p>预估时间（分钟）</p>
        /// </summary>
        [JsonProperty("EstimatedTime")]
        public long? EstimatedTime{ get; set; }

        /// <summary>
        /// <p>排序</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public long? SortOrder{ get; set; }

        /// <summary>
        /// <p>是否启用</p>
        /// </summary>
        [JsonProperty("IsEnabled")]
        public bool? IsEnabled{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>是否删除</p>
        /// </summary>
        [JsonProperty("Deleted")]
        public long? Deleted{ get; set; }

        /// <summary>
        /// <p>案例热度</p>
        /// </summary>
        [JsonProperty("Popularity")]
        public long? Popularity{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ExampleId", this.ExampleId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Readme", this.Readme);
            this.SetParamSimple(map, prefix + "CodeArchiveUrl", this.CodeArchiveUrl);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "LabImage", this.LabImage);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Difficulty", this.Difficulty);
            this.SetParamSimple(map, prefix + "EstimatedTime", this.EstimatedTime);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
            this.SetParamSimple(map, prefix + "Popularity", this.Popularity);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

