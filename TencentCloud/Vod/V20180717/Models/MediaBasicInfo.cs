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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaBasicInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 媒体文件描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 媒体文件的创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 媒体文件的最近更新时间（如修改视频属性、发起视频处理等会触发更新媒体文件信息的操作），使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 媒体文件的过期时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。过期后该媒体文件及其相关资源（转码结果、雪碧图等）将被永久删除。“9999-12-31T23:59:59Z”表示永不过期。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 媒体文件的分类 ID。
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// 媒体文件的分类名称。
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// 媒体文件的分类路径，分类间以“-”分隔，如“新的一级分类 - 新的二级分类”。
        /// </summary>
        [JsonProperty("ClassPath")]
        public string ClassPath{ get; set; }

        /// <summary>
        /// 媒体文件的封面图片地址。
        /// </summary>
        [JsonProperty("CoverUrl")]
        public string CoverUrl{ get; set; }

        /// <summary>
        /// 媒体文件的封装格式，例如 mp4、flv 等。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 原始媒体文件的 URL 地址。
        /// </summary>
        [JsonProperty("MediaUrl")]
        public string MediaUrl{ get; set; }

        /// <summary>
        /// 该媒体文件的来源信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceInfo")]
        public MediaSourceData SourceInfo{ get; set; }

        /// <summary>
        /// 媒体文件存储地区，如 ap-chongqing，参见[地域列表](https://cloud.tencent.com/document/product/266/9760#.E5.B7.B2.E6.94.AF.E6.8C.81.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8)。
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// 媒体的存储路径。
        /// </summary>
        [JsonProperty("StoragePath")]
        public string StoragePath{ get; set; }

        /// <summary>
        /// 媒体文件的标签信息。
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }

        /// <summary>
        /// 直播录制文件的唯一标识。
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// 文件类型：
        /// <li>Video: 视频文件</li>
        /// <li>Audio: 音频文件</li>
        /// <li>Image: 图片文件</li>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 文件状态：Normal：正常，Forbidden：封禁。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 媒体文件的存储类别：
        /// <li> STANDARD：标准存储。</li>
        /// <li> STANDARD_IA：低频存储。</li>
        /// <li> ARCHIVE：归档存储。</li>
        /// <li> DEEP_ARCHIVE：深度归档存储。</li>
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamSimple(map, prefix + "ClassPath", this.ClassPath);
            this.SetParamSimple(map, prefix + "CoverUrl", this.CoverUrl);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MediaUrl", this.MediaUrl);
            this.SetParamObj(map, prefix + "SourceInfo.", this.SourceInfo);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "StoragePath", this.StoragePath);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StorageClass", this.StorageClass);
        }
    }
}

