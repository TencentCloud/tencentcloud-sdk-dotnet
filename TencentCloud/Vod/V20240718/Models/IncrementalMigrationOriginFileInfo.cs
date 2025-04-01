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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncrementalMigrationOriginFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件前缀配置。
        /// </summary>
        [JsonProperty("PrefixConfig")]
        public IncrementalMigrationOriginPrefixConfig PrefixConfig{ get; set; }

        /// <summary>
        /// 文件后缀配置。
        /// </summary>
        [JsonProperty("SuffixConfig")]
        public IncrementalMigrationOriginSuffixConfig SuffixConfig{ get; set; }

        /// <summary>
        /// 固定文件配置。
        /// </summary>
        [JsonProperty("FixedFileConfig")]
        public IncrementalMigrationOriginFixedFileConfig FixedFileConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PrefixConfig.", this.PrefixConfig);
            this.SetParamObj(map, prefix + "SuffixConfig.", this.SuffixConfig);
            this.SetParamObj(map, prefix + "FixedFileConfig.", this.FixedFileConfig);
        }
    }
}

