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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BuildPacksInfo : AbstractModel
    {
        
        /// <summary>
        /// 基础镜像
        /// </summary>
        [JsonProperty("BaseImage")]
        public string BaseImage{ get; set; }

        /// <summary>
        /// 启动命令
        /// </summary>
        [JsonProperty("EntryPoint")]
        public string EntryPoint{ get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [JsonProperty("RepoLanguage")]
        public string RepoLanguage{ get; set; }

        /// <summary>
        /// 上传文件名
        /// </summary>
        [JsonProperty("UploadFilename")]
        public string UploadFilename{ get; set; }

        /// <summary>
        /// 语言版本
        /// </summary>
        [JsonProperty("LanguageVersion")]
        public string LanguageVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BaseImage", this.BaseImage);
            this.SetParamSimple(map, prefix + "EntryPoint", this.EntryPoint);
            this.SetParamSimple(map, prefix + "RepoLanguage", this.RepoLanguage);
            this.SetParamSimple(map, prefix + "UploadFilename", this.UploadFilename);
            this.SetParamSimple(map, prefix + "LanguageVersion", this.LanguageVersion);
        }
    }
}

