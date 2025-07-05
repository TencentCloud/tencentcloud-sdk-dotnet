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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigSubmitContext : AbstractModel
    {
        
        /// <summary>
        /// 配置文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 配置文件旧内容，base64编码
        /// </summary>
        [JsonProperty("OldConfValue")]
        public string OldConfValue{ get; set; }

        /// <summary>
        /// 配置文件新内容，base64编码
        /// </summary>
        [JsonProperty("NewConfValue")]
        public string NewConfValue{ get; set; }

        /// <summary>
        /// 保存配置文件的路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "OldConfValue", this.OldConfValue);
            this.SetParamSimple(map, prefix + "NewConfValue", this.NewConfValue);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
        }
    }
}

