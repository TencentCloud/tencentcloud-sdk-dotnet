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

    public class IOSInfo : AbstractModel
    {
        
        /// <summary>
        /// info.plist的url，必须保证不用权限校验就可以下载
        /// </summary>
        [JsonProperty("InfoPListUrl")]
        public string InfoPListUrl{ get; set; }

        /// <summary>
        /// info.plist文件的大小
        /// </summary>
        [JsonProperty("InfoPListSize")]
        public long? InfoPListSize{ get; set; }

        /// <summary>
        /// info.plist文件的md5
        /// </summary>
        [JsonProperty("InfoPListMd5")]
        public string InfoPListMd5{ get; set; }

        /// <summary>
        /// release: 需要INFO-PLIST文件，会生成工具部署安装包，并带有license文件，绑定机器；nobind不需要INFO-PLIST文件，不绑定机器
        /// </summary>
        [JsonProperty("BuildType")]
        public string BuildType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InfoPListUrl", this.InfoPListUrl);
            this.SetParamSimple(map, prefix + "InfoPListSize", this.InfoPListSize);
            this.SetParamSimple(map, prefix + "InfoPListMd5", this.InfoPListMd5);
            this.SetParamSimple(map, prefix + "BuildType", this.BuildType);
        }
    }
}

