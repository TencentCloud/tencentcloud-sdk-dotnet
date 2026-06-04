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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SupportedFileType : AbstractModel
    {
        
        /// <summary>
        /// 文件类型描述(如"文本文档")
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 文件类型(如 txt、pdf、jpg, 建议用扩展名)
        /// </summary>
        [JsonProperty("FileExt")]
        public string FileExt{ get; set; }

        /// <summary>
        /// 文件大小限制(单位: 字节)
        /// </summary>
        [JsonProperty("MaxSizeBytes")]
        public string MaxSizeBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FileExt", this.FileExt);
            this.SetParamSimple(map, prefix + "MaxSizeBytes", this.MaxSizeBytes);
        }
    }
}

