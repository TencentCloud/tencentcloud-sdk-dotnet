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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteAndroidInstanceBackupFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件对象键列表
        /// </summary>
        [JsonProperty("ObjectKeys")]
        public string[] ObjectKeys{ get; set; }

        /// <summary>
        /// 存储服务器类型，如 COS、S3。注意：使用 COS 和 S3 都将占用外网带宽。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// COS协议选项
        /// </summary>
        [JsonProperty("COSOptions")]
        public COSOptions COSOptions{ get; set; }

        /// <summary>
        /// S3存储协议选项
        /// </summary>
        [JsonProperty("S3Options")]
        public S3Options S3Options{ get; set; }

        /// <summary>
        /// 安卓实例可用区。StorageType 为 S3 时，需要填写该字段；StorageType 为 COS 时，不需要填写该字段
        /// </summary>
        [JsonProperty("AndroidInstanceZone")]
        public string AndroidInstanceZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ObjectKeys.", this.ObjectKeys);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamObj(map, prefix + "COSOptions.", this.COSOptions);
            this.SetParamObj(map, prefix + "S3Options.", this.S3Options);
            this.SetParamSimple(map, prefix + "AndroidInstanceZone", this.AndroidInstanceZone);
        }
    }
}

