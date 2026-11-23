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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionArtifactDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>物料ID</p>
        /// </summary>
        [JsonProperty("ArtifactId")]
        public string ArtifactId{ get; set; }

        /// <summary>
        /// <p>会话ID</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>AgentID</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>文件名</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件沙箱内路径</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>文件字节数</p>
        /// </summary>
        [JsonProperty("FileSizeBytes")]
        public long? FileSizeBytes{ get; set; }

        /// <summary>
        /// <p>文件摘要值(Sha256)</p>
        /// </summary>
        [JsonProperty("FileSha256")]
        public string FileSha256{ get; set; }

        /// <summary>
        /// <p>物料状态</p><p>枚举值：</p><ul><li>PENDING： 处理中</li><li>READY： 准备完毕</li><li>FAILED： 失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：RFC3339 UTC</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：RFC3339 UTC</p>
        /// </summary>
        [JsonProperty("UploadedTime")]
        public string UploadedTime{ get; set; }

        /// <summary>
        /// <p>过期时间</p><p>参数格式：RFC3339 UTC</p>
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ArtifactId", this.ArtifactId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileSizeBytes", this.FileSizeBytes);
            this.SetParamSimple(map, prefix + "FileSha256", this.FileSha256);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UploadedTime", this.UploadedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

