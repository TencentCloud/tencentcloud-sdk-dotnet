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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStorageCredentialResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>密钥信息</p>
        /// </summary>
        [JsonProperty("Credentials")]
        public Credentials Credentials{ get; set; }

        /// <summary>
        /// <p>失效时间，为 Unix 时间戳</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public long? ExpiredTime{ get; set; }

        /// <summary>
        /// <p>开始时间，为 Unix 时间戳</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>对象存储桶</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>对象存储可用区</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>文件存储目录</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>存储类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>企业主账号</p>
        /// </summary>
        [JsonProperty("CorpUin")]
        public string CorpUin{ get; set; }

        /// <summary>
        /// <p>图片存储目录</p>
        /// </summary>
        [JsonProperty("ImagePath")]
        public string ImagePath{ get; set; }

        /// <summary>
        /// <p>上传存储路径，到具体文件</p>
        /// </summary>
        [JsonProperty("UploadPath")]
        public string UploadPath{ get; set; }

        /// <summary>
        /// <p>文件上传地址，使用put请求上传文件到该地址</p>
        /// </summary>
        [JsonProperty("UploadUrl")]
        public string UploadUrl{ get; set; }

        /// <summary>
        /// <p>文件的预签名地址，支持下载</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

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
            this.SetParamObj(map, prefix + "Credentials.", this.Credentials);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CorpUin", this.CorpUin);
            this.SetParamSimple(map, prefix + "ImagePath", this.ImagePath);
            this.SetParamSimple(map, prefix + "UploadPath", this.UploadPath);
            this.SetParamSimple(map, prefix + "UploadUrl", this.UploadUrl);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

