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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelServiceHotUpdatedRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像信息，配置服务运行所需的镜像地址等信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 模型信息，需要挂载模型时填写
        /// </summary>
        [JsonProperty("ModelInfo")]
        public ModelInfo ModelInfo{ get; set; }

        /// <summary>
        /// 挂载信息
        /// </summary>
        [JsonProperty("VolumeMount")]
        public VolumeMount VolumeMount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "ModelInfo.", this.ModelInfo);
            this.SetParamObj(map, prefix + "VolumeMount.", this.VolumeMount);
        }
    }
}

