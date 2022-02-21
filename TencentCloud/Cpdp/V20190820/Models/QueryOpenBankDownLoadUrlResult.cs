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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryOpenBankDownLoadUrlResult : AbstractModel
    {
        
        /// <summary>
        /// 供下一步请求账单文件的下载地址。
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// 从 download_url 下载的文件的哈希值，用于校验文件的完整性。
        /// </summary>
        [JsonProperty("HashValue")]
        public string HashValue{ get; set; }

        /// <summary>
        /// 从 download_url 下载的文件的哈希类型，用于校验文件的完整性。
        /// </summary>
        [JsonProperty("HashType")]
        public string HashType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "HashValue", this.HashValue);
            this.SetParamSimple(map, prefix + "HashType", this.HashType);
        }
    }
}

