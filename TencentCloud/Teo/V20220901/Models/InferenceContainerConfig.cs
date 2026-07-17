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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceContainerConfig : AbstractModel
    {
        
        /// <summary>
        /// 镜像类型。取值有：<li>TCR：腾讯云容器镜像服务的镜像。</li>
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// TCR 镜像仓库信息。当 ImageType 为 TCR 时必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcrRepositoryConfig")]
        public InferenceTCRRepositoryConfig TcrRepositoryConfig{ get; set; }

        /// <summary>
        /// 容器启动时执行的命令，未填写时默认使用镜像的 Entrypoint/CMD。最长支持 1024 字符。
        /// </summary>
        [JsonProperty("StartupCommand")]
        public string StartupCommand{ get; set; }

        /// <summary>
        /// 容器运行时的环境变量。最多支持 10 个变量。
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public InferenceEnvironmentVariable[] EnvironmentVariables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamObj(map, prefix + "TcrRepositoryConfig.", this.TcrRepositoryConfig);
            this.SetParamSimple(map, prefix + "StartupCommand", this.StartupCommand);
            this.SetParamArrayObj(map, prefix + "EnvironmentVariables.", this.EnvironmentVariables);
        }
    }
}

