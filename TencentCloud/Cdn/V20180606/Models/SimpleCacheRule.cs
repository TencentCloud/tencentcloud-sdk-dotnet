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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SimpleCacheRule : AbstractModel
    {
        
        /// <summary>
        /// 规则类型：
        /// all：所有文件生效
        /// file：指定文件后缀生效
        /// directory：指定路径生效
        /// path：指定绝对路径生效
        /// index：首页
        /// </summary>
        [JsonProperty("CacheType")]
        public string CacheType{ get; set; }

        /// <summary>
        /// CacheType 对应类型下的匹配内容：
        /// all 时填充 *
        /// file 时填充后缀名，如 jpg、txt
        /// directory 时填充路径，如 /xxx/test
        /// path 时填充绝对路径，如 /xxx/test.html
        /// index 时填充 /
        /// </summary>
        [JsonProperty("CacheContents")]
        public string[] CacheContents{ get; set; }

        /// <summary>
        /// 缓存过期时间设置
        /// 单位为秒，最大可设置为 365 天
        /// </summary>
        [JsonProperty("CacheTime")]
        public long? CacheTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CacheType", this.CacheType);
            this.SetParamArraySimple(map, prefix + "CacheContents.", this.CacheContents);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
        }
    }
}

