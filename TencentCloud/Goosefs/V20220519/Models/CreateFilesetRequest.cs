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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFilesetRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统id
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// Fileset名称
        /// </summary>
        [JsonProperty("FsetName")]
        public string FsetName{ get; set; }

        /// <summary>
        /// Fileset目录
        /// </summary>
        [JsonProperty("FsetDir")]
        public string FsetDir{ get; set; }

        /// <summary>
        /// Fileset容量配额（需带单位G）
        /// </summary>
        [JsonProperty("QuotaSizeLimit")]
        public string QuotaSizeLimit{ get; set; }

        /// <summary>
        /// Fileset文件数配额
        /// </summary>
        [JsonProperty("QuotaFilesLimit")]
        public string QuotaFilesLimit{ get; set; }

        /// <summary>
        /// Fileset文件删除操作审计
        /// </summary>
        [JsonProperty("AuditState")]
        public string AuditState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "FsetName", this.FsetName);
            this.SetParamSimple(map, prefix + "FsetDir", this.FsetDir);
            this.SetParamSimple(map, prefix + "QuotaSizeLimit", this.QuotaSizeLimit);
            this.SetParamSimple(map, prefix + "QuotaFilesLimit", this.QuotaFilesLimit);
            this.SetParamSimple(map, prefix + "AuditState", this.AuditState);
        }
    }
}

