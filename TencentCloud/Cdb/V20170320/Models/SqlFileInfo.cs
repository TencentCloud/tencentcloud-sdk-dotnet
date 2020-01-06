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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SqlFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 上传时间
        /// </summary>
        [JsonProperty("UploadTime")]
        public string UploadTime{ get; set; }

        /// <summary>
        /// 上传进度
        /// </summary>
        [JsonProperty("UploadInfo")]
        public UploadInfo UploadInfo{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件大小，单位为Bytes
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// 上传是否完成标志，可选值：0 - 未完成，1 - 已完成
        /// </summary>
        [JsonProperty("IsUploadFinished")]
        public long? IsUploadFinished{ get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UploadTime", this.UploadTime);
            this.SetParamObj(map, prefix + "UploadInfo.", this.UploadInfo);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "IsUploadFinished", this.IsUploadFinished);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

