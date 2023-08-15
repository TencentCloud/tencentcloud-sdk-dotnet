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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DuplicateImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 源命名空间名称
        /// </summary>
        [JsonProperty("SourceNamespace")]
        public string SourceNamespace{ get; set; }

        /// <summary>
        /// 源镜像仓库名称
        /// </summary>
        [JsonProperty("SourceRepo")]
        public string SourceRepo{ get; set; }

        /// <summary>
        /// 源镜像tag或digest值，目前仅支持tag
        /// </summary>
        [JsonProperty("SourceReference")]
        public string SourceReference{ get; set; }

        /// <summary>
        /// 目标镜像版本
        /// </summary>
        [JsonProperty("DestinationTag")]
        public string DestinationTag{ get; set; }

        /// <summary>
        /// 目标命名空间，不填默认与源一致
        /// </summary>
        [JsonProperty("DestinationNamespace")]
        public string DestinationNamespace{ get; set; }

        /// <summary>
        /// 目标镜像仓库，不填默认与源一致
        /// </summary>
        [JsonProperty("DestinationRepo")]
        public string DestinationRepo{ get; set; }

        /// <summary>
        /// 是否覆盖
        /// </summary>
        [JsonProperty("Override")]
        public bool? Override{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "SourceNamespace", this.SourceNamespace);
            this.SetParamSimple(map, prefix + "SourceRepo", this.SourceRepo);
            this.SetParamSimple(map, prefix + "SourceReference", this.SourceReference);
            this.SetParamSimple(map, prefix + "DestinationTag", this.DestinationTag);
            this.SetParamSimple(map, prefix + "DestinationNamespace", this.DestinationNamespace);
            this.SetParamSimple(map, prefix + "DestinationRepo", this.DestinationRepo);
            this.SetParamSimple(map, prefix + "Override", this.Override);
        }
    }
}

