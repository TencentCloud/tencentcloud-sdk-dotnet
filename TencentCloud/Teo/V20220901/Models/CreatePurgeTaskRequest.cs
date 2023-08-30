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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePurgeTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 节点缓存清除类型，取值有：
        /// <li>purge_url：URL刷新；</li>
        /// <li>purge_prefix：目录刷新；</li>
        /// <li>purge_host：Hostname 刷新；</li>
        /// <li>purge_all：站点下全部缓存刷新；</li>
        /// <li>purge_cache_tag：cache-tag 刷新。</li>缓存清除类型详情请查看[清除缓存](https://cloud.tencent.com/document/product/1552/70759)。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 节点缓存清除方法，针对目录刷新、Hostname刷新以及刷新全部缓存 类型有效，取值有：<li> invalidate：仅刷新目录下产生了更新的资源；</li><li> delete：无论目录下资源是否更新都刷新节点资源。</li>注意：使用目录刷新时，默认值： invalidate。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 要清除缓存的资源列表。每个元素格式依据清除缓存类型而定，可参考接口示例。<li>EO 默认针对内容含有非 ASCII 字符集的字符进行转义，编码规则遵循 RFC3986；</li><li>单次提交的任务数受计费套餐配额限制，请查看 [EO计费套餐](https://cloud.tencent.com/document/product/1552/77380)。</li>
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// 若有编码转换，仅清除编码转换后匹配的资源。
        /// 若内容含有非 ASCII 字符集的字符，请开启此开关进行编码转换（编码规则遵循 RFC3986）。
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
        }
    }
}

