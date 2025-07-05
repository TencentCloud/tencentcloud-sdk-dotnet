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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublishLayerVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 层名称，支持26个英文字母大小写、数字、连接符和下划线，第一个字符只能以字母开头，最后一个字符不能为连接符或者下划线，名称长度1-64
        /// </summary>
        [JsonProperty("LayerName")]
        public string LayerName{ get; set; }

        /// <summary>
        /// 层适用的运行时，可多选，可选的值对应函数的 Runtime 可选值。
        /// </summary>
        [JsonProperty("CompatibleRuntimes")]
        public string[] CompatibleRuntimes{ get; set; }

        /// <summary>
        /// 层的文件来源或文件内容
        /// </summary>
        [JsonProperty("Content")]
        public Code Content{ get; set; }

        /// <summary>
        /// 层的版本的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 层的软件许可证
        /// </summary>
        [JsonProperty("LicenseInfo")]
        public string LicenseInfo{ get; set; }

        /// <summary>
        /// 层Tag 参数，以键值对数组形式传入
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayerName", this.LayerName);
            this.SetParamArraySimple(map, prefix + "CompatibleRuntimes.", this.CompatibleRuntimes);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LicenseInfo", this.LicenseInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

