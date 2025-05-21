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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageConfig : AbstractModel
    {
        
        /// <summary>
        /// 镜像仓库类型，个人版或者企业版：personal/enterprise
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// {domain}/{namespace}/{imageName}:{tag}@{digest}
        /// </summary>
        [JsonProperty("ImageUri")]
        public string ImageUri{ get; set; }

        /// <summary>
        /// 用于企业版TCR获取镜像拉取临时凭证，ImageType为"enterprise"时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 该参数即将下线，不推荐用户使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EntryPoint")]
        public string EntryPoint{ get; set; }

        /// <summary>
        /// 容器的启动命令。该参数为可选参数，如果不填写，则默认使用 Dockerfile 中的 Entrypoint。传入规范，填写可运行的指令，例如 python
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 容器的启动参数。该参数为可选参数，如果不填写，则默认使用 Dockerfile 中的 CMD。传入规范，以“空格”作为参数的分割标识，例如 -u app.py
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Args")]
        public string Args{ get; set; }

        /// <summary>
        /// 镜像加速开关，默认False
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContainerImageAccelerate")]
        public bool? ContainerImageAccelerate{ get; set; }

        /// <summary>
        /// 镜像函数端口设置，可指定镜像类型
        /// Web Server镜像：9000
        /// Job 镜像：-1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// 默认值：9000
        /// 示例值：9000
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImagePort")]
        public long? ImagePort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageUri", this.ImageUri);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "EntryPoint", this.EntryPoint);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "Args", this.Args);
            this.SetParamSimple(map, prefix + "ContainerImageAccelerate", this.ContainerImageAccelerate);
            this.SetParamSimple(map, prefix + "ImagePort", this.ImagePort);
        }
    }
}

