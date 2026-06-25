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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GooseFSVolume : AbstractModel
    {
        
        /// <summary>
        /// <p>存储卷名</p>
        /// </summary>
        [JsonProperty("VolumeName")]
        public string VolumeName{ get; set; }

        /// <summary>
        /// <p>gooseFS实例ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>gooseFS 命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>在命名空间中的挂载路径</p>
        /// </summary>
        [JsonProperty("SubPath")]
        public string SubPath{ get; set; }

        /// <summary>
        /// <p>FuseVERSION描述</p>
        /// </summary>
        [JsonProperty("FuseVersion")]
        public string FuseVersion{ get; set; }

        /// <summary>
        /// <p>Client Version描述，例如 GOOSE-1.5.2</p>
        /// </summary>
        [JsonProperty("ClientVersion")]
        public string ClientVersion{ get; set; }

        /// <summary>
        /// <p>默认挂载参数</p>
        /// </summary>
        [JsonProperty("MountOptions")]
        public string MountOptions{ get; set; }

        /// <summary>
        /// <p>默认JVM参数</p>
        /// </summary>
        [JsonProperty("JvmOptions")]
        public string JvmOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeName", this.VolumeName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "SubPath", this.SubPath);
            this.SetParamSimple(map, prefix + "FuseVersion", this.FuseVersion);
            this.SetParamSimple(map, prefix + "ClientVersion", this.ClientVersion);
            this.SetParamSimple(map, prefix + "MountOptions", this.MountOptions);
            this.SetParamSimple(map, prefix + "JvmOptions", this.JvmOptions);
        }
    }
}

