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

    public class UpdateFilesetRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统id
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// Fileset id
        /// </summary>
        [JsonProperty("FsetId")]
        public string FsetId{ get; set; }

        /// <summary>
        /// 容量配额限定值
        /// </summary>
        [JsonProperty("QuotaSizeLimit")]
        public string QuotaSizeLimit{ get; set; }

        /// <summary>
        /// 文件数配额限定值
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
            this.SetParamSimple(map, prefix + "FsetId", this.FsetId);
            this.SetParamSimple(map, prefix + "QuotaSizeLimit", this.QuotaSizeLimit);
            this.SetParamSimple(map, prefix + "QuotaFilesLimit", this.QuotaFilesLimit);
            this.SetParamSimple(map, prefix + "AuditState", this.AuditState);
        }
    }
}

