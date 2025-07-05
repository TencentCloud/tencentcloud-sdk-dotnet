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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Volume : AbstractModel
    {
        
        /// <summary>
        /// 来源(emptyDir|hostPath|configMap|secret|nfs)
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Host挂载配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostPath")]
        public VolumeHostPath HostPath{ get; set; }

        /// <summary>
        /// ConfigMap挂载配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigMap")]
        public VolumeConfigMap ConfigMap{ get; set; }

        /// <summary>
        /// Secret挂载配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Secret")]
        public VolumeConfigMap Secret{ get; set; }

        /// <summary>
        /// NFS挂载配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NFS")]
        public VolumeNFS NFS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "HostPath.", this.HostPath);
            this.SetParamObj(map, prefix + "ConfigMap.", this.ConfigMap);
            this.SetParamObj(map, prefix + "Secret.", this.Secret);
            this.SetParamObj(map, prefix + "NFS.", this.NFS);
        }
    }
}

