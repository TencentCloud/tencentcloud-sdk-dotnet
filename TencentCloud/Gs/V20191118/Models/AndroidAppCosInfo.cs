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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AndroidAppCosInfo : AbstractModel
    {
        
        /// <summary>
        /// 安卓应用ID
        /// </summary>
        [JsonProperty("AndroidAppId")]
        public string AndroidAppId{ get; set; }

        /// <summary>
        /// 应用名称（支持 apk 和 tgz 两种格式文件，当应用 AppMode 为 NORMAL 时，只支持上传 apk 类型文件，当应用 AppMode 为 ADVANCED 高级模式时，只支持上传  tgz 类型文件）
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidAppId", this.AndroidAppId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
        }
    }
}

