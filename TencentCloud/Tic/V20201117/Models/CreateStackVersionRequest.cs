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

namespace TencentCloud.Tic.V20201117.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStackVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 待增加版本的资源栈ID
        /// </summary>
        [JsonProperty("StackId")]
        public string StackId{ get; set; }

        /// <summary>
        /// 模板 URL，⽬前仅限 COS URL, ⽂件为zip压缩格式
        /// </summary>
        [JsonProperty("TemplateUrl")]
        public string TemplateUrl{ get; set; }

        /// <summary>
        /// 版本名称，不得超过60个字符
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 版本描述，不得超过200个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StackId", this.StackId);
            this.SetParamSimple(map, prefix + "TemplateUrl", this.TemplateUrl);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

