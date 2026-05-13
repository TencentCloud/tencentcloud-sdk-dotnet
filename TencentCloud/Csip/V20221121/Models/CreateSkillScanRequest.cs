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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSkillScanRequest : AbstractModel
    {
        
        /// <summary>
        /// ZIP 文件内容的 Base64 编码
        /// 入参限制：文件大小上限 7MB（编码前），仅接受有效的 ZIP 格式
        /// </summary>
        [JsonProperty("FileBase64")]
        public string FileBase64{ get; set; }

        /// <summary>
        /// 文件名，用于服务端日志记录
        /// 参数格式：形如 my-skill.zip
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileBase64", this.FileBase64);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
        }
    }
}

