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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudRunServiceVolume : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// NFS的挂载方式
        /// </summary>
        [JsonProperty("NFS")]
        public CloudBaseRunNfsVolumeSource NFS{ get; set; }

        /// <summary>
        /// secret名称
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 是否开启临时目录逐步废弃，请使用 EmptyDir
        /// </summary>
        [JsonProperty("EnableEmptyDirVolume")]
        public bool? EnableEmptyDirVolume{ get; set; }

        /// <summary>
        /// emptydir数据卷详细信息
        /// </summary>
        [JsonProperty("EmptyDir")]
        public CloudBaseRunEmptyDirVolumeSource EmptyDir{ get; set; }

        /// <summary>
        /// 主机路径挂载信息
        /// </summary>
        [JsonProperty("HostPath")]
        public CloudBaseRunServiceVolumeHostPath HostPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "NFS.", this.NFS);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "EnableEmptyDirVolume", this.EnableEmptyDirVolume);
            this.SetParamObj(map, prefix + "EmptyDir.", this.EmptyDir);
            this.SetParamObj(map, prefix + "HostPath.", this.HostPath);
        }
    }
}

