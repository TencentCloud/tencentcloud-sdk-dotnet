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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Library : AbstractModel
    {
        
        /// <summary>
        /// 媒体库 ID
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }

        /// <summary>
        /// 媒体库友好名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 媒体库绑定的 COS 存储桶
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 媒体库绑定的 COS 存储桶所在的地域
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 媒体库创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 媒体库配置项
        /// </summary>
        [JsonProperty("LibraryExtension")]
        public LibraryExtension LibraryExtension{ get; set; }

        /// <summary>
        /// 媒体库用量，单位为 Bytes，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 媒体库目录数，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("DirNum")]
        public string DirNum{ get; set; }

        /// <summary>
        /// 媒体库文件数，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("FileNum")]
        public string FileNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamObj(map, prefix + "LibraryExtension.", this.LibraryExtension);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "DirNum", this.DirNum);
            this.SetParamSimple(map, prefix + "FileNum", this.FileNum);
        }
    }
}

