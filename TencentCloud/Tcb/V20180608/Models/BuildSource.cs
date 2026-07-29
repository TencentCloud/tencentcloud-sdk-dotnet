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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BuildSource : AbstractModel
    {
        
        /// <summary>
        /// <p>源码来源类型，取值：&quot;git&quot; &quot;zip&quot;</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Git 仓库 HTTPS URL；或 COS 下载完整 URL；与 CodeUrlWithAuth / CosTimestamp 之一非空（zip 二阶段上传时可留空）</p>
        /// </summary>
        [JsonProperty("Repo")]
        public string Repo{ get; set; }

        /// <summary>
        /// <p>分支 tag commit；Git 默认 main，zip 模式下忽略</p>
        /// </summary>
        [JsonProperty("Ref")]
        public string Ref{ get; set; }

        /// <summary>
        /// <p>&quot;git&quot; &quot;github&quot; &quot;gitlab&quot; &quot;gitee&quot; &quot;coding&quot;；私有仓必填，平台据此走 OAuth 鉴权</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>是否私有仓；true 时平台自动注入 CodeUrlWithAuth</p>
        /// </summary>
        [JsonProperty("IsPrivate")]
        public bool? IsPrivate{ get; set; }

        /// <summary>
        /// <p>调用方显式传入的带鉴权 clone URL 或带签名的 zip 下载直链（优先级最高，会覆盖平台 OAuth / 自动签名）</p>
        /// </summary>
        [JsonProperty("CodeUrlWithAuth")]
        public string CodeUrlWithAuth{ get; set; }

        /// <summary>
        /// <p>仅 Type=zip/cos 时使用。配合 zip 二阶段上传：填 DescribeCloudAppCosInfo 返回的 UnixTimestamp，平台据此自动签名出 ZIP_FILE_URL</p>
        /// </summary>
        [JsonProperty("CosTimestamp")]
        public string CosTimestamp{ get; set; }

        /// <summary>
        /// <p>仅 Type=zip/cos 时使用。zip 文件后缀，默认 .zip；与 CosTimestamp 配合定位 COS 对象</p>
        /// </summary>
        [JsonProperty("CosSuffix")]
        public string CosSuffix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Repo", this.Repo);
            this.SetParamSimple(map, prefix + "Ref", this.Ref);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "IsPrivate", this.IsPrivate);
            this.SetParamSimple(map, prefix + "CodeUrlWithAuth", this.CodeUrlWithAuth);
            this.SetParamSimple(map, prefix + "CosTimestamp", this.CosTimestamp);
            this.SetParamSimple(map, prefix + "CosSuffix", this.CosSuffix);
        }
    }
}

