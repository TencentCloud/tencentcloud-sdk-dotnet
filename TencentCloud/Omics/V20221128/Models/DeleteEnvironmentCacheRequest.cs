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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteEnvironmentCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境ID。</p>
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// <p>缓存类型</p><p>枚举值：</p><ul><li>RUNTIME： 清理默认缓存卷的运行缓存目录</li><li>INPUT： 清理默认缓存卷的输入缓存目录</li><li>ALL： 清空环境下全部有效缓存卷</li><li>PATH： 指定缓存卷下指定路径，需要在Path中填入实际绝对路径</li></ul>
        /// </summary>
        [JsonProperty("CacheType")]
        public string CacheType{ get; set; }

        /// <summary>
        /// <p>指定路径删除</p><p>入参限制：以盘符开头的绝对路径地址</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "CacheType", this.CacheType);
            this.SetParamSimple(map, prefix + "Path", this.Path);
        }
    }
}

