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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRepositoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("RepositoryName")]
        public string RepositoryName{ get; set; }

        /// <summary>
        /// 仓库类型（默认仓库：default，私有仓库：private）
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// 仓库所在桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 仓库所在桶地域
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 目录
        /// </summary>
        [JsonProperty("Directory")]
        public string Directory{ get; set; }

        /// <summary>
        /// 仓库描述
        /// </summary>
        [JsonProperty("RepositoryDesc")]
        public string RepositoryDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepositoryName", this.RepositoryName);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "Directory", this.Directory);
            this.SetParamSimple(map, prefix + "RepositoryDesc", this.RepositoryDesc);
        }
    }
}

