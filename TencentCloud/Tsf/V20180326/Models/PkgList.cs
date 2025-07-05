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

    public class PkgList : AbstractModel
    {
        
        /// <summary>
        /// 程序包总量
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 程序包信息列表
        /// </summary>
        [JsonProperty("Content")]
        public PkgInfo[] Content{ get; set; }

        /// <summary>
        /// 程序包仓库id
        /// </summary>
        [JsonProperty("RepositoryId")]
        public string RepositoryId{ get; set; }

        /// <summary>
        /// 程序包仓库类型
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// 程序包仓库名称
        /// </summary>
        [JsonProperty("RepositoryName")]
        public string RepositoryName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "RepositoryId", this.RepositoryId);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "RepositoryName", this.RepositoryName);
        }
    }
}

