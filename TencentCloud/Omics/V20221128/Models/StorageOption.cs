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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageOption : AbstractModel
    {
        
        /// <summary>
        /// 文件存储类型，取值范围：
        /// - SD：通用标准型
        /// - HP：通用性能型
        /// - TB：turbo标准型
        /// - TP：turbo性能型
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 文件存储可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 文件系统容量，turbo系列必填，单位为GiB。 
        /// - turbo标准型起售40TiB，即40960GiB；扩容步长20TiB，即20480 GiB。
        /// - turbo性能型起售20TiB，即20480 GiB；扩容步长10TiB，即10240 GiB。
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
        }
    }
}

