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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalMediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒资绑定模板 ID，可取值为：
        /// <li>1000000：媒体文件为 URL，且 URL Scheme 为 https；</li>
        /// <li>1000001：媒体文件为 URL，且 URL Scheme 为 http。</li>
        /// 
        /// 注：如果要支持其它存储平台或者类型的媒体绑定，请联系 [客服](https://cloud.tencent.com/online-service?from=doc_1156)。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 媒资绑定媒体路径或文件 ID，如果要绑定 URL 类型的媒体，请将 URL 的 'https://' 或者 'http://' 去掉。
        /// </summary>
        [JsonProperty("MediaKey")]
        public string MediaKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "MediaKey", this.MediaKey);
        }
    }
}

