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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileVolumeMount : AbstractModel
    {
        
        /// <summary>
        /// <p>访问模式：RO=只读，RW=读写；必填。挂载到 /workdir 时只能使用 RW。</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// <p>沙箱内的绝对挂载目录；/workdir 最多挂载一条且只能使用 RW。</p>
        /// </summary>
        [JsonProperty("MountPath")]
        public string MountPath{ get; set; }

        /// <summary>
        /// <p>云盘标识</p>
        /// </summary>
        [JsonProperty("VolumeId")]
        public string VolumeId{ get; set; }

        /// <summary>
        /// <p>服务端生成的挂载标识，修改保留，新增可不传</p>
        /// </summary>
        [JsonProperty("MountId")]
        public string MountId{ get; set; }

        /// <summary>
        /// <p>相对云盘 data 根目录的路径；空字符串表示挂载整个 data 根目录。</p>
        /// </summary>
        [JsonProperty("RelativePath")]
        public string RelativePath{ get; set; }

        /// <summary>
        /// <p>云盘名称，仅在查询应用配置时由服务端补充，修改时忽略；不可获取时为空且不影响挂载配置</p>
        /// </summary>
        [JsonProperty("VolumeName")]
        public string VolumeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "MountPath", this.MountPath);
            this.SetParamSimple(map, prefix + "VolumeId", this.VolumeId);
            this.SetParamSimple(map, prefix + "MountId", this.MountId);
            this.SetParamSimple(map, prefix + "RelativePath", this.RelativePath);
            this.SetParamSimple(map, prefix + "VolumeName", this.VolumeName);
        }
    }
}

