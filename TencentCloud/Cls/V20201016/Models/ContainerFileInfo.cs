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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContainerFileInfo : AbstractModel
    {
        
        /// <summary>
        /// namespace可以多个，用分隔号分割,例如A,B
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// 日志文件夹
        /// </summary>
        [JsonProperty("LogPath")]
        public string LogPath{ get; set; }

        /// <summary>
        /// 日志名称
        /// </summary>
        [JsonProperty("FilePattern")]
        public string FilePattern{ get; set; }

        /// <summary>
        /// 日志文件信息
        /// </summary>
        [JsonProperty("FilePaths")]
        public FilePathInfo[] FilePaths{ get; set; }

        /// <summary>
        /// pod标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeLabels")]
        public string[] IncludeLabels{ get; set; }

        /// <summary>
        /// 工作负载信息
        /// </summary>
        [JsonProperty("WorkLoad")]
        public ContainerWorkLoadInfo WorkLoad{ get; set; }

        /// <summary>
        /// 需要排除的namespace可以多个，用分隔号分割,例如A,B
        /// </summary>
        [JsonProperty("ExcludeNamespace")]
        public string ExcludeNamespace{ get; set; }

        /// <summary>
        /// 需要排除的pod标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludeLabels")]
        public string[] ExcludeLabels{ get; set; }

        /// <summary>
        /// metadata信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomLabels")]
        public string[] CustomLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "LogPath", this.LogPath);
            this.SetParamSimple(map, prefix + "FilePattern", this.FilePattern);
            this.SetParamArrayObj(map, prefix + "FilePaths.", this.FilePaths);
            this.SetParamArraySimple(map, prefix + "IncludeLabels.", this.IncludeLabels);
            this.SetParamObj(map, prefix + "WorkLoad.", this.WorkLoad);
            this.SetParamSimple(map, prefix + "ExcludeNamespace", this.ExcludeNamespace);
            this.SetParamArraySimple(map, prefix + "ExcludeLabels.", this.ExcludeLabels);
            this.SetParamArraySimple(map, prefix + "CustomLabels.", this.CustomLabels);
        }
    }
}

