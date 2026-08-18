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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TagInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Tag名称</p>
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// <p>制品的 ID</p>
        /// </summary>
        [JsonProperty("TagId")]
        public string TagId{ get; set; }

        /// <summary>
        /// <p>docker image 可以看到的id</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>大小</p>
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// <p>制品的创建时间</p>
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// <p>制品创建至今时间长度</p>
        /// </summary>
        [JsonProperty("DurationDays")]
        public string DurationDays{ get; set; }

        /// <summary>
        /// <p>标注的制品作者</p>
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// <p>标注的制品平台</p>
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// <p>创建制品的 Docker 版本</p>
        /// </summary>
        [JsonProperty("DockerVersion")]
        public string DockerVersion{ get; set; }

        /// <summary>
        /// <p>标注的制品操作系统</p>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>制品大小，单位：Byte</p>
        /// </summary>
        [JsonProperty("SizeByte")]
        public long? SizeByte{ get; set; }

        /// <summary>
        /// <p>序号</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>数据更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>制品更新时间</p>
        /// </summary>
        [JsonProperty("PushTime")]
        public string PushTime{ get; set; }

        /// <summary>
        /// <p>制品类型</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "DurationDays", this.DurationDays);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "DockerVersion", this.DockerVersion);
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamSimple(map, prefix + "SizeByte", this.SizeByte);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PushTime", this.PushTime);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
        }
    }
}

