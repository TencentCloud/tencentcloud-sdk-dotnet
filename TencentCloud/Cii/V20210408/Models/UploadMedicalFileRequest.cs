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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadMedicalFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件的字节内容。File与FileURL有一个不为空即可，若FileURL参数也存在，会只取File的内容。
        /// </summary>
        [JsonProperty("File")]
        public string File{ get; set; }

        /// <summary>
        /// 文件的URL地址。File与FileURL不能同时为空，若File参数也存在，会只取File的内容。
        /// </summary>
        [JsonProperty("FileURL")]
        public string FileURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "File", this.File);
            this.SetParamSimple(map, prefix + "FileURL", this.FileURL);
        }
    }
}

