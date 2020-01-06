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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppInfo : AbstractModel
    {
        
        /// <summary>
        /// app的url，必须保证不用权限校验就可以下载
        /// </summary>
        [JsonProperty("AppUrl")]
        public string AppUrl{ get; set; }

        /// <summary>
        /// app的md5，需要正确传递
        /// </summary>
        [JsonProperty("AppMd5")]
        public string AppMd5{ get; set; }

        /// <summary>
        /// app的大小
        /// </summary>
        [JsonProperty("AppSize")]
        public ulong? AppSize{ get; set; }

        /// <summary>
        /// app的文件名，指定后加固后的文件名是{FileName}_legu.apk
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// app的包名，需要正确的传递此字段
        /// </summary>
        [JsonProperty("AppPkgName")]
        public string AppPkgName{ get; set; }

        /// <summary>
        /// app的版本号
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// app的图标url
        /// </summary>
        [JsonProperty("AppIconUrl")]
        public string AppIconUrl{ get; set; }

        /// <summary>
        /// app的名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppUrl", this.AppUrl);
            this.SetParamSimple(map, prefix + "AppMd5", this.AppMd5);
            this.SetParamSimple(map, prefix + "AppSize", this.AppSize);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "AppPkgName", this.AppPkgName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "AppIconUrl", this.AppIconUrl);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
        }
    }
}

